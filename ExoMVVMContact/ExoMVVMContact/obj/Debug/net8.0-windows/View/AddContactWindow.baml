   M S B A M L   `   `   `  ����I  EExoMVVMContact, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ExoMVVMContact.ViewExoMVVMContact.View  5      *    $ExoMVVMContact.View.AddContactWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      3local!clr-namespace:ExoMVVMContact.View     5      -   5        $��addContactWindow��5   P     � Title$  AddContactWindow��6   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      $��50 �6   6*   .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $��Enter Name : ��6   $
��Left=�6,   $��
10,25,0,10q�6G   6]   �� 5      $	��200��64   $
��Left=�6@   $��
10,25,0,10q�6[   ��6   �� *Contact.Name+6q   �� 5      $��Enter First Name : ��6   $
��Left=�62   $��
10,25,0,10q�6M   6c   �� 5      $	��200��69   $
��Left=�6E   $��
10,25,0,10q�6`   ��6   �� *Contact.FirstName+6v   �� 5      $��Enter Email : ��6   $
��Left=�6-   $��
10,25,0,10q�6H   6^   �� 5      $	��200��65   $
��Left=�6A   $��
10,25,0,10q�6\   ��6   �� *Contact.Email+6r   5      �� 5   
   $��1��6   $��Center=�6   $��Right=�69   $��Validate and Close��6U   $	��100��6r   $��30��6~   $��0,0,15,0q�6�   
����  �
���������5      %  System.Windows.Markup.Reference     Name$ addContactWindow����5      �� *CloseCommand+64   5      5      