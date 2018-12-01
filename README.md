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

  - Trabajando en los reportes de PDF.
  - Trabajando en interfaces gráficas de "configuración".
  - Mostrar fotografía del usuario en el registro de usuarios.
  - Removiendo interfaces gráficas de "Bitácoras" (gracias por su recomendación, chicos de Nearsoft <3 ).
  - Trabajando en aspectos finales de importación de usuarios.
  - Planeando migración de nase de datos a PostgreSQL.

## Control de Usuarios

El sistema consiste en varios módulos:

1. **Inicio y Cierre de Sesión (LogUser):** De forma de que no cualquier persona acceda al sistema, es necesario tener que ingresar al sistema por medio de un inicio de sesión donde se pedirá un número de control y una contraseña.
2. **Principal:** Es la interfaz de usuario encargada de mostrar los módulos que se describen a continuación.
3. **Usuarios (Users):** El cual permitirá al administrador la posibilidad de ver la totalidad de los usuarios registrados en el sistema.
4. **Movimientos (Moves):** Mostrará un botón por sí el administrador desea ver todos los registros o también tiene la opción de buscar movimientos de forma más específica al seleccionar cómo buscar el(los) movimiento(s) que desea ver. Da clic en "Realizar búsqueda" y mostrará una tabla con los resultados.
5. **Estadísticas (Stats):** Muestra una interfaz gráfica con un formulario para escoger el sexo de(los) usuario(s) a buscar, así como los servicios y el rango de fechas (o diferentes opciones a escoger que son rangos de fechas prediseñados).
7. **Importación (Import):** Muestra 2 botónes, el primero de ellos es para buscar un archivo de extensión "".csv" que contendrá los usuarios a importar (leer el manual de usuario para comprender cómo se deben de organizar estos datos para su correcta importación); el otro botón es para importar los usuarios al estar seguro pero antes de ello, se mostrará una tabla con los usuarios a importar donde el administrador tendrá la opción de modificar aquellos usuarios que están mal redactaados. Una vez termine de editar o de mandar a llamar el archivo con extensión ".csv", dará clic en el botón de importar, se le pedirá una confirmación de sí desea realizar dichos cambios en la base de datos y ¡listo! usuarios importados.

A continuación, se describen las capas utilizadas para la creación del proyecto.

| Capa | Descripción |
| ------ | ------ |
| BiblioTec | Proyecto de base de datos basado en SQL Server 2012. Contiene el esquema de la base de datos. |
| Business | Contiene validaciones para los formularios o inputs que son llenados por el usuario. |
| Connections | Capa de conexión a la base de datos. Con ella se realizan las consultas a la base de datos por medio de procedimientos almacenados. |
| Entity | Contiene las entidades que representan los datos que se manejan en las tablas de la base de datos o para pasar información de un formulario a otro. |
| Options | Creada para las elecciones que haga el usuario, es decir, las opciones de diversos módulos del sistema serán las que definan las acciones de ciertos formularios. |
| Presentation | Contiene, en su mayoría, el diseño de las interfaces de usuario. |
| Reportes | Es la capa encargada de generar los reportes en PDF con [iTextPdf] y reportes en Excel con [ClosedXML]. |
| Install | Contiene el instalador del proyecto. Compilarlo implica generar el instalador. |

## Registro de Usuarios

1. **Inicio y Cierre de Sesión (LogIn y LogOut):** De forma de que no cualquier persona acceda al sistema, es necesario tener que ingresar al sistema por medio de un inicio de sesión donde se pedirá un número de control y una contraseña.
2. **Principal:** Es la interfaz de usuario encargada de mostrar el formulario que los usuarios llenan para poder ingresar al centro de información y de ahí generar los reportes solicitados.

| Capa | Descripción |
| ------ | ------ |
| CapaDatos | Capa de conexión a la base de datos. Con ella se realizan las consultas a la base de datos por medio de procedimientos almacenados.|
| CapaNegocio | Contiene validaciones para los formularios o inputs que son llenados por el usuario. |
| CapaPre | Contiene, en su mayoría, el diseño de las interfaces de usuario. |
| Instalador | Contiene el archivo .exe para la instalación del software. |

### Requerimientos

##### Control de Usuarios:

- Sistema operativo Windows XP.
- 1 GB de RAM como mínimo.
- Un disco duro de 250 GB como mínimo.
- .NET Framework 3.5. Para más información sobre su descarga: [Net Framework]
- 1 Ghz de procesamiento.
- Computadora de arquitectura de 32 o 64 bits.

##### Registro de Usuarios:

- Sistema operativo Windows 7 o superior.
- 1 GB de RAM como mínimo.
- Un disco duro de 250 GB como mínimo.
- .NET Framework 3.5. Para más información sobre su descarga: [Net Framework]
- 1 Ghz de procesamiento.
- Computadora de arquitectura de 32 o 64 bits.

## Herramientas de terceros utilizadas para la creación del software

Para la creación de los 2 sistemas, se utilizaron:
1. Librerías [iTextPdf] (Aún falta por implementar en el repositorio pero se contempla usar a futuro).
2. Librería [ClosedXML] (versión 0.87.1).
3. .Librería [DocumentFormat.OpenXml] (versión 1.0.0).
4. Librería [ExcelNumberFormat] (versión 1.0.3).
5. Iconos de [iCons8].
6. Herramienta [jcPicker].

![Separador](http://3.bp.blogspot.com/-qPaHwaM0XbI/VJSUsYWF_ZI/AAAAAAAACZ4/nvzs8yz9NNM/s1600/separador1.png)

#### Acerca de mi

Actualmente, soy estudiante del Instituto Tecnológico de Delicias cursando la carrera de Ingeniería en Sistemas Computacionales y estoy en mi décimo semestre. Tengo conocimientos en:
1. C#
2. Visual Basic.
3. SQL Server Express
4. Visual Studio Community
5. PostgreSQL.
6. Git.
7. HTML 5.
8. CSS 3.
9. JavaScript.

##### Redes Sociales o Contactos

[Facebook].
[LinkedIn].
[Twitter].
Email: joserubiodeveloper@gmail.com

[iTextPdf]: <https://developers.itextpdf.com/downloads>
[Net Framework]: <https://www.microsoft.com/net/download/thank-you/net35-sp1>
[iCons8]: <http://icons8.com/>
[jcPicker]: <http://annystudio.com/software/colorpicker/>
[Facebook]: <https://www.facebook.com/joserubiolol>
[LinkedIn]: <https://www.linkedin.com/in/joseluisrubioperez/>
[Twitter]: <https://twitter.com/ggConsu>
[ClosedXML]: <https://www.nuget.org/packages/ClosedXML/0.87.1>
[DocumentFormat.OpenXml]: <https://www.nuget.org/packages/DocumentFormat.OpenXml/1.0.0>
[ExcelNumberFormat]: <https://www.nuget.org/packages/ExcelNumberFormat/1.0.3>