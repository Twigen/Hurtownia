   M S B A M L   `   `   `  ����F  BKontrachent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kontrachent.ViewKontrachent.View  5   	   ?$clr-namespace:Kontrachent.ViewModelsKontrachent.ViewModels  5   	   )    #Kontrachent.View.EditContractorView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Kontrachent.View     5   	   ;
viewModels$clr-namespace:Kontrachent.ViewModels     5   	     � WindowStartupLocation$  Manual=�5	   	   
 � Top$	 200��5
   	    � Left$
 1000��6    � Title$ EditContractorView��5   	   $��424.567��6$   $	��300��65   .��5      � $��0,0,-0.4,-49.6q�6    � DataContext 5   
   4   .Kontrachent.ViewModels.EditContractorViewModel  5      .+�5   
   ��  �� Orientation$ Vertical=�6   .+�5      �� $ 
Horizontal=�6   .+�5      �� $
��Znak��6   6,   �� 5      $	��100��6@   $��5q�6L   ��6   ��  �� Path$ Contractor.Znak�6Y   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��SkrotK��6   6-   �� 5      $	��100��6B   $��5q�6N   ��6   �� $ Contractor.SkrotK�6[   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Regon��6   6,   �� 5      $	��100��6A   $��5q�6M   ��6   �� $ Contractor.Regon�6Z   5      �� 5      $ 
Horizontal=�6   .+�5      �� $��Kod NIP��6   6.   �� 5      $	��100��6B   $��5q�6N   ��6   �� $ Contractor.Kodnip�6[   5       �� 5!      $ 
Horizontal=�6   .+�5"      �� $	��NIP��6   6*   �� 5#      $	��100��6?   $��5q�6K   ��6   �� $ Contractor.Nip�6X   5$      �� 5%      $ 
Horizontal=�6   .+�5&      �� $��Nazk1��6   6,   �� 5'      $	��100��6A   $��5q�6M   ��6   �� $ Contractor.Nazk1�6Z   5(      �� 5)      $ 
Horizontal=�6   .+�5*      �� $��Nazk2��6   6,   �� 5+      $	��100��6A   $��5q�6M   ��6   �� $ Contractor.Nazk2�6Z   5,      �� 5-      $ 
Horizontal=�6   .+�5.      �� $��Kod pocztowy��6   63   �� 5/      $	��100��6D   $��5q�6P   ��6   �� $ Contractor.KodpoczK�6]   50      �� 51      $ 
Horizontal=�6   .+�52      �� $��Miejsce��6   6.   �� 53      $	��100��6D   $��5q�6P   ��6   �� $ Contractor.MiejsceK�6]   54      �� 55      $ 
Horizontal=�6   .+�56      �� $��Ulica��6   6,   �� 57      $	��100��6B   $��5q�6N   ��6   �� $ Contractor.UlicaK�6[   58      �� 59      $ 
Horizontal=�6   .+�5:      �� $
��NrMk��6   6+   �� 5;      $	��100��6@   $��5q�6L   ��6   �� $ Contractor.NrmK�6Y   5<      �� 5=      $ 
Horizontal=�6   .+�5>      �� $	��Tel��6   6*   �� 5?      $	��100��6@   $��5q�6L   ��6   �� $ Contractor.TelK�6Y   5@      �� 5A      $ 
Horizontal=�6   .+�5B      �� $
��TLMK��6   6+   �� 5C      $	��100��6@   $��5q�6L   ��6   �� $ Contractor.TlmK�6Y   5D      �� 5E      $ 
Horizontal=�6   $��Right=�62   .+�5F      �� $��Edytuj��6   ��6*   �� $ EditContractorCommand�5G      5H      5I      5J      