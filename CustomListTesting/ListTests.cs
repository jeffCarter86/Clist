using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTesting
{
	[TestClass]
	public class ListTests
	{
		[TestMethod]
		public void Create_ArrayOfValues_ReturnCapacity()

		//Test for the creation of the array, checks to see if capacity is correct for created array

		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expectedCapacity = 4;

			//act
			int actualCapacity = aCustomList.Capacity;
			//assert
			Assert.AreEqual(expectedCapacity, actualCapacity);
		}


		[TestMethod]
		//Tests to make sure that the list is increasing the count as new elements get added to the list
		public void Add_OneValue_IncrementCountOfList()
		{
			//arrange

			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 1;

			//act
			aCustomList.Add(expected);
			//assert
			Assert.AreEqual(expected, aCustomList.Count);
		}


		[TestMethod]
		//Tests to make sure that the index of the element added is correct when one value is added to the list
		public void Add_OneValue_ReturnValueAtIndex()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 10;

			//act
			aCustomList.Add(expected);

			//assert
			Assert.AreEqual(expected, aCustomList[0]);
		}

		[TestMethod]
		//Tests to make sure that the index of the element in index position two is correct when multiple elements are added to the list
		public void Add_TwoValues_ReturnElementAtIndex()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 15;
			int firstElement = 10;
			int secondElement = 15;

			//act
			aCustomList.Add(firstElement);
			aCustomList.Add(secondElement);

			//Assert
			Assert.AreEqual(expected, aCustomList[1]);
		}

		//Tests to make sure that the index of the element in index position two is correct when multiple elements are added to the list
		[TestMethod]
		public void Add_ThreeValues_CheckCapacityIsFour()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 4;
			int elementOne = 10;
			int elementTwo = 15;
			int elementThree = 20;

			//act
			aCustomList.Add(elementOne);
			aCustomList.Add(elementTwo);
			aCustomList.Add(elementThree);

			//Assert
			Assert.AreEqual(expected, aCustomList.Capacity);
		}
		[TestMethod]
		public void Add_SixValues_CheckCapacityIsEight()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 8;
			int elementOne = 1;
			int elementTwo = 2;
			int elementThree = 3;
			int elementFour = 4;
			int elementFive = 5;
			int elementSix = 6;
			//act
			aCustomList.Add(elementOne);
			aCustomList.Add(elementTwo);
			aCustomList.Add(elementThree);
			aCustomList.Add(elementFour);
			aCustomList.Add(elementFive);
			aCustomList.Add(elementSix);
			//Assert
			Assert.AreEqual(expected, aCustomList.Capacity);
		}

		[TestMethod]
		public void add_CheckIfExceedingCapacity_CreateNewArray()
		{

		}

		[TestMethod]
		//tests to make sure that the array and its elements at each index are properly copied to a new, larger array
		public void Add_ElementsOverDefaultArraySize_CopyArrayToNewArray()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 5;
			int elementOne = 1;
			int elementTwo = 2;
			int elementThree = 3;
			int elementFour = 4;
			int elementFive = 5;
			//act
			aCustomList.Add(elementOne);
			aCustomList.Add(elementTwo);
			aCustomList.Add(elementThree);
			aCustomList.Add(elementFour);
			aCustomList.Add(elementFive);

			//assert
			Assert.AreEqual(expected, aCustomList[4]);

		}

		[TestMethod]
		public void SubtractB_ThreeValues_CheckCapacityIsFour()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 4;
			int elementOne = 0;
			int elementTwo = 2;
			int elementThree = 1;

			//act
			aCustomList.Subtract(elementOne);
			aCustomList.Subtract(elementTwo);
			aCustomList.Subtract(elementThree);

			//Assert
			Assert.AreEqual(expected, aCustomList.Capacity);


		}

		[TestMethod]
		//Tests to make sure that the list is decreasing the count if removed from listt
		public void Subtract_OneValue_DecreaseOfList()
		{
			//arrange

			CustomList<int> aCustomList = new CustomList<int>();
			int expected = -1;

			//act
			aCustomList.Subtract(expected);
			//assert
			Assert.AreEqual(expected, aCustomList.Count);
		}
	
		[TestMethod]
		//Tests to make sure that the index of the element Subtracted is correct when one value is Subtracted to the list
		public void Subtract_OneValue_ReturnValueAtIndex()
		{
			//arrange
			CustomList<int> aCustomList = new CustomList<int>();
			int expected = 0;

			//act
			aCustomList.Subtract(expected);

			//assert
			Assert.AreEqual(expected, aCustomList[0]);
		}
	}


}
