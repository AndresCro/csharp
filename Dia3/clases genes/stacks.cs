using System;
using System.Collections.Generic;
using System.Text;

namespace clases_genes
{
    class stacks<T>
    {
        private int position = 0;
        private T[] datos;

        public stacks(int tamanio)
        {
            datos = new T[tamanio];
        }

        public void Push(T objeto)
        {
            datos[position++] = objeto;
        }

        public T Pop()
        {
            return datos[--position];
        }
    }
}
