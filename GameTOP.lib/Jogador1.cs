namespace GameTOP.lib
{

public class Jogador1 : IJogador
{
    public readonly string _Nome;

        public Jogador1()
        {
        }

        public Jogador1(string nome = "RC") => _Nome = nome;

        public string Chuta() => $"{_Nome} está Chutando!";

        public string Corre() => $"{_Nome} está Correndo!";

        public string Passe() => $"{_Nome} está Passando!";
    }
}