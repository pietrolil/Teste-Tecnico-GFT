using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Desafio2e3
{
    public class Livro : Produto
    {
        private String autor;
        private String tema;
        private int qtdPag;
 
        public Livro() { }
 
        public Livro(String autor, String tema, int qtdPag)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPag = qtdPag;
        }
 
        public void setautor(String autor)
        {
            this.autor = autor;
        }
 
        public String getautor()
        {
            return this.autor;
        }
 
        public void settema(String tema)
        {
            this.tema = tema;
        }
 
        public String gettema()
        {
            return this.tema;
        }
 
        public void setqtdPag(int qtdPag)
        {
            this.qtdPag = qtdPag;
        }
 
        public int getqtdPag()
        {
            return this.qtdPag;
        }

    
    }
}