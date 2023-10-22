**INTRODUCCIÓN A LA PROGRAMACIÓN DE VIDEOJUEGOS CON UNITY![ref1]**

**Certamen 1:** Desarrollar prototipo de VJ en Unity

Profesor Sebastián Díaz Arancibia

13 Septiembre 2023                                                         ---------------------------------------------------------------------------------------------------------------------------

Esta evaluación consiste en desarrollar los ejercicios que se encuentran en este documento. Las características de la entrega son las siguientes:

- Fecha de entrega: Miércoles 13 de Septiembre hasta las 16:15 hrs.
- Enviar el enlace del proyecto (repositorio, comprimido, drive) al mail <sebastian.diazaran@gmail.com>.
- El asunto del correo debe ser: Certamen 1 Nombre Apellido.
- La versión de Unity debe ser la **2021.3.20f1**.
- Evaluación individual.

--------------------------------------------------------------------------------------------------------------------------- **PROTOTIPO**

1\. Desarrollar un prototipo de videojuego de **hypercasual arcade** con las siguientes características:

1. Un solo jugador.
1. Perspectiva Top Down.
1. Movimiento del personaje en eje X e Y usando rigidbody. El jugador tiene una velocidad de 8f.
1. Un spawner generará de manera aleatoria un objeto con forma de punto entre 1 y 3 segundos, incluyendo decimales.
1. El spawner seleccionará aleatoriamente el objeto punto a instanciar desde un arreglo de objetos puntos donde se encontrarán los puntos azules y los puntos rojos (cada uno debe ser un prefab distinto).
1. Al instanciar el punto, se debe cambiar su nombre a “Blue” o “Red” respectivamente.
1. El spawner debe posicionar el nuevo punto instanciado según los límites de la pantalla, los cuales serán -8.5 a 8.5 en el eje X y entre -4.7 y 4.7 en el eje Y.
1. Si el jugador colisiona con un punto azul, el tamaño del jugador aumentará sumando el factor de escala. Determinar la colisión usando el nombre “Blue”.
1. Si el jugador colisiona con un punto rojo, el tamaño del jugador se reducirá restando el factor de escala multiplicado por 2. Determinar la colisión usando el nombre “Red”.
1. Las colisiones deben ser marcadas como Trigger.
1. Si la escala del jugador es menor a 0.1f, el jugador pierde la partida.
12. Los puntos cuentan con una variable entera que determina los puntos a entregar o quitar al jugador.![ref1]
12. Los puntos azules entregan 10 puntos al jugador.
12. Los puntos rojos quitan 5 puntos al jugador.
12. Cuando el jugador pierde, enviar un mensaje por consola indicando el GAME OVER. Se muestra el puntaje total obtenido y luego se destruye el personaje.

**(60 puntos)**

![](Aspose.Words.d2a2f2a9-c9bf-4694-ba0d-92b153080ca6.002.png)

(Imágen de referencia del juego solicitado)

[ref1]: Aspose.Words.d2a2f2a9-c9bf-4694-ba0d-92b153080ca6.001.jpeg
