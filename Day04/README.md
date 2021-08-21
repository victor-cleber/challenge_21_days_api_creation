# API em C# | Desafio 21 dias [DIA 04 - Orientação a objetos]

#### CRIANDO O PROJETO
> cd  console_desafio_21dias

> dotnet new console --name Dia04
 
> dotnet run


#### TIPOS DE LOOPS EM c#

WHILE - ate que faca

``` 
static void Main(string[] args){
  Console.WriteLine("Digite o numero inicial: ");
  var numeroInicial = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Digite o numer final: ");
  int numeroFinal  = Convert.ToInt32(Console.ReadLine());
  int indice = numeroInicial;
  while (indice <= numeroFinal){
    Console.WriteLine(indice);
    indice ++;
  }
  Console.ReadKey();
}
```

DO WHILE - faca ate que
```
static void Main(string[] args){
  do{
    Console.WriteLine(indice)
    indice++
  }while(indice <= numeroFinal);
  Console.ReadKey();
}
```

FOR - faca durante 
```
static void Main(string[] args){
  for (int i = numeroInicial; i<= numeroFinal; i++){
    Console.Writeline(i);
  }
}
```

FOREACH - usado para colecoes, arrays
```
static void Main(string[] args){
  int[] itens = new int[10] {1,2,3,4,5,6,7,8,9,10];
  foreach(int item in itens){
    Console.WriteLine(item);
  }
}
```
Obs.:

return - interrompe a execucao atual do laco e vai para o proximo loop

break  - encerra o laco e vai para o proximo comando fora do laco

```
static void Main(string[] args){
  while (true){
    Console.Writeline("Digite \n para sair \n 0 para continuar};
    int sair = Convert.ToInt32(Console.Readline());
    if (sair == 1){
      break;
    }else if (sair ==2 ){
      continue;
      Console.Write("Oppa passou por aqui");
  }
}
```


#### INCREMENTOS

indice +=

indice -=

Obs.:
- DevOps precisa saber a fundo de Docker, Docker Compsose, Kubernets
- Desenvolvedor so precisa levantar o proprio ambiente no Docker sem muitos detalhes da administracao da infraestrutura
