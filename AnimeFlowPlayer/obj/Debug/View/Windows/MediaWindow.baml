   M S B A M L   `   `   `  ����J  FAnimeFlowPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:AnimeFlowPlayer.View.WindowsAnimeFlowPlayer.View.Windows  5   	   .    (AnimeFlowPlayer.View.Windows.MediaWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:AnimeFlowPlayer.View.Windows     5   	   -   5          � Title$  AnimeFlowPlayer��5   	   $	��730��6!   $
��1270��6.    � WindowStartupLocation$ CenterOwner=�5	   	   $	��600��5
   	   $
��1030��6    � 	Resources 5         NoMouseOverButtonTemplate �� 
TargetType �� Triggers P� Property P� Value �� Value �� Property��%  &	        �� 5   
   " ��6<   .R�5      �� #��z��6   #��z��5      #��z��5      ._�5      �� #��z��6#   #��z��5      5       5      P� 5       � {� .  . �5      �� # Z�63    � ���� 5      # Z
�63    � ��5      5      5      .��5      � ���	#FF363636	 � RowDefinitions	 5   
   �� 5       $��40 �6   �� 5!      
 � ColumnDefinitions
 5#   
   �� 5$      �� 5%      $	��300 �6   .+�5'   
   ��  �� Orientation$ 
Horizontal=�6   $��Center=�5(      $��0��6,   .+�5)      �� -   5         ��Name$ 
backButton��5)      $��30��6)   $��30��5*      $��10,0,5,0q�6   #��[  5+      ��5*   G   Z� ��5,      �� 5-       �� ImageSource$K E/Assets/Icons/icons8-стрелка-влево-в-круге-2-50.png��6!    j� Stretch$ Uniform=�6c   5/      51      �� 53   
   $��AnimeFlowPlayer��6   $��20(�6*   $��Comic Sans MS)�54      
����� �$
��Bold"�55      $��Center=�6"   $��0��6?   $��54,0,0,0q�6O   �� 56   
   
�������$��3q�6*    �� CornerRadius$ 20��6>   $��1��6P   $��5q�6]   ._�57      �� $��1��6   $��5q�6&   .+�58      r� -   5         r�Name$ mediaElement��58      $��Stretch=�65   $	��550��59      $��Stretch=�6   $	��NaN��5:       r� LoadedBehavior$ Manual=�6    r� UnloadedBehavior$
 Stop=�5;       r� Stretch$ UniformToFill=�6'   5<      �� 5=      -   5         ��Name$ slider2��5=      $��20��6*   $��Bottom=�66   5>      �� 5?      -   5         ��Name$ controlPanel��5?      $ 
Horizontal=�63   $��Center=�6L   $��10q�6i   .+�5@      �� -   5        $ btnPlay��5@      $��75��6.   $��30��69   $��0,0,10,0q�6[   #��[  5A      ��5@   m   Z� ��5B      �� 5C      $  /Assets/Icons/iconPlay.png��6)   $ Uniform=�6R   5E      �� 5F      -   5        $ btnPause��5F      $��75��6/   $��30��6:   $��0,0,10,0q�6]   #��[  5G      ��5F   o   Z� ��5H      �� 5I      $ Uniform=�6)   $, &/Assets/Icons/icons8-пауза-50.png��6;   5K      �� 5L      -   5        $ btnStop��5L      $��75��6.   $��30��69   #��[  5M      ��5L   [   Z� ��5N      �� 5O      $ Uniform=�6)   $8 2/Assets/Icons/icons8-стоп-в-круге-50.png��6;   5Q      �� 5R      -	   5        $ fullscreenButton��5R      $��75��67   $��30��6B   $��5,0,0,0q�6N   #��[  5T      ��5S   8   Z� ��5U      �� 5V      $: 4/Assets/Icons/icons8-на-всю-ширину-50.png��6)   $ Uniform=�6a   5X      �� 5Y      -
   5        $ slider1��5Y      $��20��6.   $	��top=�6:   $
��Left=�6R   $	��100��5Z       � Minimum$ 0Q�6%    � Maximum$ 1Q�61    � Value$	 0.5Q�5[      6%   �� 5\      -   5         ��Name$
 time��5\       $��00:00��6.   $	��Top=�5]      
���  ��$��10,0,0,0q�5^      5_      5`      5a      �� 5d   
   -   5         ��Name$ seriesCatalog��5f      $��1��5d   2   $��1��5e      
������ $��1q�5f      ��5d      �� *series+��5h      �� 5i      .R�5j      �� $ Vertical=�6!   .+�5k      �� $
��fill=�69   $��90��6H   $	��Top=�6T   ��6    �� *Image+6T   �� 5l      $��Center=�6;    �� TextAlignment$ Justify=�5m      $
��Wrap=�64   $��Comic Sans MS)�6H   $��17(�5n      $
��Bold"�6*   
���������5l   $   �� *Title+5n   <   5o      5p      5r      5s      5t      