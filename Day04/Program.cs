using System;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero inicial: ");
            var numeroInicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o numero final  : ");
            int numeroFinal = Convert.ToInt32(Console.ReadLine()); 
            int indice = numeroInicial;

            Console.WriteLine($"WHILE FROM {numeroInicial} TO {numeroFinal}:");
            while (indice <= numeroFinal){
                Console.WriteLine(indice);
                indice ++;
            }            
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"DO FROM {numeroInicial} TO {numeroFinal}:");
            indice = numeroInicial;
            do{
                Console.WriteLine(indice);
                indice++;
            }while(indice <= numeroFinal);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine($"FOR FROM {numeroInicial} TO {numeroFinal}:");
            for(int i = numeroInicial; i<= numeroFinal; i++){
                Console.WriteLine(i);
            }            
            Console.ReadKey();
            Console.Clear();

            
            //foreach is used in collections, arrays
            int[] itens = new int[10] {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine($"FOREACH FROM {itens[0]} TO {itens[9]}:");
            foreach(int item in itens){
                Console.WriteLine(item);
            }
            
            Console.ReadKey();
            Console.Clear();
            //return - interrompe a execucao atual e vai para o proximo loop
            //break - encerra o break
            while (true){
                Console.WriteLine("1 - sair \n2 - continuar");
                Console.Write("> ");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(option);
                if (option == 1){
                    Console.Write("executando o break");
                    break;                    
                }else if (option == 2){                    
                    Console.WriteLine("Executando continue - Oppa passou por aq");
                    continue;
                }
            }
        }
    }
}
