   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   B >O-PAY-O, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:O_PAY_O.ViewModelO_PAY_O.ViewModel 5   	   -clr-namespace:O_PAY_O.ModelO_PAY_O.Model 5	   	      O_PAY_O.View.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5   	   /	viewmodelclr-namespace:O_PAY_O.ViewModel  5   	   'modelclr-namespace:O_PAY_O.Model  5	   	   -   5          � AllowsTransparency$
  True��5
         MaterialDesignBody#���   5   	    � Title$ 
MainWindow��5   	   $	��490��6   $	��750��6)   $	��490��5   	   $	��750��6    � WindowStyle$
 None=�5   	    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��0.33* �6   �� 5      $
��0.6* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5       $��1* �6   �� 5!      $��1* �6    � ColumnDefinitions 5$   
   �� 5%      �� 5&      ��5)   
   �� 5*       �� 
StartPoint$	 0,0&�6"   	 �� EndPoint$		 0,1&�63   .��5+      � 
 � Color$
 #343155��6    � Offset$ 0Q�6/   � 5,      $
 #4B2E58��6   $ 1Q�6/   5-      .+�52   
   � $��1��6   $��2��6    53      �� 54      $��2* �6#   �� 55      $
��0.7* �6#   �� 56      $
��0.7* �6#   �� 57      $
��0.7* �6#   �� 58      $
��0.7* �6#   �� 59      $��2* �6#   .+�5<      �� $��1��64     MaterialDesignIconButton#��[ 6D   ��6   �� *
MainWindow+.��5=      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$	 Eye=�6*   $��30��65   $��30��6@   ���#f0f0f06L   5>      �� 5@      $��2��6.   #��[ 6>   ��6   �� *Save+.��5A        $ 
FloppyDisk=�6*   $��30��6<   $��30��6G   ���#f0f0f06S   5B      �� 5D      $��3��65   #��[ 6E   ��6   �� *IncomeTypes+.��5E        $ Dollar=�6*   $��40��68   $��40��6C   ���#228b226O   5F      �� 5H      $��4��63   #��[ 6C   ��6   �� *
Category+.��5I        $ ReorderHorizontal=�6*   $��30��6C   $��30��6N   ���#f0f0f06Z   5J      5K      � 5M   
   $��5��6    5N      �� 5O      $��1* �6#   �� 5P      $��0.25* �6#   �� 5Q      $��0.25* �6$   �� 5R      $��0.25* �6$   .+�5U      �� $��3��6    �� IsCancel$
 True��6%     RedBack#��[ 65   .��5V        $ Close=�6*   $��Center=�67   $��25��6T   $��25��6_   5W      �� 5Y      $��2��6   $
 True��6%   #��[ 65   .��5Z        $ RectangleOutline=�6*   $��Center=�6B   $��25��6_   $��25��6j   5[      �� 5]      $��2��6     None#��[ 6%   .��5^        -   5        $ RectangleOutline=�5^   *   $��Center=�6B   $��25��6_   $��25��6j   6v   5_      �� 5a      $��1��6   #��[ 6%   .��5b        -   5        $ FormatVerticalAlignBottom=�5b   *   $��Center=�6K   $��25��6h   $��25��6s   6   5c      5d      �� 5f   
   $��2��6   $��2��6&   $��5��6:   ��6K   �� *CurrentViewModel+5g      5h      