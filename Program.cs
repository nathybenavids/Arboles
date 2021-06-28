using System;

namespace Program
{
    public class Arbol
    {
        class Nodo
        {
            public int info;
            public Nodo izq, der;
        }
        Nodo raiz;

        public Arbol()
        {
            raiz = null;
        }

        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }


        private void ImprimirAnterior(Nodo reco)
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirAnterior(reco.izq);
                ImprimirAnterior(reco.der);
            }
        }

        public void ImprimirAnterior()
        {
            ImprimirAnterior(raiz);
            Console.WriteLine();
        }

        private void ImprimirMedio(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirMedio(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirMedio(reco.der);
            }
        }

        public void ImprimirMedio()
        {
            ImprimirMedio(raiz);
            Console.WriteLine();
        }


        private void ImprimirDespues(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirDespues(reco.izq);
                ImprimirDespues(reco.der);
                Console.Write(reco.info + " ");
            }
        }


        public void ImprimirDespues()
        {
            ImprimirDespues(raiz);
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Arbol abo = new Arbol();
            abo.Insertar(100);
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
            Console.WriteLine("Orden anterior: ");
            abo.ImprimirAnterior();
            Console.WriteLine("Orden en medio: ");
            abo.ImprimirMedio();
            Console.WriteLine("Orden posterior: ");
            abo.ImprimirDespues();
            Console.ReadKey();
        }
    }
}
