# ![Icon](https://png.icons8.com/color/48/000000/facial-recognition-scan.png) Sistema de Registro y Control de Usuarios para el Centro de Información en el Instituto Tecnológico de Delicias

Conforme el proyecto avance, se irá actualizando este archivo.

###### _Contenido:_

- Últimas características en las que se esta trabajando.
- Control de Usuarios.
- Registro de Usuarios.
- Requerimientos.
    - Control de Usuarios.
    - Registro de Usuarios.
- Herramientas de terceros utilizadas para la creación del software.

## Últimas características en las que se esta trabajando

  - Nuevo diseño de interfaz para el control de usuarios.
  - Mayor rendimiento para el sistema de control de usuario.
  - Mostrar fotografía del usuario en el registro de usuarios.

## Control de Usuarios

El sistema consiste en varios módulos:

1. **Inicio y Cierre de Sesión (LogIn y LogOut):** De forma de que no cualquier persona acceda al sistema, es necesario tener que ingresar al sistema por medio de un inicio de sesión donde se pedirá un número de control y una contraseña.
2. **Principal:** Es la interfaz de usuario encargada de mostrar los módulos que se describen a continuación.
3. **Usuarios (Users):** El cual permitirá al administrador la posibilidad de ver la totalidad de los usuarios registrados en el sistema.
4. **Movimientos (Moves):**
5. **Estadísticas (Stats):**
6. **Bitácora (Binnacle):**
7. **Importación (Import):**

A continuación, se describen las capas utilizadas para la creación del proyecto.

| Capa | Descripción |
| ------ | ------ |
| Business | Contiene validaciones para los formularios o inputs que son llenados por el usuario. |
| Connections | Capa de conexión a la base de datos. Con ella se realizan las consultas a la base de datos por medio de procedimientos almacenados. |
| Entity | Contiene las entidades que representan los datos que se manejan en las tablas de la base de datos o para pasar información de un formulario a otro. |
| Options | Creada para las elecciones que haga el usuario, es decir, las opciones de diversos módulos del sistema serán las que definan las acciones de ciertos formularios. |
| Presentation | Contiene, en su mayoría, el diseño de las interfaces de usuario. |
| Report | Es la capa encargada de generar los reportes en PDF para el usuario por medio de la librería [iTextPdf]. |

##### **Aclaración:**
Cabe mencionar que falta una última capa que sería el instalador del software. Se creará una vez se hayan realizado las pruebas necesarias para comprobar que el software esta listo para su uso.

## Registro de Usuarios

_Esta parte aún está en desarrollo..._

| Capa | Descripción |
| ------ | ------ |
| CapaDatos | Capa de conexión a la base de datos. Con ella se realizan las consultas a la base de datos por medio de procedimientos almacenados.|
| CapaNegocio | Contiene validaciones para los formularios o inputs que son llenados por el usuario. |
| CapaPre | Contiene, en su mayoría, el diseño de las interfaces de usuario. |
| Instalador | Contiene el archivo .exe para la instalación del software. |

### Requerimientos

##### Control de Usuarios:

- Sistema operativo Windows 7 o superior.
- 1 GB de RAM como mínimo.
- Un disco duro de 250 GB como mínimo.
- .NET Framework 4.6.1. Para más información sobre su descarga: [Net Framework]
- 1 Ghz de procesamiento.
- Computadora de arquitectura de 64 bits.

##### Registro de Usuarios:

- Sistema operativo Windows 7 o superior.
- 1 GB de RAM como mínimo.
- Un disco duro de 250 GB como mínimo.
- .NET Framework 4.6.1. Para más información sobre su descarga: [Net Framework]
- 1 Ghz de procesamiento.
- Computadora de arquitectura de 64 bits.

## Herramientas de terceros utilizadas para la creación del software

Para la creación de los 2 sistemas, se utilizaron:
1. Librerías [iTextPdf].
2. Iconos de [iCons8].
3. Herramienta [jcPicker].

![Separador](http://3.bp.blogspot.com/-qPaHwaM0XbI/VJSUsYWF_ZI/AAAAAAAACZ4/nvzs8yz9NNM/s1600/separador1.png)

#### Acerca de mi

Actualmente, soy estudiante del Instituto Tecnológico de Delicias cursando la carrera de Ingeniería en Sistemas Computacionales y estoy en mi décimo semestre. Tengo conocimientos en:
1. C#
2. Visual Basic.
3. SQL Server Express
4. Visual Studio Community
5. MySQL.
6. PostgreSQL.
7. Git.
8. HTML 5.
9. CSS 3.
10. JavaScript.

##### Redes Sociales o Contactos

[Facebook].
[LinkedIn].
[Twitter].
Email: joshsk8rocker@gmail.com

[iTextPdf]: <https://developers.itextpdf.com/downloads>
[Net Framework]: <https://www.microsoft.com/net/download>
[iCons8]: <http://icons8.com/>
[jcPicker]: <http://annystudio.com/software/colorpicker/>
[Facebook]: <https://www.facebook.com/joserubiolol>
[LinkedIn]: <https://www.linkedin.com/in/joseluisrubioperez/>
[Twitter]: <https://twitter.com/ggConsu>