   M S B A M L   `   `   `  ????@  <Login, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:LoginLogin  5   	       Login.ListPemesanan   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   localclr-namespace:Login  5   	     ? WindowStyle$
  None=?5	   	    ? AllowsTransparency .  ? WindowStartupLocation$ CenterScreen=?5   	      MaterialDesignBody#???   5   	   $??Regular"?5   	   $??13(?5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   	      TextRenderingMode$
 Auto=?5   	     MaterialDesignFont#???  5   	    ? Title$ Makanan??5      $	??800??6   $
??1000??6%   .??5      ? .+?5   
   ?? $E???D:\Semester 4\Bengkel Aplikasi Desktop\ProjectBAD\assets\ws.png??6   $??69,64,642,651q?6Y   ?? 5   
   $
??Left=?6   $??601,205,0,0q?6,   $	??Top=?6A   $	??320??6Y   $??45??6e    J? RenderTransformOrigin$ 0.518,2.218&?6q   ??5      ?? 5       ?? Color$ 	#FFDDDDDD??6"    ?? Opacity$	 0.5Q?64   5      ?? 5   
   -   5        $??Checkout??5      $
??Left=?6$   $??615,213,0,0q?6?   $	??Top=?6T   $	??126??6l   $??27??6x   ???#218dd7$??14(?6?   6?   &   System.Windows.Controls.DataGrid  5   
   -   5        $??dataPemesanan??5      $??86,355,79,150q?5      	   CanUserSortColumns	 . 
   CanUserAddRows
 .     AutoGenerateColumns .  -  'MaterialDesignThemes.Wpf.DataGridAssist   CellPadding$ 13 8 8 8q?5"         ColumnHeaderPadding$ 8q?5#         Columns 5$      4  .System.Windows.Controls.DataGridCheckBoxColumn  5%       - )MaterialDesignDataGridCheckBoxColumnStyle1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 5'       4 0MaterialDesignDataGridCheckBoxColumnEditingStyle   EditingElementStyle# [ 5(         Binding 5&      ?? *
IsSelected+,  &System.Windows.Controls.DataGridColumn   Header 5)      ?? 5+      
??????  ?? Padding$ 6 0 6 0q?5-      $??Center=?5.      ._?5/      ?? $??Center=?50       ? DataContext 51      ??  ?? RelativeSource ??  ?? AncestorType"   ?? Path$ DataContext? d? 	IsChecked 52      ?? *IsAllItems3Selected+53      55      0  *System.Windows.Controls.DataGridTextColumn  56      $ 	Nama Menu??58       0 ,MaterialDesignDataGridTextColumnEditingStyle# [ 59         Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6k    57      ?? *	nama_menu+59   k   1	  +MaterialDesignThemes.Wpf.DataGridTextColumn	  5;      $ Jumlah??5=      $	 150 5>       5 1MaterialDesignDataGridTextColumnPopupEditingStyle# [ 5?       5<      ?? *jumlah+5?      	  5A      $ Harga??5C      $	 150 5D      # [ 5E       5B      ?? *harga+5E      	  5F      $ Total Harga??5H      $	 120 5I      # [ 5J       5G      ?? *total_harga+   HeaderStyle 5K      ?? 5L       ?? 
TargetType=
  7System.Windows.Controls.Primitives.DataGridColumnHeader" 
 5M       & "MaterialDesignDataGridColumnHeader ?? BasedOn# [ 5N      .?5O      ??  ?? Property ? ?? ?? Value$ Center=?5Q      ?? 5R       ? ?? 5T   "   ?? 5U   &   .R?5V   *   ?? $
??Wrap=?5W   +    ?? TextAlignment$ Center=?5Y   +   ??5X   +   ?? 5Y   +   5Z   '   5\      5]       5_      ?? 5`      " ??5a      .?5b      ??  ? ??$ Center=?5d   )   5e      5g      5j      ?? 5k   
   -   5        ???#614612
??? ???$??Kembali??5k   :   $
??Left=?6L   $??675,699,0,0q?6g   $	??Top=?6|   $	??246??6?   $??48??6?   6?   ?? 5l   
   -   5        ???#614612
??? ???$
??Edit??5l   :   $
??Left=?6I   $??381,699,0,0q?6d   $	??Top=?6y   $	??246??6?   $??48??6?   6?   ?? 5m   
   -   5        $??Hapus??5m   ?   
???  ??$??Hapus??6"   $
??Left=?62   $??112,699,0,0q?6M   $	??Top=?6b   $	??246??6z   $??48??6?   6?   ?? 5n   
   -   5        $??
totalsemua??5n      $
??Left=?6&   $??760,213,0,0q?6A   $
??Wrap=?6V   $	??Top=?6k   $ 0.563,-1.511&?6?   $??27??6?   $	??144??6?   $??16(?6?   ???	#FFFFFB006?   ?? 5q   
   
???????$??Nama :??6#   $
??Left=?64   $??
86,218,0,0q?6O   $	??Top=?6c   $ -3.395,2.807&?6{   $??16(?6?   $
??Bold"?6?   ?? 5r   
   -   5        $??order??5r   8   
???   ?
???????$
??Left=?6E   $??32??6`   $??184,213,0,0q?6l     ?? TextWrapping$
  Wrap=?6?   $?? ??6?   $	??Top=?6?   $	??344??6?   $
??Bold"?6?   $??14(?6?   ?? 5s   
   
???????$??Order :??6#   $
??Left=?65   $??
86,276,0,0q?6P   $	??Top=?6d   $ -3.395,2.807&?6|   $??16(?6?   $
??Bold"?6?   ?? 5t   
   -   5        $??atasnama??5t   &   
???????$
??Left=?66   $??184,271,0,0q?6Q   $	??Top=?6f   $	??344??6~   $ 0.175,-0.146&?6?   $??32??6?   .@?5u      ?? $??Dine In??6   $
??Left=?6-   $	??344??6H   $??32??6T   $??18(?6`   ?? 5v      $??	Take Away??6   $
??Left=?6/   $	??344??6J   $??32??6V   $??18(?6b   5w      5y      ??5z      ?? 5{   
   ! ?? ImageSource$F! @D:\Semester 4\Bengkel Aplikasi Desktop\ProjectBAD\assets\bgg.jpg??6   " j? Stretch$
" Fill=?6d   5}      