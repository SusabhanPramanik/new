   M S B A M L   `   `   `  ����A  =EmpWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EmpWPF.ViewsEmpWPF.Views  5      5clr-namespace:EmpWPF.ViewModelsEmpWPF.ViewModels  67   "    EmpWPF.Views.EmployeeDetails   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:EmpWPF.Views     5      6
viewmodelsclr-namespace:EmpWPF.ViewModels     67   $
��1123��5	      $
��1200��6   
��� ���  � 	Resources  5
         	SomeStyle �� 
TargetType)  #System.Windows.Controls.DataGridRow �� Triggers P� Property P� Value �� Property �� Value  DefaultTextBoxStyle " CustomErrorControlOnErrorStyle �� BasedOn ��Name	 �� ElementName
 �� Path��%k  &	        &	 �     &	 �     7  �� 5   
   "  6"    5   
   P� 5       �@ 
IsSelected . . �5      ��  � ��
 �  ��6/   5      5      �� 5   
   " ��6,   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ Center=�62   5      �� 5    
   " ��67   8   .�5!      ��  �@=�ErrorTemplate 5"      �� 5#      .R�5$      �� .+�5%      �� $ placeholder��68   �� 5&      $��11(�6(   $��Italic$�66   
���  ����5'   (   �� $	 placeholder��$8
 2AdornedElement.(Validation.Errors)[0].ErrorContent�5(      5)      5+      5,      5-      .��5.      ��  �� Orientation$ Vertical=�6   $��	0,0,0,402q�6(   .+�5/   
   �� $��Employee Form��6   $��10q�6*   .��50      � 
����ح�$	��240��6*    � RowDefinitions 51      �� 52      $��1* �6$   �� 53      $��1* �6$   �� 54      $��1* �6$   �� 55      $��1* �6$   �� 56      $��1* �6$    � ColumnDefinitions 58      �� 59      $	��100 �6'   �� 5:      $��* �6'   �� 5;      $	��100 �6'   �� 5<      $��* �6'   .+�5>      �� $��
EmployeeID��6   $
��Left=�6-   $��Center=�5?      $��0��6:   $��0��6J   �� 5@      -   5         ��Name$ 	TextBoxID��5@   E    �� 	MaxLength$ 8��6   $��0��6(   $��1��65   $��27��6�   #��[ 5A   g   $��5q�6�   $	��300��6�   $
��Left=�6�   ��6   �� *
EmployeeID+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5B      $��EmployeeName��6   $
��Left=�6/   $��Center=�6J   $��1��5C      $��0��6%   �� 5D      -   5        $ TextBoxName��5D   7   $��1��6   $��1��6'   $��27��6L   #��[ 5E   �   $��5q�6�   $	��300��6�   $
��Left=�6�   ��6   �� *EmployeeName+$ TwoWay=� �� ValidatesOnDataErrors . $ PropertyChanged=�6�   �� 5F      $��Address1��6   $
��Left=�6+   $��Center=�6F   $��2��5G      $��0��6%   �� 5H      -   5        $ TextBlockAddress1��5H   7   $��2��6   $��1��6'   #��[ 5I      $��5q�6�   $	��300��6�   $
��Left=�6�   ��6   �� *
Address1+$ TwoWay=� . $ PropertyChanged=�6�   �� 5J      $��Address2��6   $
��Left=�6+   $��Center=�6F   $��3��5K      $��0��6%   �� 5L      -   5        $ TextBoxAddress2��5L   7   $��3��6   $��1��6'   $��27��6P   #��[ 5M      $��5q�6�   $	��300��6�   $
��Left=�6�   ��6   �� *
Address2+$ TwoWay=� . $ PropertyChanged=�6�   �� 5N      $��Phone Number��6   $
��Left=�6/   $��Center=�6J   $��4��5O      $��0��6%   �� 5P      -   5        $ TextBoxPhoneNumber��5P   F   $ 10��6   $��4��6)   $��1��66   $��27��6�   $��5q�5Q   g   $	��300��6r   $
��Left=�6~   ��6   �� *PhoneNumber+$ TwoWay=�$ PropertyChanged=�6~   �� 5R      $��Father's Name��6   $
��Left=�60   $��Center=�6K   $��0��5S      $��2��6%   �� 5T      -   5        $ TextBoxFatherName��5T   7   $��0��6   $��3��6'   $��27��6R   #��[ 5U   �   $��5q�6�   $	��300��6�   $
��Left=�6�   ��6   �� *
FatherName+$ TwoWay=� . $ PropertyChanged=�6�   �� 5V      $��Mother's Name��6   $
��Left=�60   $��Center=�6K   $��1��5W      $��2��6%   �� 5X      -   5        $ TextBoxMotherName��5X   7   $��1��6   $��3��6'   $��27��6S   #��[ 5Y   �   $��5q�6�   $	��300��6�   $
��Left=�6�   ��6   �� *
MotherName+$ TwoWay=� . $ PropertyChanged=�6�   �� 5Z      $	��DOB��6   $
��Left=�6&   $��Center=�6A   $��2��5[      $��2��6%   (  "System.Windows.Controls.DatePicker  5\      -   5          Name$ 
Datapicker��5\   :   $��2��6   $��3��6*   $��27��6N   $��5q�5]   _   $	��300��6j   $
��Left=�6v      Text 6   �� *DOB+$ TwoWay=�$ PropertyChanged=�6v   �� 5^      $��State��6   $
��Left=�6(   $��Center=�6C   $��3��5_      $��2��6%   �� 5`      -	   5        $ TextBoxState��5`   7   $��3��6   $��3��6'   $��27��6M   #��[ 5a   |   $��5q�6�   $	��300��6�   $
��Left=�6�   ��6   �� *State+$ TwoWay=� . $ PropertyChanged=�6�   �� 5b      $	��Age��6   $
��Left=�6&   $��Center=�6A   $��4��5c      $��2��6%   �� 5d      -
   5        $ 
TextBoxAge��5d   E   $ 2��6   $��4��6(   $��3��65   $��27��6�   #��[ 5e   _   $��5q�6�   $	��300��6�   $
��Left=�6�   ��6   �� *Age+$ TwoWay=�$ PropertyChanged=�6�   5f      5g      �� 5h   
   $��1��6   $��40��6"   $ 
Horizontal=�6.   $��Center=�6G   .+�5i      �� -   5         ��Name$ 
ButtonSave��5i      $	��Add��6E   
������$��30��6k   $��80��6w   {�6)   �� *ADD+��5j      �� *PostAddButtonClicked+�� 5k      -   5        $ 
ButtonEdit��5k   C   $��Update��6   
��� ���$��2q�6k   $��30��6v   $��80��6�   {�6&   �� *Change+��6�   �� *EmployeeList+��5l   )   �� *PostButtonClicked+�� 5m      -   5        $ ButtonDelete��5m   C   $��Delete��6   
���  ��$��2q�6j   $��30��6u   $��80��6�   {�6&   �� *Change+��6�   �� *EmployeeList+��5n   )   �� *DeleteButtonClicked+6Q   �� 5o      -   5        $ 	ButtonNew��5o   #   $	��New��6   
����  �$��2q�6`   $��30��6k   $��80��6w   ��66   �� *New+6w   5p      �� 5q   
   $	��524��6   
