@echo off

call 清理.bat

echo 正在压缩。。。
set path=c:\program files\winrar
rar a -r SocanCode.rar %target% 说明.txt src\Codes

echo 完成