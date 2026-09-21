using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Fig. 5.6: PurebaLibroCalificaciones.cs
//Crea el objeto LibroCalificaciones e invoca a su metodo DeterminarPormedio
public class PruebaLibroCalificaciones
{
    public static void Main(string[] args)
    {
        //crea el objeto miLibroCalificaciones de LibroCalificaciones y pasa el nombre del curso al constructor
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones("CS101 Introduccion a la programacion en C#");

        miLibroCalificaciones.MostrarMensaje(); //muestra el mensaje de bienbenida
        miLibroCalificaciones.DeterminarPromedioClass(); //encuentra el promedio de calificaciones
    } //fin de Main
}//fin de la clase PruebaLibroCalificaciones
