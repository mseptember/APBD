   M S B A M L   `   `   `  ����E  ACwiczenia4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:Cwiczenia4
Cwiczenia4  5   	       Cwiczenia4.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:Cwiczenia4     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ 
Exercise 3��5	   	   $	��500��6   $	��800��6)   .��5
      � $��10q�6    � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �� -   5        $��StudentsListBox��5      $��2��6)   $��0��6=   $��0��6J   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      ��  d� 	IsChecked 6#   �� *Plec+ �� Mode$ TwoWay=��� 5      $
��Bold"�6=   ��6    �� *
Nazwisko+6=   �� 5      ��6    �� *Imie+5      5      5      �� 5   
   -   5        $��AddStudentButton��5      $��1��6)   $��0��66   $��10q�6F   $��
0 10 10 10q�6S   .��6�   Dodaj6�   �� 5    
   -   5        $��ShowSelectedButton��5       $��1��6+   $��1��68   $��10q�6H   $
��0 10q�6U   .��6�   Pokaż wybranego studenta6�   &   System.Windows.Controls.DataGrid  5"   
   -   5        $��StudentsDataGrid��5"      $��2��6+   $��2��6?      AutoGenerateColumns .     Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Nazwisko��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *
Nazwisko+  5%      $
	 Imie��6%   
 63   �� *Imie+5'      5(      5)      