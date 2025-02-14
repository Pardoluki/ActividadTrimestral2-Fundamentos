# ActividadTrimestral2-Fundamentos
# Actividad Trimestral 2 - Fundamentos de la Programación: Registro de Entrenamientos

Este proyecto es una aplicación de consola en C# que permite gestionar sesiones de usuarios para registrar y administrar sus entrenamientos. A continuación, se detallan las características y el funcionamiento del sistema.

## Características

- **Registrar usuarios**: Permite registrar nuevos usuarios solicitando un correo y una contraseña. No es posible registrar dos usuarios con el mismo nombre.
- **Iniciar sesión**: Permite a los usuarios iniciar sesión proporcionando su correo y contraseña. Si las credenciales son correctas, el usuario puede acceder a las siguientes acciones:
  - **Registrar un entrenamiento**: Solicita la distancia recorrida y el tiempo empleado, y lo guarda en una lista.
  - **Listar entrenamientos**: Muestra todos los entrenamientos registrados.
  - **Vaciar entrenamientos**: Elimina todos los entrenamientos de la lista.
  - **Cerrar sesión**: Finaliza la sesión del usuario.

## Funcionamiento

### Menú Principal

Al iniciar la aplicación, se presenta un menú principal con las siguientes opciones:

1. Registrar usuario
2. Iniciar sesión con usuario existente
3. Salir

### Registro de Usuario

Para registrar un nuevo usuario, se solicita un nombre de usuario y una contraseña. Si el nombre de usuario ya existe, se pide al usuario que introduzca otro nombre.

### Inicio de Sesión

Para iniciar sesión, se solicita el nombre de usuario y la contraseña. Si las credenciales son correctas, se muestra un mensaje de bienvenida y se accede al menú de entrenamientos. Si las credenciales son incorrectas, se muestra un mensaje de error.

### Menú de Entrenamientos

Una vez iniciada la sesión, el usuario puede acceder al menú de entrenamientos con las siguientes opciones:

1. Registrar entrenamiento
2. Listar entrenamientos
3. Vaciar todos los entrenamientos
4. Cerrar sesión

### Registrar Entrenamiento

Se solicita la distancia recorrida (en kilómetros) y el tiempo empleado (en horas). Estos datos se guardan en una lista de entrenamientos.

### Listar Entrenamientos

Se muestran todos los entrenamientos registrados, indicando la distancia y el tiempo de cada uno.

### Vaciar Entrenamientos

Se eliminan todos los entrenamientos de la lista.

### Cerrar Sesión

Finaliza la sesión del usuario y regresa al menú principal.

## Detalles Técnicos

El proyecto está compuesto por tres clases principales:

- **Program**: Contiene el método `Main` y el menú principal.
- **AccionesUsuario**: Gestiona el registro e inicio de sesión de los usuarios.
- **AccionesEntrenamiento**: Gestiona el registro, listado y vaciado de los entrenamientos.

## Ejecución

Para ejecutar la aplicación, simplemente compila y ejecuta el archivo `Program.cs`. Sigue las instrucciones en pantalla para interactuar con el sistema.

¡Disfruta utilizando el sistema de registro de entrenamientos!
