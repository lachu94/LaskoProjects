   M S B A M L   `   `   `  ����N  JWarsztatSamochodowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WarsztatSamochodowyWarsztatSamochodowy  5   	   #    WarsztatSamochodowy.Formularz   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WarsztatSamochodowy     5   	     � Title$"  Formularz przyjęcia usługi��5   
    � WindowState$ 	Maximized=�6.    � WindowStyle$
 None=�6F   $	��809��6Y   #��� ��6f   .��5	      � $	��779��6   $	��Top=�6   $��Center=�60   .+�5
   
   �� ���	#FFF4F4F5$
��Left=�6%   $	��179��6@   $��-10,45,-25,0q�6M   
���   �$	��Top=�6r   $	��707��6�   �� 5   
   $��Dane klienta: ��6   $
��Left=�6)   $��	40,45,0,0q�6D   $	��Top=�6W   $	��285��6o   $��28(�6{   $
��Bold"�6�   $��Italic$�6�   �� 5   
   $��Imię:��6   $
��Left=�6    $��
140,91,0,0q�6;   $	��Top=�6O   $��20(�6g   $
��Bold"�6u   �� 5   
   $��	Nazwisko:��6   $
��Left=�6$   $��140,133,0,0q�6?   $	��Top=�6T   $��20(�6l   $
��Bold"�6z   �� 5   
   $��Telefon:��6   $
��Left=�6#   $��140,174,0,0q�6>   $	��Top=�6S   $��20(�6k   $
��Bold"�6y   �� 5   
   -   5         ��Name$ txtImie��5      $
��Left=�6#   $��31��6>   $��
250,98,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��179��6�   $��18(�6�   $��1��6�   �� 5   
   -   5        $ txtNazwisko��5      $
��Left=�6'   $��31��6B   $��250,139,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��179��6�   $��18(�6�   $��2��6�   �� 5   
   -   5        $ 
txtTelefon��5      $
��Left=�6&   $��31��6A   $��250,180,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��179��6�   $��18(�6�   $��3��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��188��6@   $��-10,255,-25,0q�6M   
���   �$	��Top=�6s   $	��707��6�   �� 5   
   $��Dane pojazdu:��6   $
��Left=�6(   $��
39,255,0,0q�6C   $	��Top=�6W   $��28(�6o   $
��Bold"�6}   $��Italic$�6�   �� 5   
   $��Marka:��6   $
��Left=�6!   $��145,307,0,0q�6<   $	��Top=�6Q   $��20(�6j   $
��Bold"�6x   �� 5   
   $��Rodzaj paliwa:��6   $
��Left=�6)   $��145,393,0,0q�6D   $	��Top=�6Y   $��20(�6r   $
��Bold"�6�   �� 5   
   $��Model:��6   $
��Left=�6!   $��145,349,0,0q�6<   $	��Top=�6Q   $��20(�6j   $
��Bold"�6x   �� 5   
   -   5        $ txtModel��5      $
��Left=�6$   $��31��6?   $��250,351,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��179��6�   $��18(�6�   $��5��6�   �� 5   
   -   5        $ txtMarka��5      $
��Left=�6$   $��30��6?   $��250,314,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��179��6�   $��18(�6�   $��4��6�   �� 5   
   ���	#FFF4F4F5$
��Left=�6%   $	��253��6@   $��-10,468,-25,0q�6M   
���   �$	��Top=�6s   $	��707��6�   �� 5   
   $+��%Opis usterek lub zadań do wykonania:��6   $
��Left=�6?   $��
31,468,0,0q�6Z   $	��Top=�6n   $��28(�6�   $
��Bold"�6�   $��Italic$�6�   �� 5   
   -   5        $ txtOpisUsterki��5      $
��Left=�6*   $	��184��6E   $��
40,520,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��590��6�   $��18(�6�   $��7��6�   �� 5   
   -   5         ��Name$ btnZatwierdz��5      $
��Left=�6'   $��61��6B   $��Bottom=�6N   $	��299��6i   $��8��6�   $��-10,0,0,-32q�6�   ��5      �� 5       �� EndPoint$	 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      �  � Color$ 	#FFF3F3F3��6#   	 � Offset$	 0Q�65   � 5       $ 	#FFEBEBEB��6#   $		 0.5Q�65   � 5!      $ 	#FFDDDDDD��6#   $	 0.683Q�65   � 5"      $ 	#FF060002��6#   $	 1Q�65   5#      .��5%      �� 
 �� Orientation$
 
Horizontal=�6   .+�5&      �� $��Obrazy/ok.png��6   $��50��6/   $��Right=�6:    J� RenderTransformOrigin$ 0.5,0.5&�6V   $��60��6v   �� 5'      $��   Zatwierdź��6   $	��175��6/   $��Right=�6;   $��24(�6W   $��Tahoma)�6e   $��Center=�6y   $
��Bold"�6�   5(      5)      �� 5*   
   -   5        $
��Left=�5*      $��61��6-   $��396,0,-23,-32q�69   $��Bottom=�6P   $	��299��6k   $��9��6�   ��5+      �� 5,      $	 0,1&�6&   $	 0,0&�65   .��5-      � $ 	#FFF3F3F3��6#   $	 0Q�65   � 5.      $ 	#FFEBEBEB��6#   $		 0.5Q�65   � 5/      $ 	#FFDDDDDD��6#   $	 0.683Q�65   � 50      $ 	#FF060002��6#   $	 1Q�65   51      .��53      �� $
 
Horizontal=�6   .+�54      �� $��Obrazy/logout.png��6   $��50��63   $��Right=�6>   $ 0.5,0.5&�6Z   $��60��6z   �� 55      $��    Wyjście��6   $	��175��6.   $��Right=�6:   $��24(�6V   $��Tahoma)�6d   $��Center=�6x   $
��Bold"�6�   56      57      �� 58   
   -	   5         ��Name$ cboxTypSilnika��58      $
��Left=�6+   $��296,393,0,0q�6F   $	��Top=�6[   $	��133��6s   $��37��6   $��6��6�   $
��Bold"�6�   .@�59      �� $��Center=�6   $
��Left=�66   .��6Q   Diesel6Y   �� 5:      $
��Left=�6   $��Center=�66   .��6Q   	Benzyna6Z   �� 5;      $
��Left=�6   $��Center=�66   .��6Q   Benzyna + LPG6`   5=      5>      5?      