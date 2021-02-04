using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Desafio2e3
{
    public abstract class Produto
    {
        
        private String _nome;
        private double _preco;
        private int _qtd;
        private static int _qtdTotal;
 
        
        public Pessoa() { }
 
        public Pessoa(String _nome, String _preco, int _qtd)
        {
            this._nome = _nome;
            this._preco = _preco;
            this._qtd = _qtd;
            this._qtdTotal += _qtd;
        }
 
        public void set_Nome(String _nome)
        {
            this._nome = _nome;
        }
 
        public String get_Nome()
        {
            return this._nome;
        }
 
        public void setPreco(String _preco)
        {
            this._preco = _preco;
        }
 
        public String getPreco()
        {
            return this._preco;
        }
 
        public void set_Qtd(int _qtd)
        {
            this._qtd = _qtd;
        }
 
        public int get_Qtd()
        {
            return this._qtd;
        }

        public abstract double calcularImposto(){

            if(this.tema == "educativo"){
                Console.WriteLine(preco);
            }else if(this.isUsado == true){
                Console.WriteLine(preco * 0.25);
            }else if(this.isUsado == false){
                Console.WriteLine(preco * 0.45);
            }else{
                Console.WriteLine(preco.0.1);
            }

        
        
    }
    public void get_qtdTotal()
        {
            return this._qtdTotal;
        }
        
}

}