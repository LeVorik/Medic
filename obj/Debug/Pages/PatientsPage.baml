   M S B A M L   `   `   `  ����@  <Medic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Medic.PagesMedic.Pages  5          Medic.Pages.PatientsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Medic.Pages     5        N� Title$  PatientsPage��5	      .��5      � $��10q�6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ PatientsDataGrid��5         AutoGenerateColumns .     
IsReadOnly .    SelectionMode$ Single=�5         SelectionUnit$ FullRow=�5      $��0��5      $��0,0,0,10q�5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 Auto 6H   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Id+6H     5      $ ФИО��6%   $	 * 6O   
 62   �� *
FullName+6O     5      $ Дата рождения��6%   $
	 Auto 6j   
 6<   �� *	BirthDate+ �� StringFormat$ d��6j     5      $ Пол��6%   $
	 Auto 6M   
 62   �� *Gender+6M     5      $ Телефон��6%   $	 * 6P   
 66   �� *Phone+6P     5      $ 
Адрес��6%   $	 * 6P   
 64   �� *	Address+6P     5       $ 
Полис��6%   $	 * 6U   
 64   �� *PolicyNumber+6U     5!      $ 
СНИЛС��6%   $	 * 6N   
 64   �� *Snils+6N   5#      �� 5%   
    �� Orientation$ 
Horizontal=�6   $��Center=�6.   $��1��6K   .+�5&      �� -   5        $��Добавить��5&      $��5q�6:   �� 5'      -   5         ��Name$ btn_Edit��5'      $ ��Редактировать��6'   $��5q�6R   {�.  6]   �� 5(      -   5        $ 
btn_Delete��5(      $��Удалить��6)   $��5q�6P   {�.  6[   5)      5*      5+      