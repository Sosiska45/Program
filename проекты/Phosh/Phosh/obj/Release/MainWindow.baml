   M S B A M L   `   `   `  ���� @  <Phosh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PhoshPhosh      Phosh.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     %localclr-namespace:Phosh     -     � Title$  
MainWindow��$	��720��$
��1280�� � WindowStyle$
 None=� � 
ResizeMode$ CanResizeWithGrip=� � WindowStartupLocation$ CenterScreen=� � AllowsTransparency . .��]� ���	#FFCCCCCC.+�� -    �Name$ DragGrid��$	��Top=�$��30�� � ColumnDefinitions �� $
��auto ��� $
��102* ��� $
��181* ��� $��30 ��� $��30 ��� $��30 �.+�o� $��30��$��0,0,0,0q�$��0��.@�m� $��Файл��$��50��$��30��.@�m� -    m�Name$ 
CreateFile��$��Создать файл��m� -   $ OpenFile��$��Открыть файл��m� $!��Сохранить файл��m� $��Отменить��m� $��Вырезать��m� $��Копировать��m� $��Вставить���� -   $��1�� �� Orientation$ Vertical=����	#FFCCCCCC$��2��.+��� -   	 ��Name$	 	TitleName��$5��/Графический редактор - Phosh��$��Center=�$��18(�$��Calibri)��� -   $��3��   ButtonStyle#���   
��� ���.���� $ 
Horizontal=�.+��� $��/Icons/Minimize.png���� -   $��4��#���   
��� ���.���� $ 
Horizontal=�.+��� $��/Icons/Maximize.png���� -	   $��5��#���   
��� ���.���� $ 
Horizontal=�.+��� $��/Icons/Close.png��� $
��Left=�
 � RowDefinitions
 �� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto ��� $
��auto �.+��� $
��auto��$��0��.+��� $��30��$��
3, 5, 3, 5q�$��/Icons/ColorPicker.png���� $��1��.+��� $��30��$��
3, 5, 3, 5q�$��/Icons/Sizing.png���� $��2��.+��� -
    ��Name$ MirrorButton��.���� $��30��$��
3, 5, 3, 5q�$��/Icons/Mirror.png���� $��3��.+��� -   $ CleanButton��.���� $��30��$��
3, 5, 3, 5q�$��/Icons/CleanUp.png���� $��4��.+��� -   $ PencilButton��.���� $��30��$��
3, 5, 3, 5q�$��/Icons/Pencil.png���� $��5��.+��� -   $ BrushButton��.���� $��30��$��
3, 5, 3, 5q�$��/Icons/Brush.png���� $��6��.+��� -   $ EraserButton��.���� $��30��$��
3, 5, 3, 5q�$��/Icons/Eraser.png���� $��7��.+��� -   $ BucketButton��.���� $��30��$��
3, 5, 3, 5q�$��/Icons/Bucket.png���� $��8��.+��� -   $ PipetkaButton��.���� $��30��$��
3, 5, 3, 5q�$��/Icons/Pipetka.png���� $��9��.+��� -   $
 back��$��30��$��30��$��3,5,3,5q�
���   �
���   ��� $��10��.+��� -   $
 fore��$��30��$��30��$��3,5,3,5q�
�������
���   ��� $��11��.+��� -   $ Change_button��$��30��$��30��$��3,5,3,5q���Z� ��Z� .���� $��/Icons/refresh.png��� $��Bottom=�$��30��$y�Hidden=� �� $
��auto ��� $
��auto ��� $
��auto ��� $��* �.+��� -    ��Name$ WidthBox��$��0��$��75��$�� 5, 3, 3, 3q�$��Center=��� -   $ 	HeightBox��$��1��$��75��$�� 5, 3, 3, 3q�$��Center=��� $��2��$	��100��$��15, 3, 0, 3q����	#FFFFFFFF.@��� $��Футы���� $��
Дюймы���� $��Пиксели�� �� 
IsSelected . �� $��Сантиметры��� -   $ 	DrawField�����	#FFE0D5D5 �� $��* �.+��� -    ��Name$	 Cnv��$��0��.+��� -    ��Name$ 
MainCanvas��$	��654��$
��1230�� �� 
Background ��  �� DefaultDrawingAttributes *  $System.Windows.Ink.DrawingAttributes     Color$ Black��   Width$ 3Q�   Height$ 3Q