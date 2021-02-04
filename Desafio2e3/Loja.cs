using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Desafio2
{
    public class Loja
    {
        private String nome;
        private String cnpj;
        private List<Livro>livros;
        private List<VideoGame>videoGames;
 
        public Loja() { }
 
        public Loja(String nome, String cnpj, int videoGamesList)
        {
            this.nome = nome;
            this.cnpj = cnpj;
            this.videoGamesList = videoGamesList;
        }
 
        public void setnome(String nome)
        {
            this.nome = nome;
        }
 
        public String getnome()
        {
            return this.nome;
        }
 
        public void setcnpj(String cnpj)
        {
            this.cnpj = cnpj;
        }
 
        public String getcnpj()
        {
            return this.cnpj;
        }
 
        public void setvideoGamesList(int videoGamesList)
        {
            this.videoGamesList = videoGamesList;
        }
 
        public int getvideoGamesList()
        {
            return this.videoGamesList;
        }
        public void setvideoGamesList(int videoGamesList)
        {
            this.videoGamesList = videoGamesList;
        }
 
        public int getvideoGamesList()
        {
            return this.videoGamesList;
        }

        public void listaLivros(){
            livroList.ToList().ForEach(Console.WriteLine);
        }
        public void listavideoGames(){
            videoGameList.ToList().ForEach(Console.WriteLine);
        }

        public double calculaPatrimonio(){
            double valorTotal = this.qtdTotal + (this.preco * this.qtd)
        }

    
    }
}
