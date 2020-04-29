using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;
using System.Collections;

namespace CustomListTesting
{
    [TestClass]
    public class ListTests
    {
        private string actual;

        [TestClass]
        public class CustomListClassTests
        {
            [TestMethod]
            public void Add_CheckCount_AddNegativeNumber()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                int value = -3;
                int expected = 1;
                int actual;

                //act
                listB.Add(value);
                actual = listB.Count;


                //assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Add_CheckCount_AddPositiveNumber()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                int value = 23;
                int expected = 1;
                int actual;

                //act
                listB.Add(value);
                actual = listB.Count;


                //assert
                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Add_CheckIfNewArrayIsMade_Add5thElement()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                int value = 23;
                int expected = 8;
                int actual;

                //act
                listB.Add(value);
                listB.Add(value + 10);
                listB.Add(value + 20);
                listB.Add(value + 15);
                listB.Add(value + 32);
                actual = listB.Capacity;


                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Add_CheckListCount_Add5thElement()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                int value = 23;
                int expected = 5;
                int actual;

                //act
                listB.Add(value);
                listB.Add(value + 10);
                listB.Add(value + 20);
                listB.Add(value + 15);
                listB.Add(value + 32);
                actual = listB.Count;


                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Add_CheckArrayOrderStayedSame_Add5thElement()
            {
                // arrange

                ListB<int> listB = new ListB<int>();

                int expected = 43;
                int actual = 0;

                //act
                listB.Add(23);
                listB.Add(33);
                listB.Add(43);
                listB.Add(38);
                listB.Add(55);


                actual = listB[2];
                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Remove_CheckCount_RemoveOneValue()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                int expected = 2;
                int actual;

                //act
                listB.Add(24);
                listB.Add(12);
                listB.Add(56);
                listB.Remove(12);
                actual = listB.Count;


                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Remove_CheckCount_RemoveMultipleValues()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                int expected = 2;
                int actual;

                //act
                listB.Add(24);
                listB.Add(12);
                listB.Add(56);
                listB.Add(2);
                listB.Add(3);
                listB.Add(53);
                listB.Remove(24);
                listB.Remove(3);
                listB.Remove(56);
                listB.Remove(53);
                actual = listB.Count;


                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Remove_CheckIndexOrder_RemoveMiddleValue()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                int expected = 3;
                int actual;

                //act
                listB.Add(24);
                listB.Add(12);
                listB.Add(56);
                listB.Add(2);
                listB.Add(3);
                listB.Add(53);
                listB.Remove(2);
                actual = listB[3];


                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Remove_CheckCount_RemoveAllValues()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                int expected = 0;
                int actual;

                //act
                listB.Add(24);
                listB.Add(12);
                listB.Add(56);

                listB.Remove(24);
                listB.Remove(12);
                listB.Remove(56);
                actual = listB.Count;


                //assert
                Assert.AreEqual(expected, actual);
            }



            [TestMethod]
            public void Remove_CheckCount_RemoveAValueThatHasADuplicateValue()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                int expected = 3;
                int actual;

                //act
                listB.Add(24);
                listB.Add(12);
                listB.Add(24);
                listB.Add(33);
                listB.Remove(24);

                actual = listB.Count;


                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void Remove_CheckArrayOrder_RemoveAValueThatHasADuplicateValue()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                int expected = 24;
                int actual;

                //act
                listB.Add(24);
                listB.Add(12);
                listB.Add(24);
                listB.Add(33);

                listB.Remove(24);

                actual = listB[1];


