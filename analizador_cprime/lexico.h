#include "parametros.h"

//lexemes de las palabras reservadas
extern char *lexpal[MAXPAL];

//lista de tokens de pl0
enum simbolo {nulo,ident,numero,mas,menos,por,barra,igl,nig,mnr,mei,myr,mai,parena,parenc,coma,puntoycoma,punto,asignacion,llavea,llaveac,comillad,comillas,comp,dist,starttok,endtok,publictok,classtok,iftok,elsetok,switchtok,casetok,defaulttok,breaktok,whiletok,fortok,inttok,floattok,stringtok,chartok,booltok,falsetok,truetok,controltok,steptok,newtok,exctok,printtok,readtok,cadenatok,accmetodo}; //definido aqu� en el encabezado

extern enum simbolo token;

//tabla de tokens de palabras reservadas
extern enum simbolo tokpal [MAXPAL]; 

//tabla de tokens correspondientes a operadores y s�mbolos especiales
extern enum simbolo espec[255] ;