   M S B A M L   `   `   `  ����@  <Hover, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:HoverHover  5   	       Hover.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Hover     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � 
ResizeMode$ NoResize=�65    � WindowStyle$
 None=�6K    � 	Resources 5	       	  Hover �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value��%�  &	        �� 5
   
   .��5      U� $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6,   $ 
stackPanel��6�   .\�5        $ 0:0:0.4��6'   $ 179.656Q�69   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $ 
stackPanel��6�   .\�5        $ 0:0:0.4��6'   $ 0Q�69   5      5      5       � Triggers 5      :� 5   
   	 :� RoutedEvent$	 FrameworkElement.Loaded��6   .[�5      �� #��[  6   5      .��5      � 
 � ColumnDefinitions
 5   
   �� 5      $
��517* �6   �� 5      $��8* �6    � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5!   
   �� $��Center=�6   $��Center=�61   $��44(�6L   $��Gabriola)�6Z   ���	#FF0C00CD$
��Bold"�6�   $��0��6�   
Músicas6�   � 5"   
   $��1��6   
 5#      �� 5$      �� 5%       5'      �� 5(      �� 5)      .+�5+      � $��90��6   $	��200��6   .+�5,      �� -   5         ��Name$ 
stackPanel��5,      $	��200��61   $	��0.5��6=   
������� J� Opacity$	 0.6Q�6]    J� RenderTransformOrigin$ 0.5,0.5&�6k   z�5-      V� 5.      .~�5/      �� �� 50      �� 51      T� 52      53      55      �� 56      -   5         ��Name$ 
textBlock1��56      ���	#FF0C00CD$��16(�6G   $��Center=�6U   $	��Top=�6r   $	��0,5q�6�   $
��Bold"�6�   $��Violão��6�   $ 0Q�6�   57      �� 58      -   5        $ 
textBlock2��58      ���	#FF0C00CD$��14(�6G   $��Center=�6U   $	��Top=�6r   $
��0,25q�6�    �� TextAlignment$ Center=�6�   $
��Wrap=�6�   20Converse com pessoas que também curtem violão!6�   �� 59      ���	#FF0C00CD$	��200��61   $��90��6=   $	��0.5q�6I   $	 0.8Q�6_   5:      ��5;      �� 5<       �� ImageSource$Y Sc:\users\samir\documents\visual studio 2015\Projects\Hover\Hover\Imagens\Violao.jpg��6!    j� Stretch$ UniformToFill=�6�   5>      5?      5A      5C      