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
                //obtoken();
                CUERPO();
                if(token == llaveac){
                    printf("\nPROGRAMA SINTACTICAMENTE CORRECTO \n\n\n");
                    exit(1);
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
obtoken();    
if(token == publictok){
    obtoken();
    if(token == inttok){
        obtoken();
        if(token == ident){
            obtoken();
            if(token == parena){
                obtoken();
               // DEC_VAR();
                if(token == parenc){
                    obtoken();
                    if(token == llavea){
                        obtoken();
                        INSTRUCCION();
                        if(token == llaveac){
                            obtoken();
                           // exit(1);
                        }else error(4);
                    }else error(4);
                }else error(5);
            }else error(5);
        }else error(2);
    }
}        
}

void DEC_VAR(){
    
   /* if(token == nulo || token == parenc)
        exit(1);
   */ 
    if(token == ident || token == inttok || token == floattok || token == stringtok || token == booltok || token == chartok){
        obtoken();
        if(token == ident){
            obtoken();
            while(token == coma){
                obtoken();
                DEC_VAR();
            }
        }
    }
}

void INSTRUCCION(){
   
   // obtoken();
    if(token == nulo){
        exit(0);
    }
        IF();
        WHILE();
        FOR();
        SWITCH();
        PRINT();
    
   // EXPRESION();
    
    printf("hola prueb\n");
    
    /* if(token == nulo || token == llaveac)
        
        exit(0);
*/}


void TIPO(){
   // obtoken();
    
    if(token == ident){
        obtoken();
    }
    if(token == inttok){
        obtoken();
    }
    if(token == floattok){
        obtoken();
    }
    if(token == stringtok){
        obtoken();
    }
    if(token == booltok){
        obtoken();
    }
    if(token == chartok){
        obtoken();
    }  
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
                    DEC_VAR();
                    if(token == parenc){
                        obtoken();
                        if(token == llavea){
                            obtoken();
                            INSTRUCCION();
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
          //  CONDICION();
            if(token == parenc){
                obtoken();
                if(token == llavea){
                    obtoken();
                    INSTRUCCION();
                    while(token != llaveac){
                        obtoken();
                        INSTRUCCION();
                    }
                   /* 
                    if(token != nulo){                 //no seguro
                        obtoken();
                        //INSTRUCCION(); //mandar a llamar mas IF
                    }*/
                    
                    obtoken();
                        if(token == elsetok){
                            ELSE();
                        }else error(10);
                    
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
    

void SWITCH(){    
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
    if(token == ident){
        obtoken();
        if(token == igl){
            obtoken();
            EXPRESION();
        }else error(3);//no se encontro un signo =
    }else error(2);//no se encontro un identificador    
}

void PARAMETROS(){
    if(token == nulo){
        exit(0);
    }
    else{
        if(token == ident){
            obtoken();
    }
    else{
        if(token == ident){
            obtoken();
            while(token == coma){
                PARAMETROS();
            }
            if(token == ident){
                obtoken();
            }
            else error(2);
        }else error(2);//no se encontro un ident
        
        }
    }
}

void OBJETO(){               //REVISAR BIEN
    if(token == ident){
        obtoken();
        if(token == ident){
            obtoken();
            if(token == igl){
                if(token == newtok){
                    obtoken();
                    if(token == ident){
                        obtoken();
                        
                        while(token != parenc){
                            
                        }    
                        
                    }
                }else error(7);
            }else error(3);
        }else error(2);
    }else error(8);
}

void CONDICION(){
    EXPRESION();
    obtoken();
    COMPARACION();
    obtoken();
    EXPRESION();
    obtoken();
}


void COMPARACION(){
   // obtoken();
    if(token == mai)
        obtoken();
   
    if(token == mei)
        obtoken();
    
    if(token == myr)
        obtoken();
    
    if(token == mnr)
        obtoken();
    
    if(token == dist)
        obtoken();
    
    if(token == comp)
        obtoken();
      
}

void EXPRESION(){
    EXPNUMERICA();
}

void EXPNUMERICA(){
    obtoken();
    EXPARITMETICA();
    obtoken();
    COMPARACION();
    
 //   TERMINO();
    
}

void EXPARITMETICA(){
    
    
}

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

void PRINT(){
    if(token == printtok){
        obtoken();
        if(token == parena){
            obtoken();
            FORMATOW();
            if(token == parenc){
                obtoken();
                if(token == puntoycoma){
                    obtoken();
                }
            }
        }
    }
}

