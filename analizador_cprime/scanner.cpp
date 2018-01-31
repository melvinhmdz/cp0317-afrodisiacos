//el analizador lexicogr�fico de pl0
#include <stdio.h>
#include <ctype.h>
#include <string.h>
#include <stdlib.h>
#include "scanner.h"
#include "pl0.h"
#include "lexico.h"
#include "auxiliares.h"


char linea[MAXLINEA];     //buffer de líneas 
int ll;                   //contador de caracteres
int offset;               //corrimiento en la lectura de los caracteres del programa fuente
int fin_de_archivo;       //bandera de fin de archivo (obtch)   
int ch;                   //último caracter leído
char lex[MAXID+1];        //último lexeme leído ( +1 para colocar "\0")
long int valor ;          //valor numérico de una lexeme correspondiene a un número
bool com=false;
int num_linea;            //Numero de linea
int flag_leido;
char lexid[MAXID + 1];
//variable donde guardara la cadena
bool hayCadena=false;
int obtch(),getline(char s[],int lim); //funciones internas a scanner.cpp
bool ver_comentario(int cC);

// obtoken: obtiene el siguiente token del programa fuente.
void obtoken()
{

 memset(lexid, '\0', MAXID + 1);
 //char lexid[MAXID+1]; //+1 para colocar el marcador "\0". Aquí se guardan los lexemas de los identificadores.
 int i, j;
 int ok = 0;

 // Quitar blancos, caracter de cambio de línea y tabuladores
 while (ch==' ' || ch=='\n' || ch=='\t' || ch=='\r') ch=obtch() ; // Recordar que ch se inicializa con espacio.
if (ch=='|'){
  obtch();
  if(ch=='#'){
       while(ch != '#'){
        ch=obtch() ;
       }
  }
  //printf("comentario | %c | %d,%d \n",ch,num_linea,offset+1);
  offset=ll-1;
  
 }
 
 // Si el lexeme comienza con una letra, es identificador o palabra reservada.
 if (isalpha(ch)) {
    lexid[0]=ch;
    i=1;
    while ( isalpha( (ch=obtch()) ) ||  isdigit(ch)   ) // Se extrae un lexema.
      if (i<MAXID) lexid[i++]=ch;
    lexid[i]='\0';
  
    // ¿Ese lexema es identificador o palabra reservada? Buscar en la tabla de palabras reservadas
	// una búsqueda lineal que tendrá que ser sustituída por otro tipo de búsqueda más efectiva. 
	// En esa nueva búsqueda desaparecerá el "break".
    for (j=0;j<MAXPAL;++j) 
        if (strcmp(lexid,lexpal[j]) == 0) {
	       ok = 1; // Se le asigna 1 si el palabra reservada.
	       break;
        }

    if (ok==1) // Si es palabra reservada, a la variable token se le asigna el token correspondiente.
       token=tokpal[j]; //es palabra reservada. tokpal está en lexico.h y en lexico.cpp, es un arreglo de tokens que se conocen.
    else
       token=ident; // Si no es palabra reservada, es identificador. ident es un token,
                    // es un componente del tipo enumerado que puede tomar la variable token. Está en lexico.h
 
    strcpy(lex,lexid); // El lexema que se acaba de construir se guarda en la variable lex, que es global.


 }
 //si el dato ingresado es una cadena para que reconozca la cadena
 else {
	 if (ch == '"')
	 {
             int i = 1;
             hayCadena = true;
             ch = obtch();
             lexid[0] = ch;
             while (hayCadena)
             {
                     if (ch == '"')
                     {
                             token = cadenatok;
                             lexid[i] = '\0';
                             hayCadena = false;
                     }
                     ch = obtch();
                     if(ch != '"' && ch != ')')
                             lexid[i++] = ch;
             }
	 }
	 else // Si comienza con un dígito debe ser un número.
		 if (isdigit(ch)) 
                 {
			 lexid[0] = ch;
			 i = j = 1;

			 while (isdigit((ch = obtch()))) 
                         {
                             if (i < MAXDIGIT) {
                                     lexid[i++] = ch;
                             }
                             j++;
			 }

			 if (ch == '.') 
                         {
                             lexid[i++] = '.';
                             while (isdigit((ch = obtch()))) 
                             {
                                     if (i < MAXDIGIT) 
                                     {
                                             lexid[i++] = ch;
                                     }
                                j++;
                             }
                             token = floattok; // Si no daba el error, se identifica ese lexema como un número y se le asigna a la variable token el token correspondiente.
                             valor = atol(lexid); // Valor numérico de una lexeme correspondiene a un número. Se convierte a número.
			 }
			 else 
                         {
                             token = numero; // Si no daba el error, se identifica ese lexema como un número y se le asigna a la variable token el token correspondiente.
                             valor = atol(lexid); // Valor numérico de una lexeme correspondiene a un número. Se convierte a número.
			 }

			 lexid[i] = '\0';
			 if (j > MAXDIGIT)
				 error(30); // Este es el único error programado en esta versión. "Este número es demasiado grande".
			 //token = numero; // Si no daba el error, se identifica ese lexema como un número y se le asigna a la variable token el token correspondiente.
			 //valor = atol(lexid); // Valor numérico de una lexeme correspondiene a un número. Se convierte a número.
		 }
		 else //reconocimiento de símbolos especiales, incluyendo pares de simbolos (aplicamos "lookahead symbol technique")
		 {
                     lexid[0] = ch;
			switch(ch)
                        {
                            
                            case '#':
                            //printf("comentario | %c | %d,%d \n",ch,num_linea,offset+1);
                            offset=ll-1;
                            ch = obtch();
                            break;
                            
                            case '<':
                                ch = obtch();
                                if(ch == '=')
                                {
                                    token = mei;
                                    lexid[1] = '=';
                                    lexid[2] = '\0';
                                }else
                                    if(ch == '-')
                                    {
                                        ch = obtch();
                                        if(ch == '>')
                                        {
                                            token = accmetodo;
                                            lexid[1] = '-';
                                            lexid[2] = '>';
                                            lexid[3] = '\0';
                                            ch = obtch();
                                        }
                                    }
                                else
                                    token = mnr;
                                    
                            break;
                            
                            case '>':
                                ch = obtch();
                                if(ch == '=')
                                {
                                    token = mai;
                                    lexid[1] = '=';
                                    lexid[2] = '\0';
                                    ch = obtch();
                                }else
                                    token = myr;
                            break;
                            
                            case '=':
                                ch = obtch();
                                if(ch == '=')
                                {
                                    token = igl;
                                    lexid[1] = '=';
                                    lexid[2] = '\0';
                                    ch = obtch();
                                }else
                                    token = nulo;
                            break;
                            
                            case '!':
                                ch = obtch();
                                if(ch == '=')
                                {
                                    token = dist;
                                    lexid[1] = '=';
                                    lexid[2] = '\0';
                                    ch = obtch();
                                }else
                                    token = nulo;
                            break;
                            
                            
                            default:
                                token = espec[ch]; //hashing directo en la tabla de tokens de símbolos especiales del lenguaje
                                 ch = obtch();
                            break;
                        } 

		 }
 }
}

