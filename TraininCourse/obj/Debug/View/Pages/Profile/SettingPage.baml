   M S B A M L   `   `   `  ????H  DTraininCourse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:TraininCourse.View.Pages.Profile TraininCourse.View.Pages.Profile  5      2    ,TraininCourse.View.Pages.Profile.SettingPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:TraininCourse.View.Pages.Profile  5        N? 
FontFamily$
  Lato)?5      .??5      ? .+?5   
   ?? $??Center=?6   $??Center=?5       ?? CornerRadius$ 25??5      $	??400??5      $	??400??5      ???#1F2434 #  MaterialDesignElevationShadow16 J? Effect# [  5      ._?5      ?  ? RowDefinitions 5      ?? 5      $??80 ?6$   ?? 5      $??* ?6$   .+?5      ?? $??0??6   $??Center=?5      $	??Top=?5      $??0 20 0 0q?5      .+?5!      ??  ?? Orientation$ 
Horizontal=?6!   $??Center=?5"   !   $??Center=?5#   !   .+?5$      ?? -   5         ??Name$
 Back??5$   !   
?????? 
?????? .??5(      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Undo=?66   5)      ?? 5*      $??0 5 0 0q?5+      $??Настройки??5,      $??26(?5-      $
??Bold"?5.      
??????? ?? TextAlignment$ Center=?50      51      52      ?? 54      $??1??6   $??Center=?55      $	??Top=?56      .+?57      ?? $ 
Horizontal=?6!   .+?58        $
 User=?62   $??0 7 5 0q?59   2   ???#cfcfcf5:   2   ?? 5;      -   5         ??Name$ TbFirstName??5<   $   $	??150??5;   "   $??15(?5=   $   ???#cfcfcf)  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Ваше имя??5?   $   .  (MaterialDesignThemes.Wpf.TextFieldAssist
   HasClearButton
 . 5@   $   5A      ?? 5B      $ 
Horizontal=?6!   .+?5C        $
 User=?62   $??0 7 5 0q?5D   2   ???#cfcfcf5E   2   ?? 5F      -   5        $ 
TbLastName??5G   $   $	??150??5F   "   $??15(?5H   $   ???#cfcfcf$	 Ваша фамиля??5J   $   
 . 5K   $   5L      ?? 5M      $ 
Horizontal=?6!   .+?5N        $ Image=?62   $??0 7 5 0q?5O   2   ???#cfcfcf5P   2   ?? 5Q      -   5        $ TbLinkAvatar??5R   $   $	??150??5Q   "   $??15(?5S   $   ???#cfcfcf$=	 7Ссылка на изображение профиля??5U   $   
 . 5V   $   5W      ?? 5X      $??0 20 0 0q?6!   .+?5Z      ?? -   5        $ BtnSave??5\   !   ???	#776f85f6
???????$??0q?5^   !     MaterialDesignRaisedButton#??[ 5_   !   {?5`   !   ?? *DataContext.ControlsEnabled+ ?? RelativeSource ?? *FindAncestor+ ?? AncestorType$ WindowL?.??5a      ?? $ 
Horizontal=?6)   .+?5b   "     $ 
FloppyDisc=?6:   $??0 0 5 0q?5c   :   ?? 5d   "   $??Сохранить??6,   $??SemiBold"?5e   ,   5f      5g      5h      ?? 5j      $??0 5 0 0q?6!   .+?5l      ?? -   5        $ 	BtnLogout??5n   !   ???	#776f85f6
???????$??0q?5p   !   #??[ 5q   !   {?5r   !   ?? *DataContext.ControlsEnabled+ ?? *FindAncestor+$ WindowL?.??5s      ?? $ 
Horizontal=?6)   .+?5t   "     $ Logout=?6:   $??0 0 5 0q?5u   :   ?? 5v   "   $&?? Выйти из аккаунта??6,   $??SemiBold"?5w   ,   5x      5y      5z      5|      5}      5~      5      5?      