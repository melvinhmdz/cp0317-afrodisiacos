#include "parametros.h"

//lexemes de las palabras reservadas
extern char *lexpal[MAXPAL];

//lista de tokens de pl0
enum simbolo {nulo,ident,numero,mas,menos,por,barra,igl,nig,mnr,mei,myr,mai,parena,parenc,coma,puntoycoma,punto,asignacion,llavea,llaveac,comillad,comillas,comp,dist,readcar,readcad,readint,readfloat,starttok,endtok,publictok,classtok,iftok,elsetok,switchtok,casetok,defaulttok,breaktok,whiletok,fortok,inttok,floattok,voidtok,stringtok,chartok,booltok,falsetok,truetok,controltok,steptok,newtok,exctok,printtok,readtok,cadenatok,accmetodo,vstringtok,strlngtok,searchctok,replacetok,parseftok,parimpartok,vinttok,vfloattok,cutdecimaltok,aproxcuttok,partdectok,potenciatok,senotok,cosenotok,tangentetok,pitok,factorialtok,raizcuadtok,combinaciontok,permutaciontok,residuodivtok,vabsolutotok}; //definido aqu� en el encabezado

extern enum simbolo token;

//tabla de tokens de palabras reservadas
extern enum simbolo tokpal [MAXPAL]; 

//tabla de tokens correspondientes a operadores y s�mbolos especiales
extern enum simbolo espec[255] ;