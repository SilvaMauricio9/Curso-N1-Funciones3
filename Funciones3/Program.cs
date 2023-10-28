using System;

namespace Funciones3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
            // Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
            // Informar el promedio teniendo en cuenta sólo los números primos.
            int numeros, totalPrimo = 0, acuPrimo = 0, promedio;
            Console.WriteLine("Ingrese numero: ");
            numeros = int.Parse(Console.ReadLine());

            while (numeros > 0)
            {
                if (primo(numeros)){
                    totalPrimo++;
                    acuPrimo += numeros;
                }
                
                Console.WriteLine("Ingrese numero: ");
                numeros = int.Parse(Console.ReadLine());
            }
            promedio = totalPrimo / acuPrimo;
            Console.WriteLine("Los numero primos son: " + totalPrimo);
            
        }
        static bool primo (int n1){
            int con = 0;
            for (int x = 1; x <= n1; x++){
                if (n1 % x == 0)
                    con++;
            }
            if (con == 2)
                return true; 
            else
                return false;
            
            
        
        }
    }
}
