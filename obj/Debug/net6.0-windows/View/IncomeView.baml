   M S B A M L   `   `   `  ����B  >O-PAY-O, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:O_PAY_O.ViewO_PAY_O.View  5      5clr-namespace:O_PAY_O.ViewModelO_PAY_O.ViewModel  67       O_PAY_O.View.IncomeView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:O_PAY_O.View  5      /	viewmodelclr-namespace:O_PAY_O.ViewModel  67   .��5      � ��5   
   �� 5        �� 
StartPoint$	  0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ #343155��6    � Offset$ 0Q�6/   � 5      $ #4B2E58��6   $ 1Q�6/   5       � ColumnDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6    � RowDefinitions 5   
   �� 5      $
��1.2* �6   �� 5      $
��0.8* �6   �� 5      $
��1.3* �6   �� 5      $
��1.4* �6   �� 5      $
��1.2* �6   �� 5      $��1* �6   .+�5!   
   �� $��Incomes��6   
������$��2��6:   $��Center=�6N   $��60(�5"      �� 5$   
   $��5��6R   
������ $	��350��6   $��70��6�   $	��Top=�6�   $��0,0,0,0q�5%      $��2��6#   $��30(�60   
�������
��� �|�$��Right=�6h   $��Center=�6�   ��5$      �� *	TextInput+ �� UpdateSourceTrigger$ PropertyChanged=�.��5%   �    � 	Resources 5&       �� 
TargetType	 �� Property
 �� Value��%_   '��       �� 5'      " ��6   .�5(      �� 	 �@��CornerRadius$
 10��65   5)      5*      .��6!   5+      �� 5-   
   $��5q�6   $��3��6   $��1��6+   $��Right=�6?   $	��170��5.      $��50��6   $��Center=�6+   $��25(�6c   $��Center=�5/      $��Center=�67   $
��Bold"�6Y   ��5.   F   �� *Type+ �� SelectedIndex 50      �� *	TypeBox+51      �� 53   
   $��5q�6   $��3��6   $��1��6+   $��1��6<   $
��Left=�6P   $	��170��54      $��50��6   $��Center=�6+   $��25(�6c   $��Center=�55      $��Center=�67   $
��Bold"�6Y   ��54   F   �� *Date+ 56      �� *	TimeBox+57      �� 5:   
      WD#��[  6-   $��4��6I   $��2��6V   $��Center=�6j   $	��230��5;      $��50��6   $��Confirm��6)   ��5:      �� *	Confirm+5;   )   5=      5>      