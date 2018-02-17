/*

*/



#include <stdio.h>
#include <stdlib.h>
#include "pl0.h"
#include "auxiliares.h"
#include "lexico.h"
#include "scanner.h"
#include "parser.h"
#include "lista_errores.h"
#include "tds.h"


int error(int no);
bool bandera_err = true;
//char *ERRORES[];

int error(int no){
 //printf("error: %d: %s", no, mensaje_de_error[no]);    
    //fclose(fp);//cerrar el programa fuente
    printf ("%s~%d\n", mensaje_de_error[no], num_linea+1);
    bandera_err = false;
    obtoken();
    //exit(1); //estoy en modo de panico...cualquier error es fatal
}



void programa(){
//    int temp; // Para guardar el valor de it (se?alador de la TDS) temporalmente.
    obtoken();
    if(token == llavea) obtoken(); else error(4);
    if(token == publictok){
        CLAS_DEF();
        while(token != llaveac){
            CLAS_DEF();
        }
        
    }
    else if(token == llaveac) ; else error(4);
    if(bandera_err) printf("OK\n"); else;
    
   /* 
    for(int i=1; i< it ; i++){
        printf("%d", tabla[i].tipo);
        printf("%s\n", tabla[i]);
    }
    
     for(int i=0; i<= it ; i++){
        for(int j=0; j<= it; j++){
            if(j == i);
            else{
                if((tabla[i].nombre == tabla[j].nombre) && (tabla[i].tipo == tabla[j].tipo)){
                    printf("Variable ya declarada");
                }
            }
        }
    }
    */
    //printf("%s\n", tabla[1]);
    //int contador = 1;
    
   // printf("%i",contador);
    /*
     * 
     *
    for(int i=0; i<= sizeof(tabla) ; i++){
        printf("%s",tabla[i].nombre);
        //printf("%s",tabla[i].tipo);
    }
    
    
   
     * */
}

void CLAS_DEF(){
    if(token == publictok) obtoken(); else error(17); 
    if(token == classtok){
        obtoken();
        poner(CLASE);
    }  else error(8);
        if(token == ident) obtoken(); else error(2);
          //  poner(CLASE);obtoken(); else error(2);
            if(token == llavea) obtoken(); else error(4);
                CUERPO();
                if(token == llaveac ) obtoken(); else error(4);
                    //exit(1);
                 //no se enc endtoken
}
void TIPO_ACCESO(){
    if(token == publictok){
        obtoken();
    }else error(1); 
}


void DEC_METODO_MAIN(){
    if(token == ident || token == inttok || token == stringtok || token == floattok || token == chartok || token == voidtok) obtoken(); else error(37); //cambar a void
        if(token == ident){
            poner(METODO);
            obtoken(); 
        } else error(2);
            if(token == parena) obtoken(); else error(5);
                while(token != parenc){
                    TIPO(); 
                    if(token == ident) obtoken(); else error(2);
                    while(token == coma){
                        obtoken();
                        TIPO();
                        if(token == ident) obtoken(); else error(2);
                    }
                }
                if(token == parenc) obtoken(); else error(5);
                    if(token == llavea) obtoken(); else error(4);
                            INSTRUCCION();
                            while(token != llaveac){
                                obtoken();
                                INSTRUCCION();
                            }
                            if(token == llaveac)  obtoken(); else error(4);
}


void CUERPO(){
    if(token == ident || token == inttok || token == stringtok || token == floattok || token == chartok){
         TIPO();
        if(token == ident)obtoken(); else error(5);
        if(token == puntoycoma) obtoken(); else error(1);
         while(token == ident || token == inttok || token == stringtok || token == floattok || token == chartok ){
             TIPO();
            if(token == ident)obtoken(); else error(5);
            if(token == puntoycoma) obtoken(); else error(1);
         }
         if(token == publictok){
             obtoken();
             if(token == ident || token == inttok || token == stringtok || token == floattok || token == chartok || token == voidtok){            //si el siguiente es void es MAIN
                DEC_METODO_MAIN(); 
                 while(token == publictok){
                    obtoken();
                    if(token == ident || token == inttok || token == stringtok || token == floattok || token == chartok || token == voidtok) DEC_METODO_MAIN(); else CONSTRUCTOR();
                }
             }
             else if(token == constructortok){
             CONSTRUCTOR();
            }
         }
         else ;
    }
    else if(token == publictok){
        obtoken();
        if(token == ident || token == inttok || token == stringtok || token == floattok || token == chartok || token == voidtok){            //si el siguiente es void es MAIN
                DEC_METODO_MAIN(); 
                 while(token == publictok){
                    obtoken();
                    if(token == ident || token == inttok || token == stringtok || token == floattok || token == chartok || token == voidtok) DEC_METODO_MAIN(); else CONSTRUCTOR();
                }
             }
        else if(token == constructortok){
        CONSTRUCTOR();
       }       
    }
    else ;//si no hay nada, vale pija esta bueno igual porque puede ir vacio
}        

