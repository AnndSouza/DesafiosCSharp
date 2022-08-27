// using System;
// //TODO: Complete os espaços em branco com uma solução possível para o problema.
// namespace Desafio
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             var dias = int.Parse(Console.ReadLine());
//             var anos = dias / 365 ;
//             dias = dias % 365;
            
//             var meses = dias / 30;
//             dias = dias % 30;
            
//             Console.WriteLine($"{anos} ano(s)");
//             Console.WriteLine($"{meses} mes(es)");
//             Console.WriteLine($"{dias} dia(s)");
//         }
//     }
// }


// using System;

//     class MinhaClasse {
//         static void Main(string[] args) {
//             var timeInSeconds = int.Parse(Console.ReadLine());
//             //var timeInSeconds = int.Parse(Console.ReadLine());
//         //TODO: Implementar a formula para calcular as horas.
//             var hours = timeInSeconds / 3600 ;
//             timeInSeconds = timeInSeconds % ( 3600 );
           
//         //TODO: Implementar a formula para calcular as horas.
//             var minutes = timeInSeconds / 60;
//             var seconds = timeInSeconds % 60;

//             Console.WriteLine($"{hours}:{minutes}:{seconds}");
//         }
//     }


// using System;

// TODO: Complete os espaços em branco com uma possível solução para o problema. 
// class MinhaClasse {
//   public static void Main (string[] args) {
//     string[] line1 = Console.ReadLine().Split(" ");
//     string[] line2 = Console.ReadLine().Split(" ");
    
//     int finalExpediente = int.Parse(line1[0]);
    
//     int presente1 = int.Parse(line2[0]);
//     int presente2 = int.Parse(line2[1]);

//         int totalNecessario = presente1 + presente2;

//         if ( totalNecessario > finalExpediente )
//     {
//       Console.WriteLine("Deixa para amanha!");
//     }
//     else
//     {
//       Console.WriteLine("Farei hoje!");
//     }
//   }
// }