@echo off
"%programfiles(x86)%\IIS Express\iisexpress.exe"  /config:".vs\config\applicationhost.config" /site:"GanSoft.Pro.Help" /apppool:"Clr4IntegratedAppPool"