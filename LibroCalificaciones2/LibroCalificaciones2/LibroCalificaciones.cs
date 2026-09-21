using System;
public class LibroCalificaciones
{
    private string nombreCurso;

    public LibroCalificaciones(string nombre)
    {
        nombreCurso = nombre;
    }

    public string NombreCurso
    {
        get { return nombreCurso; }
        set { nombreCurso = value; }
    }

    public void MostrarMensaje()
    {
        Console.WriteLine($"Bienvenido al libro de calificaciones para \n{0}!\n", NombreCurso);
    }

    public void DeterminarPromedioClass()
    {
        int total;
        int contadorCalif;
        int calificacion;
        double promedio;

        total = 0;
        contadorCalif = 0;

        Console.Write("Escriba la calificación o -1 para terminar: ");
        calificacion = Convert.ToInt32(Console.ReadLine());

        while (calificacion != -1)
        {
            total = total + calificacion;
            contadorCalif = contadorCalif + 1;
            Console.Write("Escriba la calificación o -1 para terminar: ");
            calificacion = Convert.ToInt32(Console.ReadLine());
        }

        if (contadorCalif != 0)
        {
            promedio = (double)total / contadorCalif;
            Console.WriteLine($"\nEl total de las {contadorCalif} calificaciones introducidas es {total}");
            Console.WriteLine($"El promedio de la clase es {promedio:F}");
        }
        else
        {
            Console.WriteLine("No se introdujeron calificaciones");
        }
    }
}