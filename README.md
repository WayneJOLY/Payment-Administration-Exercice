# 🎯Sistema de Administración de Pagos de Cuotas de Alumnos

Este proyecto tiene como objetivo modelar e implementar un sistema para registrar y administrar el pago de cuotas de los alumnos de un instituto. El sistema está diseñado siguiendo los principios de la Programación Orientada a Objetos (POO) y permite gestionar la información relevante de cada alumno.

## Clase CAlumno

La clase `CAlumno` representa a un alumno del instituto y contiene los siguientes atributos y métodos:

### Atributos

- **CUOTA**: Número real (punto flotante de precisión simple) que representa el valor de la cuota. Este valor es único y compartido para todas las instancias de la clase.
- **Legajo**: Número entero que actúa como identificador único del alumno, con un rango de [0 a 20000].
- **Nombre**: Cadena de caracteres que concatena los nombres y apellidos del alumno.
- **Beca**: Número real (punto flotante de precisión simple) que representa el porcentaje de beca del alumno, en el intervalo [0 a 100].

- ## Descripción de Métodos

- **setNombre(string nombApe)**: Establece el nombre del alumno.
- **setCUOTA(float monto)**: Establece el valor de la cuota.
- **CCuenta(int numLegAlumno)**: Constructor que inicializa el legajo del alumno.
- **setBeca(float porcentaje)**: Establece el porcentaje de beca del alumno.
- **darImporteMensual()**: Calcula y devuelve el importe mensual a abonar, aplicando la beca.
- **darDatos()**: Devuelve una cadena con los datos del alumno, incluyendo el importe mensual.
- **abonaMasImporteQue(CAlumno otroAlumno)**: Compara el importe mensual de dos alumnos y devuelve un valor booleano.
