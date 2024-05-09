;manzi giuliano, 3i, 24-01-2022
;Risoluzione di W=2x+2y-3z   

name "Risoluzione di W=2x+2y-3z"

.model small

.data
    num1 DB 04h ;x = 4
    num2 DB 03h ;y = 3
    num3 DB 02h ;z = 2  
    ris1 DB ?
    ris2 DB ?
    ris3 DB ?  
    ris4 DB ?
       
.code
    .startup
        mov AL, num1
        add AL, num1
        mov ris1, AL
        
        mov AL, num2
        add AL, num2
        mov ris2, AL 
        
        mov AL, num3
        add AL, num3
        add AL, num3
        mov ris3, AL
        
        mov AL, ris1
        add AL, ris2 
        sub AL, ris3 
        mov ris4, AL 
    .exit
    
end
