   M S B A M L   `   `   `  ����@  <Medic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MedicMedic  5   	       Medic.DoctorDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Medic     5   	     � Title$  Доктор��5   	   $	��250��6   $	��400��6%    � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V   .��5	      � $��20q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��ФИО:��6   $��0��6    $��0��6-   $��Center=�6=   �� 5   
   -   5         ��Name$ FullNameBox��5      $��0��6'   $��1��64   $��5q�6D   �� 5   
   $!��Специальность:��6   $��1��6*   $��0��67   $��Center=�6G   �� 5   
   -   5        $ SpecialtyBox��5      $��1��6(   $��1��65   $��5q�6E   �� 5   
   $��Кабинет:��6   $��2��6$   $��0��61   $��Center=�6A   �� 5   
   -   5        $ RoomBox��5      $��2��6#   $��1��60   $��5q�6@   �� 5   
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��2��6;   $��0,20,0,0q�6O   $��Right=�6a   .+�5       �� -   5        $��OK��5       $��80��6"   $��5q�6-   68   �� 5!      -   5        $��Отмена��5!      $��80��6&   $��5q�61   6<   5"      5#      5$      