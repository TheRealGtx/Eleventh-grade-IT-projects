;Manzi Giuliano 3i
;W =X^2+4X con x=2
;Operazioni in assembly

name "Esercizio 5"

.model small

.data
x DW 2
w DW ?

.code
    .startup
    mov ax, x   ;ax=2
    push ax     ;x nello stack
    mul ax      ;ax=x*x
    
    pop bx      ;x in bx
    shl bx, 2   ;moltiplica per 4 (2^2)
                
    add ax, bx  ;somma x^2 e 4x
    
    mov w, ax
     
    
    .exit
end