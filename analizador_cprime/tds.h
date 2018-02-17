#include "parametros.h"

//definición de la tabla de símbolos - organizacion y acceso lineal
//sufrirá modificaciones cuándo se presente el compilador completo

//tipos de objetos de pl0
enum objeto {CONSTANTE,VARIABLE,CONSTRUCTO, METODO, CLASE}; //definidos aquí en el encabezado. si se guardan más tipos de cosas, se ponen aquí.

typedef struct { // El tipo de la TDS.
 char nombre[MAXID+1]; // El lexema que se leyó.
 enum objeto tipo; // El tipo de objeto: CONSTANTE, VARIABLE O FUNCION.
} registro;

// Declaración de la tabla de símbolos.
extern registro tabla[MAXIT+1]; //MAXIT en parametros (+1 porque tabla[0] esta reservada. Es para controlar...)
extern int it; // Indice para recorrer la tabla de símbolos. Si la TDS tiene x valores, it tiene el valor x.

void poner(enum objeto k); // Recibe un elto a guardar y lo guarda en la posisición que it le indica en la TDS.
int posicion(); // Devuelve el valor de it.