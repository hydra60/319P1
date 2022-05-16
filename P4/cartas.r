#dataframe para elegir cartas 
mi_df <- data.frame(
    "simbolos" = rep(c("corazon","trebol","diamante","picas"),13),
    "colores" = rep(c(rep("negro",13),rep("rojo",13)),2),
    "numeros"  = rep(rep(c(1,2,3,4,5,6,7,8,9,10,11,12,13),2),2)    
) 
mi_df 

