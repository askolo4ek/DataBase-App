   M S B A M L   `   `   `  ����D  @WorkingDB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:SchedulingBaseSchedulingBase  5   	       SchedulingBase.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:SchedulingBase     5   	     � Title$  Клиент��5   	   $	��400��6   $	��406��6%    � 
ResizeMode$ NoResize=�61    � 	Resources 5	      (  "SchedulingBase.SubroutineViewModel   SubroutineViewModel��%   &	          5
   
   6$   5      .��5      � .+�5   
   �� -   5         ��Name$ subsBox��5      $
��Left=�6#   $��	200,0,0,0q�6>   $	��200��6Q    � DataContext 6]   ��  �� Source# [  ��6�   ��  �� Path$ Subroutines� �� SelectedItem 6�   �� $ 
Subroutine���5      �� 5      .R�5      �� ��5      `� 5       �� StringFormat$ 	({0}) {1}��6+   .1�5   "   �� $
 Type�6*   �� 5   "   $
 Name�6*   5      5      5      5      �� 5   
   -   5        	 ��Name$	 HostBox��5      $
��Left=�6#   $��23��6>   $��5,8,0,0q�6J   
 �� TextWrapping$

 Wrap=�6[   $��	localhost��6o   $	��Top=�6�   $	��190��6�   �� 5   
   -   5        $	 	DbNameBox��5      $
��Left=�6%   $��23��6@   $��5,36,0,0q�6L   $

 Wrap=�6^   $��postgres��6r   $	��Top=�6�   $	��190��6�   �� 5   
   -   5        $	 UsernameBox��5      $
��Left=�6'   $��23��6B   $��5,64,0,0q�6N   $

 Wrap=�6`   $	��Top=�6t   $	��190��6�   G� 5   
   -   5         G�Name$ PasswordBox��5      $
��Left=�6+   $��5,92,0,0q�6F   $	��Top=�6X   $	��190��6p   $��23��6|   �� 5   
   -   5         ��Name$ ConnectButton��5      $��Подключиться��6(   $
��Left=�6?   $��	5,119,0,0q�6Z   $	��Top=�6m   $��89��6�   6�   �� 5    
   -   5        $ DisConnectButton��5       {�.  $��Отключиться��6=   $
��Left=�6S   $��104,119,0,0q�6n   $	��Top=�6�   $��91��6�   $��19��6�   �� 5!   
   -   5        $ ProjectTableButton��5!      $��Project��6-   $
��Left=�6?   $��
55,147,0,0q�6Z   $	��Top=�6n   $��88��6�    J� RenderTransformOrigin$ 0.483,0.507&�6�   6�   �� 5"   
   -	   5        $ WorkDayTableButton��5"      $��WorkDay��6-   $
��Left=�6?   $��
55,166,0,0q�6Z   $	��Top=�6n   $��88��6�   $ 0.483,0.507&�6�   6�   �� 5#   
   -
   5        $ TaskTableButton��5#      $
��Task��6*   $
��Left=�69   $��
55,185,0,0q�6T   $	��Top=�6h   $��88��6�   $ 0.483,0.507&�6�   6�   �� 5$   
   -   5        $ ManagerTableButton��5$      $��Manager��6-   $
��Left=�6?   $��
55,204,0,0q�6Z   $	��Top=�6n   $��88��6�   $ 0.483,0.507&�6�   6�   �� 5%   
   -   5        $ WorkerTableButton��5%      $��Worker��6,   $
��Left=�6=   $��
55,223,0,0q�6X   $	��Top=�6l   $��88��6�   $ 0.483,0.507&�6�   6�   �� 5&   
   -   5        $ DepartmentTableButton��5&      $��
Department��60   $
��Left=�6E   $��
55,242,0,0q�6`   $	��Top=�6t   $��88��6�   $ 0.483,0.507&�6�   6�   5'      5(      