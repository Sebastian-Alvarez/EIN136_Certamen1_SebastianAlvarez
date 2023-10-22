<img src="https://github.com/Sebastian-Alvarez/Certamen1_SebastianAlvarez/assets/65298949/27a09025-2bbc-4617-8f67-90dfae3a73c1" width="100"/>

<a> Universidad Técnico Federico Santa María <br> Introducción a la Programación de Videojuegos con Unity - EIN136B <a> <br>


<h1>Certamen 1: Desarrollar prototipo de VJ en Unity</h1>

<h3>Entrega de Sebastián Álvarez Avendaño</h3>
<h4>Introducción a la Programación de Videojuegos con Unity</h4>
<h4>Profesor Sebastián Díaz Arancibia</h4>
<h5>13 Septiembre 2023</h5>                                                         


---

Esta evaluación consiste en desarrollar los ejercicios que se encuentran en este documento. Las características de la entrega son las siguientes:

  - Fecha de entrega: Miércoles 13 de Septiembre hasta las 16:15 hrs.
  - Enviar el enlace del proyecto (repositorio, comprimido, drive) al mail .
  - El asunto del correo debe ser: Certamen 1 Nombre Apellido.
  - La versión de Unity debe ser la **2021.3.20f1**.
  - Evaluación individual.

--- 
**PROTOTIPO**

<h4>1. Desarrollar un prototipo de videojuego de hypercasual arcade con las siguientes características:</h4>

  <p>1.1) Un solo jugador.</p>
  <p>1.2) Perspectiva Top Down.</p>
  <p>  1.3) Movimiento del personaje en eje X e Y usando rigidbody. El jugador tiene una velocidad de 8f.</p>
  <p>  1.4) Un spawner generará de manera aleatoria un objeto con forma de punto entre 1 y 3 segundos, incluyendo decimales.</p>
  <p>1.5) El spawner seleccionará aleatoriamente el objeto punto a instanciar desde un arreglo de objetos puntos donde se encontrarán los puntos azules y los puntos rojos (cada uno debe ser un prefab distinto).</p>
  <p>1.6) Al instanciar el punto, se debe cambiar su nombre a “Blue” o “Red” respectivamente.</p>
  <p>1.7) El spawner debe posicionar el nuevo punto instanciado según los límites de la pantalla, los cuales serán -8.5 a 8.5 en el eje X y entre -4.7 y 4.7 en el eje Y.</p>
  <p>1.8) Si el jugador colisiona con un punto azul, el tamaño del jugador aumentará sumando el factor de escala. Determinar la colisión usando el nombre “Blue”.</p>
  <p>1.9) Si el jugador colisiona con un punto rojo, el tamaño del jugador se reducirá restando el factor de escala multiplicado por 2. Determinar la colisión usando el nombre “Red”.</p>
  <p>1.10) Las colisiones deben ser marcadas como Trigger.</p>
  <p>1.11) Si la escala del jugador es menor a 0.1f, el jugador pierde la partida.</p>
  <p>1.12) Los puntos cuentan con una variable entera que determina los puntos a entregar o quitar al jugador.</p>
  <p>1.13) Los puntos azules entregan 10 puntos al jugador.</p>
  <p>1.14) Los puntos rojos quitan 5 puntos al jugador.</p>
  <p>1.15) Cuando el jugador pierde, enviar un mensaje por consola indicando el GAME OVER. Se muestra el puntaje total obtenido y luego se destruye el personaje.</p>

**(60 puntos)**

(Imágen de referencia del juego solicitado) <br>
![GameImgRef](https://github.com/Sebastian-Alvarez/Certamen1_SebastianAlvarez/assets/65298949/d46a1c23-d4e0-4bab-888c-f7c44a985b49)
