   M S B A M L   `   `   `  ����N  JWarsztatSamochodowy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:WarsztatSamochodowyWarsztatSamochodowy  5   	   )    #WarsztatSamochodowy.DodajPracownika   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:WarsztatSamochodowy     5   	     � Title$  DodajPracownika��5   	    � WindowState$ 	Maximized=�6!    � WindowStyle$
 None=�69   $	��809��6L   #��� ��6Y   .��5	      � .+�5
   
   �� -   5         ��Name$ btnDodajPracownika��5
      $��Dodaj pracownika��6-   $��Center=�6H   $��
74,249,0,0q�6e   $��Bottom=�6y   $	��137��6�   6�   �� 5   
   -   5         ��Name$ txtImie��5      $
��Left=�6#   $��23��6>   $��133,142,0,0q�6J    �� TextWrapping$
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ txtNazwisko��5      $
��Left=�6'   $��23��6B   $��133,170,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��120��6�   �� 5   
   -   5         ��Name$ label��5      $�� imie��6   $
��Left=�6/   $��	9,139,0,0q�6J   $	��Top=�6]   $	��100��6u   �� 5   
   -   5        $ 
txtTelefon��5      $
��Left=�6&   $��23��6A   $��133,198,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   -   5        $ label2��5      $��numer telefonu��6    $
��Left=�69   $��
10,195,0,0q�6T   $	��Top=�6h   $	��100��6�   �� 5   
   -   5        $ label1��5      $��	 nazwisko��6    $
��Left=�64   $��	9,170,0,0q�6O   $	��Top=�6b   $	��100��6z   �� 5   
   -   5        $ label3��5      $&�� Wprowadz dane nowego pracownika:��6    $
��Left=�6K   $��	20,10,0,0q�6f   $	��Top=�6y   $	��233��6�   �� 5   
   -	   5        $ label4��5      $��login��6    $
��Left=�60   $��	10,41,0,0q�6K   $	��Top=�6^   G� 5   
   -
   5         G�Name$ pasHaslo��5      $
��Left=�6(   $��
133,75,0,0q�6C   $	��Top=�6W   $	��120��6o   $��23��6{   �� 5   
   -   5        $ label5��5      $��hasło��6    $
��Left=�60   $��	10,74,0,0q�6K   $	��Top=�6^    J� RenderTransformOrigin$ 
0.235,0.49&�6v   �� 5   
   -   5        $ txtLogin��5      $
��Left=�6$   $��23��6?   $��
133,44,0,0q�6K   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   �� 5   
   -   5        $ label6��5      $��wybierz typ konta��6    $
��Left=�6<   $��	9,105,0,0q�6W   $	��Top=�6j   $	��113��6�   �� 5   
   -   5        	 ��Name$	 comboBox��5      $
��Left=�6%   $��133,115,0,0q�6@   $	��Top=�6U   $	��120��6m   .@�5      �� $
��Szef��6   $
��Left=�6*   $	��118��6E   �� 5      $��	Pracownik��6   $
��Left=�6/   $	��118��6J   5      �� 5   
   -   5        $
��Left=�5      $��61��6-   $��406,0,-33,24q�69   $��Bottom=�6O   $	��299��6j   ��5      �� 5      
 �� EndPoint$	
 0,1&�6&    �� 
StartPoint$	 0,0&�65   .��5      �  � Color$ 	#FFF3F3F3��6#    � Offset$ 0Q�65   � 5       $ 	#FFEBEBEB��6#   $	 0.5Q�65   � 5!      $ 	#FFDDDDDD��6#   $ 0.683Q�65   � 5"      $ 	#FF060002��6#   $ 1Q�65   5#      .��5%      ��  �� Orientation$ 
Horizontal=�6   .+�5&      �� $��Obrazy/logout.png��6   $��50��63   $��Right=�6>   $ 0.5,0.5&�6Z   $��60��6z   �� 5'      $��    Wyjście��6   $	��175��6.   $��Right=�6:   $��24(�6V   $��Tahoma)�6d   $��Center=�6x   $
��Bold"�6�   5(      5)      5+      5,      