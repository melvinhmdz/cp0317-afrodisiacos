#include <stdio.h>
#include <stdlib.h>
#include "pl0.h"
#include "auxiliares.h"
#include "lexico.h"
#include "scanner.h"
#include "parser.h"
#include "lista_errores.h"


int error(int no);


int error(int no){
 //printf("error: %d: %s", no, mensaje_de_error[no]);    
    fclose(fp);//cerrar el programa fuente
    printf ("\nError %d: %s\n",no, mensaje_de_error[no]);
    exit(1); //estoy en modo de p�nico...cualquier error es fatal
}

void programa(){
//    int temp; // Para guardar el valor de it (se?alador de la TDS) temporalmente.
    TIPO_ACCESO();
    if(token == classtok){
        obtoken();
        if(token == ident){
            obtoken();
            if(token == llavea){
                obtoken();
                CUERPO();
                if(token == llaveac){
                    printf("\nPROGRAMA SINTACTICAMENTE CORRECTO ;) \n\n\n");
                    //exit(1);
                }
                else error(4);
            }else error(4);
        }else error(2);
    }else error(8); //no se enc endtoken
}

void TIPO_ACCESO(){
    obtoken();
    if(token == publictok){
        obtoken();
    }else exit(1); 
}

void CUERPO(){
 //   TIPO_ACCESO();
//obtoken();    
if(token == publictok){
    obtoken();
    if(token == inttok){
        obtoken();
        if(token == ident){
            obtoken();
            if(token == parena){
                obtoken();   
                if(token == parenc){
                    obtoken();
                    if(token == llavea){
                        obtoken();
                        //DEC_ATRIBUTO();
                        INSTRUCCION();
                        while(token != llaveac){
                            //obtoken();
                            INSTRUCCION();
                        }
                        if(token == llaveac){
                            printf("final } de main() \n");
                            obtoken();
                        }else error(4);
                    }else error(4);
                }else error(4);
            }else error(5);
        }else error(5);
    }else error(2);
}
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
        obtoken(); 
    }else error(2);
}

void INSTRUCCION(){
    
    if(token == iftok){
        IF();
    }
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
                        if(token == nulo)
                            nulo;
                        else
                            if(token == asignacion)
                                ASIGNACION();
                        else
                            if(token == constructortok)
                                CONSTRUCTOR();
                                else error(36);
                        //else
                          //  if(token == objetotok) 
    }  
  //  printf("hola prueb\n");    
}

void TIPO(){
   // obtoken(); 
    if(token == ident){
        obtoken();
    }else
        if(token == inttok)
            obtoken();
        else
            if(token == floattok)
                obtoken();
            else
                if(token == stringtok)
                    obtoken();
                else
                    if(token == booltok)
                        obtoken();
                    else
                        if(token == chartok)
                            obtoken();      
}

void CONSTRUCTOR(){
    obtoken();
    if(token == publictok){
        obtoken();
        if(token == publictok){//aqui va constructortok
            obtoken();
            if(token == ident){
                obtoken();
                if(token == parena){
                    obtoken();
                    while(token != parenc){
                        DEC_ATRIBUTO();
                        while(token==coma){
                            obtoken();
                            DEC_ATRIBUTO();
                        }
                    }
                    if(token == parenc){
                        obtoken();
                        if(token == llavea){
                            obtoken();
                            INSTRUCCION();
                            while(token != llaveac){
                                obtoken();
                                INSTRUCCION();
                            }
                            if(token == llaveac){
                                obtoken();
                            }else error(6);
                        }else error(6);
                    }else error(5);
                }else error(5);
            }else error(2);
        }else error(17);//es el de constructor
    }else error(17);
}

void IF(){
    if(token == iftok){
        obtoken();
        if(token == parena){
            obtoken();
            CONDICION();
            if(token == parenc){
                obtoken();
                if(token == llavea){
                    obtoken();
                    INSTRUCCION();
                    while(token != llaveac){
                        obtoken();
                        INSTRUCCION();
                    }
                    if(token == llaveac){
                        printf("final }if \n");
                        obtoken();
                        if(token == elsetok){
                            ELSE();
                        }
                                                
                    }else error(4);                                        
                }else error(4);
            }else error(5);
        }else error(5);
    }else error(9);
}

void ELSE(){
    if(token == elsetok){
        obtoken();
        if(token == llavea){
            obtoken();
            INSTRUCCION();
            while(token != llaveac){
                obtoken();
                INSTRUCCION();
            }if(token == llaveac){
                printf("final }else \n");
                obtoken();
            }else error(5);       //falto llave
        }else error(5);
    }else error(10);
}

