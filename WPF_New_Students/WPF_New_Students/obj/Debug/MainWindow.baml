   M S B A M L   `   `   `  ����K  GWPF_New_Students, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:WPF_New_StudentsWPF_New_Students  5   	   !    WPF_New_Students.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:WPF_New_Students     5   	     � Title$  
MainWindow��5   	   $	��420��6   $	��640��6)    � WindowStartupLocation$ CenterScreen=�65   
�������.��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ grdStudents��5
      $
��Left=�6(   $	��167��6C   $��
355,91,0,0q�6P   $	��Top=�6d   $	��215��6|      SelectionMode$ Single=�6�      SelectionUnit$ FullRow=�6�      CanUserAddRows .     
IsReadOnly . 6�   �� 5   
   -   5         ��Name$ 
FNameLabel��5      $��
First Name��6$   $
��Left=�69   $��
157,91,0,0q�6T   $	��Top=�6h   $
��Bold"�6�   $��16(�6�   �� 5   
   -   5         ��Name$ FNameTextBox��5      $
��Left=�6(   $��23��6C   $��139,122,0,0q�6O   	 �� TextWrapping$
	 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ 
LNameLabel��5      $��	Last Name��6$   $
��Left=�68   $��159,145,0,0q�6S   $	��Top=�6h   $
��Bold"�6�   $��16(�6�   �� 5   
   -   5        $ LNameTextBox��5      $
��Left=�6(   $��23��6C   $��139,176,0,0q�6O   $
	 Wrap=�6d   $	��Top=�6x   $	��120��6�   �� 5   
   -   5        $ SemesterLabel��5      $��Semester��6'   $
��Left=�6:   $��159,204,0,0q�6U   $	��Top=�6j   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        
 ��Name$
 SemesterComboBox��5      $
��Left=�6-   $��139,236,0,0q�6H   $	��Top=�6]   $	��120��6u    �� SelectedIndex$ 0��6�   .@�5      �� .��6   16   �� 5      .��6   26   �� 5      .��6   36   �� 5      .��6   46   �� 5      .��6   56   �� 5      .��6   66   �� 5      .��6   76   �� 5      .��6   86   5      �� 5   
   -   5         ��Name$ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��148,315,0,0q�6J   $	��Top=�6_   $��90��6w   $
��Bold"�6�   $��35��6�   6�   �� 5   
   -	   5        $ 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��268,315,0,0q�6P   $	��Top=�6e   $��90��6}   $
��Bold"�6�   $��35��6�   {�.  6�   �� 5   
   -
   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��388,315,0,0q�6P   $	��Top=�6e   $��90��6}   $
��Bold"�6�   $��35��6�   {�.  6�   �� 5   
   $��University of Something��6   $
��Left=�62   $��
165,10,0,0q�6M   $	��Top=�6a   $	��313��6y   $��24(�6�   $
��Bold"�6�   �� 5   
   $
��Left=�6   $	��100��6+   $��	23,22,0,0q�68   $	��Top=�6K   $	��100��6c   $��img/logo.png��6o   5       5!      