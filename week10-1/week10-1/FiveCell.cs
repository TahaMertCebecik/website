using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week10_1
{
    public class FiveCell
    {
        const int CAPACITY = 5; 
        private int[] items;
        public int Count { get; set; }

        public FiveCell()
        {
            items = new int[CAPACITY];
            Count = 0;
            for (int i = 0; i < CAPACITY; i++)
                items[i] = -1;
        }

        public void Add(uint item)
        {
            if (Count == CAPACITY)
                throw new Exception("Cells are full");

            items[Count] = (int) item;
            Count++;
        }

        public int this[int index]   // get:  fivecell[3]       set: fivecell[3] = 1123 
        {
            get { return items[index]; }
            set { items[index] = value;  }
        }

      
    }

    public class FiveCell<T>
    {
        const int CAPACITY = 5;
        private T[] items;

        public int Count { get; set; }

        public FiveCell()
        {
            items = new T[CAPACITY];
            Count = 0;
        }

        public void Add(T item)
        {
            if (Count == CAPACITY)
                throw new Exception("Cells are full");

            items[Count] = item;
            Count++;
        }

        public T this[int index]   // get:  fivecell[3]       set: fivecell[3] = 1123 
        {
            get { return items[index]; }
            set { items[index] = value; }
        }
    }
}
