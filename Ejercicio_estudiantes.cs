using System;

class Estudiante
{
    public string NombreEstudiante { get; set; }
    public int EdadEstudiante { get; set; }
    public double NotaEstudiante { get; set; }

    public void Presentar()
    {
        string EstadoEstudiante = NotaEstudiante >= 4.0 ? "Has aprobado" : "Has reprobado";
        Console.WriteLine($"Nombre del estudiante: {NombreEstudiante}, Edad del estudiante: {EdadEstudiante}, Nota del estudiante: {NotaEstudiante:F1} -> {EstadoEstudiante}");
    }
}

public class Program
{
    public static void Main()
    {
        // Leer nombre
        Console.Write("Ingrese nombre del estudiante: ");
        string nombre = Console.ReadLine(); 

        // Leer y validar edad
        int edad;
        do
        {
            Console.Write("Ingrese edad del estudiante (Debe ser un entero positivo): ");
        } while (!int.TryParse(Console.ReadLine(), out edad) || edad <= 0);

        // Leer y validar nota
        double nota;
        do
        {
            Console.Write("Ingresa una nota del 1 al 7: ");
        } while (!double.TryParse(Console.ReadLine(), out nota) || nota < 1.0 || nota > 7.0);

        // Crear objeto Estudiante
        Estudiante estudiante = new Estudiante
        {
            NombreEstudiante = nombre, 
            EdadEstudiante = edad,
            NotaEstudiante = nota
        };

        estudiante.Presentar();
    }
}
