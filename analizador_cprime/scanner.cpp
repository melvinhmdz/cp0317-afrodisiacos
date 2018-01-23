//el analizador lexicogr�fico de pl0
#include <stdio.h>
#include <ctype.h>
#include <string.h>
#include <stdlib.h>
#include "scanner.h"
#include "pl0.h"
#include "lexico.h"
#include "auxiliares.h"

char linea[MAXLINEA];     //buffer de l�neas 
int ll;                   //contador de caracteres
int offset;               //corrimiento en la lectura de los caracteres del programa fuente
int fin_de_archivo;       //bandera de fin de archivo (obtch)   
int ch;                   //�ltimo caracter le�do
int num_linea;            //Numero de linea
int flag_leido;
char lexid[MAXID+1];      //+1 para colocar el marcador "\0"
char lex[MAXID+1];        //�ltimo lexeme le�do ( +1 para colocar "\0")
long int valor ;          //valor num�rico de una lexeme correspondiene a un n�mero

int obtch(),getline(char s[],int lim); //funciones internas a scanner.cpp

//obtoken: obtiene el siguiente token del programa fuente                   
void obtoken()
{
  memset(lexid,'\0',MAXID+1);

 int i,j;
 int ok=0;

 //quitar blancos, caracter de cambio de l�nea y tabuladores
 while (ch==' ' || ch=='\n' || ch=='\t') ch=obtch() ;
 if(ch=='#'){
  printf("comentario | %c | %d,%d \n",ch,num_linea,offset+1);
  offset=ll-1;
  obtch();
 }
 if(ch=='|'){
  obtch();
  if(ch=='#'){
       while(ch != '#'){
        ch=obtch() ;
       }
  }
  printf("comentario | %c | %d,%d \n",ch,num_linea,offset+1);
  offset=ll-1;
  
 }

 //si la lexeme comienza con una letra, es identificador o palabra reservada
 if (isalpha(ch)) {
    lexid[0]=ch;
    i=1;
    while ( isalpha( (ch=obtch()) ) ||  isdigit(ch)   ) 
      if (i<MAXID) lexid[i++]=ch;
    lexid[i]='\0';
  
    //�es identificador o palabra reservada?.buscar en la tabla de palabras reservadas
	//una b�squeda lineal que tendr� que ser sustitu�da por otro tipo de b�squeda m�s efectiva. 
	//...en esa nueva b�squeda desaparecer� el "break"
    for (j=0;j<MAXPAL;++j) 
        if (strcmp(lexid,lexpal[j])==0) {
	       ok=1;
	       break;
        }
    //printf("-> %d\n",j);
    if (ok==1) 
       token=tokpal[j]; //es palabra reservada
    else
       token=ident; //es identificador
 
    strcpy(lex,lexid); //copiar en lex
 }
 else //si comienza con un d�gito...
    if (isdigit(ch)) {
       lexid[0]=ch;
       i=j=1;
       while ( isdigit( (ch=obtch()))) {
	         if (i<MAXDIGIT) lexid[i++]=ch;
	         j++;
       }
       lexid[i]='\0';
       if (j>MAXDIGIT)
          error(30); //este n�mero es demasiado grande
       token=numero;
       valor=atol(lexid); //valor num�rico de una lexeme correspondiene a un n�mero	        
    }
    else //reconocimiento de s�mbolos especiales, incluyendo pares de simbolos (aplicamos "lookahead symbol technique")
    {
        lexid[0]=ch;
        switch(ch)
        {
            case '<':
                ch = obtch();
                if(ch == '=')
                {
                    token=mei;
                    ch=obtch();
                }else ch = mnr;
                break;
                
            case '>':
                ch = obtch();
                if(ch == '=')
                {
                    token=mai;
                    ch=obtch();
                }else ch = myr;
                break;
            
            case '=':
                ch = obtch();
                if(ch == '=')
                {
                    token=comp;
                    ch=obtch();
                }else ch = igl;
                break;
            case '!':
                ch = obtch();
                if(ch == '=')
                {
                    token=dist;
                    ch=obtch();
                }else ch = nulo;
                break;
            default:
                token=espec[ch];
                ch= obtch();
                break;
        }
    }
}

//obtch: obtiene el siguiente caracter del programa fuente
int obtch()
{ 

 if (fin_de_archivo==1) {
	fclose(fp);//cerrar el programa fuente
    printf("Analisis lexicografico finalizado.");
    exit(1); //salir...
 }
  
 if (offset==ll-1) {
    ll=getline(linea,MAXLINEA); //trae una l�nea del programa fuente al buffer de l�neas
    if (ll==0) 	   
       fin_de_archivo=1; //se retrasa en un blanco la deteccion de EOF, porque obtoken lleva un caracter adelantado. si no, en 
						 //algunos casos tendr�amos problemas, por ejemplo: no se reconoceria el punto final del programa (...end.)
    offset=-1;
 }

 ++offset;

 if ( (linea[offset]=='\0') || (fin_de_archivo==1) )   
    return(' '); 
 else  
    return(toupper(linea[offset])); //de esto depende si el lenguaje es sensitivo de may�sculas o no.

}

//getline: lee la siguiente l�nea del fuente y regresa su tama�o (incluyendo '\n') o 0 si EOF. (por ejemplo: para VAR regresa 4)
//es probablemente la rutina de m�s bajo nivel del compilador
//tomada de "El Lenguaje de programaci�n C" - Kernighan & Ritchie - pag 28                        
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


