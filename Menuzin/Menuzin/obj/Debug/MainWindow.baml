   M S B A M L   `   `   `  ����B  >Menuzin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:MenuzinMenuzin  5   	       Menuzin.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Menuzin     5   	   6wpf&clr namespace:MaterialDesignThemes.Wpf     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   5domain1'clr namespace:MaterialDesignDemo.Domain  5
   	   FcodeDisplayer2clr namespace:CodeDisplayer;assembly-CodeDisplayer  5   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1024��6)    � 
ResizeMode$ NoResize=�66    � WindowStyle$
 None=�6L    � 	Resources 5         Filme1Style �� 
TargetType �� Property �� Value  OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame	 O� KeyTime
 O� Value  	CloseMenu��%K  &	        &	 Q     &	 +    �� 5   
   " ��6$   .�5      ��  � ��$ LeftToRight=�6.   5      �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ MenuPrincipal��6�   .\�5        $	 0:0:1��6'   $
 247.929Q�67   5      5      �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ MenuPrincipal��6�   .\�5        $	 0��6'   $
 247.929Q�63     5      $	 0:0:1��6'   $
 0Q�67   5      5      5       � Triggers 5      :� 5   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5      �� #��[ 6   5       :� 5!   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5"      �� -   5         ��Name$ CloseMenu_BeginStoryboard��5"      #��[ 6A   5#      .��5%      � -   5         �Name$ 	OneForAll��5%      .+�5&   
   � -   5        $ MenuPrincipal��5&       J� RenderTransformOrigin$ 0.5,0.5&�6&   $��2.049,0,-2.049,0q�6F   z�5'      V� 5(      .~�5)      �� �� 5*      �� 5+      T� 5,      5-      .+�5/      � ���	#FF030340 � ColumnDefinitions 50      �� 51      $��* �6'   �� 52      $	��250 �6'   .+�55      �� $	��600��6   $��Visible=�6,   .��56      �  � RowDefinitions 57      �� 58      $	��240 �6,   �� 59      $	��350 �6,   �� 5:      $	��350 �6,   .+�5<      �� $��0,90,0,87.2q�6%   $��1��6:   ���	#FF03002C6G   �� 5=      $��0,90,0,87.2q�6%   $��2��6:   ���	#FF03002C6G   �� 5>      -   5         ��Name$ ButtonCloseMenu��5>   !    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6:   $��40��6�   $��40��6�   $��0q�6�   $	��Top=�6�   $
��Left=�6�   $	��5,5q�6  $y�	Collapsed=�6.  ��6�   Z� ��6�   Z� .��5?      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�66   
�������$��30��6U   $��30��6`   5@      �� 5A      -   5        $ ButtonOpenMenu��5A   !   #��[ 69   $��40��6   $��40��6�   $��0q�6�   $	��Top=�6�   $
��Left=�6�   $	��5,5q�6  ��6�   Z� ��6�   Z� .��5B        $
 Menu=�66   
