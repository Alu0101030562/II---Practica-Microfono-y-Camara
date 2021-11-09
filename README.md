# II - Practica Microfono y Cámara

En esta practica tendremos que implementar mediante una interfaz, el reconocimiento por camara web a través de un objeto y el poder grabar una serie de segmentos mediante el microfono del ordenador y reproducirlo en la misma aplicación.

Para la parte de la cámara web lo primero que haremos será visualizar el numero de dispositivos disponibles, en nuestro caso, solo reconocera una camara web. Para ello tendremos que crear una variable publica declarando una *WebCamTexture*, una vez hecho esto crearemos un array con los dispositivos de la variable *WebCamTexture* y despues con un bucle recorreremos el array y con un *debug.log* imprimiremos por pantalla el nombre de los dispositivos disponibles.  

Ahora, crearemos una nueva *WebCamTexture* y lo asociaremos con el método *.play()* para iniciar la visualizaciçon de la camara. Una vez hecho esto hacemos un *renderer* para poder visualizarlo por la interfaz y despues si la camara esta en funcionamiento la convertiremos en la textura principal del objeto asociado en el script con *.maintexture*.

Después de esto, haremos una funcion *OnGUI* para crear una serie de botones que nos permitan pausar la camara y reanudarla en cualquier momento. Para ello en caso de si la camara esta encendida o apgada, crearemos un boton con *GUILayout.Button* que hara que la camara se pare, pause o encienda.

Para la parte del microfono crearemos un *GameObject* de audio y ahí introduciremos un script para permitir grabar sonidos y reproducirlos. Para ello comprobaremos el número de dispositivos disponibles y usaremos *Microphone.devices* en un *foreach* para visualizar después con un *debug.Log* el numero de micrófonos disponibles. Una vez hecho esto, crearemos unas variables publicas para poder visualizarlo desde el inspector de unity que nos permita usar el micrófono o no y cual se esta usando. Después crearemos una fuente de audio capaz de recoger el sonido del micrófono con *Microphone.Start(_selectedDevice, true, 10, 444100)* y una vez hecho eso lo iniciamos con *audioSource.Play()*. Ahora, crearemos un botón que detenga el micrófono y sera como hicimos anteriormente en la camara web.
