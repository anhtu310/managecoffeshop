   M S B A M L   `   `   `  ����G  CManageCoffee, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ManageCoffeeManageCoffee  5   	       ManageCoffee.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ManageCoffee     5   	     � Title$  
MainWindow��5   	   $	��837��6   $	��500��6(   .��5	      � $��	0,-15,0,5q�6   .+�5
   
   �� 
������� �� CornerRadius$ 6��5      $��418,10,11,0q�6    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 15Q�6#      	Direction$	 -90Q�5         RenderingBias$ Quality=�5         ShadowDepth$ 0Q�5         Color$
 Gray��5      ._�5      ��  �� Orientation$ Vertical=�6   $��20q�5      .+�5      �� $��Login��6   $��25(�5      $��Center=�5      $	��Top=�5      $
��Bold"�5      	 �� Padding$	 10q�5      � 5      $��Center=�6   
 � RowDefinitions
 5      �� 5      $��* �6(   �� 5       $��* �6(   �� 5!      $��* �6(   �� 5"      $��* �6(   .+�5$      �� $��	User Name��6    $��0��5%      $
��0,15q�5&      $
��Left=�5'      �� 5(      $��1��6   $��Admin��5)      $��1��5*      $	��0,5q�5+      $	��255��5,      $��0,0,0,1q�5-      $
��Left=�5.      �� 50      $��Password��6    $��2��51      $
��0,15q�52      $
��Left=�53      G� 54      $��3��6"    G� Password$ 122343��55      $	��0,5q�56      $	��255��57      $��0,0,0,1q�58      $
��Left=�59      5:      �� 5<      -   5         ��Name$ LoginBtn��5<      $��Login��5=      
�������
���   �$
��0,25q�5@      $��35��5A      $	��250��5B      ��5C      �� 5D       �� 
TargetType" ��6    .�5E      ��  �� Property � �� �� Value 5F   "   �� 5G   &    �� 
TargetType" ��66   .R�5H   *   ��  ��Name$ LoginBorder��61   #��z��6F   $ 16��5I   -   ._�5J   .   �� $��Center=�6?   $��Center=�5K   ;   5L   +    �� Triggers 5M   *   P� 5N   .    P� Property �@J�IsMouseOver P� Value$
 True��6M   . �5O   2   ��  �� 
TargetName$ LoginBorder��6a    � ��
 ������� 5P   2   $ LoginBorder��6h    � ��
 �   �5Q   /   5S   '   5U      5V      5X      �� 5Y      $��Not a member?��6   $	��0,5q�5Z      $��Bottom=�5[      $��Center=�5\      �� 5]      $��Sign Up��6   $
��0,10q�5^      $��Bottom=�5_      $��Center=�5`      5a      5b      �� 5c   
   $��view/image/logo.jpg��6   $
��Fill=�6-   $
��Left=�6<   $	��470��6W   $��1,0,0,0q�6d   $��Center=�6u   $	��403��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5d      V� 5e      .~�5f      �� �� 5g       �� AngleY$ 0.339Q�6$   �� 5h      T� 5i       T� Y$ 1.097Q�6)   5j      5l      5m      5n      