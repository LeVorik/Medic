   M S B A M L   `   `   `  ����@  <Medic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Medic.ModalViewsMedic.ModalViews  5   	   (    "Medic.ModalViews.AppointmentDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Medic.ModalViews     5   	     � Title$   Запись к врачу��5   	   $	��300��6    $	��400��6-    � WindowStartupLocation$ CenterScreen=�5	   	    � 
ResizeMode$ NoResize=�6.   .��5
      � $��20q�6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��120 �6   �� 5      $��* �6   .+�5   
   �� $��Пациент:��6   $��0��6$   $��0��61   $��Center=�6A   �� 5   
   -   5         ��Name$ 
PatientBox��5      $��0��6'   $��1��64   $��5q�6D    �� DisplayMemberPath$ FullName��6O   �� 5   
   $��	Врач:��6   $��1��6!   $��0��6.   $��Center=�6>   �� 5   
   -   5        $ 	DoctorBox��5      $��1��6&   $��1��63   $��5q�6C   $ FullName��6N   �� 5   
   $��Дата и время:��6   $��2��6)   $��0��66   $��Center=�6F   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
DatePicker��5      $��2��6)   $��1��66   $��5q�6F   �� 5    
   $��Статус:��6   $��3��6#   $��0��60   $��Center=�6@   �� 5!   
   -   5        $ 	StatusBox��5!      $��3��6&   $��1��63   $��5q�6C   .@�5"      �� $��Запланирован��6   �� 5#      $��Завершён��6   �� 5$      $��Отменён��6   5%      �� 5'   
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��2��6;   $��0,20,0,0q�6O   $��Right=�6a   .+�5(      �� -   5        $��OK��5(      $��80��6"   $��5q�6-   68   �� 5)      -   5        $��Отмена��5)      $��80��6&   $��5q�61   6<   5*      5+      5,      