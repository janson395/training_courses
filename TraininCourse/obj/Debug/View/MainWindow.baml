   M S B A M L   `   `   `  ????H  DTraininCourse, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:TraininCourseTraininCourse  5   	       TraininCourse.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:TraininCourse     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          ? Title$  Курсывест??5	   	   $	??600??5
   	   $
??1000??5   	    ? WindowStyle$
 None=?5   	    ? WindowStartupLocation$ CenterScreen=?5   	    ? 
ResizeMode$ NoResize=?5   	   ???#21273D ? AllowsTransparency . $
??Lato)?5   	   .??5      ?  ? RowDefinitions 5   
   ?? 5      $??30 ?6   ?? 5      $??40 ?6   ?? 5      .+?5   
   ?? ???#21273D6   ?? 5   
   $
??Left=?6   $??Center=?5      $??8 0 0 0q?5      $??20(?5      ?? 5      $??14(?6   ???#cfcfcf.?65   Курсывест6@   5      ?? 5    
   $??Right=?6   $??Center=?5!      $??0 0 5 0q?5"      .+?5#      ?? -   5         ??Name$ BtnClose??5%       &  "MaterialDesignIconForegroundButton#??[  5#       ? ToolTip$) #Закрыть приложение??5$      .??5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=?6*   ???#cfcfcf5(   *   5)      5*      ?? 5+   
   $??1??6   ???#1F2434	 ?? Orientation$	 
Horizontal=?5-      
 ? Cursor$
  ??6.   .+?5.      ?? $
??Left=?5/      $??Center=?50      $??	10 0 10 0q?51      $	 
Horizontal=?52      .+?53      ?? -   5        $ BtnMain??53      
?????? 
?????? .??56   3   Главная6<   ?? 57      -   5        $ BtnMyCourses??57      
?????? 
?????? .??5:   3   Мои курсы6>   ?? 5;      -   5        $ BtnAddCourse??5;      $y?	Collapsed=?5<      
?????? 
?????? .??5?   3   Добавить курс6B   5@      5A      ?? 5C   
   $??1??5D      $??Right=?5E      $??Center=?61   $??0 0 22 0q?5F      .+?5G      ?? -   5        $ BtnOpenProfile??5G      
?????? 
?????? $??36??5K      .??5L      ? .+?5M      ?? $	 
Horizontal=?5N      .+?5P      A? $??26??6"   $??26??6-   ??5Q      ?? 5R   "   -   5        
ImgUserAva?? ?? ImageSource$ /Images/ic_user.png??5R   A   5T      ?? 5U      -   5         ??Name$ 
TbUserName??5X      $??Right=?5V      $??Center=?5W      
???????$??5 0 0 0q?5Z      $??16(?5[      $??UserName??5\      5]      5_      5`      ?? 5c      -	   5         ??Name$ SPLogin??5c      $y?	Collapsed=?6*   .+?5d      ?? -
   5        $ BtnLogin??5d      
?????? 
?????? .??5g   2   Авторизация6?   5h      5j       ? 5l   
   -   5          ?Name$ MainWindowFrame??5m      $??2??5l        ? NavigationUIVisibility$ Hidden=?5n      5o      5p      