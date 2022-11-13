
using System;

class Program
{
    static void Main() {
    string[] parqueo = new string[5];
    
    parqueo[1] = "P123AAA";
    for(int i=0; i<5; i++){
        Console.WriteLine("Indice "+i);
        Console.WriteLine(parqueo[i]);
    }
    
    for(int i=0; i<5; i++){
        Console.WriteLine("Ingrese placa para espacio  "+i);
        parqueo[i]= Console.ReadLine();
    }
    
// impresion de parqueos
    for(int i=0; i<5; i++){
        Console.WriteLine("Posicion "+(i+1));
        Console.WriteLine(parqueo[i]);
    }



    }
}