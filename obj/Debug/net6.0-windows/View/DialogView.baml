   M S B A M L   `   `   `  ����B  >O-PAY-O, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:O_PAY_O.ViewO_PAY_O.View  5      5clr-namespace:O_PAY_O.ViewModelO_PAY_O.ViewModel  5          O_PAY_O.View.DialogView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      &localclr-namespace:O_PAY_O.View  5      /	viewmodelclr-namespace:O_PAY_O.ViewModel  5        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   %    5      .��5      � ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5      �  � Color$ #343155��6    � Offset$ 0Q�6/   � 5      $ #4B2E58��6   $ 1Q�6/   5       � ColumnDefinitions 5   
   �� 5      $
��2.1* �6   �� 5       $
��0.7* �6   �� 5!      $
��0.7* �6   �� 5"      $
��0.7* �6   �� 5#      $
��2.1* �6    � RowDefinitions 5&   
   �� 5'      $��0.45* �6   �� 5(      $
��2.2* �6   �� 5)      $
��0.8* �6   �� 5*      $
��0.8* �6   �� 5+      $
��0.8* �6   �� 5,      $
��0.8* �6   .+�51   
   �� $��1��6+   $��1��6@   $��1��6L   $��2��6\   ��6   �� *Input+6\   �� 52   
   $��4��6+   $��4��6@   $��1��6L   $��3��6\   ��6   �� *Input+6\   �� 53   
   $��7��6+   $��7��6@   $��1��6L   $��4��6\   ��6   �� *Input+6\   �� 55   
   $��2��6+   $��2��6@   $��2��6L   $��2��6\   ��6   �� *Input+6\   �� 56   
   $��5��6+   $��5��6@   $��2��6L   $��3��6\   ��6   �� *Input+6\   �� 57   
   $��8��6+   $��8��6@   $��2��6L   $��4��6\   ��6   �� *Input+6\   �� 58   
   $��0��6+   $��0��6@   $��2��6L   $��5��6\   ��6   �� *Input+6\   �� 5;   
   $��3��6+   $��3��6@   $��3��6L   $��2��6\   ��6   �� *Input+6\   �� 5<   
   $��6��6+   $��6��6@   $��3��6L   $��3��6\   ��6   �� *Input+6\   �� 5=   
   $��9��6+   $��9��6@   $��3��6L   $��4��6\   ��6   �� *Input+6\   �� 5>   
   $��9��6+   $��9��6@   $��3��6L   $��4��6\   ��6   �� *Input+6\   �� 5@   
   $��1q�60   $��55��6;   $��80��6G      WD#��[  6R   $��3��6�   $��5��6�   ���#00bfff��6   �� *
SendToMain+��6n   �� *	TextInput+.��5A      '  !MaterialDesignThemes.Wpf.PackIcon  	   Kind$	 ArrowRightBold=�6&   $��40��6=   $��40��6H   5B      �� 5D   
   $��7��6+   $��CE��6@   
���   �$��1��6`   $��5��6p   ��6   �� *Clean+6p   �� 5E   
   $��7��6/   $	��⌫��6D   
���  ��$��4��6g   $��70��6w   $��2q�6�   $
��Left=�6�   $��2��6�   ��6   �� *	Backspace+6�   �� 5G   
   $��5��6R   
������ $	��350��6   $��70��6�   $��Bottom=�6�   $��	30,0,0,30q�5H      
 �� 
IsReadOnly$

 True��6%   $��1��67   $��30(�6D   
����������#FF00FF$��Right=�6z   $��Center=�6�   ��5G      �� *	TextInput+ �� UpdateSourceTrigger$ PropertyChanged=�.��5H   �     5I       �� 
TargetType �� Property �� Value��%_   '��       �� 5J      " ��6   .�5K      ��  �@��CornerRadius$ 10��65   5L      5M      .��6!   5N      5O      5P      