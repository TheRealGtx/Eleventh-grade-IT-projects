:: Confronta due numeri
@echo off
::variabili
set /p n2=Inserisci un numero: 
::input
set /p stringa=Inserisci un altro numero:
echo %stringa%
echo --------
echo %n2%
echo --------
set /a n1=%stringa%
::business logic
if %n1% equ %stringa% (
	if %n1% gtr %n2% (
		echo %n1% e' maggiore di %n2%
	) else (
			if %n2% gtr %n1% (
				echo %n1% e' minore di %n2% 
			) else (
					if %n1% equ %n2% (
						echo %n1% e' uguale a %n2%
					)
			)
	)
) else (
	echo %stringa% non e' un numero
)