/*
void DEC_VAR_METODOS(){
    //if(token == ident || token == inttok || token == floattok || token == stringtok || token == booltok || token == chartok){
    TIPO();
    if(token == ident){
        obtoken();
        if(token == coma){
            obtoken();
            DEC_VAR_METODOS();
        }
    }else error(2);
    
}
  */  
void DEC_ATRIBUTO(){
    //if(token == ident || token == inttok || token == floattok || token == stringtok || token == booltok || token == chartok){
    TIPO();
    if(token == ident){
        //poner(VARIABLE);
        obtoken(); 
    }else error(2);
}

void INSTRUCCION(){
 
    if(token == iftok)
        IF();
    else{
        if(token == whiletok)
            WHILE();
        else
            if(token == fortok)
                FOR();
            else
                if(token == switchtok)
                    SWITCH();
                else
                    if(token == printtok)
                        PRINT();
                        else
                            if(token == asignacion)
                                ASIGNACION();
                             else
                                if(token == returntok){
                                    RETORNAR();
                                }
                            else ;
                                    //else error(36);

                            //else
                          //  if(token == objetotok) 
    }  
  //  printf("hola prueb\n");    
}

void TIPO(){
   // obtoken(); 
    if(token == ident){
        obtoken();
        poner(VARIABLE);
    }else
        if(token == inttok){
            obtoken();
            poner(VARIABLE);
        }
        else
            if(token == floattok){
            obtoken();
            poner(VARIABLE);
        }
            else
                if(token == stringtok){
            obtoken();
            poner(VARIABLE);
        }
                else
                    if(token == booltok){
            obtoken();
            poner(VARIABLE);
        }
                    else
                        if(token == chartok){
            obtoken();
            poner(VARIABLE);
        }
                        else error(38);
}

void RETORNAR(){
    if(token == returntok) obtoken(); else error(35);
        EXPRESION();
            if(token == puntoycoma) obtoken(); else error(1);
}

void CONSTRUCTOR(){
        if(token == constructortok) obtoken(); else error(17);//es el de constructortok
            if(token == ident){
                poner(CONSTRUCTO);
                obtoken();
            }  else error(2);
                if(token == parena) obtoken(); else error(5);
                    while(token != parenc){
                        DEC_ATRIBUTO();
                        while(token==coma){
                            obtoken();
                            DEC_ATRIBUTO();
                        }
                    }
                    if(token == parenc) obtoken(); else error(5);
                        if(token == llavea) obtoken(); else error(6);
                            INSTRUCCION();
                            while(token != llaveac){
                                obtoken();
                                INSTRUCCION();
                            }
                            if(token == llaveac) obtoken(); else error(6);
                        
}

void IF(){
    if(token == iftok) obtoken(); else error(9);
        if(token == parena)obtoken();else error(5);
            CONDICION();
            if(token == parenc) obtoken(); else error(5);
                if(token == llavea) obtoken(); else error(4);
                    INSTRUCCION();
                    while(token != llaveac)
                    {
                        obtoken();
                        INSTRUCCION();
                    }
                    if(token == llaveac) obtoken(); else error(5);                                        
                        if(token == elsetok) ELSE();
}

void ELSE(){
    if(token == elsetok) obtoken(); else error(10);
        if(token == llavea) obtoken(); else error(5);
            INSTRUCCION();
            while(token != llaveac){
                obtoken();
                INSTRUCCION();
            }if(token == llaveac) obtoken(); else error(5);       //falto llave
}

void WHILE(){
    if(token == whiletok) obtoken(); else error(11);
        if(token == parena) obtoken(); else error(5);
            CONDICION();
            if(token == parenc) obtoken(); else error(5);
                if(token == llavea) obtoken(); else error(4);
                    INSTRUCCION();
                    while(token != llaveac){
                        obtoken();
                        INSTRUCCION();
                    }
                    if(token == llaveac){ obtoken();} else error(4);
                           //falto llave
}

void FOR(){    
    if(token == fortok) obtoken(); else error(22); //no ae encontro un identificador 
        if(token == parena) obtoken() ;else error(22);
            if(token == ident) obtoken(); else error(5); //no se encontro un igual 
                if(token == igl)obtoken(); else error(2); //no se encontro un numero
                    EXPRESION();
                        if(token == puntoycoma) obtoken(); else error(3); //no se encontro un punto y coma
                            if(token == ident) obtoken(); else error(1); //no se encontro un identificador
                                if(token == mei | token == mai | token == myr | token == mnr){ obtoken(); EXPRESION(); }else error(1); //no se encontro un < o >
                                    if(token == puntoycoma) obtoken(); else error(1); // no se encontro punto y coma
                                            if(token == ident) obtoken(); else error(2);
                                                if(token == mas | token == menos) obtoken(); else error(19);
                                                    EXPRESION();
                                                    if(token == parenc) obtoken(); else error(5);
                                                        if(token == llavea) obtoken(); else error(4);
                                                            INSTRUCCION();
                                                            while(token != llaveac){
                                                                obtoken();
                                                                INSTRUCCION();
                                                            }
                                                            if(token == llaveac) obtoken(); else error(4);
                                                                                 
}
    

