   M S B A M L   `   `   `  ����C  ?VocablEW, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:VocablEWVocablEW  5   	       VocablEW.CheckingWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:VocablEW     5   	   -   5          � Title$  CheckingWindow��5   	   $��124.49��6    $��361.702��60    � WindowStyle$
 None=�6Y    � AllowsTransparency . 
������  � Topmost .  � 	Resources 5	       �� 
TargetType   btnTemplate ��Name �� CornerRadius �� Triggers	 P� Property
 P� Value �� 
TargetName �� Property �� Value��%I  &	        �� 5
   
   " ��6   .R�5      �� $ buttonBorder��6   $ 5��6+   
�����_�$��2q�6T   #��z��6h   ._�5      �� $��Center=�6!   $��Center=�6>   #��z��6Y   5       5      P� 5      	 �@J�IsMouseOver
 . . �5      �� $ buttonBorder��6    � �� �	#FF823DF36M   5      P� 5      	 � ��
 . . �5      �� $ buttonBorder��6    � ��
 ��  �6N   5      P� 5      	 � {�
 .  . �5      ��  � ��
 �����63   �� 5      $ buttonBorder��6    � ��
 �����6M   5      5      5      .��5      � .+�5   
   �� .+�5      �� ���	#FF1B1B23$
��Left=�6)   $	��114��6D   $��7��6Q   ���	#FF03075B$	��Top=�6x   $	��352��6�    �� RadiusX$ 15��5       �� RadiusY$ 15��6!    �� Left$ 10��6.   
 �� Top$ 10��6?   �� 5       -   5         ��Name$ 
entryField��5       $ 28��6*    �� TextWrapping$
 Wrap=�6;   $��TextBox��6O   $ 54��6^   $	��239��6n   $��18(�5!      ���	#FF35405D6;   �� 5"      -   5         ��Name$ lblIssue��5"      $��Label��6&   $ 25��66   $ 24��6G   $��18(�6W   
���   �6e   �� 5#      -   5         ��Name$ btnCheck��5#      #��[  6'   $	 272��6O   $ 55��6a   $��75��6q   $��25��6|   $��16(�5$      ���	#FF35405D$��Check��6:   6J   �� 5%      -   5        $ 
btnOpenWeb��5%      #��[  6)   $��Open Web��6Q   $	 253��6d   $��25��5&      $ 24��6!   $��94��61   $��16(�6<   ���	#FF35405D6a   �� 5'      -   5        $ 
lblCorrect��5'      $��Label��6(   $ 25��68   $ 75��6I   $��18(�6Y   
���   �6g   5(      5)      5*      