void WHILE(){
    if(token == whiletok){
        obtoken();
        if(token == parena){
            obtoken();
            CONDICION();
            if(token == parenc){
                obtoken();
                if(token == llavea){
                    obtoken();
                    INSTRUCCION();
                    while(token != llaveac){
                        obtoken();
                        INSTRUCCION();
                    }if(token == llaveac){
                        printf("final } while()\n");
                        obtoken();
                    }else error(4);       //falto llave
                }else error(4);
            }else error(5);
        }else error(5);
    }else error(11);
}

void FOR(){    
    if(token == fortok){
        obtoken();
        if(token == parena){
            obtoken();
            if(token == ident){
                obtoken();
                if(token == igl){
                    obtoken();
                    EXPRESION();
                    
                        if(token == puntoycoma){
                            obtoken();
                            if(token == ident){
                                obtoken();
                                if(token == mei | token == mai | token == myr | token == mnr){
                                    obtoken();
                                    EXPRESION();
                                    if(token == puntoycoma){
                                        obtoken();
                                            if(token == ident){
                                                obtoken();
                                                if(token == mas | token == menos){
                                                   obtoken();
                                                   EXPRESION();
                                                    if(token == parenc){
                                                        obtoken();
                                                        if(token == llavea){
                                                            obtoken();
                                                            INSTRUCCION();
                                                            while(token != llaveac){
                                                                obtoken();
                                                                INSTRUCCION();
                                                            }
                                                            if(token == llaveac){
                                                                obtoken();
                                                            }else error(4); //no se encontro el cierre de llaves
                                                        }else error(4); //no se encontro llave abierta
                                                    }else error(5); //no se encontro parentesis cerrado
                                                }else error(19); //no se encontro step aumento o disminucion
                                            }else error(2); //no se encontro un identificador
                                        }else error(1); // no se encontro punto y coma
                                    }else error(21); //no se encontro un numero
                                }else error(1); //no se encontro un < o >
                            }else error(1); //no se encontro un identificador
                        }else error(3); //no se encontro un punto y coma
                    }else error(2); //no se encontro un numero
                }else error(5); //no se encontro un igual
            }else error(22); //no ae encontro un identificador 
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
                                            if(token == llaveac){
                                                obtoken();
                                            }else error(4);//no se encontro llave cerrada;
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
    
    if(token == asignacion){
        obtoken();
        if(token == ident){
            obtoken();
            if(token == igl){
                obtoken();
                EXPRESION();
            }else error(3);//no se encontro un signo =
        }else error(2);//no se encontro un identificador    
    }
}

void OBJETO(){
//    obtoken();
    if(token == ident){
        obtoken();
        if(token == ident){
            obtoken();
            if(token == igl){
                obtoken();
                if(token == newtok){
                    obtoken();
                    if(token == ident){
                        obtoken();
                        if(token == parena){
                            obtoken();
                            if(token == parenc){
                                obtoken();
                                if(token == puntoycoma){
                                    printf("final del ; del OBJETO\n");
                                    obtoken();
                                    
                                }else error(1);    
                            }else error(5);    
                            
                            /*while(token != parenc){
                                
                            }*/

                        }else error(5);
                    }else error(2);
                }else error(7);
            }else error(3);
        }else error(2);
    }else error(2);
}

void CONDICION(){
    
    EXPRESION();
    COMPARACION();
    EXPRESION();
    
}


void COMPARACION(){
   // obtoken();
    
    if(token == mai){
        printf(">= \n");
        obtoken();
    }else{
        if(token == mei){
            printf("<= \n");
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
                        else error(32);
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
            printf("+ o - \n");
            obtoken();
            TERMINO();
        }
    }

}

void TERMINO(){
    
    if(token == por || token == barra){
        printf("* o / \n");
        obtoken();
        FACTOR();
    }
    else{
        FACTOR();   

        while(token == por || token == barra){
            printf("* o / \n");
            obtoken();
            FACTOR();
        }
    }
}

void FACTOR(){
    if(token == ident){
        printf("ident \n");
        obtoken();
    }
    else{
        if(token == numero){
            printf("numero\n");
            obtoken();
        }
        else{
            if(token == parena){
                printf("( \n");        
                obtoken();
                EXPRESION();
                if(token == parenc){
                    printf(") \n");
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
    if(token == printtok){
        obtoken();
        if(token == parena){
            obtoken();
            //if(token == comillad){
            //    obtoken();
                if(token == comillad || token == cadenatok){
                    obtoken();
                    //if(token == comillad){
                    //    obtoken();
                        if(token == parenc){
                            obtoken();
                            if(token == puntoycoma){
                                printf("final de ; print()\n");
                                obtoken();
                            }else error(1);
                        }else error(5);
                   // }else error(34);
                }else error(31);
           // }else error(34);
        }else error(5);
    }else error(35);
}

