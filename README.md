
⚪Aplicación de Manejo de Archivos y Validación de Datos de Empleados
------------------------------------------------------------------

Este proyecto trata de una aplicación de escritorio desarrollada en C# que permite capturar, validar y 
almacenar información de empleados en un archivo de texto.
La aplicación utiliza arquitectura por capas, valida que los campos no estén vacíos, muestra 
mensajes de alerta y permite guardar y abrir archivos mediante cuadros de diálogo, similar al funcionamiento 
de aplicaciones como Word o PowerPoint.Los datos se almacenan en formato de tabla, garantizando orden, legibilidad y 
correcta organización de la información.

⚪Tecnologías Utilizadas
-----------------------------------------------------------------

•	Lenguaje:
C#
          
•	Framework: 
Windows Forms (.NET)

• Arquitectura: 
 Arquitectura por Capas
 
•	Base de datos: 
No aplica (uso de archivos de texto)

•	IDE(entorno de desarrollo): 
Visual Studio

⚪Imágenes de la Ejecución del Proyecto
--------------------------------------------------------------
•fomulario principal del sistema donde se ingresan los datos del 
empleados.Esenario 1: sin datos



<img width="416" height="220" alt="image" src="https://github.com/user-attachments/assets/1207e2a1-3dd1-4c74-8fc5-ba6a84c69e7e" />



•Esenario 2: con datos datos



<img width="414" height="217" alt="image" src="https://github.com/user-attachments/assets/070bb550-d475-4a88-94ab-45806d9c3959" />



•Esenario 3: Mensajes de validación



<img width="494" height="253" alt="image" src="https://github.com/user-attachments/assets/6b669243-6167-45a6-a07b-eda7fd4cf78e" />



•Esenario 4: 



<img width="477" height="245" alt="image" src="https://github.com/user-attachments/assets/c29f4375-f1e6-40bc-893a-83ec1b1d9e34" />



•Esenario 5: Archivo de texto generado con los datos en forma de tabla.



<img width="656" height="134" alt="image" src="https://github.com/user-attachments/assets/32fdc1d2-a3c4-46d8-a1c7-7aae3ea1621f" />



Arquitectura del Proyecto
------------------------------------------------------------
El sistema está estructurado en capas para facilitar el
mantenimiento y la organización del código:

•Capa Presentación (UI):
Maneja los formularios de Windows Forms, validaciones visuales,
mensajes de alerta y cuadros de diálogo.

•Capa Lógica de Negocio (BLL):
Contiene las reglas de negocio y validaciones de los 
datos del empleado.

•Capa Acceso a Datos (DAL):
Se encarga de la lectura y escritura de los archivos
de texto.

•Capa Entidad (Entidades):
Define la clase Empleado con sus atributos (ID, nombre,
apellidos, dirección, teléfono, email, cargo, salario, fecha de ingreso y género).

Funcionalidades
-------------------------------------------------
1-Validación de campos obligatorios
2-Mensajes de alerta informativos
3-Guardado de archivos con nombre personalizado
4-Apertura de archivos de texto guardados
5-Visualización de datos en formato tabular
6-Confirmación al salir de la aplicación

Interfaz con criterios de usabilidad y accesibilidad
⚪ Uso o Ejecución
----------------------------------------------------------

1-Abrir el proyecto en Visual Studio.

2-Ejecutar la aplicación.

3-Completar los datos del empleado:
•ID
•Nombre
•Apellidos
•Dirección
•Teléfono
•Email
•Cargo
•Salario
•Fecha de ingreso
•Género

4-El sistema validará que todos los campos estén completos.

5-Guardar la información usando el cuadro de diálogo.

6-Abrir el archivo para visualizar los datos almacenados.

7-Al cerrar la aplicación, se mostrará un mensaje de confirmación


⚪ Contexto Académico
------------------------------------------------------------
•Nivel: Secundaria Técnico Profesional

•Módulo Formativo: Desarrollo de Aplicaciones y Sistemas de Información

•Curso / Sección: 5to D1

•Año Escolar: 2025-2026

⚪ Autor
------------------------------------------------------------
Jendry Elianne James Torres



