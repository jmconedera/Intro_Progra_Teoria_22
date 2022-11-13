using System;

class Program
{
    static void Main() {
        string[] nombres = new string[4];
        int[] notas = new int[4];
        
        for(int i=0; i<4 ; i++){
            Console.WriteLine("Ingrese nombre de estudiante ");
            nombres[i] = Console.ReadLine();
            Console.WriteLine("Ingrese nota ");
            notas[i] = int.Parse(Console.ReadLine());
        }
        
        double promedio = 0;
        double suma =0;
        for(int i=0; i<4 ; i++)
        {
            suma = suma + notas[i];
        }
        promedio = suma /4;
        Console.WriteLine("El promedio es "+promedio);
        
        for(int i=0; i<4 ; i++)
        {
            if (notas[i] > promedio){
                Console.WriteLine(nombres[i]);
            }
        }
        
        
    }
}