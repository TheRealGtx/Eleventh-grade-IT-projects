;Manzi Giuliano 3i
;scrivere un programma in asembly che date due variabili x e y inserisca 1 nel semi-registro al se x>=y, x<y = 2

name "confronto x e y"

.model small

.data
x DW 5
y DW 4
risultato DB 1  

.code
    .startup
    mov bx, x
    mov cx, y
        
    cmp bx, cx
    JC SOMMA
    JMP FINE
    
    SOMMA:  
    mov risultato, 2
    
    FINE:

    .exit
end