using System;

namespace HistoricoDisciplinas{
    class HistoricoDisciplinas{
        private static int Menu(){
            int opc;

            do{
                Console.WriteLine("1: Inserir disciplina");
                Console.WriteLine("2: Remover disciplina");
                Console.WriteLine("3: Alterar disciplina");
                Console.WriteLine("4: Listar todas as disciplinas");
                Console.WriteLine("5: Listar todas as disciplinas do tipo 2");
                Console.WriteLine("6: Listar todas as disciplinas do tipo 3");
                Console.WriteLine("7: Sair");
                Console.Write("Entre com a sua opcao:\n");
                opc = int.Parse(Console.ReadLine());
            } while(opc < 1 || opc > 7);

            return opc;
        }

        private static Disciplina CriarDisciplina(){
            int tipo;

            do{
                Console.WriteLine("1: Disciplina tipo 1");
                Console.WriteLine("2: Disciplina tipo 2");
                Console.WriteLine("3: Disciplina tipo 3");
                Console.Write("Entre com o tipo da disciplina:\n");
                tipo = int.Parse(Console.ReadLine());
            } while(tipo < 1 || tipo > 3);

            switch(tipo){
                case 1: return new DisciplinaTipo1();
                case 2: return new DisciplinaTipo2();
                case 3: return new DisciplinaTipo3();
                default: return null;
            }
        }

        public static void Main(String[] args){
            Historico h = new Historico();
            Disciplina d;
            int codigo;
            bool fim = false;

            while(!fim){
                switch(Menu()){
                    case 1:
                        d = CriarDisciplina();
                        d.Ler();
                        h.Inserir(d);
                        break;
                    case 2:
                        Console.WriteLine("Digite o codigo da disciplina para remocao:\n");
                        codigo = int.Parse(Console.ReadLine());
                        h.Remover(codigo);
                        break;
                    case 3:
                        Console.WriteLine("Digite o codigo da disciplina para alteracao:\n");
                        codigo = int.Parse(Console.ReadLine());
                        d = CriarDisciplina();
                        d.Ler();
                        h.Alterar(codigo, d);
                        break;
                    case 4:
                        h.Listar();
                        Console.ReadKey();
                        break;
                    case 5:
                        h.ListarTipo2();
                        Console.ReadKey();
                        break;
                    case 6:
                        h.ListarTipo3();
                        Console.ReadKey();
                        break;
                    case 7:
                        fim = true;
                        break;
                }
            }
        }
    }
}