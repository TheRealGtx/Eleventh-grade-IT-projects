:: Conta quanti file di testo sono presenti in una directory
@echo off
set /a N=0
for /r %%c in (/*.txt*) do ( set /a N=N+1 )
echo %N% files di testo
start notepad "contafileditesto.txt"