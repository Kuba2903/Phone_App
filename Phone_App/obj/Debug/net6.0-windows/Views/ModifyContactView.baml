   M S B A M L   `   `   `  ����D  @Phone_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Phone_App.ViewsPhone_App.Views  5   	   '    !Phone_App.Views.ModifyContactView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Phone_App.Views     5   	     � Title$  ModifyContactView��5   	   $	��250��6#   $	��300��60   .��5	      �� .+�5
   
   �� $��	Enter id:��6   
 �� Top$ 10��6$   �� 5   
   $	��100��6/   $ 15��6>    �� Left$	 100��6N   ��6   �� *Contacts.Id+6N   �� 5   
   $��Enter name:��6   $ 40��6&   �� 5   
   $	��100��61   $ 45��6@   $	 100��6P   ��6   �� *Contacts.Name+6P   �� 5   
   $��Enter phone:��6   $ 80��6'   �� 5   
   -   5        $	��100��5   3   $ 85��6B   $	 100��6R    �� 	MaxLength$ 9��5      ��5      �� *Contacts.Number+5       �� 5   
   $��Enter email:��6   $	 120��6'   �� 5   
   $	��100��62   $	 125��6A   $	 100��6R   ��6   �� *Contacts.Email+6R   �� 5   
   $��Enter address:��6   $	 160��6)   �� 5   
   $	��100��64   $	 165��6C   $	 100��6T   $ 11��6f   ��6   �� *Contacts.Address+6f   �� 5   
   $��Submit��6   $	 190��6K   $	 120��6\   $��12(�5   	   $��60��6   ��5   "   �� *ModifyContactCommand+5      5      5      