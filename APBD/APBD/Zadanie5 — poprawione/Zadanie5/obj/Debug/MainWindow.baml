   M S B A M L   `   `   `  ����C  ?Zadanie5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:Zadanie5Zadanie5  5   	       Zadanie5.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Zadanie5     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5   
   �� 5      $��3* �6   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��1* �6   �� 5      $��5* �6   �� 5      $��1* �6   .+�5   
   o� $	��Top=�6   
�������$��0��67   $��0��6D   $��3��6T   .@�5      m� $
��Plik��6   $��5,5,0,0q�6%   .@�5      m� -   5         m�Name$ CloseMenuItem��5      $��Zamknij��62   6C   5      5      �� 5   
   $��Lista studentów��6   $��10 0 0 0q�6*   $��30(�6<   $��0��6J   $��1��6Z   &   System.Windows.Controls.DataGrid  5    
   -   5        $��StudentsDataGrid��5       $��0��6+   $��2��6;   $��3��6H      AutoGenerateColumns .     
IsReadOnly . $��	15,0,15,0q�6�      Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ Nazwisko��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6T   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 67   �� *
LastName+6T     5#      $ Imię��6%   $ * 6Q   	 63   �� *	FirstName+6Q     5$      $ Numer indeksu��6%   $
 1.5* 6\   	 6<   �� *IndexNumber+6\     5%      $ Adres��6%   $
 1.5* 6P   	 64   �� *	Address+6P     5&      $ Studia��6%   $ 3* 6N   	 65   �� *Name+6N   5(      �� 5*   
   -   5        $��AddStudentButton��5*      $��3��6)   $��1��66   $��10q�6F   $��10 10 10 10q�6S   .��6�   Dodaj6�   �� 5+   
   -   5        $��DeleteStudentButton��5+      $��3��6,   $��2��69   $��10q�6I   $��10 10 10 10q�6V   .��6�   Usuń6�   �� 5-   
   
 �� ContentStringFormat$
 Wybrano {0} studentów��6[   $��0��6�   $��3��6�   ��6   ��  �� ElementName$ StudentsDataGrid�� �� Path$ SelectedItems.Count�6�   5/      50      