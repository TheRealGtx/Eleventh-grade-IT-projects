;Manzi Giuliano 3i, 21/02/2022
;Team colori. Dato un numero in base al
;suo valore assegna un team
name "Es 1 verifica"

.model small

.stack

.data
    x DB 20
    TEAM_GIALLO DB 'Team giallo$'
    TEAM_VERDE DB 'Team verde$'
    TEAM_ROSSO DB 'Team rosso$'
    TEAM_BLU DB 'Team blu$'
.code
    .startup
    ;segmento dati
    MOV AX, @DATA
    MOV DS, AX
        
    ;Compara con x<=5
    MOV AL, 5   
    CMP x, AL
    JBE GIALLO
    JMP NEXT1
    
    ;Output giallo
    GIALLO:
    LEA DX, TEAM_GIALLO
    MOV AH, 9
    INT 21H
    
    ;Spaziatura per le prossime scritte
    MOV AH, 2
    MOV DL, 0DH
    INT 21H
    MOV DL, 0AH
    INT 21H
    
    ;------------
    JMP FINE
    
    ;Compara con 5<x<=10
    NEXT1:
    MOV AL, 10
    CMP x, AL
    JBE VERDE
    JMP NEXT2
    
    ;Output verde
    VERDE:
    LEA DX, TEAM_VERDE
    MOV AH, 9
    INT 21H
    
    ;Spaziatura per le prossime scritte
    MOV AH, 2
    MOV DL, 0DH
    INT 21H
    MOV DL, 0AH
    INT 21H
    
    ;------------
    JMP FINE
    
    ;Compara con 11<x<15
    NEXT2:
    MOV AL, 15
    CMP x, AL
    JC ROSSO
    JMP NEXT3
    
    ;Output rosso
    ROSSO:
    LEA DX, TEAM_ROSSO
    MOV AH, 9
    INT 21H
    
    ;Spaziatura per le prossime scritte
    MOV AH, 2
    MOV DL, 0DH
    INT 21H
    MOV DL, 0AH
    INT 21H
    
    ;------------
    JMP FINE
            
    ;Compara con x>=15
    NEXT3:
    MOV AL, 15
    CMP x, AL
    JNC BLU
    JMP FINE
    
    ;Output blu
    BLU:
    LEA DX, TEAM_BLU
    MOV AH, 9
    INT 21H  
    
    FINE:
    MOV AH, 4CH
    INT 21H
    .exit
end 