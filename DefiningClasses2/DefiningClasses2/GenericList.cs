using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class GenericList<T> where T: IComparable
    {
        private T[] elements;
        private int index = 0;

        public GenericList(int Limit)
        {
            this.elements = new T[Limit];
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > elements.Count())
                {
                    throw new ArgumentException(string.Format("Invalid index : {0}.It`s out of range.", index));
                }
                return this.elements[index];
            }
            set
            {
                if (index < 0 || index > elements.Count())
                {
                    throw new ArgumentException(string.Format("Invalid index : {0}.It`s out of range.", index));
                }
                this.elements[index] = value;
            }
        }

        public void AddElement(T element)
        {
            if (index == this.elements.Length)
            {
                DoubleSize();
            }
            this.elements[index] = element;
            index++;
        }

        public void RemoveElement(int Index)
        {
            T[] result = new T[elements.Count() - 1];
            for (int i = 0; i < Index; i++)
            {
                result[i] = elements[i];
            }
            for (int i = Index+1; i <elements.Count(); i++)
            {
                result[i-1] = elements[i];
            }
            elements = new T[elements.Count() - 1];
            for (int i = 0; i < elements.Count(); i++)
            {
                elements[i] = result[i];
            }

        }

        public void InsertAtPosition(int index, T element)
        {
           

            T[] result = new T[elements.Count() + 1];

            for (int i = 0; i < elements.Count() + 1; i++)
            {
                if (i == index)
                {
                    result[i] = element;
                }
                else if (i < index)
                {
                    result[i] = elements[i];
                }
                else if (i > index)
                {
                    result[i] = elements[i - 1];
                }
            }
            elements = new T[elements.Count() + 1];
            for (int i = 0; i < elements.Count(); i++)
            {
                elements[i] = result[i];
            }
        }

        public int IndexOf(T element)
        {
            int index = 0;
            for (int i = 0; i < elements.Count(); i++)
            {
                if (elements[i].Equals(element))
                {
                    index = i;
                }
            }
            return index;
        }

        private void DoubleSize()
        {
            
            T[] newList = new T[this.elements.Count()*2];

            for (int i = 0; i < newList.Count(); i++)
            {
                newList[i] = this.elements[i];
            }

            this.elements = newList;
            
        }

        public T MinElement(T[] Elements)
        {
            T bestElement = Elements[0];
           // T currentElement;
            for (int i = 0; i < Elements.Length; i++)
			{
                //currentElement = Elements[i];
                if (Elements[i].CompareTo(bestElement) < 0)
                {
                    bestElement = Elements[i];
                }
			}
            return bestElement;
        }

        public T MaxElement(T[] Elements)
        {
            T bestElement = Elements[0];
            for (int i = 0; i < Elements.Length; i++)
            {
                if (Elements[i].CompareTo(bestElement) > 0)
                {
                    bestElement = Elements[i];
                }
            }
            return bestElement;
        }

    }
}
