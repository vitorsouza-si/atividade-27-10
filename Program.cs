class Animal{
    public string Nome { get; private set;}
    public int Idade { get; private set;}


public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

public virtual string EmitirSom()
  (
    return ("O animal emite som.");
  )

}

class Cachorro : Animal {
    public Cachorro string (Nome, int idade)
}