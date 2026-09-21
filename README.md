# Laboratorio # 5

📅 Fecha: 21/09/2026

## 📄 Contenido del Repositorio

Este repositorio contiene la implementación de la clase `LibroCalificaciones` en C#, la cual resuelve el problema de calcular el promedio de calificaciones de una clase utilizando dos estrategias de repetición distintas:

- **Repetición controlada por un contador**: se procesan exactamente 10 calificaciones ingresadas por el usuario.
- **Repetición controlada por un centinela**: se procesa un número arbitrario de calificaciones hasta que el usuario ingresa el valor centinela `-1`.

## 🛠️ Tecnologías Utilizadas

### 🌐 Tecnologías utilizadas

`C#` `.NET` `Visual Studio` `Console Application` `Git`

- **Lenguaje / Framework:** C# (.NET)
- **Entorno de ejecución:** Consola (Console Application)
- **Herramientas:** Git, Visual Studio / Visual Studio Code

## 🖥️ Capturas de Pantalla y Problemas

### Interfaz Principal

*(Aquí se incluye la imagen de la salida de la consola)*

- **Problema 1 — Promedio con repetición controlada por contador (`LibroCalificaciones.cs` / `PruebaLibroCalificaciones.cs`):** se crea un objeto `LibroCalificaciones` pasando el nombre del curso al constructor. El método `MostrarMensaje()` saluda al usuario y `DeterminarPromedioClase()` solicita exactamente 10 calificaciones mediante un ciclo `while (contadorCalif <= 10)`, acumula el total y calcula el promedio (división entera). Ejemplo de salida:
<img width="1460" height="547" alt="image" src="https://github.com/user-attachments/assets/641071c2-a67a-40fe-aa2f-4aaaadf2d236" />

- **Problema 2 — Promedio con repetición controlada por centinela (`LibroCalificaciones.cs` versión con centinela):** se modifica la clase para aceptar un número arbitrario de calificaciones. El programa lee la primera calificación antes de entrar al ciclo `while (calificacion != -1)`, suma cada valor válido al total e incrementa el contador; al ingresar `-1` el ciclo termina. Con un `if...else` se valida que se haya introducido al menos una calificación antes de calcular el promedio como `double` (con dos decimales de precisión).
<img width="1471" height="578" alt="image" src="https://github.com/user-attachments/assets/9a00a525-022f-484f-a479-a0470d388f37" />


## ▶️ Instrucciones de Ejecución / Uso

1. Clonar el repositorio:
   ```
   git clone <url-del-repositorio>
   ```
2. Abrir la solución en Visual Studio (o Visual Studio Code con la extensión de C#/.NET).
3. Compilar y ejecutar el proyecto:
   ```
   dotnet run
   ```
4. Ingresar las calificaciones solicitadas por consola (10 valores en la versión de contador, o valores arbitrarios terminando en `-1` en la versión de centinela).

## 👤 Autor y Contexto

- **Nombre:** Wilson Wu
- **Institución:** Universidad Tecnológica de Panamá (UTP)
- **Fecha de Realización:** 8/09/2026

## 🔗 Referencias
-Hoja impresa proporcionado por el docente
-Plataforma virtual UTP: https://virtual.utp.ac.pa/
-Sección de entrega en la plataforma: https://virtual.utp.ac.pa/moodle/mod/assign/view.php?id=295035
