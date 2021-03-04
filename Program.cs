using retoP1.list;
using System;
using System.Collections.Generic;

namespace retoP1
{
    class Program
    {
        static void Main(string[] args)
        {


            LinkedList lista1 = new LinkedList();

            lista1.add(1);
            lista1.add(4);
            lista1.add(3);
            lista1.add(7);


            Console.WriteLine("El tamaño es " + lista1.getSize());

            //int data = lista1.get(2);
            //Console.WriteLine("El dato en 2 es:  " + data);

            for (int i = 0; i < lista1.getSize(); i++)
            {
                Console.WriteLine("El dato en " + i + "es: " + lista1.get(i));
            }

            //Console.WriteLine("-----------------------------");

            Iterator it = lista1.getIterator();
            ReverseIterator it2 = lista1.getReverseIterator();

            while (it.hasNext())
            {
                Iterator backupIt = new Iterator(it);
                int element = it.next(); //regresar el dato y avanzar el iterador

                if (element == 3)
                {
                    lista1.insert(10, LinkedList.BEFORE, backupIt);
                }

                if (element == 7)
                {
                    lista1.insert(15, LinkedList.AFTER, backupIt);
                }
            }

            Console.WriteLine("-----------------------------");
            Console.WriteLine("El tamaño es " + lista1.getSize());
            for (int i = 0; i < lista1.getSize(); i++)
            {
                Console.WriteLine("El dato en " + i + "es: " + lista1.get(i));
            }

            lista1.delete(1);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("El tamaño es " + lista1.getSize());

            for (int i = 0; i < lista1.getSize(); i++)
            {
                Console.WriteLine("El dato en " + i + "es: " + lista1.get(i));
            }

            Console.WriteLine("-----------------------------");

            it = lista1.getIterator();
            while (it.hasNext())
            {
                int element = it.next();

                Console.WriteLine("dato: " + element);
            }

            Console.WriteLine("-----------------------------");

            it2 = lista1.getReverseIterator();

            while (it2.hasNext())
            {
                int element = it2.previous();

                Console.WriteLine("Dato: " + element);
            }
        }
    }
}
