   M S B A M L   `   `   `  ����N  JWarsztatSamochodowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WarsztatSamochodowyWarsztatSamochodowy  5   	   "    WarsztatSamochodowy.Zlecenia   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WarsztatSamochodowy     5   	     � Title$  Lista Zleceń��5       � WindowState$ 	Maximized=�6$    � WindowStyle$
 None=�6<   $	��809��6O   #��� ��6\   .��5	      � .+�5
   
   �� -   5        $��lvUsers��5
   &   $��	0,10,0,87q�6   $
��Auto��65    �� View 5      �� 5      .P�5      �� $��id��6%    �� Width$
 Auto��61    �� DisplayMemberBinding 6>   �� *
id_Klienta+�� 5      $
��Imie��6%   $
 Auto��63    6@   �� *Imie+�� 5      $��Naziwsko��6%   $
 Auto��67    6D   �� *
Nazwisko+�� 5      $��Telefon��6%   $
 Auto��66    6C   �� *	Telefon+�� 5      $��Model��6%   $
 Auto��64    6A   �� *Model+�� 5      $��Marka��6%   $
 Auto��64    6A   �� *Marka+�� 5      $��	Pracownik��6%   $	 115��68    �� CellTemplate 5      �� 5      .R�5   "   ��  ��Name$ 	comboBox1��6+   $	��100��5   +    �� SelectedValuePath$ Binding Pracownik��67   	 �� SelectedValue	 5   ?   �� *iojo+.@�5   &   �� .��63   Patryk6;   �� 5   &   .��63   Damian6;   �� 5   &   .��63   Rafał6:   5   #   5      5"      �� 5#      $��Status��6%   $	 115��65    5%      �� 5&      .R�5'   "   �� $	��100��5(   +   $ Binding Status��67   	 5'   ,   �� *joij+.@�5*   &   �� .��63   Gotowe6;   �� 5+   &   .��63   	Anulowane6>   �� 5,   &   .��63   W realizacji6A   �� 5-   &   .��63   
Zakonczone6?   5/   #   50      54      �� 55      $��Status��6%   $
 Auto��65    6B   �� *Status+�� 56      $��	Pracownik��6%   $
 Auto��68    6E   �� *NazwiskoPracownika+�� 57      $��Telefon��6%   $
 Auto��66    6C   �� *
nrTelefonu+�� 58      $
��Opis��6%   $
 Auto��63    6@   �� *Opis_Usterek+�� 59      $��Podsumowanie��6%   $
 Auto��6;    6H   �� *Podsumowanie+�� 5:      $
��Cena��6%   $
 Auto��63    6@   �� *Cena+5;      5>      �� 5?   
   $
��Left=�6   $��61��6-   $��	10,0,0,11q�69   $��Bottom=�6L   $	��299��6g   ��5@      �� 5A      
 �� EndPoint$	
 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5B      �  � Color$ 	#FFF3F3F3��6#    � Offset$ 0Q�65   � 5C      $ 	#FFEBEBEB��6#   $	 0.5Q�65   � 5D      $ 	#FFDDDDDD��6#   $ 0.683Q�65   � 5E      $ 	#FF060002��6#   $ 1Q�65   5F      .��5H      ��  �� Orientation$ 
Horizontal=�6   .+�5I      �� $��Obrazy/ok.png��6   $��50��6/   $��Right=�6:    J� RenderTransformOrigin$ 0.5,0.5&�6V   $��60��6v   �� 5J      $��   Zatwierdź��6   $	��175��6/   $��Right=�6;   $��24(�6W   $��Tahoma)�6e   $��Center=�6y   $
��Bold"�6�   5K      5L      �� 5M   
   -   5         ��Name$ btnWyjdz��5M      $
��Left=�6#   $��61��6>   $��
451,0,0,11q�6J   $��Bottom=�6^   $	��299��6y   ��5N      �� 5O      $	
 0,1&�6&   $	 0,0&�65   .��5P      � $ 	#FFF3F3F3��6#   $ 0Q�65   � 5Q      $ 	#FFEBEBEB��6#   $	 0.5Q�65   � 5R      $ 	#FFDDDDDD��6#   $ 0.683Q�65   � 5S      $ 	#FF060002��6#   $ 1Q�65   5T      .��5V      �� $ 
Horizontal=�6   .+�5W      �� $��Obrazy/logout.png��6   $��50��63   $��Right=�6>   $ 0.5,0.5&�6Z   $��60��6z   �� 5X      $��    Wyjście��6   $	��175��6.   $��Right=�6:   $��24(�6V   $��Tahoma)�6d   $��Center=�6x   $
��Bold"�6�   5Y      5Z      �� 5[   
   -   5        $ 
btnParagon��5[      $��Paragon��6%   $
��Left=�67   $��
324,0,0,11q�6R   $��Bottom=�6f   $��75��6�   $��61��6�   5\      5]      