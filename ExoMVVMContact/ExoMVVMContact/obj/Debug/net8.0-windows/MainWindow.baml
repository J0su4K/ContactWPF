   M S B A M L   `   `   `  ����I  EExoMVVMContact, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ExoMVVMContactExoMVVMContact  5   	       ExoMVVMContact.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:ExoMVVMContact     5   	   -   5        $��
mainWindow��5   5     � Title$  
MainWindow��6	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��55* �6   �� 5      $
��299* �6   �� 5      $
��446* �6    � RowDefinitions 5   
   �� 5      $��50 �6   6*   �� 5      6   .+�5   
   �� $��Center=�6   $
��Left=�6,   $��	331,0,0,0q�6G   $	��100��6Z   $��50��6f   
���� ��$��Add Contact��5   %   
��� ���$��2��6O   ��5      %  System.Windows.Markup.Reference     Name$ 
mainWindow����6B   �� *OpenContactWindowCommand+6q   �� 5   
   $��1��6   $��3��6A   ��6    �� *
Contacts+ �� View 5      �� 5      .P�5      �� $
��Name��6K    �� DisplayMemberBinding 6%   �� *Name+6[   �� 5      $��	FirstName��6P    6%   �� *	FirstName+6e   �� 5      $��EMail��6L    6%   �� *Email+6]   5      5       5!      5"      