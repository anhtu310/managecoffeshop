   M S B A M L   `   `   `  ����G  CManageCoffee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ManageCoffee.View.DialogManageCoffee.View.Dialog  5   	   (    "ManageCoffee.View.Dialog.AddDialog   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ManageCoffee.View.Dialog     5   	   X TXceed.Wpf.Toolkit, Version=4.6.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  6>     � Title$  Thêm sản phẩm��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   � $��
59,74,41,0q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��0��6   $��0��6%   $	��ID:��65   $��5q�6@   �� 5      -   5         ��Name$ txt_id��5      $��0��6(   $��1��65   $��	5,5,521,5q�6Y   ��6E   �� *Id+6Y   �� 5      $��1��6   $��0��6%   $��Name:��65   $��5q�6B   �� 5      -   5        $ txt_name��5      $��1��6*   $��1��67   $��	5,5,521,5q�6^   ��6G   �� *Title+6^   �� 5      $��2��6   $��0��6%   $��Status:��65   $��5q�6D   �� 5      -   5        $ 
txt_status��5      $��2��6,   $��1��69   $��	5,5,521,5q�6a   ��6I   �� *Status+6a   �� 5      $��3��6   $��0��6%   $��	Ghi chú:��65   $��	0,5,10,19q�6E   �� 5       -   5         ��Name$ txt_description��5       $��3��6/   $��1��6<   $��
10,7,10,-8q�6o    �� AcceptsReturn$
 True��6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   ��6L   �� *Note+ �� Mode$ TwoWay=�6�   �� 5"      $��1��6   $��	Quantity:��6(   $��345,3,240,3q�69    J� RenderTransformOrigin$ 0.663,0.193&�6N   %  Xceed.Wpf.Toolkit.IntegerUpDown  5#      -   5        	  Name$	 number_quantity��5#   !   $��1��6:   $��
437,3,42,0q�6�   �  �Xceed.Wpf.Toolkit.Primitives.UpDownBase`1[[System.Nullable`1[[System.Int32, System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]], System.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a]]
   Minimum
 06�      Maximum 10006�      Value 6J   �� *
Quantity+$ TwoWay=� �� FallbackValue$ 0��6�   �� 5%      $��3��6   $��1��6&    �� Orientation$ 
Horizontal=�66   $��Right=�6O   $��0,112,307,-102q�6k   .+�5&      �� -   5        $��OK��5&      $��75��6&   $��5q�61   $��28��6S   
����  �6_   �� 5'      -   5        $��Cancel��5'      $��75��6*   $��5q�65   $��28��6[   
���  ��6g   5(      5*      5+      5,      