void SWITCH(){    //pendiente
    if(token == switchtok){
        obtoken();
        if(token == parena){
            obtoken();
            EXPRESION();
                if(token == parenc){
                    obtoken();
                    if(token == llavea){
                        obtoken();
                        
                        while(token != defaulttok){
                            if(token == casetok){
                                obtoken();
                                EXPRESION();
                                if(token == punto){ //tiene que ser : 2puntos
                                    obtoken(); //ver si llevara :
                                    INSTRUCCION();
                                    while(token != breaktok){
                                        obtoken();
                                        INSTRUCCION();
                                    }
                                    if(token == breaktok){
                                        obtoken();
                                        if(token == puntoycoma){
                                           
                                            obtoken();                      
                                        }else error(1);//no se encontro ;
                                    }else error(25);//no se encontro break;
                                }else error(20);//no se encontraron un numero
                            }else error(26);//no se encontro case
                        }
                    
                        if(token == defaulttok){
                            obtoken();
                            INSTRUCCION();
                            while(token != breaktok){
                                obtoken();
                                INSTRUCCION();
                            }
                            if(token == breaktok){
                                obtoken();
                                if(token == puntoycoma){
                                    obtoken();                      
                                    if(token == llaveac){
                                        
                                        obtoken();
                                    }else error(4);//no se encontro llave cerrada;
                                }else error(1);//no se encontro ;
                            }else error(25);//no se encontro break;
                                                  
                        }else error(27);//no se encontro llamarinstruccion();
                    }else error(4);//no se encontro llave abierta
                }else error(5);//no se encontro un parentesis cerrado
             
        }else error(5); //no se encontro un numero
    }else error(28);//no encontro un parentesis abierto 
} 


void ASIGNACION(){
    
    if(token == asignacion) obtoken(); else error(6);
        if(token == ident) obtoken(); else error(2);//no se encontro un identificador  
            obtoken();
            if(token == igl) obtoken(); else error(3);
                EXPRESION();        
}

void OBJETO(){
//    obtoken();
    if(token == ident) obtoken(); else error(2);
        if(token == ident) obtoken(); else error(2);
            if(token == igl) obtoken(); else error(3);
                if(token == newtok) obtoken(); else error(7);
                    if(token == ident) obtoken(); else error(2);
                        if(token == parena) obtoken(); else error(5);
                            if(token == parenc) obtoken(); else error(5);    
                                if(token == puntoycoma) obtoken(); else error(1);    
                            
}

void CONDICION(){
    
    EXPRESION();
    COMPARACION();
    EXPRESION();
    
}


void COMPARACION(){
   // obtoken();
    
/*    if(token == mai || token == mei || token == myr || token == mnr || token == dist || token == comp) obtoken;
    else error(21);
*/    
    if(token == mai){
     //   printf(">= \n");
        obtoken();
    }else{
        if(token == mei){
         //   printf("<= \n");
            obtoken();
        }else
            if(token == myr)
                obtoken();
            else
                if(token == mnr)
                obtoken();
                else
                    if(token == dist)
                        obtoken();
                    else
                        if(token == comp)
                            obtoken();
                        else 
                            if(token == nulo)
                                obtoken();
                            else error(21);
    } 
}

void EXPRESION(){
     
    if (token==mas || token==menos) {
        obtoken(); // Siempre se pone en el siguiente token (un token adelantado) para analizarlo al salir de aquí. Al entrar a la siguiente función solo se pregunta, no se lee uno.
        TERMINO();
    }
    else{    
        TERMINO();
        while(token == mas || token == menos){
            obtoken();
            TERMINO();
        }
    }

}

void TERMINO(){
    
    if(token == por || token == barra){
        obtoken();
        FACTOR();
    }
    else{
        FACTOR();   

        while(token == por || token == barra){
            obtoken();
            FACTOR();
        }
    }
}

void FACTOR(){
    if(token == ident){
        obtoken();
    }
    else{
        if(token == numero){
            obtoken();
        }
        else{
            if(token == parena){
                obtoken();
                EXPRESION();
                if(token == parenc){
                    obtoken();
                }else error(5); 
            }else error(5);
        }   
   }    
}
/*
void FORMATOW(){
    if(token == comillad){
        obtoken();
        if(token == cadenatok){
            obtoken();
            if(token == comillad){
                obtoken();
            }else error(29);
        }else error(31);
    }else error(29);
}
*/
void PRINT(){
    if(token == printtok) obtoken(); else error(35);
        if(token == parena) obtoken(); else error(5); 
            //if(token == comillad){
            //    obtoken();
                if(token == comillad || token == cadenatok) obtoken(); else error(31);
                    //if(token == comillad){
                    //    obtoken();
                        if(token == parenc) obtoken(); else error(5);
                            if(token == puntoycoma) obtoken(); else error(1);
                   // }else error(34);
           // }else error(34);
}
