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
		//Tests to make sure that the returned default value of the array is of the correct data type
		public void Create_ArrayOfInts_ReturnValueTypeDefaultValue()
        {
            //arrange
            CustomList<int> aCustomList = new CustomList<int>();

            int expectedDefaultValue = 0;

            //act
            //deal with this error
            int actualDefaultValue = aCustomList.DefaultIfEmpty();

            //assert
            Assert.AreEqual(expectedDefaultValue, actualDefaultValue);
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
			aCustomList.AddValueToArray(expected);

			//assert
			Assert.AreEqual(expected, aCustomList);
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
			aCustomList.AddValueToArray(firstElement);
			aCustomList.AddValueToArray(secondElement);

			//Assert
			Assert.AreEqual(expected, aCustomList);
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
			Assert.AreEqual(expected, aCustomList);

		}


	}
}
