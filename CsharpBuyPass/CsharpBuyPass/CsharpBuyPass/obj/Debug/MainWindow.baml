   M S B A M L   `   `   `  ����H  DCsharpBuyPass, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CsharpBuyPassCsharpBuyPass  5   	       CsharpBuyPass.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:CsharpBuyPass     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��600��6   $
��1024��6)    � WindowStyle$
 None=�66    � 
ResizeMode$ NoResize=�6I    � Topmost .  � WindowStartupLocation$ CenterScreen=�6n   $��Center=�6�   $��Center=�6�    � SizeToContent$ WidthAndHeight=�6�   .��5
      � ���#202020$��Right=�6    $
��1024��6<   $	��600��6I   $	��Top=�6V    J� RenderTransformOrigin$ 0.479,0.487&�6n   .+�5   
   �� -   5         ��Name$ Power��5       0  ,MaterialDesignFloatingActionMiniAccentButton#��[  6    $��50��6f   $��50��6q   $��0q�6}   $��Right=�6�   $	��Top=�6�   $��20,20q�6�   ��6�   Z� ��6�   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Power=�6&   $��40��63   $��40��6?   ���	#DDFFFFFF6J   5      �� 5   
   	 �� CornerRadius$	 15��6   ���#A2A2A2
 �� Padding$
 2q�68   $��450px��6D   $	��500��6S   ._�5      � ��5      �� 5       �� 
TargetType" �6   .�5      ��  �� Property � �� �� Value$	 500��62   �� 5       � ��$	 450��63   �� 5       � �� �#20202067   �� 5       � ��$ Center=�6>   �� 5       � ��$ Center=�6@   5      .+�5      � $��	3.2,0,0,0q�6   .+�5      �� $ ��Imagem\LogoProvisório.png��6   $	��200��6?   $	��Top=�6K   $��Center=�6c   $��50,60,160,0q�6�   6�   �� 5      $��Login��6    $
��Lato)�6-   $
��30px(�6?   $
��Bold"�6O   ���	#FFFFBA00$��0,130,230,0q�6x   $��Center=�6�   6�   �� 5      $��Center=�6!   $��0,10,0,0q�6<   $��Center=�6N   $	��500��6k   .+�5      �� -   5         ��Name$ txtEmail��5   "   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ E-mail��64    % !MaterialDesignFloatingHintTextBox#��[ 6\   $
��Lato)�6�   $
��20px(�6�   
�������$��100,50,100,0q�6�   6�   G� 5      -   5         G�Name$ txtSenha��5   &   $ Senha��68    ) %MaterialDesignFloatingHintPasswordBox#��[ 6_   $
��Lato)�6�   $
��20px(�6�   
�������$��100,20,100,0q�6�   6�   �� 5      -   5         ��Name$ btnRelembrar��5   $   $��Right=�6:   $
��13px(�6V   $��Esqueceu sua senha?��6f   ���	#FFA2A2A2$��	0,3,100,0q�6�    � Cursor$
 Hand��6�   5       5!      �� 5"      $��Bottom=�6!   .+�5#      �� $��21��6%   $��100,-30,-0.2,0q�61   .+�5$      �� $
��Lado)�6(   ���#A2A2A2$
��Left=�6O   $��0,0,0,0q�6j   $
��15px(�6{   $��Não possui conta?��6�   �� 5%      -   5        $ btnCadastrar��5%   (   $
��Lado)�6>   ���	#FFFF4343$
��15px(�6g   $��Clique aqui��6w   $
��Wrap=�6�   $
��Left=�6�   $	��Top=�6�   $��125,-16,0,-18q�6�   $
 Hand��6�   $��27��6'  5&      �� 5'      -   5        $ 	btnEntrar��5'   !   ���	#FFFF4343$	��300��6K   $��Center=�6W   $��Bottom=�6t   $��0,0,0,50q�6�   $
 Hand��6�   .��5(      �� $��Entrar��6(   $
��Lado)�66   ���#FFFFFF$
��20px(�6]   $��Center=�6m   $��Center=�6�   $��0,0,0,0q�6�   5)      5*      5+      5,      5-      5.      5/      