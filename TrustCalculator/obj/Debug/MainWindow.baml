   M S B A M L   `   `   `  ����  TrustCalculator     TrustCalculator.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Trust Calculator��5   	   $	��400��6"   $	��625��6/    � WindowStartupLocation$ CenterScreen=�6;    � Topmost .  � 
ResizeMode$ NoResize=�6o    � Icon$ images/logo.png��6�   .��5      �  J� OpacityMask# � ��6   $��Center=�6P   $��0,0,-8,0q�6m   $	��625��6    � ColumnDefinitions 5   
   �� 5      $
��499* �6   �� 5      $
��126* �6   ��5
   
   �� 5       �� ImageSource$ images/home.jpg��6    j� TileMode$
 Tile=�67   	 j� Stretch$
	 Fill=�6G   .+�5   
   �� $��	User Name��6   $
��Left=�6$   $��359,164,0,0q�6?   $	��Top=�6T   $��14(�6l   ���	#FFF6F6F66z   �� 5   
   $��Password��6   $
��Left=�6#   $��364,209,0,0q�6>   $	��Top=�6S   
 J� RenderTransformOrigin$
 0.056,0.504&�6k   $��14(�6�   ���	#FFF6F6F66�   �� 5   
   -   5        $��txt_username��5      $
��Left=�6&   $��30��6A   $��458,163,0,0q�6M    �� TextWrapping$
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��120��6�   $��2��6�   G� 5   
   -   5        $��txt_Password��5      $
��Left=�6*   $��457,209,0,0q�6E   $	��Top=�6Z   $	��120��6r   $��30��6~   $��2��6�   �� 5   
   -   5        $��Submit��5      $
��Left=�6"   $��476,254,0,0q�6=   $	��Top=�6R   $	��100��6j   $��30��6v   $
 0.512,-0.319&�6�   $��2��6�   5      5      