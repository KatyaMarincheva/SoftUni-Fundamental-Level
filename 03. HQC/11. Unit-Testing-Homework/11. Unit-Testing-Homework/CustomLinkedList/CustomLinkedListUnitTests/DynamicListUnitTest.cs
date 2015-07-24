// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DynamicListUnitTest.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The dynamic list unit test.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CustomLinkedListUnitTest
{
    using System;
    using CustomLinkedList;
    using CustomLinkedListUnitTests;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The dynamic list unit test.
    /// </summary>
    [TestClass]
    public class DynamicListUnitTest : TestBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DynamicListUnitTest"/> class.
        /// </summary>
        public DynamicListUnitTest()
        {
            this.TestContext = this.TestContext;
        }

        /// <summary>
        /// Gets or sets the dynamic list.
        /// </summary>
        public static DynamicList<string> DynamicList { get; set; }

        /// <summary>
        /// Gets or sets the test context.
        /// </summary>
        public TestContext TestContext { get; set; }

        /// <summary>
        /// Initializes the dynamic list tests.
        /// </summary>
        /// <param name="testContext">
        /// The test context.
        /// </param>
        [ClassInitialize]
        public static void DynamicListTestsInitialize(TestContext testContext)
        {
            DynamicList = new DynamicList<string>();
        }

        /// <summary>
        /// Resets the dynamic list object.
        /// </summary>
        [TestInitialize]
        public void ResetDynamicListObject()
        {
            DynamicList = new DynamicList<string>();
        }

        /// <summary>
        /// The count test tests count on new list creation - should pass test.
        /// </summary>
        [TestMethod]
        public void Count_TestCountOnNewListCreation_ShouldPassTest()
        {
            int initialCount = DynamicList.Count;
            Assert.AreEqual(0, initialCount, "A newly created list should have a count of 0.");
        }

        /// <summary>
        /// The count test tests count after adding one element - should pass test.
        /// </summary>
        [TestMethod]
        public void Count_TestCountAfterAddingOneElement_ShouldPassTest()
        {
            DynamicList.Add("one");
            this.AddCleanupAction(() => DynamicList.Remove("one"));

            int count = DynamicList.Count;
            Assert.AreEqual(1, count, "After adding one element the count of the list should be 1.");
        }

        /// <summary>
        /// The indexer test with empty dynamic list should throw argument out of range exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_TestWithEmptyDynamicList_ShouldThrowArgumentOutOfRangeException()
        {
            string value = DynamicList[0];
        }

        /// <summary>
        /// The indexer test with negative index should throw argument out of range exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_TestWithNegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            string value = DynamicList[-1];
        }

        /// <summary>
        /// The indexer test with index beyond list count should throw argument out of range exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Indexer_TestWithIndexBeyondListCount_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList.Add("one");
            this.AddCleanupAction(() => DynamicList.Remove("one"));

            string actual = DynamicList[1];
        }

        /// <summary>
        /// The indexer test with valid index should pass test.
        /// </summary>
        [TestMethod]
        public void Indexer_TestWithValidIndex_ShouldPassTest()
        {
            DynamicList.Add("one");
            this.AddCleanupAction(() => DynamicList.Remove("one"));

            string value = DynamicList[0];
        }

        /// <summary>
        /// The add test tests added element value should pass test.
        /// </summary>
        [TestMethod]
        public void Add_TestAddedElementValue_ShouldPassTest()
        {
            DynamicList.Add("one");
            this.AddCleanupAction(() => DynamicList.Remove("one"));

            string value = DynamicList[0];
            Assert.AreEqual("one", value, "The value at index 0 should be equal to the value entered.");
        }

        /// <summary>
        /// The elements test tests positions of elements added in sequence - should pass test.
        /// </summary>
        [TestMethod]
        public void Elements_TestPositionsOfElementsAddedInSequence_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");
            this.AddCleanupAction(() => DynamicList.Remove("first"));
            this.AddCleanupAction(() => DynamicList.Remove("second"));

            string firstElement = DynamicList[0];
            string secondElement = DynamicList[1];

            Assert.AreEqual(
                "first", 
                firstElement, 
                "The element at index 0 should be the first element added to the list.");
            Assert.AreEqual(
                "second", 
                secondElement, 
                "The element at index 1 should be the second element added to the list.");
        }

        /// <summary>
        /// The set test at negative index should throw argument out of range exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Set_TestAtNegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList[-1] = "one";
        }

        /// <summary>
        /// The set test 1: at index beyond list count should throw argument out of range exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Set_TestAtIndexBeyondListCount1_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList.Add("one");
            this.AddCleanupAction(() => DynamicList.Remove("one"));

            DynamicList[1] = "two";
        }

        /// <summary>
        /// The set test 2: at index beyond list count should throw argument out of range exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Set_TestAtIndexBeyondListCount2_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList[0] = "one";
        }

        /// <summary>
        /// The set test at valid index should pass test.
        /// </summary>
        [TestMethod]
        public void Set_TestAtValidIndex_ShouldPassTest()
        {
            DynamicList.Add("initial");
            DynamicList[0] = "changed";
            this.AddCleanupAction(() => DynamicList.Remove("changed"));

            string newValue = DynamicList[0];
            Assert.AreEqual("changed", newValue, "The value at index 0 should be changed through the indexer.");
        }

        /// <summary>
        /// The remove test at negative index should throw argument out of range exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_TestAtNegativeIndex_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList.RemoveAt(-1);
        }

        /// <summary>
        /// The remove test at index beyond list count should throw argument out of range exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Remove_TestAtIndexBeyondListCount_ShouldThrowArgumentOutOfRangeException()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");
            this.AddCleanupAction(() => DynamicList.Remove("first"));
            this.AddCleanupAction(() => DynamicList.Remove("second"));

            DynamicList.RemoveAt(2);
        }

        /// <summary>
        /// The count test - list count after remove at should pass test.
        /// </summary>
        [TestMethod]
        public void Count_TestListCountAfterRemoveAt_ShouldPassTest()
        {
            DynamicList.Add("one");
            DynamicList.RemoveAt(0);

            int count = DynamicList.Count;
            Assert.AreEqual(0, count);
        }

        /// <summary>
        /// The remove at test - remaining elements positions after remove at should pass test.
        /// </summary>
        [TestMethod]
        public void RemoveAt_TestRemainingElementsPositionsAfterRemoveAt_ShouldPassTest()
        {
            DynamicList.Add("one");
            DynamicList.Add("two");
            DynamicList.Add("three");
            this.AddCleanupAction(() => DynamicList.Remove("one"));
            this.AddCleanupAction(() => DynamicList.Remove("three"));

            DynamicList.RemoveAt(1);

            string first = DynamicList[0];
            string second = DynamicList[1];

            Assert.AreEqual("one", first, "The string entered first should be at position 0.");
            Assert.AreEqual("three", second, "The entered third should be at position 1 after the removal at 1.");
        }

        /// <summary>
        /// The count test after removing non existing element from list should pass test.
        /// </summary>
        [TestMethod]
        public void Count_TestAfterRemovingNonExistingElementFromList_ShouldPassTest()
        {
            DynamicList.Add("one");
            DynamicList.Add("two");
            this.AddCleanupAction(() => DynamicList.Remove("one"));
            this.AddCleanupAction(() => DynamicList.Remove("two"));

            DynamicList.Remove("three");

            int count = DynamicList.Count;

            Assert.AreEqual(
                2, 
                count, 
                "The count of the list should remain unchanged after trying to remove a non-existing element.");
        }

        /// <summary>
        /// The remove test return value after removing non existing element from list should pass test.
        /// </summary>
        [TestMethod]
        public void Remove_TestReturnValueAfterRemovingNonExistingElementFromList_ShouldPassTest()
        {
            DynamicList.Add("one");
            DynamicList.Add("two");
            this.AddCleanupAction(() => DynamicList.Remove("one"));
            this.AddCleanupAction(() => DynamicList.Remove("two"));

            int index = DynamicList.Remove("three");

            Assert.AreEqual(-1, index, "The returned index of a non-existing element should be -1.");
        }

        /// <summary>
        /// The count test after removing element from list should pass test.
        /// </summary>
        [TestMethod]
        public void Count_TestAfterRemovingElementFromList_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");
            DynamicList.Add("third");
            this.AddCleanupAction(() => DynamicList.Remove("first"));
            this.AddCleanupAction(() => DynamicList.Remove("third"));

            DynamicList.Remove("second");
            int count = DynamicList.Count;

            Assert.AreEqual(2, count, "The count of elements of the list should be 2 after removing an element.");
        }

        /// <summary>
        /// The remove test return value after removing element from list should pass test.
        /// </summary>
        [TestMethod]
        public void Remove_TestReturnValueAfterRemovingElementFromList_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");
            DynamicList.Add("third");
            this.AddCleanupAction(() => DynamicList.Remove("first"));
            this.AddCleanupAction(() => DynamicList.Remove("third"));

            int index = DynamicList.Remove("second");

            Assert.AreEqual(1, index, "The index of the removed element should be 1.");
        }

        /// <summary>
        /// The remove test remaining elements positions after remove should pass test.
        /// </summary>
        [TestMethod]
        public void Remove_TestRemainingElementsPositionsAfterRemove_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");
            DynamicList.Add("third");
            this.AddCleanupAction(() => DynamicList.Remove("first"));
            this.AddCleanupAction(() => DynamicList.Remove("third"));

            DynamicList.Remove("second");
            string first = DynamicList[0];
            string second = DynamicList[1];

            Assert.AreEqual("first", first, "The first element of the list should be the first one entered.");
            Assert.AreEqual(
                "third", 
                second, 
                "The second element in the list should be the third one entered after removing the second element.");
        }

        /// <summary>
        /// The index of test on non existing element should pass test.
        /// </summary>
        [TestMethod]
        public void IndexOf_TestOnNonExistingElement_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");
            this.AddCleanupAction(() => DynamicList.Remove("first"));
            this.AddCleanupAction(() => DynamicList.Remove("second"));

            int index = DynamicList.IndexOf("third");

            Assert.AreEqual(-1, index, "The return value when searching for a non-existing element should be -1.");
        }

        /// <summary>
        /// The index of test on existing element should pass test.
        /// </summary>
        [TestMethod]
        public void IndexOf_TestOnExistingElement_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");
            this.AddCleanupAction(() => DynamicList.Remove("first"));
            this.AddCleanupAction(() => DynamicList.Remove("second"));

            int index = DynamicList.IndexOf("second");

            Assert.AreEqual(1, index, "The index of the searched element should be 1.");
        }

        /// <summary>
        /// The contains test on non existing element should pass test.
        /// </summary>
        [TestMethod]
        public void Contains_TestOnNonExisingElement_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");
            this.AddCleanupAction(() => DynamicList.Remove("first"));
            this.AddCleanupAction(() => DynamicList.Remove("second"));

            bool isFound = DynamicList.Contains("third");

            Assert.IsFalse(isFound, "The element is not in the list and Contains should return false.");
        }

        /// <summary>
        /// The contains test on existing element should pass test.
        /// </summary>
        [TestMethod]
        public void Contains_TestOnExisingElement_ShouldPassTest()
        {
            DynamicList.Add("first");
            DynamicList.Add("second");
            this.AddCleanupAction(() => DynamicList.Remove("first"));
            this.AddCleanupAction(() => DynamicList.Remove("second"));

            bool isFound = DynamicList.Contains("second");

            Assert.IsTrue(isFound, "The element is in the list and Contains should return true.");
        }

        /// <summary>
        /// The test cleanup removes any values added to the DynamicList for testing purposes.
        /// </summary>
        [TestCleanup]
        public void Cleanup()
        {
            this.TestCleanup();
        }

        /// <summary>
        /// The class cleanup - returns the DynamicList object to not-initialized state.
        /// </summary>
        [ClassCleanup]
        public static void ClassCleanup()
        {
            DynamicList.Clear();
        }
    }
}