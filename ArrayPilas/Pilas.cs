using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPilas
{
    public class Pilas
    {
        private string[] array;
        private int max;
        private int tope;
        public Pilas(int tamano)
        {
            array = new string[tamano];
            tope = 0;
            max = array.Length - 1;
        }
        //public bool ValidaVacio() 
        //{
        //    if(tope< 1)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public bool ValidaVacio()
        //{
        //    if (tope < 1)
        //        return true;
        //    else
        //        return false;
        //}
        private bool ValidaVacio()
        {
            return (tope < 1);
        }
        private bool ValidaLleno()
        {
            return (tope > max);
        }
        public void Agregar(string elemento)
        {
            try
            {
                if (ValidaLleno())
                {
                    throw new Exception("El arreglo esta lleno. ");
                }
                array[tope] = elemento;
                tope ++;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Eliminar()
        {
            try
            {
                if (ValidaVacio())
                {
                    throw new Exception("Esta vacío. ");
                }
                tope--;
                array[tope] = null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void Imprimir()
        {
            try
            {
                if (ValidaVacio())
                {
                    throw new Exception("Esta vacío. ");
                }
                for (int i = 0; i <= max; i++)
                {
                    Console.WriteLine(array[i]);
                } 
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
