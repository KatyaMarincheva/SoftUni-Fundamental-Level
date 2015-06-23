// <copyright file="GenericList.cs" company="Katya">
//     Katya All rights reserved.
// </copyright>
// <author>Katya</author>
namespace _03.Genereic_List_and_Version
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// GenericList class
    /// </summary>
    /// <typeparam name="T">generic type element</typeparam>
    [Version(0, 1)]
    public class GenericList<T> : IEnumerable where T : IComparable
    {
        /// <summary>
        /// The default capacity
        /// </summary>
        private const int DefaultCapacity = 16;

        /// <summary>
        /// The array
        /// </summary>
        private T[] array;

        /// <summary>
        /// The count
        /// </summary>
        private int currentIndex;

        /// <summary>
        /// Initializes a new instance of the <see cref="GenericList{T}"/> class.
        /// </summary>
        /// <param name="initialCapacity">The initial capacity.</param>
        public GenericList(int initialCapacity = DefaultCapacity)
        {
            this.array = new T[initialCapacity];
            this.Count = this.currentIndex = 0;
        }

        /// <summary>
        /// Gets the number of elements that have been added to the GenericList.
        /// </summary>
        public int Count
        {
            get
            {
                return this.currentIndex;
            }

            private set
            {
                this.currentIndex = value;
            }
        }

        /// <summary>
        /// Gets the current capacity of the GenericList. If the number of elements exceeds the capacity, the capacity is doubled.
        /// </summary>
        public int Capacity
        {
            get
            {
                return this.array.Length;
            }
        }

        /// <summary>
        /// Returns the element at the given index of the GenericList.
        /// If the index is outside the boundaries of the GenericList, throws IndexOutOfRangeException.
        /// </summary>
        /// <value>
        /// The <see cref="T"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns>Returns the element at the given index of the GenericList.</returns>
        /// <exception cref="System.IndexOutOfRangeException">Index is outside the boundaries of the GenericList.</exception>
        public T this[int index]
        {
            get
            {
                if (index < 0 || this.Count <= index)
                {
                    throw new IndexOutOfRangeException("Index is outside the boundaries of the GenericList.");
                }

                return this.array[index];
            }
        }

        /// <summary>
        /// Finds the minimal value element of the CustomList.
        /// </summary>
        /// <returns>The minimal value element of the CustomList</returns>
        /// <exception cref="ArgumentException">The CustomList is empty</exception>
        public T Min()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("The GenericList is empty");
            }

            T minEelement = this.array[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (minEelement.CompareTo(this.array[i]) > 0)
                {
                    minEelement = this.array[i];
                }
            }

            return minEelement;
        }

        /// <summary>
        /// Finds the maximal value element of the CustomList
        /// </summary>
        /// <returns>
        /// The maximal value element of the CustomList
        /// </returns>
        /// <exception cref="ArgumentException">The CustomList is empty</exception>
        public T Max()
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("The GenericList is empty");
            }

            T maxEelement = this.array[0];

            for (int i = 0; i < this.Count; i++)
            {
                if (maxEelement.CompareTo(this.array[i]) < 0)
                {
                    maxEelement = this.array[i];
                }
            }

            return maxEelement;
        }

        /// <summary>
        /// Adds the specified element at the end of the list.
        /// </summary>
        /// <param name="elementToAdd">The element to be added.</param>
        public void Add(T elementToAdd)
        {
            if (this.Count + 1 >= this.array.Length)
            {
                this.ResizeList();
            }

            this.array[this.Count] = elementToAdd;

            this.Count++;
        }

        /// <summary>
        /// Removes the element at the specified index.
        /// </summary>
        /// <param name="index">The index of the element.</param>
        /// <exception cref="System.IndexOutOfRangeException">Index is outside the boundaries of the GenericList.</exception>
        public void RemoveAt(int index)
        {
            if (index < 0 || this.Count <= index)
            {
                throw new IndexOutOfRangeException("Index is outside the boundaries of the GenericList.");
            }

            T[] newArray = new T[this.array.Length];
            Array.Copy(this.array, 0, newArray, 0, index);
            Array.Copy(this.array, index + 1, newArray, index, this.Count - index - 1);

            this.Count--;
            this.array = newArray;
        }

        /// <summary>
        /// Removes the first occurrence (if any) of the specified element from the GenericList.
        /// </summary>
        /// <param name="elementToRemove">The element to remove.</param>
        /// <exception cref="ArgumentException">Specified element was not found.</exception>
        public void Remove(T elementToRemove)
        {
            int index = this.IndexOf(elementToRemove);

            if (index == -1)
            {
                throw new ArgumentException("Specified element was not found.");
            }

            this.RemoveAt(index);
        }

        /// <summary>
        /// Inserts a new element at the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="newElement">The new element.</param>
        /// <exception cref="ArgumentException">List is empty</exception>
        /// <exception cref="IndexOutOfRangeException"></exception>
        public void InsertAt(int index, T newElement)
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }

            if (index < 0 || index >= this.Count)
            {
                throw new IndexOutOfRangeException(string.Format("Invalid index: {0}.", index));
            }

            if (this.Count == this.array.Length)
            {
                this.ResizeList();
            }

            T[] newArray = new T[this.Capacity];
            Array.Copy(this.array, 0, newArray, 0, index);
            newArray[index] = newElement;

            this.Count++;
            Array.Copy(this.array, index, newArray, index + 1, this.Count - index - 1);
            this.array = newArray;
        }

        /// <summary>
        /// Searches for the first occurrence of the specified element in the list and returns its index if found, -1 otherwise.
        /// Compares value types by value and reference types by reference.
        /// </summary>
        /// <param name="elementToFind">The element to search for.</param>
        /// <returns>
        /// The zero-based index of the element or -1 if the element isn't found in the list.
        /// </returns>
        /// <exception cref="ArgumentException">List is empty</exception>
        public int IndexOf(T elementToFind)
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }

            for (int index = 0; index < this.Count; index++)
            {
                if (object.ReferenceEquals(this.array[index], elementToFind))
                {
                    return index;
                }

                if (typeof(T).IsValueType && this.array[index].Equals(elementToFind))
                {
                    return index;
                }
            }

            return -1;
        }

        /// <summary>
        /// Clears the contents of this instance of the GenericList.
        /// </summary>
        public void Clear()
        {
            this.Count = 0;
            this.array = new T[DefaultCapacity];
        }

        /// <summary>
        /// Searches for the last occurrence of the specified element in the list and returns its index if found, -1 otherwise.
        /// Compares value types by value and reference types by reference.
        /// </summary>
        /// <param name="elementToFind">The element to search for.</param>
        /// <returns>
        /// The zero-based index of the element or -1 if the element isn't found in the list.
        /// </returns>
        /// <exception cref="ArgumentException">List is empty</exception>
        public int LastIndexOf(T elementToFind)
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }

            for (int index = this.Count - 1; index >= 0; index--)
            {
                if (object.ReferenceEquals(this.array[index], elementToFind))
                {
                    return index;
                }

                if (typeof(T).IsValueType && this.array[index].Equals(elementToFind))
                {
                    return index;
                }
            }

            return -1;
        }

        /// <summary>
        /// Checks whether the GenericList contains the specified element.
        /// </summary>
        /// <param name="elementToCheck">The element to check.</param>
        /// <returns>
        /// Returns false or true
        /// </returns>
        /// <exception cref="ArgumentException">List is empty</exception>
        public bool Contains(T elementToCheck)
        {
            if (this.Count == 0)
            {
                throw new ArgumentException("List is empty");
            }

            bool contains = this.IndexOf(elementToCheck) != -1;
            return contains;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            var resultElements = this.array.Take(this.Count);

            return this.Count > 0 ? string.Join(", ", resultElements) : "list is empty";
        }

        /// <summary>
        /// Implements the IEnumerable<typeparam name="T"></typeparam>, and the IEnumerabble
        /// </summary>
        /// <returns>Enumerator</returns>
        public IEnumerator<T> GetEnumerator()
        {
            return this.array.Take(this.Count).GetEnumerator();
        }

        /// <summary>
        /// Implements the IEnumerabble
        /// </summary>
        /// <returns>Enumerator</returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Displays version information for the GenericList.
        /// </summary>
        public void Version()
        {
            Type type = typeof(GenericList<T>);
            object[] allAttributes = type.GetCustomAttributes(false);
            foreach (var ver in allAttributes)
            {
                if (ver is VersionAttribute)
                {
                    VersionAttribute temp = ver as VersionAttribute;
                    Console.WriteLine("GenericList Version {0}.{1}", temp.MajorVersion, temp.MinorVersion.ToString("X2"));
                }
            }
        }

        /// <summary>
        /// Resizes the GenericList.
        /// </summary>
        private void ResizeList()
        {
            int newArraySize = this.array.Length * 2;
            T[] newArray = new T[newArraySize];

            Array.Copy(this.array, newArray, this.array.Length);
            this.array = newArray;
        }
    }
}