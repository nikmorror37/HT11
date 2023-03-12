using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT11
{
    public class GenericArray<T>
    {
        private T[] array;
        private int currentIndex;
        public GenericArray()
        {
            array = new T[10];
            currentIndex = 0;
        }
        public void AddElement(T element)
        {
            try
            {
                array.SetValue(element, currentIndex);
                currentIndex++;
            }
            catch (IndexOutOfRangeException) 
            { 
                Console.WriteLine($"Количество элементов в массиве не может быть больше {currentIndex}"); 
            }
        }
        public void GetElement(int index)
        {
            try 
            {
                Console.WriteLine((T)array.GetValue(index)); 
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Запрашиваемый индекс вне границ массива");
            }
            
        }
        public void CountElements()
        {
            Console.WriteLine($"Количество элементов в массиве: {currentIndex}");
        }
    }

}
