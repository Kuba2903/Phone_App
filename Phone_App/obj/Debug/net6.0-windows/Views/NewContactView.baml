   M S B A M L   `   `   `  ����D  @Phone_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Phone_App.ViewsPhone_App.Views  5   	   $    Phone_App.Views.NewContactView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Phone_App.Views     5   	     � Title$  NewContactView��5   	   $	��220��6    $	��300��6-   .��5	      �� .+�5
   
   �� $��Enter name:��6   
 �� Top$ 10��6&   �� 5   
   $	��100��63   $ 15��6B    �� Left$	 100��6R   ��6   �� *NewContact.Name+6R   �� 5   
   $��Enter phone:��6   $ 50��6'   �� 5   
   -   5        $	��100��5   5   $ 55��6D   $	 100��6T    �� 	MaxLength$ 9��5      ��5      �� *NewContact.Number+5       �� 5   
   $��Enter email:��6   $ 90��6'   �� 5   
   $	��100��64   $ 95��6C   $	 100��6S   ��6   �� *NewContact.Email+6S   �� 5   
   $��Enter address:��6   $	 130��6)   �� 5   
   $	��100��66   $	 135��6E   $	 100��6V   $ 11��6h   ��6   �� *NewContact.Address+6h   �� 5   
   $��Submit��6   $	 160��6A   $	 120��6R   $��12(�5      $��60��6   ��5   "   �� *
AddContact+5      5      5      