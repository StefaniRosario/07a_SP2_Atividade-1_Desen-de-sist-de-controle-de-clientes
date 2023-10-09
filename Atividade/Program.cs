using System;//bliblioteca System. Os comandos vão buscar neste biblioteca. Entrada e saída de dados
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        //main significa que tudo que está dentro dele será executado
        {
            //essa variavel é o tipo pessoa fisica. Vai copiar a classe de PF para dentro deste local
            // variavel do tipo PF , da classe PF
            float val_pag;
            Console.WriteLine("Informar Nome");//Serve para imprimir um número na tela e LINE, faz ele pular a linha
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa física (f) ou Pessoa Jurídica(j)?");
            string var_tipo = Console.ReadLine();
            if(var_tipo == "f")
            {
                //------Pessoa Física------
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar o valor da compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("_______Pessoa Física_______:");
                Console.WriteLine("Nome.............: " + pf.nome);
                Console.WriteLine("Endereço.........: " + pf.endereco);
                Console.WriteLine("CPF..............: " + pf.cpf);
                Console.WriteLine("RG...............: " + pf.rg);
                Console.WriteLine("Valor da Compra..: " + pf.valor.ToString("C"));
                //ToString "C" significa que irá transformar em moedas R$
                Console.WriteLine("Impostos.........: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar....: " + pf.total.ToString("C"));
            }
            if(var_tipo == "j")
            {
                //Pessoa Juridica
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar Valor da Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("_______Pessoa Jurídica_______:");
                Console.WriteLine("Nome.............: " + pj.nome);
                Console.WriteLine("Endereço.........: " + pj.endereco);
                Console.WriteLine("CNPJ.............: " + pj.cnpj);
                Console.WriteLine("IE...............: " + pj.ie);
                Console.WriteLine("Valor da Compra..: " + pj.valor.ToString("C"));
                //ToString "C" significa que irá transformar em moedas R$
                Console.WriteLine("Impostos.........: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar....: " + pj.total.ToString("C"));

            }
        }
    }
}