:: Permette di selezionare una squadra
@echo off

set stringa=

set /p stringa=Inserisci un numero: 

set /A numeroSquadra=%stringa%

if %numeroSquadra% EQU 1 (
echo squadra gialla
) else if %numeroSquadra%% EQU 2 (
	echo squadra bianca
		) else if %numeroSquadra%% EQU 3 (
			echo squadra verde
			) else if %numeroSquadra%% EQU 4 (
				echo squadra rossa
				) else if %numeroSquadra%% EQU 5 (
					echo squadra blu
					) else echo input errato