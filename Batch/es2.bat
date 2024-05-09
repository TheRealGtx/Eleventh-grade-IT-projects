:: Controlla se l'input è un numero e se è positivo o negativo
@echo off
::dichiarazione di variabile
set STRINGA=
::input del valore stringa
set /P STRINGA=Digita un numero: 
::controllo sui numeri
::con la clausola /A assegno il contenuto ad una variabile numerica = se presenta un numero viene salvato in NUMERO
SET /A NUMERO=%STRINGA%
echo ----------------
echo %STRINGA%
echo ----------------
echo %NUMERO%
echo ----------------
::se il contenuto del numero equivale a quello della stringa:
if %NUMERO% EQU %STRINGA% (
	::se minore di 0 - lesser
	if %NUMERO% LSS 0 (
		ECHO %NUMERO% numero negativo
	) else (
		::se maggiore di zero -greater
		if %NUMERO% GTR 0 (
			ECHO %NUMERO% VALORE POSITIVO
		) else (
				ECHO %NUMERO% ZERO
		)
	)
) else (
	ECHO %STRINGA% NON E' UN NUMERO
)