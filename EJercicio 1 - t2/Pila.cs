using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJercicio_1___t2
{
    internal class Pila
    {
        private Nodo vinicio;
        public Nodo inicio
        {
            get { return vinicio; }
            set { vinicio = value; }
        }

        public Pila()
        {
            inicio = null;
        }

        public bool esVacia()
        {
            if (inicio == null)
            {
                return true;
            }
            else
                return false;
        }
        public void push(int valor)
        {
            Nodo nuevo = new Nodo(valor);
            nuevo.sgte = inicio;
            inicio = nuevo;

        }
        public int pop()
        {
            int x;
            x = inicio.info;
            inicio = inicio.sgte;
            return x;
        }
        public void mostrar(ListBox lst)
        {
            Nodo actual = inicio;
            lst.Items.Clear();
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }

        public int contador ()
        {
            Pila aux = new Pila();
            int c = 0;
            Nodo actual = inicio;
            while (actual != null)
            {
                aux.push(actual.info);
                actual = actual.sgte;
                c++;
            }
            Nodo actual1 = aux.inicio;
            while (actual1 != null)
            {
                push(actual1.info);
                actual1 = actual1.sgte;
            }
           return c;

        }

        public int Fondo ()
        {
            int x;
            while (inicio.sgte != null)
            {
                inicio = inicio.sgte;
            }
            x = inicio.info;
            return x;
        }
        public void desapilar (int x, ListBox lst, Pila aux)
        {
            if (contador() < x)
            {
                lst.Items.Clear();
                mostrar(lst);
            }
            else
            {
               int k = 0;
               while (k != x)
               {
                    aux.push(pop());
                    k++;
               }
                lst.Items.Clear();
                aux.mostrar(lst);
            }
        }
    }
}
