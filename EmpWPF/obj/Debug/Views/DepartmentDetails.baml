   M S B A M L   `   `   `  ����A  =EmpWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:EmpWPF.ViewsEmpWPF.Views  5      5clr-namespace:EmpWPF.ViewModelsEmpWPF.ViewModels  67   $    EmpWPF.Views.DepartmentDetails   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:EmpWPF.Views     5      6
viewmodelsclr-namespace:EmpWPF.ViewModels     67   $
��1123��5      $
��1200��6   
���k���  � 	Resources  5	         DefaultTextBoxStyle �� 
TargetType �� Property �� Value " CustomErrorControlOnErrorStyle �� BasedOn ��Name �� ElementName �� Path��%�  &	        &	 o     7   �� 5
   
   " ��6,   .�5      ��  � ��$ 5q�6'   �� 5       � ��$ Center=�62   5      �� 5   
   " ��67   8   .�5      ��  �@=�ErrorTemplate 5      �� 5      .R�5      �� .+�5      �� $ placeholder��68   �� 5      $��11(�6(   $��Italic$�66   
���  ����5   (   �� $ placeholder��$8 2AdornedElement.(Validation.Errors)[0].ErrorContent�5      5      5      5      5      .��5      ��  �� Orientation$ Vertical=�6   $��	0,0,0,402q�6(   .+�5   
   �� $��Department Form��6   $��10q�6,   .��5      � 
����ح�$	��240��6*   	 � RowDefinitions	 5       �� 5!      $��1* �6$   �� 5"      $��1* �6$   �� 5#      $��1* �6$   �� 5$      $��1* �6$   �� 5%      $��1* �6$   
 � ColumnDefinitions
 5'      �� 5(      $	��137 �6'   �� 5)      .+�5,      �� $��Employee ID��6   $
��Left=�6.   $��Center=�5-      $��0��6:   $��0��6J   $��77��6W   �� 5.      -   5         ��Name$ 	TextBoxID��5.   E    �� 	MaxLength$ 8��6   $��0��6(   $��1��65   #��[ 5/   f   $��	5,10,0,10q�6�   $	��300��6�   $
��Left=�6�   ��6   �� *
EmployeeID+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 50      $��Department ID��6   $
��Left=�60   $��Center=�6K   $��1��51      $��0��6%   $��88��65   �� 52      -   5        $ TextBoxDepID��52   E   $ 2��6   $��1��6(   $��1��65   #��[ 53   g   $��5,0,0,15q�6�   $	��300��6�   $
��Left=�6�   $��Bottom=�6�   ��6   �� *DepartmentID+$ TwoWay=�$ PropertyChanged=�6�   �� 54      $��Department Name��6   $
��Left=�62   $��Center=�6M   $��2��55      $��0��6%   $��26��65   $	��109��6A   �� 56      -   5         ��Name$ 
cmbDepName��56   9   $��2��6   $��1��6)   $��5,5,0,5q�57   �   $	��300��6�    �� 
IsEditable . $
��Left=�6�    �� Text 6   �� *DepartmentName+$ TwoWay=� �� ValidatesOnDataErrors . $ PropertyChanged=�.@�59      �� .��6#   C#6'   �� 5:      .��6#   Java6)   �� 5;      .��6#   Python6+   �� 5<      .��6#   C++6(   �� 5=      .��6#   C6&   �� 5>      .��6#   java Script60   5?      5@      5A      �� 5B   
   $��40��6   $ 
Horizontal=�6!   $��Center=�6:   .+�5C      �� -   5         ��Name$ 
ButtonSave��5C      $	��Add��6)   
������$��30��6i   $��80��6u   {�67   �� *ADD+��5D      �� *PostAddButtonClicked+�� 5E      -   5        $ 
ButtonEdit��5E   &   $��Update��6   
��� ���$��2q�6k   $��30��6v   $��80��6�   {�6:   �� *chnage+��6�   �� *DepartmentList+��5F   )   �� *PostButtonClicked+�� 5G      -   5        $ ButtonDelete��5G   &   $��Delete��6   
���  ��$��2q�6j   $��30��6u   $��80��6�   {�6<   �� *chnage+��6�   �� *DepartmentList+��5H   )   �� *DeleteButtonClicked+6Q   �� 5I      -   5        $ 	ButtonNew��5I   #   $	��New��6   
����  �$��2q�6`   $��30��6k   $��80��6w   ��66   �� *New+6w   5K      �� 5L   
   $	��248��6   
�������.+�5M      &   System.Windows.Controls.DataGrid  D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5N      -   5          Name$ dgDepartment��5M         CanUserAddRows .    AutoGenerateColumns .  $��14(�5O   <   ��6   �� $ Departments� �� SelectedItem 6J   �� *DepartmentList+$ TwoWay=�   Columns 5P      0  *System.Windows.Controls.DataGridTextColumn  5Q      ,  &System.Windows.Controls.DataGridColumn   Header$ Employee ID��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6}   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� $ 
EmployeeID� . 6}     5R      $ Department ID��6)   $	 140 6�      
IsReadOnly .  6@   �� $ DepartmentID� . 6�     5S      $ Department Name��6)   $	 150 6j    .  6B   �� $ DepartmentName�6w   4  .System.Windows.Controls.DataGridTemplateColumn  5T      $	 100 6-   5U      5W      5X      5Y      5Z      