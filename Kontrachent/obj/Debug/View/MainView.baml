   M S B A M L   `   `   `  ����F  BKontrachent, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:KontrachentKontrachent  5   	   ?$clr-namespace:Kontrachent.ViewModelsKontrachent.ViewModels  5   	       Kontrachent.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Kontrachent     5   	   ;
viewModels$clr-namespace:Kontrachent.ViewModels     5   	     � SizeToContent$  WidthAndHeight=�5	   	    � Title$ MainView��5
   	   $	��350��6   $	��700��6'   .��5      �  � DataContext 5   
   *   $Kontrachent.ViewModels.MainViewModel  5       � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   &   System.Windows.Controls.DataGrid     AutoGenerateColumns .  ��6   ��  �� Path$ Contractors� �� SelectedItem 6<   �� $ SelectedContractor�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5       ,  &System.Windows.Controls.DataGridColumn   Header$
 Znak��6C   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� $
 Znak�6C     5!      $ SkrotK��6E   	 6%   �� $ SkrotK�6E     5"      $ Regon��6D   	 6%   �� $ Regon�6D     5#      $ Kod nip��6E   	 6%   �� $ Kodnip�6E     5$      $	 Nip��6B   	 6%   �� $	 Nip�6B     5%      $ Nazk1��6D   	 6%   �� $ Nazk1�6D     5&      $ Nazk2��6D   	 6%   �� $ Nazk2�6D     5'      $ KodpoczK��6G   	 6%   �� $ KodpoczK�6G     5(      $ MiejsceK��6G   	 6%   �� $ MiejsceK�6G     5)      $ UlicaK��6E   	 6%   �� $ UlicaK�6E     5*      $
 NrmK��6C   	 6%   �� $
 NrmK�6C     5+      $
 TelK��6C   	 6%   �� $
 TelK�6C     5,      $
 TlmK��6C   	 6%   �� $
 TlmK�6C   5.      �� 5/   
   
 �� Orientation$
 
Horizontal=�6   $��1��6.   .+�50      �� $��Dodaj��6   $��0,0,5,0q�6W   ��6%   �� $ ShowAddContractorCommand�6W   �� 51      $��Popraw��6   $��0,0,5,0q�6Y   ��6&   �� $ ShowEditContractorCommand�6Y   �� 52      $��Usuń��6   ��6$   �� $ RemoveContractorCommand�53      54      55      