   M S B A M L   `   `   `  ����D  @Phone_App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Phone_App.ViewsPhone_App.Views  5   	   #    Phone_App.Views.TicTacToeView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Phone_App.Views     5   	     � Title$  TicTacToeView��5	   	   $	��400��6   $	��550��6,   .��5
      � ��5   
   �� 5      .��5      �  � Color$ 	LightBlue��6    � Offset$ 0Q�61   5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��10q�6   $��80(�6   {�6+   �� *IsButtonEnabled+��5       �� *ButtonClickedCommand00+��6<   �� *
Board[0]+�� 5!   
   $��1��6   $��10q�6!   $��80(�6-   ��6;   �� *ButtonClickedCommand01+��5"      �� *
Board[1]+{�6.   �� *IsButtonEnabled+�� 5#   
   $��2��6   $��10q�6!   $��80(�6-   ��6;   �� *ButtonClickedCommand02+��5$      �� *
Board[2]+{�6.   �� *IsButtonEnabled+�� 5%   
   $��0��6   $��1��6!   $��10q�6.   $��80(�6:   ��6H   �� *ButtonClickedCommand03+��5&      �� *
Board[3]+{�6.   �� *IsButtonEnabled+�� 5'   
   $��1��6   $��1��6!   $��10q�6.   $��80(�6:   ��6H   �� *ButtonClickedCommand04+��5(      �� *
Board[4]+{�6.   �� *IsButtonEnabled+�� 5)   
   $��2��6   $��1��6!   $��10q�6.   $��80(�6:   ��6H   �� *ButtonClickedCommand05+��5*      �� *
Board[5]+{�6.   �� *IsButtonEnabled+�� 5+   
   $��0��6   $��2��6!   $��10q�6.   $��80(�6:   ��6H   �� *ButtonClickedCommand06+��5,      �� *
Board[6]+{�6.   �� *IsButtonEnabled+�� 5-   
   $��1��6   $��2��6!   $��10q�6.   $��80(�6:   ��6H   �� *ButtonClickedCommand07+��5.      �� *
Board[7]+{�6.   �� *IsButtonEnabled+�� 5/   
   $��2��6   $��2��6!   $��10q�6.   $��80(�6:   ��6H   �� *ButtonClickedCommand08+��50      �� *
Board[8]+{�6.   �� *IsButtonEnabled+�� 52   
   $��3��6   $��1��6   $��50��6.   $	��100��6:   $��Reset��6F   ��53      �� *ButtonResetCommand+54      55      