�������.+�5r      &   System.Windows.Controls.DataGrid  D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5s      -   5          Name$ 
dgEmployee��5r         CanUserAddRows .    AutoGenerateColumns .  $��14(�5t   :   ��6   �� $
 	Employees� �� SelectedItem 6H   �� *EmployeeList+$ TwoWay=�   Columns 5u      0  *System.Windows.Controls.DataGridTextColumn  5v      ,  &System.Windows.Controls.DataGridColumn   Header$ 
EmployeeID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6a   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� $
 
EmployeeID�6a     5w      $ Employee Name��6)   $	 120 6f      
IsReadOnly .  6@   �� $
 EmployeeName�6s     5x      $ Address1��6)   $	 100 6]    .  6;   �� $
 Address1�6j     5y      $ Address2��6)   $	 100 6]    .  6;   �� $
 Address2�6i     5z      $ Phone Number��6)   $	 120 6d    .  6?   �� $
 PhoneNumber�6p     5{      $ Father's Name��6)   $	 120 6d    .  6@   �� $
 
FatherName�6p     5|      $ Mother's Name��6)   $	 130 6d    .  6@   �� $
 
MotherName�6p     5}      $	 DOB��6)   $	 100 6S    .  66   �� $	
 DOB�6_     5~      $ State��6)   $	 100 6W    .  68   �� $
 State�6c     5      $	 Age��6)   $	 100 6S    .  66   �� $	
 Age�6_   4  .System.Windows.Controls.DataGridTemplateColumn  5�      $	 100 6-   5�      5�      5�      5�      5�      