using System;
namespace GenericsQuestion21
{
	public class MyGenericClass<T> where T: struct
    {
        // define an array of Generic type with length 5
        private T[] arr = new T[5];
        int count = 0;

        // adding items mechanism into generic type
        public void Add(T item)
        {
            //checking length
            if (count + 1 < 6)
            {
                arr[count] = item;

            }
            count++;
        }

        //indexer for foreach statement iteration
        public T this[int index]
        {
            get { return arr[index]; }

            set { arr[index] = value; }
        }

        // sort descending

    }
}