                //assert
                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            public void ToString_CheckCoversion_ListOfIntegers()
            {
                // arrange

                ListB<int> listB = new ListB<int>();
                string expected = "1986";
                string actual;

                //act
                listB.Add(1);
                listB.Add(9);
                listB.Add(8);
                listB.Add(6);



                actual = listB.ToString();


                //assert
                Assert.AreEqual(expected, actual);
            }


        }
        [TestMethod]
        public void ToString_CheckCoversion_ListOfStrings()
        {
            // arrange

            ListB<string> listB = new ListB<string>();
            string expected = "Packers Suck";
            string actual;

            //act
            listB.Add("P");
            listB.Add("a");
            listB.Add("c");
            listB.Add("k");
            listB.Add("e");
            listB.Add("r");
            listB.Add("s");
            listB.Add(" ");
            listB.Add("S");
            listB.Add("u");
            listB.Add("c");
            listB.Add("k");


            actual = listB.ToString();


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ToString_CheckCoversion_ListOfDoubles()
        {
            // arrange

            ListB<double> listB = new ListB<double>();
            string expected = "56.323.21";
            string actual;

            //act
            listB.Add(56.32);
            listB.Add(3.21);




            actual = listB.ToString();


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadAdditionOfLists_CheckCount_TwoListsOfIntegers()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            ListB<int> listA = new ListB<int>();
            ListB<int> combinedList = new ListB<int>();
            int expected = 8;
            int actual;

            //act
            listB.Add(3);
            listB.Add(9);
            listB.Add(27);
            listA.Add(71);
            listA.Add(213);
            listA.Add(639);
            listA.Add(18);
            listA.Add(25);

            combinedList = listB + listA;



            actual = combinedList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadAdditionOfLists_CheckCount_TwoListsOfStrings()
        {
            // arrange

            ListB<string> listB = new ListB<string>();
            ListB<string> listA = new ListB<string>();
            ListB<string> combinedList = new ListB<string>();
            int expected = 8;
            int actual;

            //act
            listB.Add("J");
            listB.Add("e");
            listB.Add("f");
            listA.Add("f");
            listA.Add("r");
            listA.Add("e");
            listA.Add("y");
            listA.Add("C");

            combinedList = listB + listA;



            actual = combinedList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadAdditionOfLists_CheckArrayOrderAfterCombining_TwoListsOfStrings()

        {
            // arrange

            ListB<string> listB = new ListB<string>();
            ListB<string> listA = new ListB<string>();
            ListB<string> combinedList = new ListB<string>();
            string expected = "e";

            //act

            listB.Add("J");
            listB.Add("e");
            listB.Add("f");
            listA.Add("f");
            listA.Add("r");
            listA.Add("e");
            listA.Add("y");
            listA.Add("C");

            combinedList = listB + listA;

            actual = combinedList[5];
            //assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void OverloadSubtractionOfLists_CheckCount_TwoListsOfStrings()
        {
            // arrange

            ListB<string> listB = new ListB<string>();
            ListB<string> listA = new ListB<string>();
            ListB<string> combinedList = new ListB<string>();
            int expected = 1;
            int actual;

            //act
            listB.Add("J");
            listB.Add("e");
            listB.Add("f");
            listA.Add("J");
            listA.Add("a");
            listA.Add("r");
            listA.Add("t");
            listA.Add("e");

            combinedList = listB - listA;



            actual = combinedList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverloadSubtractionOfLists_CheckCount_TwoListsOfInts()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            ListB<int> listA = new ListB<int>();
            ListB<int> combinedList = new ListB<int>();
            int expected = 2;
            int actual;

            //act
            listB.Add(1);
            listB.Add(2);
            listB.Add(3);
            listA.Add(1);
            listA.Add(4);
            listA.Add(5);
            listA.Add(6);
            listA.Add(7);

            combinedList = listB - listA;



            actual = combinedList.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void OverloadSubtractionOfLists_CheckCountOfOriginalList_TwoListsOfInts()
        {
            // arrange

            ListB<int> listB = new ListB<int>();
            ListB<int> listA = new ListB<int>();
            ListB<int> combinedList = new ListB<int>();
            int expected = 3;
            int actual;

            //act
            listB.Add(1);
            listB.Add(2);
            listB.Add(3);
            listA.Add(1);
            listA.Add(4);
            listA.Add(5);
            listA.Add(6);
            listA.Add(7);

            combinedList = listB - listA;



            actual = listB.Count;


            //assert
            Assert.AreEqual(expected, actual);
        }




    }
}



