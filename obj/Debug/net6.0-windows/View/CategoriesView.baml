   M S B A M L   `   `   `  ����B  >O-PAY-O, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:O_PAY_O.ViewO_PAY_O.View  5      5clr-namespace:O_PAY_O.ViewModelO_PAY_O.ViewModel  67   !    O_PAY_O.View.CategoriesView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      X TXceed.Wpf.Toolkit, Version=4.3.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44wpfx)http://schemas.xceed.com/wpf/xaml/toolkit  5      &localclr-namespace:O_PAY_O.View  5      /	viewmodelclr-namespace:O_PAY_O.ViewModel  67   .��5      � ��5   
   �� 5        �� 
StartPoint$	  0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ #343155��6    � Offset$ 0Q�6/   � 5      $ #4B2E58��6   $ 1Q�6/   5       � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      .+�5   
   #  Xceed.Wpf.Toolkit.ColorPicker  $	��100��6   $��50��6(   $��60,0,0,0q�6T   $
��Left=�6f      DisplayColorAndName$
 True��6�      SelectedColor 64   �� *Color+6�   �� 5   
   $��2��6R   
������ $	��350��6   $��70��6�   $��Center=�6�   $��0��5      $��30(�6   
����������#FF00FF$��Right=�6U   $��Center=�6x   ��5      �� *	TextInput+ �� UpdateSourceTrigger$ PropertyChanged=�.��5   �   	 � 	Resources	 5       
 �� 
TargetType �� Property �� Value��%_   '��       �� 5!      "
 ��6   .�5"      ��  �@��CornerRadius$ 10��65   5#      5$      .��6!   5%      �� 5&   
      WD#��[  6-   $��0��6I   $��1��6V   $��Right=�6f   $	��150��5'      $��0,0,40,0q�6   $��50��6/   $��Confirm��6;   ��5&      �� *	Confirm+5'   ;   � 5*   
   -   5         �Name$ sp��5*      $��2��6!   $��1��65    � Orientation$ 
Horizontal=�6B   .+�5,      �� .��5-      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ GiftOutline=�6*   ���#FF1493$��80��6R   $��80��6]   5.      �� 50      .��51        $ BasketballHoopOutline=�6*   ���#7cfc00$��80��6\   $��80��6g   52      �� 54      .��55        $	 Cat=�6*   ���#00bfff$��80��6J   $��80��6U   56      �� 58      .��59        $ FoodOutline=�6*   ���#DDD000$��80��6R   $��80��6]   5:      �� 5<      .��5=        $ 
CarOutline=�6*   ���#FFD700$��80��6Q   $��80��6\   5>      �� 5@      .��5A        $	 Bus=�6*   ���#ff69b4$��80��6J   $��80��6U   5B      �� 5D      .��5E        $ MarketplaceOutline=�6*   ���#9370db$��80��6Y   $��80��6d   5F      �� 5G      .��5H        $ HomeOutline=�6*   ���#40E0D0$��80��6R   $��80��6]   5I      �� 5K      .��5L        $ TshirtVOutline=�6*   ���#FF00FF$��80��6U   $��80��6`   5M      �� 5O      .��5P        $ PhoneOutline=�6*   ���#D3D3D3$��80��6S   $��80��6^   5Q      �� 5S      .��5T        $ Vacuum=�6*   ���#5cfa8b$��80��6M   $��80��6X   5U      �� 5W      .��5X        $ TreeOutline=�6*   ���#61C026$��80��6R   $��80��6]   5Y      �� 5[      .��5\        $ FoodForkDrink=�6*   ���#ffdab9$��80��6T   $��80��6_   5]      �� 5_      .��5`        $ 
TagOutline=�6*   ���#6f65eb$��80��6Q   $��80��6\   5a      �� 5c      .��5d        $ Temperature=�6*   ���#ff0f7b$��80��6R   $��80��6]   5e      �� 5g      .��5h        $
 Baby=�6*   ���#00aaff$��80��6K   $��80��6V   5i      �� 5k      .��5l        $ Comedy=�6*   ���#ff4000$��80��6M   $��80��6X   5m      �� 5o      .��5p        $ Company=�6*   ���#24bfa6$��80��6N   $��80��6Y   5q      5r      �� 5t   
   -   5         ��Name$ Line1��5t      $y�Visible=�6   $��2��63   $��2��6G   
���   �$��5��6g    �� Stretch$
 Fill=�6{   	 �� X1$ 0��5u      	 �� Y1$ 0��6   	 �� X2$ 1��6   	 �� Y2$ 1��6&   �� 5v   
   -   5        $ Line2��5v      $y�Visible=�6   $��2��63   $��2��6G   
���   �$��5��6g   $
 Fill=�6{   $ 0��5w      $ 1��6   $ 1��6   $ 0��6&   �� 5y   
   $��COMING SOON��6   $��60(�6&   $��2��64   $��2��6H   $��Center=�6Y   $��Center=�6v   
���  ��6�   5z      5{      