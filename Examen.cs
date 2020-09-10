using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Examen{

    class Examen{
        class Nodo{

            public string Nombre;
            public string Apllido;
            public string Id;
            public double Hrtrabajadas;
            public Nodo siguiente;
        }
        private Nodo raiz, fondo;

        public Examen(){
            raiz = null;
            fondo = null;
        }

        public bool vacia(){
            if (raiz == null)
            return true;
            else
            return false;
        }

        public void AgregarInfo(string Nombre, string Apellido, int Id, double Hrtrabajadas){
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.Nombre = Nombre;
            nuevo.Apllido = Apellido;
            nuevo.Id = Id;
            nuevo.Hrtrabajadas = Hrtrabajadas;
            nuevo.siguiente = null;

            if (vacio()){
                raiz = nuevo;
                fondo = nuevo;
            }else{
                fondo.siguiente = nuevo;
                fondo = nuevo;
            }
        }

        public void Mostrar(){
            Nodo dato = raiz;
            Console.WriteLine("Empleados");
            while(dato != null){
                Console.WriteLine("Nombre " + dato.Nombre + "\n" +
                                  "Apellido " + dato.Apllido + "\n" +
                                  "Id " + dato.Id + "\n" + 
                                  "Horas trabajadas " + dato.Hrtrabajadas + "horas");
                Console.WriteLine("---------------------------------------------------");
                dato = dato.siguiente;
            }
            Console.WriteLine();
        }

        double PagoDiario;

        public void PagoDiario(int salario){
           Nodo Salario = raiz;
           Console.WriteLine("el pago diario de los trabajadores  \n");
           while(salario != null){
               PagoDiario = Salario.Hrtrabajadas * 365;
               Console.WriteLine("salario de " + Salario.Nombre + " es de " + PagoDiario);
               Console.WriteLine("-------------------------------------");
               Salario = Salario.siguiente;
           }
        }
        static void Main(string[] args){
            Examen Cola = new Examen();
            Cola.AgregarInfo("Manuel", "Rodriguez", 11065071193, 65);
            Cola.AgregarInfo("Carolina", "Torrez", 100650543578, 120);
            Cola.Mostrar;
            Cola.PagoDiario;

        }
    }
}