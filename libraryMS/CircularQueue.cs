using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryMS
{
    public class CircularQueue
    {
        private BookWaiter[] data;
        public int Front;
        private int Rear;
        public int Size;

        public CircularQueue(int size)
        {
            this.Size = size;
            data = new BookWaiter[Size];
            Front = -1;
            Rear = -1;
        }

        public void EnQueue(BookWaiter value)
        {
            if (Front == -1 && Rear == -1)
            {
                Front = Rear = 0;
                data[Rear] = value;
            }
            else if (((Rear + 1) % Size) == Front)
            {
                Console.WriteLine("over flow!");
            }
            else
            {
                Rear = (Rear + 1) % Size;
                data[Rear] = value;
            }
        }

        public void DeQueue()
        {
            if (Front == -1 && Rear == -1)
            {
                Console.WriteLine("empty queue!");
            }
            else if (Front == Rear)
            {
                Console.WriteLine("relavant request removed!");
                Front = Rear = -1;
            }
            else
            {
                Console.WriteLine("relavant request removed!");
                Front = (Front + 1) % Size;
            }
        }

        public void Display()
        {
            int i = Front;
            if (Front == -1 && Rear == -1)
            {
                Console.WriteLine("empty queue!");
            }
            else
            {
                Console.WriteLine("{0,-10}  {1,-35}  {2,-30}","Waiter","BookWaitFor","Date of Request");
                Console.WriteLine();
                while (i != Rear)    // condition of i==Rear can be true if there is only one value within the queue
                {
                    Console.WriteLine("{0,-10} | {1,-35} | {2,-30}", data[i].WaiterId, data[i].BookWaitFor, data[i].RequestedDay);
                    i = (i + 1) % Size;
                }
                Console.WriteLine("{0,-10} | {1,-35} | {2,-30}", data[Rear].WaiterId, data[Rear].BookWaitFor, data[Rear].RequestedDay);

            }
        }


        public BookWaiter? DeQueueObjReturn()
        {
            if (Front == -1 && Rear == -1)
            {
                return null;
            }
            else if (Front == Rear)
            {
                int temp=Front;
                Front = Rear = -1;
                return data[temp];
            }
            else
            {
                int temp = Front;
                Front = (Front + 1) % Size;
                return data[temp];
            }
        }

        //public void Peek()
        //{
        //    if (Front == -1 && Rear == -1)
        //    {
        //        Console.WriteLine("empty queue!");
        //    }
        //    else
        //    {
        //        Console.WriteLine(data[Front]);
        //    }
        //}

    }
}
