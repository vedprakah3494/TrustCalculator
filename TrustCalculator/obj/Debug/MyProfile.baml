   M S B A M L   `   `   `  ����  TrustCalculator    TrustCalculator.MyProfile   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  	MyProfile��5   	   $	��500��6   $	��800��6)    � WindowStartupLocation$ CenterScreen=�65   .��5      � -   5        $��	grid_main��5      $��Center=�6�   $��Center=�6�   ��6   ��  �� ElementName$ 	MyProfile�� �� Path$ ActualWidth���6D   �� $ 	MyProfile��$ ActualHeight���5   
   �� 5       �� ImageSource$ images/bg.jpg��6    j� TileMode$
 Tile=�65    j� Stretch$
 Fill=�6E    � ColumnDefinitions 5	   
   �� 5
      $	��195 �6   �� 5      $	��200 �6   �� 5      $��10 �6   �� 5      $	��200 �6   �� 5      $	��195 �6    � RowDefinitions 5   
   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   �� 5      $��40 �6   .+�5   
   �� $��	User Name��6   $��1��6%   $��2��65   $��Times New Roman)�6B   �� 5   
   $
��Name��6   $��1��6    $��3��60   $��Times New Roman)�6=   �� 5   
   $��Email ID��6   $��1��6$   $��4��64   $��Times New Roman)�6A   �� 5    
   $��Old Passowrd��6   $��1��6(   $��5��68   $��Times New Roman)�6E   �� 5!   
   $��New Password��6   $��1��6(   $��6��68   $��Times New Roman)�6E   �� 5#   
   -   5        $��txt_UserName��5#   F   
�������	 �� CharacterCasing$	 Upper=�6.   $��30��6Z   $��2��6f   $��3��6s   
 �� 
IsReadOnly
 .  �� TextWrapping$
 Wrap=�6�   $	��150��6�   $��Times New Roman)�6�   �� 5$   
   -   5        $��txt_Name��5$   *   $	 Upper=�6   $��30��6:   $��3��6F   $��3��6S   $
 Wrap=�6c   $	��150��6w   $��Times New Roman)�6�   �� 5%   
   -   5        $��txt_EmailID��5%   +   $	 Upper=�6   $��30��6>   $��4��6J   $��3��6W   $
 Wrap=�6g   $	��250��6{   $��2��6�   $��
25,7,120,3q�6�   $��Times New Roman)�6�   �� 5&   
   -   5        $��txt_OldPassword��5&   +   $	 Upper=�6   $��30��6B   $��5��6N   $��3��6[   $
 Wrap=�6k   $	��150��6   $��Times New Roman)�6�   �� 5'   
   -   5        $��txt_NewPassword��5'   +   $	 Upper=�6   $��30��6B   $��6��6N   $��3��6[   $
 Wrap=�6k   $	��150��6   $��Times New Roman)�6�   �� 5(   
   -   5        $��Submit��5(      $��Submit��6   $��3��60   $��8��6@   $��30��6M   $��75��6Y   $��Times New Roman)�6y   5+      5,      