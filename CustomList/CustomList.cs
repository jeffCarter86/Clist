using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{


	public class CustomList<T>
	{
		//member variables
		int count;
		int capacity;
		private T[] arrayOfData;

		public int Count { get { return count; } }

		public int Capacity { get; set; }

		//ctor
		public CustomList()
		{

		}

		//member methods
		public void Add(T item)
		{

		}

		public int DefaultIfEmpty()
		{
			throw new NotImplementedException();
		}

		public void AddValueToArray(int expected)
		{
			throw new NotImplementedException();
		}
	}
}
