   M S B A M L   `   `   `  ����@  <APBD5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:APBD5APBD5  5   	       APBD5.DeansOffice   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:APBD5     5   	     � Title$  DeansOffice��5   	    � WindowStartupLocation$ CenterScreen=�6   $	��400��6B   $	��330��6O    � 
ResizeMode$ NoResize=�6[   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $��60 �6   �� 5      �� 5      �� 5      �� 5      �� 5      $��3* �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� -   5        $��
TitleLabel��5      $��2��6"   $��30(�66   $��Center=�6D   �� 5   
   $��Nazwisko��6   $��1��6#   $��Right=�60   $��Center=�6L   �� 5   
   $
��Imie��6   $��2��6   $��Right=�6,   $��Center=�6H   �� 5   
   $��
Nr indeksu��6   $��3��6%   $��Right=�62   $��Center=�6N   �� 5   
   $��Studia��6   $��4��6!   $��Right=�6.   $��Center=�6J   �� 5   
   $��
Przedmioty��6   $��5��6%   $��Right=�62   $	��Top=�6N   �� 5   
   -   5        $��NazwiskoTextBox��5      $��1��6)   $��1��69   $��5q�6F   �� 5    
   -   5        $��ImieTextBox��5       $��1��6%   $��2��65   $��5q�6B   �� 5!   
   -   5        $��NrIndeksuTextBox��5!      $��1��6*   $��3��6:   $��5q�6G   �� 5"   
   -   5        $��StudiaComboBox��5"       �� DisplayMemberPath$
 Name��6)   $��1��6B   $��4��6R   $��5q�6_   �� 5#   
   -   5        $��PrzedmiotyListBox��5#      $��1��6+   $��5��6;   $��5q�6H   ��5$      �� 5%      .R�5&      ��  �� Orientation$ 
Horizontal=�6!   .+�5'      �� ��6#   �� *Name+ d� 	IsChecked 6<   �� *	IsChecked+ �� Mode$ TwoWay=�5(      5)      5+      �� 5-   
   -   5        $��ConfirmButton��5-      $��1��6&   $��6��66   $��25��6C   $��90��6O   $
��Left=�6Z   $��5 0 0 0q�6u   6�   �� 5.   
   -   5        $��RemoveButton��5.      $��Usuń��6%   $��1��64   $��6��6D   $��25��6Q   $��90��6]   $��Right=�6h   $��0 0 5 0q�6�   6�   �� 5/   
   -	   5        $��CheckButton��5/      $��Check��6$   $��0��64   $��6��6D   $��25��6Q   $��90��6]   $��Right=�6h   $��0 0 5 0q�6�   6�   51      52      