// obtch: obtiene el siguiente caracter del programa fuente. También
// sabe cundo cerrar el programa: cuando ya no hay más que leer.
int obtch()
{ 

 if (fin_de_archivo==1) {
	fclose(fp);//cerrar el programa fuente
    //printf("\nAnalisis lexicografico finalizado.\n");
    exit(1); //salir...
 }
  
 if (offset==ll-1) {
    ll=getline(linea,MAXLINEA); //trae una línea del programa fuente al buffer de líneas
    if (ll==0) 	   
       fin_de_archivo=1; //se retrasa en un blanco la deteccion de EOF, porque obtoken lleva un caracter adelantado. si no, en 
						 //algunos casos tendríamos problemas, por ejemplo: no se reconoceria el punto final del programa (...end.)

	//printf("\n%s",linea);
    offset=-1;
 }

 ++offset;

 if ( (linea[offset]=='\0') || (fin_de_archivo==1) )   
    return(' '); 
 else return(toupper(linea[offset])); //de esto depende si el lenguaje es sensitivo de mayúsculas o no.
}

//getline: lee la siguiente línea del fuente y regresa su tamaño (incluyendo '\n') o 0 si EOF. (por ejemplo: para VAR regresa 4)
//es probablemente la rutina de más bajo nivel del compilador
//tomada de "El Lenguaje de programación C" - Kernighan & Ritchie - pag 28                        
int getline(char s[],int lim)
{
 int c,i;

 for (i=0;i<lim-1 && (c=getc(fp))!=EOF && c!='\n';++i)
     s[i]=c;

 if (c=='\n') {
    s[i]=c;
    ++i;
 }

 s[i]='\0';
 num_linea++;
 return (i);
}
/*
//funcion para ver si es comentarios
bool ver_comentario(int cC)
{

  if(cC=='#' && !com)
  {
    com=true;
    return true;
  }
  else if(com){
    if(cC != '#' && com)
    {
    return true;
    }
    else
    {
    if(cC == '#' && com)
    {
        com=false;
        return true;
    }
                  
    }
  }
  else
    return false;
}*/