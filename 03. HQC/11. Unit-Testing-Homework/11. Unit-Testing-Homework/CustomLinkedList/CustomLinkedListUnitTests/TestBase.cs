// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TestBase.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The test base.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace CustomLinkedListUnitTests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The test base.
    /// </summary>
    [TestClass]
    public abstract class TestBase
    {
        /// <summary>
        /// The cleanup actions.
        /// </summary>
        private readonly List<Action> cleanupActions = new List<Action>();

        /// <summary>
        /// The add cleanup action.
        /// </summary>
        /// <param name="cleanupAction">
        /// The cleanup action.
        /// </param>
        public void AddCleanupAction(Action cleanupAction)
        {
            this.cleanupActions.Add(cleanupAction);
        }

        /// <summary>
        /// The test cleanup.
        /// </summary>
        [TestCleanup]
        public void TestCleanup()
        {
            Console.WriteLine("=============================== Test Cleanup ===============================");
            Console.WriteLine();

            this.CallCleanupActions();
        }

        /// <summary>
        /// The call cleanup actions.
        /// </summary>
        /// <exception cref="Exception">Cleanup action failed.
        /// </exception>
        /// <exception cref="AggregateException">Multiple exceptions occured in Cleanup. See test log for more details.
        /// </exception>
        private void CallCleanupActions()
        {
            this.cleanupActions.Reverse();
            var exceptions = new List<Exception>();

            foreach (var action in this.cleanupActions)
            {
                try
                {
                    action();
                }
                catch (Exception ex)
                {
                    exceptions.Add(ex);
                    Console.WriteLine("Cleanup action failed: " + ex);
                }
            }

            if (exceptions.Count == 0)
            {
                return;
            }

            if (exceptions.Count == 1)
            {
                throw exceptions.Single();
            }

            throw new AggregateException(
                "Multiple exceptions occured in Cleanup. See test log for more details", 
                exceptions);
        }
    }
}