   M S B A M L   `   `   `  ����G  CManageCoffee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:ManageCoffee.ViewManageCoffee.View  5   	   &     ManageCoffee.View.ManageCategory   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:ManageCoffee.View     5   	     � Title$  ManageCategory��5   	   $	��450��6    $	��800��6-    � 	Resources 5	         DataGridColumnHeaderStyle �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader �� Property �� Value��%�   &	        �� 5   
   "  62   .�5      ��  � ��
 �����6+   �� 5       � ��
 ��  �6+   �� 5       � ��$
 Bold"�6+   �� 5       � ��$ Center=�6;   5      5      .��5      � $��
0,0,10,108q�6   
����ح�.+�5   
   �� -   5         ��Name$ btn_add��5      $��Thêm Mới��6"   $
��Left=�65   $��	50,22,0,0q�6P   $	��Top=�6c   $	��145��6{   6�   &   System.Windows.Controls.DataGrid  5   
   -   5           AutoGenerateColumns$ False��5   +   $��50,52,38,10q�6G      ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6\      ColumnHeaderStyle# [  6�   ��6   �� 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$	
 STT��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Id+  5      $

 Name��6%    63   �� *Name+5      �� 5   
   -   5         ��Name$ 
txt_search��5      $
��Left=�6&   $��
456,17,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $	��Top=�6j   $	��198��6�   $��25��6�   �� 5   
   -   5        $��Tìm kiếm��5      $
��Left=�6$   $��
669,22,0,0q�6?   $	��Top=�6S   $��83��6k   $��20��6v   6�   5      5      