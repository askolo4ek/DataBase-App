   M S B A M L   `   `   `  ����D  @WorkingDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SchedulingBaseSchedulingBase  5   	   #    SchedulingBase.ExecutorWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SchedulingBase     5   	     � Title$  ExecutorWindow��5   	   $
��Auto��6    $	��300��6.    � 
ResizeMode$ NoResize=�5	   	    � SizeToContent$ Height=�5
   	    � 	Resources 5      &   SchedulingBase.ArgumentViewModel   ArgumentViewModel��%   &	          5   
   6"   5      .��5      � $
��Auto��6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� -   5         ��Name$ ArgIC��5      $��0��6�   $
��Auto��6�   $��10��6�    � DataContext 6&   ��  �� Source# [  ��6h   �� *	Arguments+��5      �� 5      .R�5      �� 
���OO/�$��0,1,0,1q�69   ._�5      � $��0,0,0,10q�6    5      �� 5   "   �� 5   "   �� 5   "   .+�5      �� $��0��6C   ��6(   ��  �� Path$
 Type�6C   �� 5      $��1��6C   ��6(   �� $
 Name�6C   �� 5       $��2��6<   ��6&   �� *Text+6<   5!      5"      5#      5%      �� 5&   
   -   5        	 ��Name$	 ExecuteButton��5&      $��Выполнить��6(   $��60,0,59.6,9.6q�6<   $��19��6S   $��Bottom=�6_   $��1��6z   6�   5'      5(      