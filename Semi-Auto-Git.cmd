pushd %~0\..
set /p comment="Commit neve > "

git add .
if not %errorlevel%==0 (goto:error)

git commit -m "%date% - %comment%"
if not %errorlevel%==0 (goto:error)

git push
timeout 5 /nobreak
exit /b

:error
echo.
echo.
timeout 5 /nobreak > nul
pause
exit /b