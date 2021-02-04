using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace Desafio2e3
{
    public class VideoGame : Produto
    {
        // 1. Atributos da classe
        private String marca;
        private String modelo;
        private boolean isUsado;
 
        // 2. Métodos construtores
        public VideoGame() { }
 
        public VideoGame(String marca, String modelo, int isUsado)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }
 
        //3. Métodos acessores
        public void setmarca(String marca)
        {
            this.marca = marca;
        }
 
        public String getmarca()
        {
            return this.marca;
        }
 
        public void setmodelo(String modelo)
        {
            this.modelo = modelo;
        }
 
        public String getmodelo()
        {
            return this.modelo;
        }
 
        public void setisUsado(int isUsado)
        {
            this.isUsado = isUsado;
        }
 
        public int getisUsado()
        {
            return this.isUsado;
        }
    }
}