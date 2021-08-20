# API em C# | Desafio 21 dias [DIA 02 - Loop, Array e Lista dinamica]

#### CRIAR O PROJETO

> mkdir console_desafio_21dias 

> cd console_desafio_21dias 

> dotnet new console 

> dotnet run


#### CRIAR A CLASSE ALUNO
```
public class Aluno{
#propriedades complexas
private string _name;

public string Name{
get{
return this._name;
}
set{
this.set = _name;
}

public string Matriculca {get; set;}

public List<double> Notas{get; set;}
}
```
Obs.: Se nao for tratar os atributos pode usar a propriedade padrao
public string Name {get;set;}

Mas se for tratar o atributo deve-se usar propriedades complexas
```
public string Name{
get{
	return this._name.ToLower();
}
set{
	this.set = _name.ToUper;
}
```
Obs. Existem dois tipos de objetos: entidade ou ojeto com propriedade e metodo 
	
O Servico e usado em caso da necessidade de um metodo para gravar no BD ou enviar email sera necessaio criar um servico responsavel por estas acoes

Obs.: Correcao do erro null
```
//atributo
private List<double> notas;
//propriedade
public List<double> Notas{
	get{
		if (this.notas == null){
			this.notas = new List<double> (); 
	}
	set{
		this.notas = value
	}
}
```	
#### CONCEITOS 
- TDD
- DDD, SOLID
- CLASSES, PROPRIEDADES E METODOS
- OO (heranca, polimorfismo, encapsulamento, e abstracao)

#### ASSISTIR
- aula 06 funcoes e aula 19 propriedades


