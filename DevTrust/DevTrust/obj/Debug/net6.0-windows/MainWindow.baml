   M S B A M L   `   `   `  ????C  ?DevTrust, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DevTrustDevTrust  5   	   9!clr-namespace:DevTrust.ViewModelsDevTrust.ViewModels  5   	       DevTrust.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:DevTrust     5   	   0vm!clr-namespace:DevTrust.ViewModels     5   	   $??20(?5        ? WindowStartupLocation$  CenterScreen=?6)    ? Title$ DevTrust??5	   	   $	??450??6   $	??800??6'    ? DataContext 5
      (  "DevTrust.ViewModels.ShellViewModel  5   
   .??5      ?  ? RowDefinitions 5   
   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   ?? 5      $
??auto ?6   $??0??6*   ?? 5      $
??auto ?6   $??0??6*   ?? 5      .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid??5         AlternatingRowBackground
 ?????   CanUserAddRows$ false??5      $??0,0,0,0q?5      $??5??5      ???	#FFEFEFEF???	#FF0D74A0???	#FF2A4E71$??Dubai Light)?5      $??Stretch=?5         AutoGenerateColumns$ False??5       ??5   %   ?? *People+   Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn	   Header$	 
First Name??6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 69   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6C   ?? *	FirstName+  5$      $	 	Last Name??6%   $
 * 68    6B   ?? *
LastName+  5%      $
	 Mail??6%   $
 * 63    6=   ?? *Email+  5&      $	 Full Adress??6%   $
 * 6:    6D   ?? *FullAddress+5+      5,      5-      