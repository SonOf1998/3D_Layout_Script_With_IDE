using _3D_layout_script;
using _3D_layout_script.Objects;
using _3D_layout_script.ObjExport;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using ICSharpCode.AvalonEdit.CodeCompletion;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3DLayoutScriptIDE
{
    // Main window logikája
    public partial class MainWindow : Window
    {
        private const string projectFilesSer = "projectFiles.dat";
        private HashSet<string> projects;
        private const string windowBaseTitle = "3D Layout Script IDE - 2020";
        private string projectFile = null;
        private string lastSavedStateOfEditor = "";

        private int documentationWidth = 300;        
        private int projectsWidth = 300;

        CompletionWindow completionWindow;
        char previousChar = ' ';
        Dictionary<char, List<String>> charKeywordPairs;

        public MainWindow()
        {
            InitializeComponent();
            // TODO serializacio
            SetWindowTitle("~ untitled");

            textEditor.TextArea.TextEntering += textEditor_TextArea_TextEntering;
            textEditor.TextArea.TextEntered += textEditor_TextArea_TextEntered;
            textEditor.TextArea.PreviewKeyUp += tab_passing;
           // textEditor.TextArea.IndentationStrategy = new CSharpIndentationStrategy();
            charKeywordPairs = new Dictionary<char, List<string>>();
            matchCharKeywordPairs();


            // deszerializálni a projekteket tartalmazó halmazba
            projects = new HashSet<string>();
            if (File.Exists(projectFilesSer))
            {
                string[] projectsArray = File.ReadAllLines(projectFilesSer);
                foreach (var proj in projectsArray)
                {
                    projects.Add(proj);
                }
            }
            

            // project ablakot feltöltjük
            FillProjectWindow();

            // kezdesnel legyen minden elől
            BProjectsClick(null, null);
            BDocumentationClick(null, null);
        }

        private void FillProjectWindow()
        {
            ProjectTree.Items.Clear();

            foreach (var project in projects)
            {
                TreeViewItem item = new TreeViewItem();           
                item.Header = project.Substring(project.LastIndexOf("\\") + 1, project.LastIndexOf(".") - project.LastIndexOf("\\") - 1);
                item.SetValue(TextBlock.FontWeightProperty, FontWeights.Bold);
                item.SetValue(TextBlock.FontSizeProperty, 14.0);
                item.VerticalAlignment = VerticalAlignment.Center;
                item.ToolTip = project;
                item.Expanded += new RoutedEventHandler(ExpandProjectNode);
                item.Items.Add(new object());
                ProjectTree.Items.Add(item);
            }

            string[] projectsInArray = new string[projects.Count];
            projects.CopyTo(projectsInArray);
            File.WriteAllLines(projectFilesSer, projectsInArray);
        }

        private void ExpandProjectNode(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = (TreeViewItem)sender;
            string dddFilePath = item.ToolTip.ToString();
            string objFilePath = dddFilePath.Substring(0, dddFilePath.LastIndexOf(".")) + ".obj";
            item.Items.Clear();

            if (!File.Exists(dddFilePath))
            {
                ProjectTree.Items.Remove(item);
                return;
            }

            TreeViewItem DDDItem = new TreeViewItem();
            StackPanel dddPanel = new StackPanel();
            dddPanel.Orientation = System.Windows.Controls.Orientation.Horizontal;
            Image dddImage = new Image();
            dddImage.Width = 15;
            dddImage.Height = 20;
            dddImage.Source = new BitmapImage(new Uri("UIPics/document.png", UriKind.Relative));
            TextBlock dddtb = new TextBlock();
            dddtb.SetValue(TextBlock.FontWeightProperty, FontWeights.Normal);
            dddtb.SetValue(TextBlock.FontSizeProperty, 13.0);
            dddtb.Text = dddFilePath.Substring(dddFilePath.LastIndexOf("\\") + 1);
            dddPanel.Children.Add(dddImage);
            dddPanel.Children.Add(dddtb);
            DDDItem.Header = dddPanel;
            DDDItem.Tag = dddFilePath;
            DDDItem.ToolTip = "Double click to edit .ddd file";
            DDDItem.MouseDoubleClick += new MouseButtonEventHandler(DDDDoubleClick);
            item.Items.Add(DDDItem);

            if (File.Exists(objFilePath))
            {
                TreeViewItem OBJItem = new TreeViewItem();
                StackPanel objPanel = new StackPanel();
                objPanel.Orientation = System.Windows.Controls.Orientation.Horizontal;
                Image objImage = new Image();
                objImage.Width = 15;
                objImage.Height = 20;
                objImage.Source = new BitmapImage(new Uri("UIPics/3dtype.png", UriKind.Relative));
                TextBlock objtb = new TextBlock();
                objtb.SetValue(TextBlock.FontWeightProperty, FontWeights.Normal);
                objtb.SetValue(TextBlock.FontSizeProperty, 13.0);
                objtb.Text = objFilePath.Substring(objFilePath.LastIndexOf("\\") + 1);
                objPanel.Children.Add(objImage);
                objPanel.Children.Add(objtb);
                OBJItem.Header = objPanel;
                OBJItem.Tag = objFilePath.Substring(0, objFilePath.LastIndexOf("."));
                OBJItem.ToolTip = "Double click to view the .obj file";
                OBJItem.MouseDoubleClick += new MouseButtonEventHandler(OBJDoubleClick);
                item.Items.Add(OBJItem);
            }
        }

        private void DDDDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TreeViewItem DDDItem = (TreeViewItem)sender;
            ClearWindow();
            string filename = (string)DDDItem.Tag;
            textEditor.Text = File.ReadAllText(filename);
            lastSavedStateOfEditor = textEditor.Text;
            SetWindowTitle(filename);
            projectFile = filename;
        }

        private void OBJDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TreeViewItem OBJItem = (TreeViewItem)sender;
            OpenInMicrosoft3DViewer((string)OBJItem.Tag);
        }

        private void ClearWindow()
        {
            textEditor.Clear();
            ErrorPane.ItemsSource = null;
        }

        private void SetWindowTitle(string projName)
        {
            Window.Title = windowBaseTitle + "         " + projName;
        }

        private void tab_passing(object sender, System.Windows.Input.KeyEventArgs e)
        {
            // csillaggal bejelöljük, ha szükséges mentés, ~untitled fájloknál nem nézzük
            // mert az úgyis megköveteli a mentést.
            if (projectFile != null)
            {
                if (textEditor.Text != lastSavedStateOfEditor)
                {
                    SetWindowTitle(projectFile + "*");
                }
                else
                {
                    SetWindowTitle(projectFile);
                }
            }

            int lenght = textEditor.Text.Length;
            if (lenght > 0)
            {
                if (textEditor.CaretOffset > 1 && (textEditor.Text[textEditor.CaretOffset - 1] == ' ' || textEditor.Text[textEditor.CaretOffset - 1] == '\t' || textEditor.Text[textEditor.CaretOffset - 1] == '\n'))
                {
                    previousChar = ' ';
                }
                else
                {
                    previousChar = 'X';
                }
            }
            else
            {
                previousChar = ' ';               
            }         
        }

        private void matchCharKeywordPairs()
        {
            List<string> stringList = new List<string>
            {
                "'very-low'",
                "'low'",
                "'medium'",
                "'high'"
            };
            charKeywordPairs.Add('\'', stringList);

            List<string> aList = new List<string>
            {
                "attr-group"
            };
            charKeywordPairs.Add('a', aList);

            List<string> cList = new List<string>
            {
                "const var",
                "circle",
                "cube",
                "cuboid",
                "cone",
                "cylinder"
            };
            charKeywordPairs.Add('c', cList);

            List<string> pList = new List<string>
            {
                "position"
            };
            charKeywordPairs.Add('p', pList);

            List<string> sList = new List<string>
            {
                "sphere",
                "step",
                "scale"
            };
            charKeywordPairs.Add('s', sList);

            List<string> hList = new List<string>
            {
                "height",
                "hemisphere"
            };
            charKeywordPairs.Add('h', hList);

            List<string> tList = new List<string>
            {
                "triangle"
            };
            charKeywordPairs.Add('t', tList);

            List<string> wList = new List<string>
            {
                "width"
            };
            charKeywordPairs.Add('w', wList);

            List<string> atList = new List<string>
            {
                "@include"
            };
            charKeywordPairs.Add('@', atList);

            List<string> dList = new List<string>
            {
                "depth"
            };
            charKeywordPairs.Add('d', dList);

            List<string> qList = new List<string>
            {
                "quad",
                "quality"
            };
            charKeywordPairs.Add('q', qList);

            List<string> rList = new List<string>
            {
                "rotation-axis",
                "rotation-angle",
                "radius",
                "range"
            };
            charKeywordPairs.Add('r', rList);

            List<string> VList = new List<string>
            {
                "Vec3"
            };
            charKeywordPairs.Add('V', VList);

            List<string> IList = new List<string>
            {
                "Int"
            };
            charKeywordPairs.Add('I', IList);

            List<string> FList = new List<string>
            {
                "Float"
            };
            charKeywordPairs.Add('F', FList);
        }

        void textEditor_TextArea_TextEntered(object sender, TextCompositionEventArgs e)
        {
            char c = e.Text[0];
            if (charKeywordPairs.ContainsKey(c) && char.IsWhiteSpace(previousChar))
            {
                completionWindow = new CompletionWindow(textEditor.TextArea);
                IList<ICompletionData> data = completionWindow.CompletionList.CompletionData;
                foreach (var suggestion in charKeywordPairs[c])
                {
                    data.Add(new CompletionData(suggestion));
                }
                completionWindow.StartOffset -= 1;
                completionWindow.Show();
                completionWindow.Closed += delegate {
                    completionWindow = null;
                };

            }


            // szó írása közben nem engedjük a code completion dialogot felbukkanni
            // csak akkor engedjük, ha space előzte meg a szavunkat
            // erro szolgálóan elmentjük az előző karaktert
            previousChar = e.Text[0];
        }

        // A code completiont enterrel space-szel vagy tabbal lehet kiváltani
        void textEditor_TextArea_TextEntering(object sender, TextCompositionEventArgs e)
        {
            if (e.Text.Length > 0 && completionWindow != null) {
                char c = e.Text[0];
                if (c == ' ' || c == '\n' || c == '\t')
                {
                    completionWindow.CompletionList.RequestInsertion(e);
                }
            }
        }

        // dokumentáció előhozatala / elrejtése
        private void BDocumentationClick(object sender, RoutedEventArgs e)
        {
            var middleGrid = (Grid)FindName("gridMiddle");
            var documentationSplitter = (GridSplitter)FindName("splitterDocumentation");
            var documentation = (Grid)FindName("gridDocumentation");

            if (documentation.IsEnabled)
            {
                // következő megnyitáskor az utoljára fent lévő ablakméretet vegye fel
                documentationWidth = (int)middleGrid.ColumnDefinitions[4].Width.Value;

                documentationSplitter.IsEnabled = false;
                documentation.IsEnabled = false;
           
                documentationSplitter.Width = 0;
                documentation.Width = 0;
                middleGrid.ColumnDefinitions[3].Width = new GridLength(0);
                middleGrid.ColumnDefinitions[4].Width = new GridLength(0);
            }
            else
            {
                // bekapcsoljuk az ablakot és a szeparátort
                documentationSplitter.IsEnabled = true;
                documentation.IsEnabled = true;

                documentationSplitter.Width = 5;
                documentation.Width = projectsWidth;
                middleGrid.ColumnDefinitions[3].Width = new GridLength(5);
                middleGrid.ColumnDefinitions[4].Width = new GridLength(documentationWidth);
            }
        }

        // projektek előhozatala / elrejtése
        private void BProjectsClick(object sender, RoutedEventArgs e)
        {
            var middleGrid = (Grid)FindName("gridMiddle");
            var projectsSplitter = (GridSplitter)FindName("splitterProjects");
            var projects = (Grid)FindName("gridProjects");
            
            if (projects.IsEnabled)
            {
                // következő megnyitáskor az utoljára fent lévő ablakméretet vegye fel
                projectsWidth = (int)middleGrid.ColumnDefinitions[0].Width.Value;

                projectsSplitter.IsEnabled = false;
                projects.IsEnabled = false;

                projectsSplitter.Width = 0;
                projects.Width = 0;
                middleGrid.ColumnDefinitions[1].Width = new GridLength(0);
                middleGrid.ColumnDefinitions[0].Width = new GridLength(0);                
            }
            else
            {
                // bekapcsoljuk az ablakot és a szeparátort
                projectsSplitter.IsEnabled = true;
                projects.IsEnabled = true;

                // beállítjuk az ablak, a szeparátor és a grid oszlopok szélességét a megfelelő értékre
                projectsSplitter.Width = 5;
                projects.Width = projectsWidth;
                middleGrid.ColumnDefinitions[1].Width = new GridLength(5);
                middleGrid.ColumnDefinitions[0].Width = new GridLength(projectsWidth);
            }
        }

        private void Compile(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
            Save(null, null);
            VisitSourceCode(false);
            Mouse.OverrideCursor = null;
        }

        private void CompileAndRun(object sender, RoutedEventArgs e)
        {
            Mouse.OverrideCursor = System.Windows.Input.Cursors.Wait;
            Save(null, null);
            VisitSourceCode(true);
            Mouse.OverrideCursor = null;
        }

        // capturing CTRL S, CTRL O
        private void WindowKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.S)
            {
                Save(null, null);
            }

            if (Keyboard.Modifiers == ModifierKeys.Control && e.Key == Key.O)
            {
                Open(null, null);
            }
        }

        // új üres fájl.
        private void MakeNew(object sender, RoutedEventArgs e)
        {
            projectFile = null;
            SetWindowTitle("~ untitled");
            ClearWindow();
        }

        private void Open(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();

            dlg.DefaultExt = ".ddd";
            dlg.Filter = "3D Layout Script files (*.ddd)|*.ddd";

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                string filename = dlg.FileName;
                SetWindowTitle(filename);
                projectFile = filename;

                ClearWindow();
                textEditor.Text = File.ReadAllText(filename);
                lastSavedStateOfEditor = textEditor.Text;

                int size0 = projects.Count;
                projects.Add(filename);
                int newSize = projects.Count;
               
                if (size0 != newSize)
                {
                    FillProjectWindow();
                }
            }
        }

        private void Save(object sender, RoutedEventArgs e)
        {
            if (projectFile == null)
            {
                Microsoft.Win32.SaveFileDialog dlg = new Microsoft.Win32.SaveFileDialog();
                dlg.FileName = "unknown.ddd";
                dlg.Filter = "3D Layout Script files (*.ddd)|*.ddd";

                bool? result = dlg.ShowDialog();

                if (result == true)
                {
                    string filename = dlg.FileName;

                    File.WriteAllText(filename, textEditor.Text);
                    projectFile = filename;
                    SetWindowTitle(filename);

                    projects.Add(filename);
                    FillProjectWindow();
                }
            }
            else
            {
                File.WriteAllText(projectFile, textEditor.Text);
                SetWindowTitle(projectFile);   // unsaved *-ot leszedi ez a set
            }

            lastSavedStateOfEditor = textEditor.Text;
        } 

        private void CloseWindow(object sender, EventArgs e)
        {
            Console.Write("");

            if (sender is System.Windows.Controls.MenuItem)
            {
                System.Windows.Application.Current.Shutdown();
            }
        }

        private void OpenInMicrosoft3DViewer(string pathWithoutExtension)
        {
            Process process = new Process();
            process.StartInfo.FileName = pathWithoutExtension + ".obj";
            process.Start();
        }

        private IParseTree ReadAST()
        {
            var code = textEditor.Text;
            var inputStream = new AntlrInputStream(code);
            var lexer = new DDD_layout_scriptLexer(inputStream);
            //lexer.RemoveErrorListeners();
            


            var tokenStream = new CommonTokenStream(lexer);
            var parser = new DDD_layout_scriptParser(tokenStream);
            var syntaxErrorListener = new SyntaxErrorListener();
            parser.RemoveErrorListeners();
            parser.AddErrorListener(syntaxErrorListener);           
            var context = parser.program();
            List<ErrorPaneRow> rows = new List<ErrorPaneRow>();
            var syntaxAlerts = syntaxErrorListener.GetAlerts();
            foreach (var alert in syntaxAlerts)
            {
                rows.Add(new ErrorPaneRow(alert.GetAlertType(), alert.LineNumber, alert.Msg));
            }
            ErrorPane.ItemsSource = rows;
            if (syntaxAlerts.Count != 0)
            {
                return null;
            }
            return context;
        }

        private void VisitSourceCode(bool openAtTheEnd)
        {
            var ast = ReadAST();
            if (ast == null)
            {
                return;
            }

            var visitor = new Visitor();

            List<DDDObject> objects = (List<DDDObject>)visitor.Visit(ast);
            var alerts = visitor.GetAlerts();
            bool hadErrors = false;
            List<ErrorPaneRow> rows = new List<ErrorPaneRow>();
            foreach (var alert in alerts)
            {
                if (alert.GetAlertType() == "Error")
                {
                    hadErrors = true;
                }
                rows.Add(new ErrorPaneRow(alert.GetAlertType(), alert.LineNumber, alert.Msg));
            }
            ErrorPane.ItemsSource = rows;

            if (hadErrors)
            {
                return;
            }

            if (objects.Count == 0)
            {
                rows.Add(new ErrorPaneRow("Warning", null, "No valid 3DObjects found. Skipped generating .obj"));
                ErrorPane.ItemsSource = null;
                ErrorPane.ItemsSource = rows;
            }

        
            if (projectFile == null)
            {
                return;
            }

            string projectDirectory = projectFile.Substring(0, projectFile.LastIndexOf('.'));

            ExportManager em = new ObjExportManager(projectDirectory);     
            em.Export(objects);

            // default win10 3D viewert nyitja meg

            if (openAtTheEnd)
            {
                OpenInMicrosoft3DViewer(projectDirectory);
            }
        }
    }
}
