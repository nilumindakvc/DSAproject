using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMS
{
    public class DynamicArray<T>   //Template class to store objects of different classes
    {
        private int capacity;
        public int count;
        private T[] data;

        public DynamicArray()
        {
            capacity = 5;
            count = 0;
            data = new T[capacity];
        }

        public void Add(T? value)
        {
            if(value == null)
            {
                return;
            }
            if (count == capacity)
            {
                capacity *= 2;
                T[] newarray = new T[capacity];
                Array.Copy(data, newarray, data.Length);
                data = newarray;

            }
            data[count] = value;
            count++;

        }

        public T GetObj(int index)
        {
            return data[index];
        }

        public void Remove(int index)
        {
            if (count == 0)
            {
                Console.WriteLine("nothing in array");
                return;
            }
            for (int i = index; i < count - 1; i++)
            {
                data[i] = data[i + 1];
            }
            count--;
            this.Srink();
        }

        public void Srink()
        {
            if (count < capacity / 4)
            {
                capacity = capacity / 2;
                T[] newarray = new T[capacity];
                Array.Copy(data, newarray, data.Length / 2);
                data = newarray;


            }
        }



        //public void Print()
        //{
        //    if (count == 0)
        //    {
        //        Console.WriteLine("empty array");
        //        return;
        //    }
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.Write($"{data[i]}  ");
        //    }
        //    Console.WriteLine();
        //}

        public int ArrayCapacity()
        {
            return capacity;
        } 
    }
    

    
}
