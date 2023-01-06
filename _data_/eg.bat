@rem in bat, use utf-9 without bom
@echo this is an example bat's path:
@echo %0
@echo.
@echo bat as a doc:
@echo %~nx0
@echo.
@echo bat's container's shield:
@echo %~dp0
@echo.
@echo bat's address:
@echo %~dpnx0
@echo.
@echo change the path of your bat file in the ".exe.config" file by the side of the ".exe" file;
@echo.
@echo also change the arguments there when needed;
@echo.
@echo now echos the arguments of the bat:
@echo %*
@echo:
@echo the first arg:
@echo %1
@rem 

@pause 

