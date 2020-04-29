using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{


    public class ListB<T>
    {
        //member variables

        string stringOfList;
        public int arrayIndexer;
        public bool indexerSwitch = true;
        int count;
        public int Count
        {
            get
            {

                return this.count;
            }
            set
            {
                this.count = value;
            }
        }
        int capacity;
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        private T[] listArray;
        public T this[int number]
        {
            get
            {
                if (number >= 0 && number < Count)
                {
                    return listArray[number];
                }
                else
                {
                    throw new IndexOutOfRangeException("Out of range");
                }


            }
            set
            {

                listArray[number] = value;

            }
        }
        private T[] tempArray;




        //constructor
        public ListB()
        {
            capacity = 4;
            listArray = new T[capacity];



        }

        //member methods

      
        public void Add(T value)
        {
            if (count < capacity)
            {
                listArray[count] = value;
                count++;
            }


            else if (count >= capacity)
            {

                capacity *= 2;
                tempArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = listArray[i];

                }
                listArray = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    listArray[i] = tempArray[i];
                }


                listArray[count] = value;
                count++;

            }
        }

        public void Remove(T value)
        {

            for (int i = 0; i < count; i++)
            {
                if (listArray[i].Equals(value))
                {
                    arrayIndexer = i;
                    break;
                }
                else if (i == count - 1)
                {
                    indexerSwitch = false;
                }
            }
            tempArray = new T[capacity];
            if (indexerSwitch == true)
            {


                if (arrayIndexer == 0)
                {
                    for (int j = 0; j < count; j++)
                    {
                        if (j == count - 1)
                        {
                            break;
                        }
                        tempArray[j] = listArray[j + 1];
                    }
                }
                else if (arrayIndexer == count - 1)
                {
                    for (int j = 0; j < count - 1; j++)
                    {
                        tempArray[j] = listArray[j];
                    }

                }
                else if (arrayIndexer > 0 && arrayIndexer < count - 1)
                {
                    for (int j = 0; j < arrayIndexer; j++)
                    {
                        tempArray[j] = listArray[j];
                    }
                    for (int k = arrayIndexer + 1; k < count; k++)
                    {
                        tempArray[k - 1] = listArray[k];
                    }

                }
                count--;
                listArray = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    listArray[i] = tempArray[i];


                }
            }
        }

              public override string ToString()
        {

            for (int i = 0; i < count; i++)
            {
                string stringValue = Convert.ToString(listArray[i]);
                stringOfList += stringValue;
            }
            return stringOfList;
        }

        public static ListB<T> operator +(ListB<T> l1, ListB<T> l2)
        {


            ListB<T> combinedList = new ListB<T>();

            for (int i = 0; i < l1.Count; i++)
            {

                combinedList.Add(l1[i]);

            }

            for (int i = 0; i < l2.Count; i++)
            {
                combinedList.Add(l2[i]);
            }

            return combinedList;
        }






    }
}
    
