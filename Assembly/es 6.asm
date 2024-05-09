;Manzi Giuliano 3i
;parte a : scrivere un programma in assembly che, date due variabili x e y,
;inserisca in una variabile 'confronto' 1 al se x>y, inserisca 0 se x=y, 2 se x<y

name "Esercizio 6"

.model small

.data
x DW 5
y DW 5
confronto DW 1
.code
    .startup
     mov bx, x
     mov cx, y
     
     cmp bx, cx
     JC xpiupiccolo
     JMP xpiugrande
     
     xpiupiccolo:
     mov confronto, 2
     JMP fine
     
     xpiugrande:
     cmp bx, cx
     jz uguali
     jmp fine
     
     uguali:
     mov confronto, 0
     
     fine:
    .exit
end