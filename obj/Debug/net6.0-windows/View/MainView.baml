   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5      B >O-PAY-O, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:O_PAY_O.ViewModelO_PAY_O.ViewModel 5      +clr-namespace:O_PAY_O.ViewO_PAY_O.View 5	         O_PAY_O.View.MainView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.3.0.3, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      /	viewmodelclr-namespace:O_PAY_O.ViewModel  5      &localclr-namespace:O_PAY_O.View  5	        � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $f `pack://application:,,,/MaterialDesignThemes.Wpf;component/Themes/MaterialDesignTheme.Button.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5       �� 5!      ��5$   
   �� 5%       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 0,1&�63   .��5&      �  � Color$ #343155��6    � Offset$ 0Q�6/   � 5'      $ #4B2E58��6   $ 1Q�6/   5(      .+�5.   
   ��    MaterialDesignIconButton#��[  60   $��0��6b   
������ 
������ $��80��5/      $��80��6"   $��Center=�6-   $
��Left=�6H   $��40, 0, 0, 0q�6c   ��5.      �� *
OpenDialog+.��50      '  !MaterialDesignThemes.Wpf.PackIcon  -   5        	  Name$	 Sport��50   &   
   Kind$
 BasketballHoopOutline=�65   $��40��6S   $��40��6^   ���#7cfc006j   ��51      "  O_PAY_O.ViewModel.SeriesData  52         Color �#7cfc00   Name$ Sport��67   54      �� 56   
   $��1��60   #��[  6=   
������ 
������ $��80��57      $��80��6"   $��Center=�6-   $
��Left=�6H   $��40, 0, 0, 0q�6c   ��56      �� *
OpenDialog+.��58        $
 GiftOutline=�6&   $��40��6:   $��40��6E   ���#FF14936Q   ��59        5:       �#FF1493$ Gifts��68   5<      �� 5>   
   $��2��60   #��[  6=   
������ 
������ $��80��5?      $��80��6"   $��Center=�6-   $
��Left=�6H   $��40, 0, 0, 0q�6c   ��5>      �� *
OpenDialog+.��5@        $	
 Cat=�6&   $��40��62   $��40��6=   ���#00bfff6I   ��5A        5B       �#00bfff$ Animals��67   5D      �� 5F   
   $��3��60   #��[  6=   
������ 
������ $��80��5G      $��80��6"   $��Center=�6-   $
��Left=�6H   $��40, 0, 0, 0q�6c   ��5F      �� *
OpenDialog+.��5H        $
 FoodForkDrink=�6&   $��40��6<   $��40��6G   ���#ffdab96S   ��5I        5J       �#ffdab9$
 Food��67   5L      �� 5N   
   $��4��60   #��[  6=   
������ 
������ $��80��5O      $��80��6"   $��Center=�6-   $
��Left=�6H   $��40, 0, 0, 0q�6c   ��5N      �� *
OpenDialog+.��5P        $
 
CarOutline=�6&   $��40��69   $��40��6D   ���#FFD7006P   ��5Q        5R       �#FFD700$ Vehicles��67   5T      �� 5Z   
   $��1��60   $��0��6@   #��[  6M   
������ 
������ $��80��5[      $��80��6"   $��Center=�6-   $��Right=�6H   $��0, 0, 40, 0q�6d   ��5Z      �� *
OpenDialog+.��5\        $	
 Bus=�6&   $��40��62   $��40��6=   ���#ff69b46I   ��5]        5^       �#ff69b4$	 Bus��67   5`      �� 5b   
   $��1��61   $��1��6A   #��[  6O   
������ 
������ $��80��5c      $��80��6"   $��Center=�6-   $��Right=�6H   $��0, 0, 40, 0q�6d   ��5b      �� *
OpenDialog+.��5d        $
 MarketplaceOutline=�6&   $��40��6A   $��40��6L   ���#9370db6X   ��5e        5f       �#9370db$ Shopping��67   5h      �� 5j   
   $��1��62   $��2��6B   #��[  6O   
������ 
������ $��80��5k      $��80��6"   $��Center=�6-   $��Right=�6H   $��0, 0, 40, 0q�6d   ��5j      �� *
OpenDialog+.��5l        $
 HomeOutline=�6&   $��40��6:   $��40��6E   ���#40E0D06Q   ��5m        5n       �#40E0D0$
 Home��67   5p      �� 5r   
   $��1��61   $��3��6A   #��[  6N   
������ 
������ $��80��5s      $��80��6"   $��Center=�6-   $��Right=�6H   $��0, 0, 40, 0q�6d   ��5r      �� *
OpenDialog+.��5t        $
 TshirtVOutline=�6&   $��40��6=   $��40��6H   ���#FF00FF6T   ��5u        5v       �#FF00FF$ Dresses��67   5x      �� 5z   
   $��1��61   $��4��6A   #��[  6N   
������ 
������ $��80��5{      $��80��6"   $��Center=�6-   $��Right=�6H   $��0, 0, 40, 0q�6d   ��5z      �� *
OpenDialog+.��5|        $
 PhoneOutline=�6&   $��40��6;   $��40��6F   ���#D3D3D36R   ��5}        5~       �#D3D3D3$ Phone��67   5�      �� 5�   
   $��2��6.   $��4��6B   #��[  6O   
������ 
������ $��80��5�      $��80��6"   ��5�      �� *	Incomes+.��5�        $
 PlusCircleOutline=�6&   $��70��6?   $��70��6J   
������6V   ��5�        5�       �#D3D3D3$ Phone��67   5�         LiveCharts.Wpf.PieChart  5�   
   $��2��6   $��3��6,   $��1��6a      InnerRadius$	 100Q�6n   $	��250��6�   $	��290��6�   &    LiveCharts.Wpf.Charts.Base.Chart   	Hoverable$ False��5�      $��Center=�6)   $��Center=�6F   $��0,0,0,5q�6b      Series 5�   =   �� *SeriesCollection+   DataTooltip 5�      #   LiveCharts.Wpf.DefaultTooltip  5�         
BulletSize$ 15Q�6%   67   5�      �� 5�   
   $��1��6   $��2��6&   $��5��6:   ��6K   �� *CurrentViewModel+�� 5�   
   $��2��61   $��2��6>   $��25(�6R   $��Center=�5�      $	��Top=�6-   
���  ����5�      �� *ExpensesText+5�   E   �� 5�   
   $��2��6T   $��2��6a   $��25(�6u   $��Center=�5�      $��Bottom=�6-   
��� � ���5�      �� *
IncomeText+ �� UpdateSourceTrigger$ PropertyChanged=�5�   H   5�      5�      