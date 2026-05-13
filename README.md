# Manual de Estructura - Proyecto S.I.A.R.A

Este documento sirve como guía para entender la organización del frontend y la navegación del sistema construido en ASP.NET MVC.

## 1. Estructura de Carpetas Principal
En ASP.NET MVC, el trabajo se divide en tres áreas clave:
* Controllers/: Los "mensajeros". Reciben la URL que se escribe en el navegador y deciden qué pantalla mostrar.
* Views/: El corazón del diseño. Aquí estan los archivos .cshtml con todo tu código HTML.
* wwwroot/: Recursos estáticos. Aquí se guarda lo que no cambia (CSS e Imágenes).

## 2. Controladores (Rutas y Navegación)
Ubicados en la carpeta Controllers/.

* AuthController.cs: Maneja el acceso al sistema (Login, Recuperar, Restablecer).
* AdminController.cs: Maneja el panel del Administrador (Dashboard, Asignaturas, Graficas, DocumentosIniciales, DetalleDocente).


## 3. Vistas y Diseño (HTML / Razor)
Ubicados en la carpeta Views/.

### Carpeta Shared/ (Lo que se repite)
* _Layout.cshtml: Plantilla maestra. Contiene el encabezado azul, el menú lateral y los modales globales.
* _ViewStart.cshtml: Archivo que indica a todas las pantallas que usen el _Layout.

### Carpeta Auth/ (Módulo de Acceso)
* Login.cshtml: Pantalla de inicio de sesión.
* Recuperar.cshtml: Pantalla para ingresar el correo asociado.
* Restablecer.cshtml: Formulario para cambiar la clave.

### Carpeta Admin/ (Módulo del Administrador)
* Dashboard.cshtml: Tabla principal de Cursos y Docentes. Contiene modales de gestión.
* Asignaturas.cshtml: Catálogo de materias.
* Graficas.cshtml: Panel de generación de reportes visuales.
* DocumentosIniciales.cshtml: Tabla de estado de entrega de los maestros.
* DetalleDocente.cshtml: Vista individual de archivos subidos por un maestro.


## 4. Recursos Visuales
Ubicados en la carpeta wwwroot/.
* css/estilos.css: Contiene las reglas de diseño, colores institucionales, animaciones de gráficas y modales.
* img/: Contiene tecnm_logo.png, instituto_logo.png y siara_logo.png.

## 5. Lógica de Interacción (JavaScript Global)
Ubicado al final de Views/Shared/_Layout.cshtml:
* abrirModal(id) / cerrarModal(id): Controlan ventanas flotantes.
* mostrarAlertaExito(mensaje) / mostrarAlertaConfirmacion(mensaje): Activan las notificaciones flotantes con formato.
