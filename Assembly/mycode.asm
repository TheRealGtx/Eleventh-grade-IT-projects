;esercizio che calcola y = 3x - 4
name "Esercizio uno"

.model small  

.data     
  
    Num1 DB 02h
    Num2 DB 04h
    Ris DB 0h
    
.code     
    .startup                        
        MOV AL, Num1         
        add AL, Num1         
        add AL, Num1         
        sub AL, Num2         
        MOV Ris, AL       
               
.exit end