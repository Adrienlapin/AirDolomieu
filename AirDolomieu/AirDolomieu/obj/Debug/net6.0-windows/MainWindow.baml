   M S B A M L   `   `   `  ����F  BAirDolomieu, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AirDolomieuAirDolomieu  5   	   5clr-namespace:AirDolomieu.ClassAirDolomieu.Class  61       AirDolomieu.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AirDolomieu     5   	   0dataclr-namespace:AirDolomieu.Class     61     � Title$  AirDolomieu��5	   	   $	��718��6   $	��800��6*    � DataContext 5   	   ��  �� RelativeSource �� *Self+.��5
      � $��0,0,0,1q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $	��vol��5      $��308,29,10,257q�6   �� 5   
   $��
Nom Pilote��6   $
��Left=�6%   $��
70,122,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        $��
ListPilote��5      $
��Left=�5      $��
70,153,0,0q�6.   $	��Top=�6B   $	��120��6Z   ��5      �� *	_Pilote+ �� *FindAncestor+ �� AncestorType   AirDolomieu.MainWindow"   �� SelectedItem 5      �� *	_Pilote+��5      �� 5      .R�5      �� ��6    �� *	Nompilote+6=   5      5      �� 5      $��Nom de l'avion��6   $
��Left=�6-   $��
70,209,0,0q�6H   $	��Top=�6\   �� 5   
   -   5        $��	ListAvion��5      $
��Left=�5      $��
70,240,0,0q�6.   $	��Top=�6B   $	��120��6Z   ��5      �� *_Avion+ �� *FindAncestor+"   5      �� *_Avion+��5      �� 5      .R�5      �� ��6    �� *
Nomavion+6<   5       5"      �� 5#   
   -   5        $��	CheckVols��5#   +   $��
Check Vols��6=   $
��Left=�6R   $��
80,351,0,0q�6m   $	��Top=�6�   $	��100��6�   $��25��6�   �� 5$   
   -   5        $��Clear��5$   +   $��Clear Results��69   $��Right=�6Q   $��0,461,130,0q�6m   $	��Top=�6�   $��99��6�   $��25��6�   �� 5%   
   $=��7Ajouter un vol pour le couple Pilote/Avion selectionné��6   $
��Left=�6Q   $��
43,505,0,0q�6l   $	��Top=�6�   $	��318��6�   �� 5&   
   -   5        $��	NewNumVol��5&      $
��Left=�6#   $��
60,560,0,0q�6>    �� TextWrapping$
 Wrap=�6R   $
��NOU2��6f   $	��Top=�6r   $	��120��6�   �� 5'   
   -   5        $��NewVilleDep��5'      $
��Left=�6%   $��210,560,0,0q�6@   $
 Wrap=�6U   $��Paris��6i   $	��Top=�6v   $	��120��6�   �� 5(   
   -   5        $��
NewDateDep��5(      $��Center=�6$   $��	0,560,0,0q�6A   $	��Top=�6T   $��05:00��6l   $��18��6y   $��80��6�    J� RenderTransformOrigin$ 0.506,-2.553&�6�   �� 5)   
   -	   5        $��NewVilleArr��5)      $
��Left=�6'   $��528,560,0,0q�6B   $
 Wrap=�6W   $��Londre��6k   $	��Top=�6y   $	��120��6�   �� 5*   
   -
   5        $��
NewDateArr��5*      $
��Left=�6%   $��670,560,0,0q�6@   $	��Top=�6U   $��18��6m   $��80��6y   $��06:00��6�   �� 5+   
   -   5        $��AJouter Vol��5+   ,   $
��Left=�6B   $��
60,609,0,0q�6]   $	��Top=�6q   $��37��6�   $	��120��6�   �� 5,   
   $��NumVol��6   $
��Left=�6!   $��
60,536,0,0q�6<   $	��Top=�6P   �� 5-   
   $��VilleDep��6   $
��Left=�6#   $��210,534,0,0q�6>   $	��Top=�6S   �� 5.   
   $��HeureDep��6   $
��Left=�6#   $��360,531,0,0q�6>   $	��Top=�6S   �� 5/   
   $��VilleArr��6   $
��Left=�6#   $��528,534,0,0q�6>   $	��Top=�6S   �� 50   
   $��HeureArr��6   $
��Left=�6#   $��670,534,0,0q�6>   $	��Top=�6S   51      52      