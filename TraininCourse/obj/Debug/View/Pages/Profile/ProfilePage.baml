   M S B A M L   `   `   `  ????H  DTraininCourse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:TraininCourse.View.Pages.Profile TraininCourse.View.Pages.Profile  5      2    ,TraininCourse.View.Pages.Profile.ProfilePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:TraininCourse.View.Pages.Profile  5        N? 
FontFamily$
  Lato)?5      .??5      ? .+?5   
   ?? $??Center=?6   $??Center=?5       ?? CornerRadius$ 25??5      $	??950??5      $	??500??5      ._?5      ?  ? RowDefinitions 5      ?? 5      $??90 ?6$   ?? 5      $??* ?6$   .+?5      ?? $??0??6   $??Center=?5      $??Center=?5       ?? Orientation$ 
Horizontal=?5      .+?5      ?? $
??Left=?6!   .+?5      A? $??68??6"   $??68??6-   ??5      ?? 5   "   -   5        IUserAva?? ?? ImageSource$ /Images/ic_user.png??5   ?   5!      5"      ?? 5#      $??Right=?6!   $??5 0 0 0q?5$   !   .+?5%      ?? -   5         ??Name$ 
TbUserName??5)   $   $??UserName??5%   $   $??16(?5&   $   
???????$??2 0 0 0q?5(   $   5)   $   ?? 5*      -   5        $ 
TbUserRole??5.   $   $??Admin??5*   $   $??14(?5+   $   ???#F9A992$??2 0 0 0q?5-   $   5.   $   ?? 5/      -   5         ??Name$ 
BtnSetting??5/   !   
?????? ???	#776F85F6.??53      ?? $??Настройки??6(   54      55      56      ?? 58      $??1??6   .+?59      ?? $ 
Horizontal=?6!   $??Center=?5:   !   $??0 10 0 0q?5;   !   .+?5<      ?? -   5        $ BtnStudying??5<   !   
?????? 
?????? .??5?   7   Изучаю6?   ?? 5@      -   5        $ BtnWillStudy??5@   !   
?????? 
?????? .??5C   7   Буду изучать6E   ?? 5D      -   5        $ 
BtnStudied??5D   !   
?????? 
?????? .??5G   7   Изучил6?   5H      ?? 5I      -   5         ??Name$ LbMyCoursesList??5I      $??Disabled=?5J      $??0 5 0 0q?5K      ??5M      ?? 5N      .R?5O   "   ?  ? 
ItemHeight$	 160??6,   	 ? 	ItemWidth$		 235??5P       
 ? Orientation$
 
Horizontal=?5Q       5R      ??5T      ?? 5U      .R?5V   "   ?? ???#1F2434$ 8??5W   %   ._?5X   &   ?? $??Center=?61   .+?5Y   *   ?? $	??229??5[   )   $	??229??65   $	??125??5\   )   $	??125??66   ??5Z   )   ?? *Path+5\   6   ?? 5]   *    ?? TextAlignment$
 Left=?5^   )   $??Center=?5_   )   $??CharacterEllipsis=?5`   )   $??0 2 0 0q?5a   )   $
??Lato)?5c   )   $??14(?5d   )   
?????????5b   )   ?? *Name+5e   )   5f   '   5g   #   5h      5j      5k      5l      5m      5n      5o      