�������$��30��6U   $��30��6`   5C      �� 5D      $	��240��6    $��Right=�6-   $��0,10,59,340.4q�6I   $#��Imagem/gamer-colour-400px.png��6`   $��2��6�   �� 5E      $
��Left=�6$   $��50(�6?   ���	#FFFFF933$��40,50q�6d   $
��Bold"�6s   �� 6�   $�Bem-Vindo(a)!��6�   6�   �� 5F      $
��Left=�6$   $��20(�6?   ���	#FFABABAB$��
40,120,0,0q�6d   $
��Bold"�6x   $
��Wrap=�6�   $	��345��6�   �� 6�   $P�JCompre ingressos para filmes, peças de teatro e outros eventos culturais!��6�   6  �� 5H      $��1��6$   $
��Left=�61   $��35(�6L   $
��Bold"�6Z   ���	#FFBC1313$��40,0,0,283.4q�6�    J� Opacity$	 1.4Q�6�   �� 6�   $�Filmes��6�   6�   �� 5K      -   5        $ Anterior��5K   !   $��1��63   $
��Left=�6m   $��30��6�   $��30��6�   ��6@   Z� ��6V   Z� .��5L        $ 	ArrowBack=�66   $��30��6G   $��40��6S   $��
-25,-5,0,0q�6^   
�������6r   5M      �� 5N      -   5         ��Name$ Filme1��5N        J� Effect 5O      3  -System.Windows.Media.Effects.DropShadowEffect  5P   "      ShadowDepth$ 7Q�63   ��5R      �� 5S   "   " ��6(   .�5T   &   ��  � ��$ Imagem/Jumanji.jpg��6?   �� 5U   &    � ��$
 90,0q�6?   �� 5V   &    � ��$
 Left=�6L   �� 5W   &    � ��$ 1��6A   �� 5X   &    �@J�Opacity$	 0.6Q�6@   �� 5Y   &    � ��$	 175��6?    �� Triggers 5Z   &   P� 5[   *    P� Property �@J�IsMouseOver P� Value . . �5\   .   ��  �@�Cursor$
 Hand��6G   �� 5]   .    �@J�Opacity$	 1.0Q�6H   �� 5^   .    � ��$	 200��6G   5_   +   5a   #   5c      �� 5d      -   5        $ Filme2��5d        5e        5f   "   $ 7Q�63   ��5h      �� 5i   "   " ��6(   .�5j   &   ��  � ��$ Imagem/Star Wars.jpg��6?   �� 5k   &    � ��$ 243,78,0,77.4q�6?   �� 5l   &    � ��$
 Left=�6L   �� 5m   &    � ��$ 1��6A   �� 5n   &    �@J�Opacity$	 0.6Q�6@   �� 5o   &    � ��$	 175��6?    5p   &   P� 5q   *    �@J�IsMouseOver . . �5r   .   ��  �@�Cursor$
 Hand��6G   �� 5s   .    �@J�Opacity$	 1.0Q�6H   �� 5t   .    � ��$	 200��6G   �� 5u   .    � ��$ 243,68,0,77.4q�6G   5v   +   5x   #   5z      �� 5{      -	   5        $ Filme3��5{        5|        5}   "   $ 7Q�63   ��5      �� 5�   "   " ��6(   .�5�   &   ��  � ��$ Imagem/Sonic.jpg��6?   �� 5�   &    � ��$ 402,78,0,77.4q�6?   �� 5�   &    � ��$
 Left=�6L   �� 5�   &    � ��$ 1��6A   �� 5�   &    �@J�Opacity$	 0.6Q�6@   �� 5�   &    � ��$	 175��6?    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  �@�Cursor$
 Hand��6G   �� 5�   .    �@J�Opacity$	 1.0Q�6H   �� 5�   .    � ��$	 200��6G   �� 5�   .    � ��$ 402,68,0,77.4q�6G   5�   +   5�   #   5�      �� 5�      -
   5        $ Filme4��5�        5�        5�   "   $ 7Q�63   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$ Imagem/Animais.jpg��6?   �� 5�   &    � ��$ 551,78,0,77.4q�6?   �� 5�   &    � ��$
 Left=�6L   �� 5�   &    � ��$ 1��6A   �� 5�   &    �@J�Opacity$	 0.6Q�6@   �� 5�   &    � ��$	 175��6?    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  �@�Cursor$
 Hand��6G   �� 5�   .    �@J�Opacity$	 1.0Q�6H   �� 5�   .    � ��$	 200��6G   �� 5�   .    � ��$ 551,68,0,77.4q�6G   5�   +   5�   #   5�      �� 5�      -   5        $ Proximo��5�   !   $��1��62   $��Right=�6l   $��30��6�   $��40��6�   ��6?   Z� ��6U   Z� .��5�        $ 
ArrowRight=�66   $��30��6H   $��30��6T   $��
-15,-5,0,0q�6_   5�      �� 5�      -   5         ��Name$ sliderFilme��5�   !   $
��Left=�66   $	��Top=�6Q   $ 0Q�6i    � Maximum$ 3Q�6u   ��6�   Z� �� 5�      $��2��6$   $
��Left=�61   $��35(�6L   $
��Bold"�6Z   ���	#FFBC1313$��40,0,0,283.4q�6�   $	 1.4Q�6�   �� 6�   $�Peças��6�   6�   �� 5�      -   5        $ AnteriorPeca��5�   !   $��2��67   $
��Left=�6q   $��30��6�   $��30��6�   ��6D   Z� ��6Z   Z� .��5�        $ 	ArrowBack=�66   $��30��6G   $��40��6S   $��
-25,-5,0,0q�6^   
�������6r   5�      �� 5�      -   5        $ Peca1��5�        5�        5�   "   $ 7Q�63   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$ Imagem/Naruto.jpeg��6?   �� 5�   &    � ��$
 90,0q�6?   �� 5�   &    � ��$
 Left=�6L   �� 5�   &    � ��$ 2��6A   �� 5�   &    �@J�Opacity$	 0.6Q�6@   �� 5�   &    � ��$	 175��6?    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  �@�Cursor$
 Hand��6G   �� 5�   .    �@J�Opacity$	 1.0Q�6H   �� 5�   .    � ��$	 200��6G   5�   +   5�   #   5�      �� 5�      -   5        $ Peca2��5�        5�        5�   "   $ 7Q�63   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$ Imagem/Hamlet.png��6?   �� 5�   &    � ��$ 243,78,0,77.4q�6?   �� 5�   &    � ��$
 Left=�6L   �� 5�   &    � ��$ 2��6A   �� 5�   &    �@J�Opacity$	 0.6Q�6@   �� 5�   &    � ��$	 175��6?    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  �@�Cursor$
 Hand��6G   �� 5�   .    �@J�Opacity$	 1.0Q�6H   �� 5�   .    � ��$	 200��6G   �� 5�   .    � ��$ 243,68,0,77.4q�6G   5�   +   5�   #   5�      �� 5�      -   5        $ Peca3��5�        5�        5�   "   $ 7Q�63   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$ Imagem/Inferno.jpeg��6?   �� 5�   &    � ��$ 402,78,0,77.4q�6?   �� 5�   &    � ��$
 Left=�6L   �� 5�   &    � ��$ 2��6A   �� 5�   &    �@J�Opacity$	 0.6Q�6@   �� 5�   &    � ��$	 175��6?    5�   &   P� 5�   *    �@J�IsMouseOver . . �5�   .   ��  �@�Cursor$
 Hand��6G   �� 5�   .    �@J�Opacity$	 1.0Q�6H   �� 5�   .    � ��$	 200��6G   �� 5�   .    � ��$ 402,68,0,77.4q�6G   5�   +   5�   #   5�      �� 5�      -   5        $ Peca4��5�        5�        5�   "   $ 7Q�63   ��5�      �� 5�   "   " ��6(   .�5�   &   ��  � ��$ Imagem/RJ.jpg��6?   �� 5�   &    � ��$ 551,78,0,77.4q�6?   �� 5   &    � ��$
 Left=�6L   �� 5  &    � ��$ 2��6A   �� 5  &    �@J�Opacity$	 0.6Q�6@   �� 5  &    � ��$	 175��6?    5  &   P� 5  *    �@J�IsMouseOver . . �5  .   ��  �@�Cursor$
 Hand��6G   �� 5  .    �@J�Opacity$	 1.0Q�6H   �� 5  .    � ��$	 200��6G   �� 5	  .    � ��$ 551,68,0,77.4q�6G   5
  +   5  #   5     �� 5     -   5        $ ProximoPeca��5  !   $��2��66   $��Right=�6p   $��30��6�   $��40��6�   ��6C   Z� ��6Y   Z� .��5       $ 
ArrowRight=�66   $��30��6H   $��30��6T   $��
-15,-5,0,0q�6_   5     �� 5     -   5        $ 
sliderPeca��5  !   $
��Left=�65   $	��Top=�6P   $ 0Q�6h   $ 3Q�6t   ��6�   Z� 5     5     � 5     -   5        $ MenuDireita��5     $��1��6,   ��5     �� 5      �� EndPoint$ 0.5,1&�6.    �� 
StartPoint$ 0.5,0&�6?   .��5     �   � Color$  Black��6+   ! � Offset$! 0Q�69   � 5     $  	#FF171717��6+   $! 0.686Q�6=   5      5     �� 5     $��* �6+   �� 5      $��0 �6+   .+�5"     �� $	��150��6   $	��Top=�6)   $��Imagem/Fundo.jpg��6A   $��UniformToFill=�6[   A� 5#     $	��100��6   $	��100��6+   $	��Top=�67   $��Right=�6O   $��0,100q�6k   
���������5$     �� 5%     " �� ImageSource$" Imagem/Nice.jpg��6)   # j� Stretch$# UniformToFill=�6G   5'     �� 5(     $
��Nice��6    
�������$��24(�6?   $��Arial)�6M   $��20, 100q�6`   $	��Top=�6q   �� 5)     $��0,150,-0.4,10.4q�6!   $��2��6:   .+�5*     � $��60��6   $��20,50q�6+    5+     �� 5,  "   $��* �63   �� 5-  "   $��* �63    5/     �� 50  "   $��30 �60   �� 51  "   $��30 �60   .+�53     �� $��2K��6(   $��Bottom=�62   ���	#FFFFF933$��1��6d   $��0��6q   $
��10,5q�6�   $��16��6�   $
��Bold"�6�   �� 54     $��
SEGUIDORES��6(   $	��Top=�6:   ���	#FFFFF933$��0��6i   $��0��6v   $
��10,5q�6�   $��16��6�   $
��Bold"�6�   �� 55     $��20��6(   $��Bottom=�62   ���	#FFFFF933$��1��6d   $��1��6q   $
��10,5q�6�   $��16��6�   $
��Bold"�6�   �� 56     $��SEGUINDO��6(   $	��Top=�68   ���	#FFFFF933$��0��6g   $��1��6t   $
��10,5q�6�   $��16��6�   $
��Bold"�6�   57     �� 58     $��SOBRE��6$   $��Bottom=�61   ���	#FFFFF933$��
10,-20,0,0q�6c   $��16��6w   $
��Bold"�6�   �� 59     $
��Wrap=�6$   $��10(�68   $��	0,0,9.6,0q�6F   $��Right=�6Y   $	��230��6u   
��������� 6�   $���Nice is the protagonist of the Hamatora franchise. He is a part of the Hamatora Detective Agency, with his partner Murasaki. Nice is empathetic and caring as shown when he quickly took the job which involved someone's life but offered less compensation than usual. He is fairly absent-minded, attempting to withdraw money in a bank while it was being robbed by armed thieves without realizing they were there. He has a positive air about him, while being somewhat carefree. However, even with his happy-go-lucky attitude, Nice can sometimes act rather opportunistic and seems to lack any sort of heroic ideals. This is shown when he fights Moral, stating that he was fighting him simply because he was annoyed, not to save anybody. He is also known to be blunt, which others perceive as being condescending; this in turn leads others to distance themselves from him.��6�   6  5:     5;     5<     �� 5>     $ �� Orientation$$ 
Horizontal=�6   $	��Top=�62   $��40��6J   $��Right=�6V   $��0,0,3,0q�6r   .+�5?     �� -   5        #��[ 5?     $��30��6_   $��30��6j   $��0q�6v   $	��5,0q�6�   ��6�   Z� ��6�   Z� .��5@       $ Power=�6.   $��25��6;   $��25��6G   5A     �� 5B     #��[ 6   $��30��6_   $��30��6j   $��0q�6v   $
��10,0q�6�   ��6�   Z� ��6�   Z� .��5C       $ Settings=�6.   $��25��6>   $��25��6J   5D     5E     � 5F     -   5        $ GridEsquerda��5F     $
��Left=�6)   $	��250��6D   $��-249.951,0,0,0q�6P   ��5G     �� 5H     $ 0.5,1&�6*   $ 0.5,0&�6;   .��5I     � $  Black��6'   $! 0Q�65   � 5J     $  	#FF171717��6'   $! 0.686Q�69   5K      5M     �� 5N     $	��150 �6$   �� 5O     $��* �6$   .+�5Q     �� $	��150��6   $	��Top=�6*   $��0��6B   .+�5R     A� $	��100��6   $	��100��6+   $	��Top=�67   $��Center=�6O   $��20q�6l   
���������5S     �� 5T     $" Imagem/Nice.jpg��6)   $# UniformToFill=�6G   5V     �� 5W     -   5        #��[ 5W     $��50��6c   $��50��6n   $��0q�6z   $
��Left=�6�   $	��Top=�6�   $��10,-100q�6�   ��6�   Z� ��6�   Z� .��5X       $ Power=�62   $��40��6?   $��40��6K   5Y     �� 5Z     #��[ 6   $��50��6c   $��50��6n   $��0q�6z   $��Right=�6�   $	��Top=�6�   $��10,-100q�6�   ��6�   Z� ��6�   Z� .��5[       $ Settings=�62   $��40��6B   $��40��6N   5\     �� 5]     ���	#FFBC1313$��2��61   $	 1.0Q�6<   $��Bottom=�6J   $��0,-10q�6e   6v   5^     � 5_     $��1��6   ���	#FF171717 5`     �� 5a     $��70 �6(   �� 5b     $��70 �6(   �� 5c     $��70 �6(   �� 5d     $��70 �6(   .+�5f     �� #��[ 6   $��0��6c   
�������$��28(�6�   $��70��6�   $	��250��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   ��6�   Z� ��6	  Z� .��6!  Home5g       5h     $
 Home=�6.   $��40��6:   $��40��6F   
�������$��30,14q�6d   $��0��6s   �� 5i     #��[ 6   $��1��6c   
�������$��28(�6�   $��70��6�   $	��250��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��	0,0,-20,0q�6   ��6�   Z� ��6	  Z� .��63  Amigos5j       5k     $ Person=�6.   $��40��6<   $��40��6H   
�������$��30,14q�6f   $��1��6u   �� 5l     #��[ 6   $��2��6c   
�������$��28(�6�   $��70��6�   $	��250��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   ��6�   Z� ��6	  Z� .��6!  Conta5m       5n     $	 Key=�6.   $��40��69   $��40��6E   
�������$��30,14q�6c   $��2��6r   �� 5o     #��[ 6   $��3��6c   
�������$��28(�6�   $��70��6�   $	��250��6�   $��Center=�6�   $��Center=�6�   $
��Bold"�6�   $��	0,0,-20,0q�6   ��6�   Z� ��6	  Z� .��63  	Eventos5p       5q     $ Calendar=�6.   $��40��6>   $��40��6J   
�������$��30,14q�6h   $��3��6w   5r     5s     5t     5u     5v     