   M S B A M L   `   `   `  ����U  QMahApps.Metro, Version=0.13.1.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       WpfApplication1   RSSReader.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5        � Title$  
RSS READER��5       � Icon$ Image/appbar.rss.png��6   $��2q�64   ��5      
� 5   
   .��5      �  � Color$ 	#FF738CF9��6    � Offset$ 1Q�6-   � 5	      $ White��6   5
      (   "MahApps.Metro.Controls.MetroWindow   Flyouts 5      +   %MahApps.Metro.Controls.FlyoutsControl  5   
   .@�5      #   MahApps.Metro.Controls.Flyout     Header$ Setting��6      IsModal .    Position$ Right=�6>   $	��400��6O   $��Right=�6[   5      5         RightWindowCommands 5      +   %MahApps.Metro.Controls.WindowCommands  5   
   .@�5      �� -   5        $��settings��5      6(   5      .��5      � 	 � RowDefinitions	 5   
   �� 5      $��42 �6   �� 5      $��3 �6   �� 5      
 � ColumnDefinitions
 5   
   �� 5       $
��178* �6   �� 5!      $��5 �6   �� 5"      $
��573* �6   .+�5$   
   c� $��43��6   $	��Top=�6   $��3��66   $��	-1,-1,0,0q�6J   $��0q�6]   ��5%      �� 5&       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5'      � $ 	#FFDFE8FB��6#   $ 1Q�65   � 5(      $ White��6#   5)      .@�5+      �� -   5        $��Stretch=�5+      $��37��61   .��5,      �� $��Image/appbar.add.png��6   $
��Fill=�66   5-      �� 5.      -   5        $��Stretch=�5.      $��37��61   .��5/      �� $��Image/appbar.minus.png��6   $
��Fill=�68   50      �� 51      -   5        $��Stretch=�51      $��37��61   .��52      �� $��Image/appbar.refresh.png��6   $
��Fill=�6:   53      �� 54      $��Stretch=�6   $��37��61   .��55      �� $!��Image/appbar.page.heart.png��6   $
��Fill=�6=   56      �� 57      $��Stretch=�6   $��37��61   .��58      �� $��Image/appbar.home.png��6   $
��Fill=�67   59      5:      R� 5;   
   -   5         R�Name$ rssFeadTree��5;      $��-1,0,0,0q�6(   $��2��6:   6G   �� 5<   
   $��1��6    J� RenderTransformOrigin$ 0.5,0.5&�6$   $��Stretch=�6D   $��1��6b   $��2��6r   �� 5=   
   -   5         ��Name$ rssItemList��5=      $��2��6'   $��2��67   
���   �6D   �� 5>   
   ���	#FFF4F4F5$��-1,0,0,0q�6%   $��1��67   ���	#FFC5B6F7$��3��6W   5@      5A      