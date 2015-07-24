// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ListNode.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The list node.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CustomLinkedList
{
    /// <summary>
    /// The list node.
    /// </summary>
    /// <typeparam name="T">
    /// Generic T
    /// </typeparam>
    internal class ListNode<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListNode{T}"/> class.
        /// </summary>
        /// <param name="element">
        /// The element.
        /// </param>
        public ListNode(T element)
        {
            this.Element = element;
            this.NextNode = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListNode{T}"/> class.
        /// </summary>
        /// <param name="element">
        /// The element.
        /// </param>
        /// <param name="prevNode">
        /// The previous node.
        /// </param>
        public ListNode(T element, ListNode<T> prevNode)
        {
            this.Element = element;
            prevNode.NextNode = this;
        }

        /// <summary>
        ///     Gets or sets the element.
        /// </summary>
        public T Element { get; set; }

        /// <summary>
        ///     Gets or sets the next node.
        /// </summary>
        public ListNode<T> NextNode { get; set; }
    }
}