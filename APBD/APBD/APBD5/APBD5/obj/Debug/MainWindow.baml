   M S B A M L   `   `   `  ����@  <APBD5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:APBD5APBD5  5   	       APBD5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:APBD5     5   	     � Title$  
MainWindow��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��400��6A   $	��800��6N   .��5	      ]� .+�5
   
   o� $	��Top=�6   
�������.@�5      m� $
��Plik��6   5      � 5   
    � RowDefinitions 5      �� 5      $��60 �6    �� 5      �� 5      $��60 �6     � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��90��6#   �� 5      $	��210 �6#   $��90��6/   .+�5      �� $��Lista studentów��6   $��Bottom=�6.   $��30(�6I   $��20 0 0 0q�6W   �� 5      -   5        $��HowManyStudentsIsSelected��5      $��2��65   $	��Top=�6B   $��10(�6Z   $��20 0 0 0q�6h   �� 5      -   5        $��	AddButton��5      $��Dodaj��6&   $��2��66   $��2��6F   $��25��6S   $��90��6_   $
��Left=�6j   6�   �� 5      -   5        $��RemoveButton��5      $��Usuń��6)   $��2��68   $��2��6H   $��25��6U   $��90��6a   $��Right=�6l   $��0 0 20 0q�6�   6�   &   System.Windows.Controls.DataGrid  5       -   5        $��StudentsDataGrid��5       $��1��6/   $��3��6<   $��	20 0 20 0q�6P      CanUserAddRows .     
IsReadOnly .    AutoGenerateColumns .   � 	Resources 5!      )  #System.Windows.Controls.DataGridRow �� 
TargetType��%E   '        �� 5"      "  6   .�5#      -   5        5$      5%      	   Columns	 5&      0  *System.Windows.Controls.DataGridTextColumn  5(      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Nazwisko��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 1.5* 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *
Nazwisko+6X     5)      $

 Imie��6)   $ 1* 6P    67   �� *Imie+6P     5*      $
 Numer indeksu��6)   $ 2* 6^    6@   �� *	NrIndeksu+6^     5+      $
 Adres��6)   $ 2* 6R    68   �� *Adres+6R     5,      $
 Studia��6)   $ 4* 6Y    69   �� *Studia.Name+6Y   5.      5/      50      51      