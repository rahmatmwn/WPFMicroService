   M S B A M L   `   `   `  ����F  BBootcampWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:BootcampWPFBootcampWPF  5   	       BootcampWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:BootcampWPF     5   	   -   5          � Title$  
MainWindow��5   	   $��475.2��6   $	��765��6+   .��5      � $��	0,0,16,10q�6   .+�5   
   �� -   5         ��Name$ 
tabControl��5      $
��Left=�6)   $	��414��6D   $��	24,10,0,0q�6Q   $	��Top=�6d   $	��707��6|   .@�5      �� $��TabItem��6   .��5      � ���	#FFE5E5E5 � ColumnDefinitions 5      �� 5      $	��30* �6+   �� 5      $
��461* �6+   .+�5      �� -   5         ��Name$ 	Namelabel��5      $
��Name��6/   $
��Left=�6>   $��	10,10,0,0q�6Y   $	��Top=�6l   $��2��6�   �� 5      -   5         ��Name$ NametextBox��5      $
��Left=�63   $��23��6~   $��	54,10,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $�� ��6�   $	��Top=�6�   $	��198��6�   $��1��6  �� 5      -   5         ��Name$ 
Savebutton��5      $
��Save��61   $
��Left=�6@   $��
348,11,0,0q�6[   $	��Top=�6o   $��75��6�   $��23��6�    J� RenderTransformOrigin$ 
1.88,0.565&�6�   $��1��6�   �� 5      -   5        $ CountTextBox��5      $
��Left=�64   $��23��6O   $��
274,10,0,0q�6[   $
 Wrap=�6o   $�� ��6�   $	��Top=�6�   $��39��6�   $��1��6�   &   System.Windows.Controls.DataGrid  5      -   5          Name$ SupplierGrid��5      $
��Left=�65   	   AutoGenerateColumns	 .  $��
10,128,0,0q�6l   $	��Top=�6�   $	��248��6�   $	��681��6�   
   
IsReadOnly
 . $��2��6-     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   ��  �� Path$ Id�6[     5      $ Supplier Name��61    6H   �� $
 Name�6h     5      $ 	Join Date��61    6D   �� $ JoinDate�6h   5      �� 5      -   5         ��Name$ SupplierComboBox��5      $
��Left=�69   $��	54,38,0,0q�6T    �� DisplayMemberPath$
 Name��6g    �� SelectedValuePath$ Id��6�   $	��Top=�6�   $��96��6�   $��1��6�   �� 5       -	   5        $ SearchComboBox��5       $
��Left=�67   $��
10,101,0,0q�6R   $	��Top=�6f   $��96��6~   $��2��6�   .@�5!      �� $��Id��6'   $
��Left=�64   $��94��6O   �� 5"      $
��Name��6'   $
��Left=�66   $��94��6Q   �� 5#      $��	Join Date��6'   $
��Left=�6;   $��94��6V   �� 5$      $��Refresh��6'   $
��Left=�69   $��94��6T   5%      �� 5&      -
   5        $ Search��5&      $��Search��6-   $
��Left=�6>   $��210,101,0,0q�6Y   $	��Top=�6n   $��75��6�   $��23��6�   $ 
1.88,0.565&�6�   $��1��6�   �� 5'      -   5        $ SearchTextBox��5'      $
��Left=�65   $��23��6P   $��
68,101,0,0q�6\   $
 Wrap=�6p   $�� ��6�   $	��Top=�6�   $	��120��6�   $��1��6�   5)      5*      �� 5+      $��TabItem��6   .��5,      � ���	#FFE5E5E56   5-      5.      50      51      