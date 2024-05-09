:: Permette di scegliere una squadra.
@echo off
::menu'
:inizio
echo scegli una squadra:
echo 1-squadra bianca
echo 2-squadra blu
echo 3-squadra rossa
echo 4-squadra gialla
echo 5-squadra verde
echo 6-esci
::input
set /p stInput=Numero: 
set /a numero=%stInput%
::business logic
if %numero% EQU 1 (
	GOTO menu1
) else (
	if %numero% EQU 2 (
		GOTO menu2
	) else (
		if %numero% EQU 3 (
			GOTO menu3
		) else (
			if %numero% EQU 4 (
				GOTO menu4
			) else (
				if %numero% EQU 5 (
					GOTO menu5
				) else (
					if %numero% EQU 6 (
						GOTO fine
					) else (
						echo Input errato
						echo ------------------------------------
						echo .
						GOTO inizio
					)
				)
			)
		)
	)
)
::menu'
:menu1
echo hai scelto la squadra bianca
echo ------------------------------------
echo .
GOTO inizio
:menu2
echo hai scelto la squadra blu
echo ------------------------------------
echo .
GOTO inizio
:menu3
echo hai scelto la squadra rossa
echo ------------------------------------
echo .
GOTO inizio
:menu4
echo hai scelto la squadra gialla
echo ------------------------------------
echo .
GOTO inizio
:menu5
echo hai scelto la squadra verde
echo ------------------------------------
echo .
GOTO inizio
:fine
