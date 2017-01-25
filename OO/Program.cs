using OO.Class.Associacoes;
using OO.Class.Encapsulamento;
using OO.Class.Heranca;
using System;

namespace OO
{
    class Program
    {
        static void Main(string[] args)
        {
            TestarHerancaEPolimorfismo();
            Console.ReadKey();            
        }

        private static void TentarTrocarClienteAposConverterOrcamentoEmPedido()
        {

            var joao = new Cliente("João", "123", new DateTime(1980, 1, 1));
            var jose = new Cliente("José", "456", new DateTime(1980, 1, 1));

            Console.WriteLine(string.Format("Criando o orçamento para o {0}.", joao.Nome));
            var orcamento = new Orcamento(joao);

            Console.WriteLine("Convertendo o orçamento em Pedido.");
            orcamento.ConverterEmPedido();

            try
            {
                Console.WriteLine(string.Format("Tentando trocar o Cliente para o {0}...", jose.Nome));
                orcamento.TrocarCliente(jose);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void TestarAssociacaoAgregacaoComposicaoOrcamento()
        {
            var cliente = new Cliente("João", "123", new DateTime(1980, 1, 1));
            Console.WriteLine(string.Format("João, sem nenhum orçamento associado: {0}.", cliente.Orcamentos.Count));
            Console.WriteLine("-------------------");

            var dell = new Marca(1, "Dell");
            var hp = new Marca(2, "HP");

            var mouse = new Produto(1, "Mouse", 5, 10, dell);
            var teclado = new Produto(2, "Teclado", 10, 20, hp);

            var orcamento = new Orcamento(cliente);
            orcamento.AdicionarItem(mouse, 2);
            orcamento.AdicionarItem(teclado, 1);
            Console.WriteLine(string.Format("João, com 1 orçamento associado: {0}.", cliente.Orcamentos.Count));
            Console.WriteLine("-------------------");

            Console.WriteLine("Produtos:");
            foreach (var item in orcamento.Itens)
            {
                Console.WriteLine(string.Format("Item {0}, valor {1}, marca {2}", item.Produto.Descricao, item.Preco, item.Produto.Marca.Descricao));
            }
            Console.WriteLine("-------------------");

            orcamento.Dispose();
            orcamento = null;

            Console.WriteLine("Orçamento e itens (composição) não existem mais. Mas o João continua existindo (agregação).");
            Console.WriteLine("-------------------");
        }

        private static void TestarAssociacaoAgregacaoComposicaoEquipe()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Teste de agregação - associação todo-parte fraca");

            var neymar = new Jogador("Neymar Jr", 11);
            var suarez = new Jogador("Luis Suárez", 9);
            var messi = new Jogador("Lionel Messi", 10);
            var barcelona = new Equipe("Futbol Club Barcelona");
            barcelona.AdicionarJogador(neymar);
            barcelona.AdicionarJogador(suarez);
            barcelona.AdicionarJogador(messi);

            Console.WriteLine("Barcelona é o todo. Os Jogadores são partes que compõe o todo.");
            Console.WriteLine(barcelona);

            barcelona.Dispose();
            Console.WriteLine("Dispose no Barcelona, que deixou de existir...");
            Console.WriteLine("Mas os jogadores não:");
            Console.WriteLine(neymar.Nome);
            Console.WriteLine(suarez.Nome);
            Console.WriteLine(messi.Nome);

            Console.WriteLine("-------------------");

            var cr7 = new Jogador("Cristiano Ronaldo", 7);
            var bale = new Jogador("Gareth Bale", 11);
            var benzema = new Jogador("Karim Benzema", 9);
            var realMadrid = new Equipe("Real Madrid Club de Fútbol");
            realMadrid.AdicionarJogador(cr7);
            realMadrid.AdicionarJogador(bale);
            realMadrid.AdicionarJogador(benzema);

            Console.WriteLine("Real Madrid é o todo. Os Jogadores são partes que compõe o todo.");
            Console.WriteLine(realMadrid);

            realMadrid.Dispose();
            Console.WriteLine("Dispose no Real Madrid, que deixou de existir...");
            Console.WriteLine("Mas os jogadores não:");
            Console.WriteLine(cr7.Nome);
            Console.WriteLine(bale.Nome);
            Console.WriteLine(benzema.Nome);
            Console.WriteLine("-------------------");
        }

        private static void TestarEncapsulamento()
        {
            var pessoa1 = new PessoaSemEncapsulamento();
            pessoa1.Nome = "A";
            pessoa1.DataNascimento = DateTime.Now.AddDays(7);

            Console.WriteLine("-------------------");
            Console.WriteLine("Pessoa 1");
            Console.WriteLine(string.Concat("Nome: ", pessoa1.Nome));
            Console.WriteLine(string.Concat("Data de nascimento: ", pessoa1.DataNascimento));
            Console.WriteLine("-------------------");

            ///////////////////////////////////////////

            var pessoa2 = new PessoaComEncapsulamento();

            Console.WriteLine("-------------------");
            Console.WriteLine("Pessoa 2");

            try
            {
                pessoa2.AtribuirNome("A");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(string.Concat("Erro: ", ex.Message));
            }

            pessoa2.AtribuirNome("José");
            try
            {
                pessoa2.AtribuirDataNascimento(DateTime.Now.AddDays(1));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(string.Concat("Erro: ", ex.Message));
            }

            pessoa2.AtribuirDataNascimento(DateTime.Now.AddYears(-10));

            Console.WriteLine(string.Concat("Nome: ", pessoa2.Nome));
            Console.WriteLine(string.Concat("Data de nascimento: ", pessoa2.DataNascimento));
            Console.WriteLine("-------------------");
        }

        private static void TestarHerancaEPolimorfismo()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Exemplo Herança e Polimorfismo");
            Console.WriteLine("-------------------");

            Console.WriteLine("-------------------");
            Console.WriteLine("Conta poupança");
            var contaPoupanca = new ContaPoupanca(DateTime.Now, 100);

            Console.WriteLine("Depositando 100,00 na conta poupança...");
            contaPoupanca.Depositar(100);

            Console.WriteLine("Saque de R$ 70,00.");
            contaPoupanca.Sacar(70);

            Console.WriteLine(string.Format("Novo saldo: {0}", contaPoupanca.ObterSaldo().ToString("###,##0.00")));
            try
            {
                Console.WriteLine("Tentando sacar 131,00...");
                contaPoupanca.Sacar(131);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(string.Format("Saldo da conta poupança: {0}", contaPoupanca.ObterSaldo().ToString("N2")));
            }
            Console.WriteLine("-------------------");

            Console.WriteLine("-------------------");
            Console.WriteLine("Conta corrente sem limite");

            var ccSemLimite = new ContaCorrente(DateTime.Now, 0);
            Console.WriteLine("Depositando 100,00 na conta corrente...");
            ccSemLimite.Depositar(100);

            Console.WriteLine("Saque de R$ 50,00");
            ccSemLimite.Sacar(50);

            Console.WriteLine(string.Format("Saldo: {0}", ccSemLimite.ObterSaldo().ToString("N2")));

            try
            {
                Console.WriteLine("Tentando sacar mais R$ 51,00 da conta corrente...");
                ccSemLimite.Sacar(51);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(string.Format("Saldo da conta corrente: {0}", ccSemLimite.ObterSaldo().ToString("N2")));
            }
            

            Console.WriteLine("-------------------");

            Console.WriteLine("-------------------");
            Console.WriteLine("Conta corrente com limite");
            var ccComLimite = new ContaCorrente(DateTime.Now, 0);

            Console.WriteLine("Depositando 100,00 na conta corrente...");
            ccComLimite.Depositar(100);
            Console.WriteLine(string.Format("Saldo da conta corrente antes do limite: {0}", ccComLimite.ObterSaldo().ToString("N2")));

            Console.WriteLine("Definindo limite de 50,00 na conta corrente...");
            ccComLimite.DefinirLimite(50);
            Console.WriteLine(string.Format("Saldo da conta corrente depois do limite: {0}", ccComLimite.ObterSaldo().ToString("N2")));

            Console.WriteLine("Tentando sacar 101,00 da conta corrente...");
            ccComLimite.Sacar(101);
            Console.WriteLine(string.Format("Saldo da conta corrente depois do saque: {0}", ccComLimite.ObterSaldo().ToString("N2")));
            Console.WriteLine("-------------------");
        }

    }
}
