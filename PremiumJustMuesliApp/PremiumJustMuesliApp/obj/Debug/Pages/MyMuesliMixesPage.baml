   M S B A M L   `   `   `  ����O  KPremiumJustMuesliApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PremiumJustMuesliApp.PagesPremiumJustMuesliApp.Pages  5      2    ,PremiumJustMuesliApp.Pages.MyMuesliMixesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:PremiumJustMuesliApp.Pages     5        N� Title$  MyMuesliMixesPage��5	       � 	Resources 5
       �� 
TargetType �� Property �� Value��%v   '��       �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       � ��$	 100��6&   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6   .+�5   
   �� $��20(�6   $��Center=�6"   $��My Muesli Mixes��6?   $��0��6V   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGMyMuesliMixes��5   C   $��1��6   $��5q�68      
IsReadOnly .    CanUserAddRows .  	   AutoGenerateColumns	 .  ��6    �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      Header$
 Name��6/   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *Name+  5      $
 auto 6%   $ 
Price/600g��62    6F   �� *Price+  5      $
 auto 6%   $ 
Created on��62    6F   �� *CreatedDate+5      �� 5   
   -   5         ��Name$ BBack��5   9   $
��Left=�6   $��0��6,   $
��Back��6\   � 5   
   $��Center=�6   $��2��61   .+�5       �� -   5        $ BEdit��5       $
��Edit��68   �� 5!      -   5        $ BDelete��5!      $��Delete��6<   5"      5#      5$      