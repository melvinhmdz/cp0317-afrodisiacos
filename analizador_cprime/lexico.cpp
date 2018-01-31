#include "lexico.h"

//se define e inicializa la tabla de lexemes correspondientes a las palabras reservadas
char *lexpal[MAXPAL]={"START", "END", "PUBLIC", "CLASS", "IF", "ELSE", "SWITCH", "CASE", "DEFAULT", "BREAK", "WHILE", "FOR", "INT", "FLOAT", "STRING", "CHAR", "BOOL", "FALSE", "TRUE", "CONTROL", "STEP", "NEW", "EXC", "PRINT", "READ","CADENA","ACCESOMETODO"};

//el token
enum simbolo token;

//se define e inicializa la tabla de tokens de palabras reservadas
enum simbolo tokpal [MAXPAL]={starttok,endtok,publictok,classtok,iftok,elsetok,switchtok,casetok,defaulttok,breaktok,whiletok,fortok,inttok,floattok,stringtok,chartok,booltok,falsetok,truetok,controltok,steptok,newtok,exctok,printtok,readtok,cadenatok,accmetodo};

//tabla de tokens correspondientes a operadores y s�mbolos especiales
enum simbolo espec[255] ;