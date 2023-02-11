using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    //PUNTO 2) 
    internal class Telefono 
    {
        //PUNTO 5 -Constructor
        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            this.marca = marca;
        }

        //PUNTO 3) -Atributos o Miembros; 
        private string modelo;
        private string marca;
        private string numero;
        private int codigoOperador;

        //PUNTO 4) -Propiedades-
        //metodo corto (lectura)
        public string Modelo { get ; }

        //metodo largo (lectura)
        public string Marca
        {
            get { return marca; }
        }

        
        //metodo largo lectura y escritura
        public string Numero
        {
            get { return numero; }
            set { numero = value;}
        }


        //metodo largo validando el ingreso de 1, 2 ó 3.
        public int CodigoOperador
        {
            get { return codigoOperador;}
            set {
                
                 if(codigoOperador == 1 || codigoOperador == 2 || codigoOperador == 3)
                    {
                     codigoOperador = value;
                    }

                 else
                    {
                       codigoOperador = 0;
                    }                        
                        
                }
        }


        // PUNTO 7 -Crear metodo llamar-
        public string llamar ()
        {
            return "Realizando LLamada.....";
        }

        //PUNTO 8 -Sobrecarga de metodo
        public string llamar (string contacto)
        {
            return "Llamando a ...." + contacto;
        }
        
        



    }
}
