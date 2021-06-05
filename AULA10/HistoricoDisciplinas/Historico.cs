using System;
using System.Collections.Generic;
using System.Text;

namespace HistoricoDisciplinas{
    class Historico{
        private Disciplina[] vet;
        private int qtd;

        public Historico(){
            vet = new Disciplina[100];
            qtd = 0;
        }

        public void Inserir(Disciplina d){
            vet[qtd] = d;
            qtd++;
        }

        private int ObterIndice(int codigo){
            int i = 0;
            bool achou = false;

            while(i < qtd && !achou){
                if(vet[i].Codigo == codigo){
                    achou = true;
                } else{
                    i++;
                }
            }
            return achou ? i : -1;
        }

        public void Remover(int codigo){
            int pos = ObterIndice(codigo);
            if(pos > -1){
                for(int i = pos; i < qtd; i++){
                    vet[i - 1] = vet[i];
                }
                qtd--;
            }
        }

        public void Alterar(int codigo, Disciplina d){
            int pos = ObterIndice(codigo);
            if(pos > -1){
                vet[pos] = d;
            }
        }

        public void Listar(){
            Console.WriteLine("{0, -30}{1}{2}", "Nome", "Cred", "Media");
            for(int i = 0; i < qtd; i++){
                Console.WriteLine("{0, -30} {1:00} {2:00.00}", vet[i).Nome, vet[i].Creditos, vet[i].Media());
            }
        }

        public void ListarTipo2(){
            Console.WriteLine("{0, -30}{1}{2}", "Nome", "Cred", "Media");
            for(int i = 0; i < qtd; i++){
                if(vet[i] is DisciplinaTipo2){
                    Console.WriteLine("{0, -30} {1:00} {2:00.00}", vet[i].Nome, vet[i].Creditos, vet[i].Media());
                }
            }
        }

        public void ListarTipo3(){
            Console.WriteLine("{0, -30}{1}{2}", "Nome", "Cred", "Media");
            for(int i = 0; i < qtd; i++){
                if(vet[i] is DisciplinaTipo3 && (vet[i] as DisciplinaTipo3).NotaApresentacao > 7){
                    Console.WriteLine("{0, -30} {1:00} {2:00.00}", vet[i].Nome, vet[i].Creditos, vet[i].Media());
                }
            }
        }
    }
}