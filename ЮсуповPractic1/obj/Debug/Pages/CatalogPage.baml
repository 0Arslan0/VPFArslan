   M S B A M L   `   `   `  ����O  KЮсуповPractic1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ЮсуповPractic1.PagesЮсуповPractic1.Pages  5      ,    &ЮсуповPractic1.Pages.CatalogPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:ЮсуповPractic1.Pages     5        N� Title$  CatalogPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5       � ColumnDefinitions 5   
   �� 5      �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DGCatalog��5   0   $��1��6   $��0��6       AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+  5      $ Материал��6%    67   �� *
Material+  5      $ Тип��6%    62   �� *Type+  5      $ 
Стиль��6%    64   �� *Style+  5      $ Количество��6%    69   �� *Quantity_in_stock+5      �� 5   
   $��0��6   $��2��6"   .+�5       �� $��Каталог��6   $��40(�6'   $��Center=�65   5!      �� 5"   
   $��1��6   $��1��6"   
������.+�5#      �� -   5         ��Name$
 BAdd��5$      $��Добавить��5%      $	��100��5&      $��15(�5'      
������
���   �5*      �� 5+      $��Редактироать��5,      $	��100��5-      $��15(�5.      
������
���   �50      �� 51      -   5        $ BDelet��51      $��Удалить��52      $	��100��53      $��15(�54      
������
���   �57      58      59      5:      