using System;

class Program

{
    static void Main(string[] args)
    {
      
        // Desafio Multicação simples
        int a, b;
        a = Convert.ToInt32(Console.ReadLine());
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("PROD = " + (  a * b  )); //implemente o código que representa a multiplicação.
        Console.ReadLine();
      

        //Desafio Pink e Cérebro
        int suavariavel = int.Parse(Console.ReadLine());
        string[] n = Console.ReadLine().Split(' ');

        int multiplo2 = 0;
        int multiplo3 = 0;
        int multiplo4 = 0;
        int multiplo5 = 0;
        //TODO: Complete os espaços em branco com uma possível solução para o desafio
        
        for (int iContador = 0; iContador < n.Length; iContador++)
        {
            
            if ((Convert.ToInt32(n[iContador]) % 2) == 0) multiplo2 += 1;
            if ((Convert.ToInt32(n[iContador]) % 3) == 0) multiplo3 += 1;
            if ((Convert.ToInt32(n[iContador]) % 4) == 0) multiplo4 += 1;        
            if ((Convert.ToInt32(n[iContador]) % 5) == 0) multiplo5 += 1;

        }
        

            Console.WriteLine("{0} Multiplo(s) de 2", multiplo2 );
            Console.WriteLine("{0} Multiplo(s) de 3", multiplo3 );
            Console.WriteLine("{0} Multiplo(s) de 4", multiplo4 );
            Console.WriteLine("{0} Multiplo(s) de 5", multiplo5 );




            //Desafio Esfera
            
            double pi, raio, volume;
            pi = 3.14159;
            //TODO: Complete os espaços em branco com uma possível solução para o desafio     

            raio = double.Parse(Console.ReadLine());
            volume = pi * (4.0/3) * Math.Pow( raio , 3 );

            Console.WriteLine($"VOLUME =  {Math.Round(volume, 3)}");
        }
    

       
   

    }
