   M S B A M L   `   `   `  ����L  H3DLayoutScriptIDE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:_3DLayoutScriptIDE_3DLayoutScriptIDE  5   	   #    _3DLayoutScriptIDE.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:_3DLayoutScriptIDE     5   	   -   5          �Name$  Window��5	   	    � WindowState$ 	Maximized=�5   	    � Title$! 3D Layout Script IDE - 2020��5   	   .��5      � -   5         �Name$ gridMain��5      $��Stretch=�6   $
��Auto��6;   $��Stretch=�6I   $
��Auto��6e   $��0,0,0,0q�6r    � RowDefinitions 5   
   �� 5      $��80 �6   $��60��6(   $	��100��67   �� 5      $��5 �6   �� 5      $��* �6   .+�5   
   � $��0��6    5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      ]� $��20��6   $
��Auto��6$   $	��Top=�62   $��Stretch=�6J   $��0��6h   .+�5      o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5        $
��_New��5   #   62   m� 5      -   5        $��_Open��5   #   62   m� 5      -   5        $��_Save��5   #   62   �� 5       m� 5!      -   5        $��_Exit��5!   #   62   5"      5#      �� 5$       �� AcceptsReturn . 6   5%      � 5&      $��1��6    � ColumnDefinitions 5'      �� 5(      $��* �6'   �� 5)      $��* �6'   �� 5*      $��* �6'   .+�5,      � $��0��6   .+�5-      �� -   5        $��35��5-      $��	30 15 0 0q�6(   $��35��6;   $
��Left=�6G    � ToolTip$	 New��6b   .��5.      �� $��/UIPics/new.png��6    $��25��69   $��25��6D   $��Center=�6P   $��Center=�6m   5/      �� 50      -   5        $��35��50      $��	70 15 0 0q�6(   $��35��6;   $
��Left=�6G   $
 Open��6b   .��51      �� $��/UIPics/open.png��6    $��25��6:   $��25��6E   $��Center=�6Q   $��Center=�6n   52      �� 53      -	   5        $��35��53      $��
110 15 0 0q�6(   $��35��6<   $
��Left=�6H   $
 Save��6c   .��54      �� $��/UIPics/save.png��6    $��25��6:   $��25��6E   $��Center=�6Q   $��Center=�6n   55      56      � 57      $��1��6   .+�58      �� -
   5        $��30��58      $��	0 15 82 0q�6(   $��30��6;   $��Center=�6G   $% Compile and run in MS 3D Viewer��6d   .��59      �� $��/UIPics/play.png��6    $��25��6:   $��25��6E   $��Center=�6Q   $��Center=�6n   5:      �� 5;      -   5        $	��100��5;      $��30��6)   $��Center=�65   $��	52 15 0 0q�6R   $��Compile��6e   $1 +Regular compilation outputting an .obj file��6w   6�   5<      5=      5A      �� 5D   
   $��Stretch=�6   $��5��63   $��Stretch=�6>   $��1��6\   � 5F   
   -   5        $ 
gridMiddle��5F      $��Stretch=�6#   $��Stretch=�6A   $
��Auto��6]   $
��Auto��6k   $��2��6x    5G      �� 5H      $��0 �6#   $	��400��6-   �� 5I      $��0 �6#   �� 5J      $��* �6#   �� 5K      $��0 �6#   �� 5L      $��0 �6#   $	��400��6-   �� 5M      $��30 �6#   .+�5Q      � -   5        $ gridProjects��5Q      $
��Auto��6)   $
��Auto��67   $��Stretch=�6D   $��Stretch=�6`   $��0,0,0,0q�6~   $��0��6�   {�.  .+�5R      R� -   5         R�Name$ ProjectTree��5R      $
��Auto��60   $��Stretch=�6=   5S      5T      �� 5V      -   5        	 ��Name$	 splitterProjects��5V      $��5��65   $��Stretch=�6?   $��0,0,0,0q�6]   $��1��6o   {�.  6   � 5X      $��2��6   $��1��6#    5Y      �� 5Z      $��* �6$   �� 5[      $��5 �6$   �� 5\      $	��150 �6$   $	��400��61   $	��100��6A   .+�5_      _ [ICSharpCode.AvalonEdit, Version=6.0.1.278, Culture=neutral, PublicKeyToken=9cc39be672370310'  !ICSharpCode.AvalonEdit.TextEditor  ?
avalonEdit.http://icsharpcode.net/sharpdevelop/avalonedit  5c      -   5        $��
textEditor��5f      $��0��5`      $��Stretch=�5a      $��Stretch=�5b      $
   HorizontalScrollBarVisibility$
 Disabled=�5d         ShowLineNumbers . $��Consolas)�5g         SyntaxHighlightingM  GICSharpCode.AvalonEdit.Highlighting.HighlightingDefinitionTypeConverter$	 DDD 5h      $
��10pt(�5i      $��10,10,10,10q�6%   �� 5k      $��Stretch=�6   $��Stretch=�6=   $��0,0,0,0q�6Z   $��1��6l   &   System.Windows.Controls.DataGrid  5l      -   5          Name$ 	ErrorPane��5l      $��2��6.      AutoGenerateColumns .     Columns 5m      0  *System.Windows.Controls.DataGridTextColumn  5n      ,  &System.Windows.Controls.DataGridColumn   Header$
 Type��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6;   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6G   �� *Type+   HeaderStyle 5o      �� 5p   "    �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6(   .�5q   &   ��  �� Property � �� �� Value$ Center=�6S   5r   #      ElementStyle 5t      �� 5u   "   " ��6(   .�5v   &   ��  � ��$ Center=�6L   5w   #   5y        5z      $
 Line��6-   $ 40 6;    6F   �� *
LineNumber+ 5{      �� 5|   "   "  6(   .�5}   &   ��  � ��$ Center=�6S   5~   #    5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$ Center=�6L   5�   #   5�        5�      $ Message��6-   $ * 6>    6H   �� *	Message+ 5�      �� 5�   "   "  6(   .�5�   &   ��  � ��$ Center=�6S   5�   #   5�      5�      5�      �� 5�      -   5        $	 splitterDocumentation��5�      $��3��6:   $��5��6J   $��Stretch=�6T   $��0,0,0,0q�6r   {�.  6�   �� 5�      $��Disabled=�6   $��Hidden=�6D   $��4��6i   .��5�      � -   5        $ gridDocumentation��5�      $
��Auto��62   $
��Auto��6@   $��Stretch=�6M   $��Stretch=�6i   $��0,0,0,0q�6�   {�.   5�      �� 5�      $��30 �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $��30 �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   �� 5�      $
��Auto �6(   .+�5�      � $��0��6   
�������.+�5�      �� $��Center=�6$   $��Center=�6A   
3D Objects6h   5�      9� 5�      $��Circle��6   $
��Bold"�6/   $��1��6A   .��5�      �  5�      �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   .+�5�      �� $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��0��6`   1/Circle made up from a 40 sided regular polygon.5�      �� 5�      $#��/DocumentationPics/Circle.png��6$   $��1��6K   �� 5�      $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��2��6`   B� 5�      .�6(   Allowed attributes6<   �� 6G   CAposition*, radius*, rotation-axis, rotation-angle, quality, scale5�      5�      5�      9� 5�      $
��Cone��6   $
��Bold"�6-   $��2��6?   .��5�      �  5�      �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   .+�5�      �� $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��0��6`   &$Cone which is not closed from below.5�      �� 5�      $!��/DocumentationPics/Cone.png��6$   $��1��6I   �� 5�      $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��2��6`   B� 5�      .�6(   Allowed attributes6<   �� 6G   LJposition*, radius*, height*, rotation-axis, rotation-angle, quality, scale5�      5�      5�      9� 5�      $
��Cube��6   $
��Bold"�6-   $��3��6?   .��5�      �  5�      �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   .+�5�      �� $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��0��6`   $"A cube, a specific kind of Cuboid.5�      �� 5�      $!��/DocumentationPics/Cube.png��6$   $��1��6I   �� 5�      $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��2��6`   B� 5�      .�6(   Allowed attributes6<   �� 6G   97position*, width*, rotation-axis, rotation-angle, scale5�      5�      5�      9� 5�      $��Cuboid��6   $
��Bold"�6/   $��4��6A   .��5�      �  5�      �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   .+�5�      �� $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��0��6`   !A cuboid, the generalized cube.5�      �� 5�      $#��/DocumentationPics/Cuboid.png��6$   $��1��6K   �� 5�      $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��2��6`   B� 5�      .�6(   Allowed attributes6<   �� 6G   JHposition*, width*, height*, depth*, rotation-axis, rotation-angle, scale5�      5�      5�      9� 5�      $��Cylinder��6   $
��Bold"�61   $��5��6C   .��5�      �  5�      �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   .+�5�      �� $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��0��6`   A closed cylinder.5�      �� 5�      $%��/DocumentationPics/Cylinder.png��6$   $��1��6M   �� 5�      $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��2��6`   B� 5�      .�6(   Allowed attributes6<   �� 6G   LJposition*, radius*, height*, rotation-axis, rotation-angle, quality, scale5      5     5     9� 5     $��
Hemisphere��6   $
��Bold"�63   $��6��6E   .��5     �  5     �� 5  "   $
��Auto �60   �� 5  "   $
��Auto �60   �� 5  "   $
��Auto �60   .+�5
     �� $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��0��6`   NLA horizontally cut Sphere. Note that this geometry is not closed from below.5     �� 5     $'��!/DocumentationPics/Hemisphere.png��6$   $��1��6O   �� 5     $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��2��6`   B� 5     .�6(   Allowed attributes6<   �� 6G   CAposition*, radius*, rotation-axis, rotation-angle, quality, scale5     5     5     9� 5     $
��Quad��6   $
��Bold"�6-   $��7��6?   .��5     �  5     �� 5  "   $
��Auto �60   �� 5  "   $
��Auto �60   �� 5  "   $
��Auto �60   .+�5     �� $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��0��6`   A horizontal plane.5     �� 5     $!��/DocumentationPics/Quad.png��6$   $��1��6I   �� 5     $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��2��6`   B� 5      .�6(   Allowed attributes6<   �� 6G   97position*, width*, rotation-axis, rotation-angle, scale5"     5#     5$     9� 5%     $��Sphere��6   $
��Bold"�6/   $��8��6A   .��5&     �  5'     �� 5(  "   $
��Auto �60   �� 5)  "   $
��Auto �60   �� 5*  "   $
��Auto �60   .+�5,     �� $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��0��6`   ?=A sphere with the lowest y coordinate point being the origin.5.     �� 5/     $#��/DocumentationPics/Sphere.png��6$   $��1��6K   �� 50     $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��2��6`   B� 51     .�6(   Allowed attributes6<   �� 6G   CAposition*, radius*, rotation-axis, rotation-angle, quality, scale53     54     55     9� 56     $��Triangle��6   $
��Bold"�61   $��9��6C   .��57     �  58     �� 59  "   $
��Auto �60   �� 5:  "   $
��Auto �60   �� 5;  "   $
��Auto �60   .+�5=     �� $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��0��6`   An equilateral triangle.5?     �� 5@     $%��/DocumentationPics/Triangle.png��6$   $��1��6M   �� 5A     $
��Wrap=�6(   $��Regular"�6<   $��14(�6R   $��2��6`   B� 5B     .�6(   Allowed attributes6<   �� 6G   97position*, width*, rotation-axis, rotation-angle, scale5D     5E     5F     � 5G     $��10��6   
�������.+�5H     �� $��10��6$   $��Center=�62   $��Center=�6O   Syntax6r   5I     9� 5J     $��Variables and Types��6   $
��Bold"�6<   $��11��6N   .��5K     �  5L     �� 5M  "   $
��Auto �60   �� 5N  "   $
��Auto �60   .+�5P     �� $)��#/DocumentationPics/VariableDecl.png��6$   $��0��6Q   �� 5Q     $
��Wrap=�6(   $��Regular"�6<   $��12(�6R   $��1��6`   Variable type could be �� 5R  5   .�6:   Int Float Vec36J   ��. The picture above shows the most common ways of initializing a variable. As you can see explicitly declaring types is completely up to you, there is an automatic type inference built into the language. �� 5T  \   .�6a   a_A variable identifier starts with a $ symbol and could only hold alphanumeric characters and _.5U  Q   qo A var declared const could only be assigned once which give you the possibility to declare lateinit variables.�� 5V  V   �� 6b   ��There are many operation defined between these types, basically every that makes sense (+ - * / %). It is also possible to negate a value (-$one) and get access to Vec3 coordinates and modify them separately $vec.x = 0.01f. Vec3 coordinates are Floats. Assigning to a variable could happen with the (+= -= *= /=) operators.5Z     5[     5\     9� 5]     $��	If blocks��6   $
��Bold"�62   $��12��6D   .��5^     �  5_     �� 5`  "   $
��Auto �60   �� 5a  "   $
��Auto �60   .+�5c     �� $#��/DocumentationPics/IfElse.png��6$   $��0��6K   �� 5d     $
��Wrap=�6(   $��Regular"�6<   $��12(�6R   $��1��6`   ��Just like in most programming languages, you can make if blocks. Keep in mind that you are obligated to use curly braces. As there is no bool type you might have to put complex operations in the condition. The two sides of a condition could be compared with the (== != < <= > >=) operators.5i     5j     5k     9� 5l     $��	For loops��6   $
��Bold"�62   $��13��6D   .��5m     �  5n     �� 5o  "   $
��Auto �60   �� 5p  "   $
��Auto �60   .+�5r     �� $$��/DocumentationPics/ForLoop.png��6$   $��0��6L   �� 5s     $
��Wrap=�6(   $��Regular"�6<   $��12(�6R   $��1��6`   ��You declare a non-const variable, define a range and optionally a step measure and you have a for loop. The range boundary can be inclusive �� 5u  B   .�6G   [ ]6L    and exclusive �� 6a   .�6f   ( )6k   ��. You could also substitute the numeric literals in the example with variable/operation values, but they will be truncated to integers. Also note that you cant define dynamic ranges with variables, it will always use the compile time value of a variable. Defining an infinite loop will cause compile time error.5y     5z     5{     9� 5|     $��Attribute groups��6   $
��Bold"�69   $��14��6K   .��5}     �  5~     �� 5  "   $
��Auto �60   �� 5�  "   $
��Auto �60   .+�5�     �� $&�� /DocumentationPics/AttrGroup.png��6$   $��0��6N   �� 5�     $
��Wrap=�6(   $��Regular"�6<   $��12(�6R   $��1��6`   ��With Attribute groups you could predefine attribute sets, that could be reused by 3D objects. It's worth doing when you have objects that have many common attributes. You can include attribute-groups in the object definition with the �� 5�  a   .�6f   @include('...');6x    statement.5�     5�     5�     9� 5�     $��Making 3D objects��6   $
��Bold"�6:   $��15��6L   .��5�     �  5�     �� 5�  "   $
��Auto �60   �� 5�  "   $
��Auto �60   .+�5�     �� $%��/DocumentationPics/MakingOf.png��6$   $��0��6M   �� 5�     $
��Wrap=�6(   $��Regular"�6<   $��12(�6R   $��1��6`   ��You define an object's characteristics with the mixture of attr-groups and attribute value assigns. Attribute groups should always precede the assign statements. Defining an attribute more than once will lead to a warning saying that only the last one will be the valid value. However this is not the case for the �� 5�  &   .�6+   rotation-axis6:    and �� 6E   .�6J   rotation-angle6Z   �� attributes. Rotation axes and angles are grouped into pairs, depending on their order in the code (first axis to the first angle etc). If more angles defined that axes, then the last angle(s) will be ignored. If more axes defined than angles, then the extra axes will use the last defined angle (which might be 0 when there are none. In case of complex geometries (approximated with large number of triangles) you can set the quality to either �� 5�  y   .�6~   very-low low medium6�    or �� 5�  !   .�6&   high6,   FD. Missing required attributes will default to zeros and nullvectors.5�     5�     5�     9� 5�     $��Comments��6   $
��Bold"�61   $��16��6C   .��5�     �  5�     �� 5�  "   $
��Auto �60   .+�5�     �� $
��Wrap=�6(   $��Regular"�6<   $��12(�6R   $��1��6`   hfThe language supports C type line and multiline comments. Commented pieces of the code are grayed out.5�     5�     5�     5�     5�     � 5�     ���#D3D3D3$��Right=�6(   $
��Auto��6D   $��Stretch=�6R   $��30��6n   $��0,0,0,0q�6y   $��5��6�   .+�5�     �� -   5         ��Name$ bDocumentation��5�     $��Documentation��61   $
��Left=�6I   $��-35,137,-35,0q�6d   $	��Top=�6{   $	��100��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��30��6�   z�5�     V� 5�     .~�5�     �� �� 5�     �� 5�      �� Angle$ 90Q�6.   T� 5�     5�     5�     �� 5�     -   5        $ 	bProjects��5�     $��Projects��6,   $
��Left=�6?   $��-35,36,-35,0q�6Z   $	��Top=�6p   $	��100��6�   $ 0.5,0.5&�6�   $��30��6�   z�5�     V� 5�     .~�5�     �� �� 5�     �� 5�     $ 90Q�6.   T� 5�     5�     5�     5�     5�     5�     5�     