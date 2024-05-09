:: L'utente deve cercare di indovinare un numero inserito da un altro utente prima di finire le vite a disposizione.
@echo off
  
 set stInput= 
 set /p numeroDaIndovinare=Numero da indovinare: 
 set contatore=0
 :inizio
 set /p stInput=Prova a indovinare il numero: 
 set /a numeroInserito=%stInput%

 
 if %numeroInserito% LSS %numeroDaIndovinare% (
 GOTO minore
 ) else (
		if %numeroInserito% GTR %numeroDaIndovinare% (
		GOTO maggiore
		) else (
			if %numeroInserito% EQU %numeroDaIndovinare% (
			GOTO uguale
				)
		)
	)

:minore
echo il numero e' troppo picolo!
set /a contatore+=1
if %contatore% EQU 3 (
GOTO fine
) else (
GOTO inizio
)
:maggiore
echo il numero e' troppo grande!
set /a contatore+=1
if %contatore% EQU 3 (
GOTO fine
) else (
GOTO inizio
)
:uguale
echo hai indovinato il numero!
GOTO inizio
:fine
echo hai finito le vite!