   M S B A M L   `   `   `  ����B  >Offline, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Offline.DialogOffline.Dialog  5   
   &     Offline.Dialog.PortConnectDialog   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Offline.Dialog     5   
   T PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ LogInDialog��5
   	   $	��300��6   $	��400��6*    � 
ResizeMode$ NoResize=�5   	    � ForceCursor .   � ShowInTaskbar .   � WindowStyle$
 None=�6I   .��5      � ���	#FFD8D8D8 � RowDefinitions 5   
   �� 5      $��1* �6   6*   �� 5      $��4* �6   6*   �� 5      $��1* �6   6*   .+�5   
   � $��0��6   .+�5      � .+�5      ]� .+�5      � $��Center=�6   $��Center=�68   $��70��6S   $
��0,10q�6_    � ColumnDefinitions 5      �� 5      61   �� 5      61   �� 5      61   .+�5      �� $��0��6    $��8,0,10,0q�60   $1��+/Offline;component/Resources/Image/left.png��6B   6z   �� 5      
�������$��20(�67   $��Center=�6E   $��Center=�6b   $��1��6}   $
��Bold"�6�   Port6�   �� 5      $��2��6    $��10,0,8,0q�60   $2��,/Offline;component/Resources/Image/right.png��6B   6{   5      5       5!      5"      � 5#   
   $��1��6   .+�5$      �� -   5         ��Name$ comboBox��5$      $	��300��6)   $��
30,90,30,0q�65   $��Center=�6I   $	��Top=�6f   5%      5&      � 5'   
   $��2��6   .+�5)      �� -   5        $��0��5)      $��Center=�6%   $��OK��6@   ���	#FFFBAB00���	#FF9E6500$
��Bold"�6{   $��80��6�   $��20��6�   5+      )  #MahApps.Metro.Controls.ProgressRing  5,      -   5        	  Name$	 Loading��5,   $   $y�Hidden=�65   $��30��6I   $��170,10q�6U   6g   5-      5.      5/      