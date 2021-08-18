# challenge_21_days_api_creation

CHALLENGE 21 DAYS OF C# API CREATION

criar estrutura git

aplicar TDD

criar classe Aluno.cs

- Assistir  aula 06 funcoes e aula 19 propriedades

#propriedades complexas
private string _name;

public string Name{
get{
return this._name;
}
set{
this.set = _name;
}

se nao for tratar nd pode usar a propriedade padrao
public string Name {get;set;}


a nao ser q va tratar
public string Name{
get{
return this._name.ToLower();
}
set{
this.set = _name.ToUper;
}


public string Matriculca {get; set;}

public List<double> Notas{get; set;}


2 tipos de objetos 
entidade ou ojeto com propriedade e metodo


entidade e servico

DDD e SOLID

se tivesse metod para gravar no bd ou enviar email eu teria um servico para fazer isso aq

public class Curso



para corrigir oerro de null

criar 

private List<double> notas;
public List<double> Notas{

get{//return this.notas
	if (this.notas == null){
		this.notas = new List<double> (); 
	}
set{
	this.notas = value
}


fazer TDD


heranca
polimorfismo

