@echo off
set path=%path%;%1
cd %homedrive%\%homepath%
%comspec% /K "echo You can start PSPP by entering 'PSPP' or 'PSPP -h' for help.&&echo Type 'exit' to close this window."
set prompt=pspp_$p$g 
