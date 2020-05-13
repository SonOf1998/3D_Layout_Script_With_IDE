using System.IO;
using System.Windows;

namespace _3DLayoutScriptIDE
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        { 
            // AvalonEditnek adunk DDD támogatást egy XML leírón keresztül
            using (var stream = new StreamReader(@"dddHighlight.xml"))
            {
                using (var reader = new System.Xml.XmlTextReader(stream))
                {
                    ICSharpCode.AvalonEdit.Highlighting.HighlightingManager.Instance.RegisterHighlighting("DDD", new string[0],
                        ICSharpCode.AvalonEdit.Highlighting.Xshd.HighlightingLoader.Load(reader,
                            ICSharpCode.AvalonEdit.Highlighting.HighlightingManager.Instance));
                }
            }
        }
    }
}
