   M S B A M L   `   `   `  ����G  CManageCoffee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:ManageCoffee.View.DialogManageCoffee.View.Dialog  5   	   )    #ManageCoffee.View.Dialog.AddProduct   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:ManageCoffee.View.Dialog     5   	     � Title$  
AddProduct��5   	   $	��450��6   $	��800��6)   .��5	      � $��
59,74,41,0q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� $��1��6   $��0��6!   $��Name:��61   $��5q�6>   �� 5   
   -   5         ��Name$ 	txt_title��5      $��1��6%   $��1��62   $��	5,5,521,5q�6C   �� 5   
   $��1��6   $��1��6!   $��Description:��61   $��193,5,400,5q�6E   �� 5   
   -   5        $ txt_description��5      $��1��6+   $��1��68   $��306,5,220,5q�6I   �� 5   
   $��2��6   $��0��6!   $��Price:��61   $��5q�6?   �� 5   
   -   5        $ 	txt_price��5      $��2��6%   $��1��62   $��	5,5,521,5q�6C   �� 5   
   $��2��6   $��1��6!   $��	Category:��61   $��193,5,396,5q�6B   �� 5   
   -   5        $ txt_category��5      $��2��6(   $��1��65   $��306,5,220,5q�6F   �� 5!   
   -   5         ��Name$ cb_category��5!       �� DisplayMemberPath$
 Name��5#       �� SelectedValuePath$ Id��5$      $��2��5%      $��1��6$   $��306,5,220,5q�64    �� SelectedValue 5"      �� *SelectedCategory.Id+5%   4   �� 5'   
   $��3��6   $��1��6"    �� Orientation$ 
Horizontal=�62   $��Right=�6K   $��0,112,307,-102q�6g   .+�5(      �� -   5        $��OK��5(      $��75��6"   $��5q�6-   $��28��6O   
����  �6[   �� 5)      -   5        $��Cancel��5)      $��75��6&   $��5q�61   $��28��6W   
���  ��6c   5*      5,      5-      