   M S B A M L   `   `   `  ����G  CManageCoffee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ManageCoffee.ViewManageCoffee.View  5   	   #    ManageCoffee.View.ManageCoffe   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ManageCoffee.View     5   	     � Title$  ManageCoffe��5   	   $	��550��6   $
��1200��6*    � 	Resources 5	         DataGridColumnHeaderStyle �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Property �� Value��%�   &	        �� 5   
   "  62   .�5      ��  � ��
 �����6+   �� 5       � ��
 ��  �6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�6;   5      5      .��5      � $��	0,0,10,14q�6   
����ح�.+�5   
   �� -   5        $��DS đồ uống��5      $
��Left=�6&   $��
436,27,0,0q�6A   $	��Top=�6U   $	��145��6m   6�   �� 5   
   -   5        $��DS đồ ăn kèm��5      $
��Left=�6(   $��
637,26,0,0q�6C   $	��Top=�6W   $	��145��6o   6{   �� 5   
   -   5        $��Tạo đơn��5      $
��Left=�6#   $��126,449,0,0q�6>   $	��Top=�6S   $	��144��6k   $��36��6w   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ list_product��5         AutoGenerateColumns$ False��6A   $��412,71,38,92q�6]      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6s      ColumnHeaderStyle# [  6�   ��6)   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 STT��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Id+  5      $

 Name��6%    63   �� *Title+  5      $
 Price��6%    64   �� *Price+  5      $
 Description��6%    6:   �� *Description+4  .System.Windows.Controls.DataGridTemplateColumn  5      $
 Status��6)      CellTemplate 5      �� 5      .R�5      �� ��6(   �� *Status+��5    "   �� 5!   &   " ��6,    �� Triggers 5"   *   �� 5#   .    �� Binding 6:   �� *Status+ �� Value 
Còn Hàng6U   .a�5$   2   ��  � ��
 � � �6O   5%   /   �� 5&   .    6:   �� *Status+ Hết Hàng6U   .a�5'   2   ��  � ��
 �  ��6O   5(   /   5*   '   5,      5-      5/      51      �� 53   
   -   5        $��
Quản lý��53      $
��Left=�6#   $��	47,10,0,0q�6>   $	��Top=�6Q   $	��159��6i   $��32��6�     55   
   -   5        $ select_grid��55      $ False��6A   $ * 6]   $��47,71,824,156q�6m   # [  6�   ��6(   �� 	 56        57      $	
 STT��6%    62   �� *Id+  58      $

 Name��6%    63   �� *Name+  59      $
 Số lượng��6%    67   �� *	soluong+5<      �� 5=   
   -   5        $��
Tất cả��5=      $
��Left=�6"   $��
851,26,0,0q�6=   $	��Top=�6Q   $	��145��6i   6u   �� 5>   
   $
��Left=�6   $��
89,388,0,0q�5?      $
��Wrap=�5@      $��Tổng tiền��5A      $	��Top=�5B      
���  ��5C      �� 5D   
   -   5         ��Name$ 	txt_total��5D      $
��Left=�6%   $��231,388,0,0q�6@    �� TextWrapping$
 Wrap=�6U   $	��Top=�6j   $	��120��6�   5F      5G      