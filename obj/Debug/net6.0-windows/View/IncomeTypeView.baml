   M S B A M L   `   `   `  ����B  >O-PAY-O, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:O_PAY_O.ViewO_PAY_O.View  5      5clr-namespace:O_PAY_O.ViewModelO_PAY_O.ViewModel  5      !    O_PAY_O.View.IncomeTypeView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:O_PAY_O.View  5      /	viewmodelclr-namespace:O_PAY_O.ViewModel  5      .��5      � ��5   
   �� 5        �� 
StartPoint$	  0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ #343155��6    � Offset$ 0Q�6/   � 5      $ #4B2E58��6   $ 1Q�6/   5       � ColumnDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      .+�5   
   �� $��25(�6   
������ ��6"   �� *Type+��5      �� 5      .R�5      �� $��60��6!    �� Orientation$ 
Horizontal=�6.   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Payment=�62   $��0,0,0,10q�6A   $��50��6S   $��50��6^   
�������6j   �� 5      $��Right=�6    $��15,0,0,0q�6C   $��30(�6U   
���   ���6c   �� *Abc+6{   5      5       5"      � 5$   
   $��1��6    � RowDefinitions 5%      �� 5&      $
��0.5* �6    �� 5'      $��1* �6    �� 5(      $��1* �6    �� 5)      $��1* �6    �� 5*       5-      �� 5.      �� 5/      .+�51      �� $��2��6   $��Information��6(   $��30(�6>   $��Center=�52      $��Bottom=�61   
�������6L   �� 54      $��1��6   $��Bottom=�6!   $��Type:��6<   $��30(�6L   
�������$��Right=�55   '   $��0,0,15,0q�6C   �� 57      $��2��6   $��Bottom=�6!   $��Income:��6<   $��30(�6N   
��� � �$��Right=�58   '   $��0,0,15,0q�6C   �� 5:      $��3��6   $��Bottom=�6!   $��	Expenses:��6<   $��30(�6P   
���  ��$��Right=�5;   %   $��0,0,15,0q�6A   �� 5=      $��1��6   $��1��6!   $��Bottom=�61   $��30(�6i   
�������$
��Left=�5>   '   ��5=   L   �� *
TextType+5>   '   �� 5@      $��2��6   $��1��6!   $��Bottom=�61   $��30(�6k   
�������$
��Left=�5A   '   ��5@   L   �� *
IncomeText+5A   '   �� 5C      $��3��6   $��1��6!   $��Bottom=�61   $��30(�6m   
�������$
��Left=�5D   '   ��5C   L   �� *ExpensesText+5D   '   5E      �� 5G   
   -   5         ��Name$ Line1��5G      $y�Visible=�6   $��2��63   
���   �$��5��6V   	 �� Stretch$
	 Fill=�6j   	
 �� X1$
 0��5H      	 �� Y1$ 0��6   	 �� X2$ 1��6   	 �� Y2$ 1��6&   �� 5I   
   -   5        $ Line2��5I      $y�Visible=�6   $��2��63   
���   �$��5��6V   $
	 Fill=�6j   $
 0��5J      $ 1��6   $ 1��6   $ 0��6&   �� 5L   
   $��COMING SOON��6   $��60(�6&   $��2��64   $��2��6H   $��Center=�6Y   $��Center=�6v   
���  ��6�   5N      5O      