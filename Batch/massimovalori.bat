:: Restituisce il valore più grande tra 10 numeri inseriti.
@echo off
::variabili
set /a max=0
set /a contatore=0

::business logic
:inizio
set /p stInput=Inserisci un valore: 
set /a x=stInput
if %x% GTR %max% (
	set /a max=x
)
set /a contatore+=1
if %contatore% LSS 10 (
	goto inizio
) else (
	goto fine
)

::output
:fine
echo il valore piu' grande inserito e' %max%