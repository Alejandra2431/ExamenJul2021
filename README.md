![UCU](https://github.com/ucudal/PII_Conceptos_De_POO/raw/master/Assets/logo-ucu.png)

### FIT - Universidad Católica del Uruguay

<br>

# Examen Programación II - Julio 2021.1

![Banner](https://azure.wgp-cdn.co.uk/app-table-top-gaming/posts/all-72050.jpg?&width=1200&height=630&mode=crop)

«La ruta de _Tokaido_, que data del siglo XI, conecta las dos cuidades más importantes de Japón: Edo (hoy llamada Tokio) y Kyoto. [...] Tiene 500km de largo y sigue la costa sur de la isla más grande del archipiélago Japonés: Honshu.»

_Tokaido_ es, además de una ruta en Japón, un juego de mesa muy popular creado por Antoine Bauza. En el juego, viajeros de distintos orígenes atravisan el camino de Edo a Kyoto participando de diversas experiencias en el afán de enriqueser su viaje lo más posible.

## Referencia gráfica

La siguiente imágen ilustra la versión simplificada del juego descrito.

![Referencia](./Assets/Reference.png)


--------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------



## ACLARACIONES Y COMENTARIOS SOBRE EL FUNCIONAMIENTO

Solo los paisajes:
-Dan puntos directamente
-Tienen capacidad para dos viajeros

Las experiencias que no son paisajes:
-Otorgan monedas o bonos que luego se calcula su equivalencia en puntos
-Tienen capacidad para un solo viajero

El bono por pasar por AguasTermales:
-Si la cantidad de visitas es par la cantidad de bonos es igual a la cantidad de de visitas a AguasTermales dividido 2.
-Si la cant de visitas es 1 no se otorgan bonos. 
-Si la cantidad de visitas es impar la cantidad de bonos será igual a la cantidad de visitas menos 1 y luego dividido 2. 

Cada vez que se visita una granja se le suma una cantidad de monedas que corresponde a multiplicar la cantidad de visitas a una granja, por 2.

Los viajeros se mueven a una posicion dada randómicamente.

El ganador es el primero de la lista de viajeros con mayor puntaje.

Cuando dos viajeros se encuentran en la última posición se mueve el primero que encuentra el programa, sin importar cuál llegó en primer lugar, luego se va a mover el que queda dado es el que sigue en la última posición. 



--------------------------------------------------------------------------------------------------------------------------
--------------------------------------------------------------------------------------------------------------------------