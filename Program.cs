internal class Program
{

    static void CadastrarNotas(double[] notasAlunos)
    {
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Informe a nota do {i + 1} aluno: ");
            notasAlunos[i] = double.Parse(Console.ReadLine());
        }
    }

    static double CalcularMediaDeNota(double[] notasAlunos)
    {
        double somaMedia = 0;
        for(int i = 0; i < notasAlunos.Length; i++)
        {
            somaMedia = somaMedia + notasAlunos[i];
        }

        somaMedia = somaMedia / 5;

        return somaMedia;
    }

    static void MostarSituacao(double[] notasAlunos)
    {
        for(int i = 0; i < notasAlunos.Length; i++)
        {
            if(notasAlunos[i] >= 7)
            Console.WriteLine($"Aluno {i + 1} aprovado.");
            else
            Console.WriteLine($"Aluno {i + 1} reprovado");
        }
    }
    private static void Main(string[] args)
    {
        double[] notasAlunos = new double [5];
        int opcao;

        
        do
        {
        Console.WriteLine(" 1 - Cadastrar notas \n 2 - Ver média da turma \n 3 - Ver situação Alunos \n 0 - sair");
        Console.WriteLine("Escolha umas das opções abaixo");
        opcao = int.Parse(Console.ReadLine());

        if(opcao == 1)
            {
                Console.Clear();
                CadastrarNotas(notasAlunos);
            }
        else if (opcao == 2)
            {
                Console.Clear();
                Console.WriteLine($"A média da turma é {CalcularMediaDeNota(notasAlunos)}");
            }
            else if(opcao == 3)
            {
                Console.Clear();
                MostarSituacao(notasAlunos);
            }
        }
        while(opcao != 0);
        
    }
}