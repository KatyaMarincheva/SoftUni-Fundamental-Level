// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Calculations.cs" company="Katya">
//   Katya.com. All rights reserved.
// </copyright>
// // <summary>
//   The calculations.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Methods.Method_Classes
{
    using System;

    /// <summary>
    /// The Calculations class. Comprises calculation type methods.
    /// </summary>
    public static class Calculations
    {
        /// <summary>
        /// The calculate triangle area.
        /// </summary>
        /// <param name="a">
        /// The side a of the triangle.
        /// </param>
        /// <param name="b">
        /// The side b of the triangle.
        /// </param>
        /// <param name="c">
        /// The side c of the triangle.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        /// <exception cref="ArgumentException">Sides should be positive numbers bigger than 0.
        /// </exception>
        public static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Sides should be positive numbers bigger than 0.", "a");
            }

            if (b <= 0)
            {
                throw new ArgumentException("Sides should be positive numbers bigger than 0.", "b");
            }

            if (c <= 0)
            {
                throw new ArgumentException("Sides should be positive numbers bigger than 0.", "c");
            }

            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        /// <summary>
        /// Finds the array max value.
        /// </summary>
        /// <param name="elements">
        /// The elements array.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        /// <exception cref="ArgumentNullException">The input array is empty.
        /// </exception>
        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("elements", "The input array is empty.");
            }

            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        /// <summary>
        /// Calculates the distance between two points.
        /// </summary>
        /// <param name="x1">
        /// The x coordinate of the first point.
        /// </param>
        /// <param name="y1">
        /// The y coordinate of the first point.
        /// </param>
        /// <param name="x2">
        /// The x coordinate of the second point.
        /// </param>
        /// <param name="y2">
        /// The y coordinate of the second point.
        /// </param>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        /// <summary>
        /// Checks if the line crossing the two given points is horizontal.
        /// </summary>
        /// <param name="x1">
        /// The x coordinate of the first point.
        /// </param>
        /// <param name="x2">
        /// The x coordinate of the second point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsHorizontalLine(double x1, double x2)
        {
            return x1 == x2;
        }

        /// <summary>
        /// Checks if the line crossing the two given points is vertical.
        /// </summary>
        /// <param name="y1">
        /// The y coordinate of the first point.
        /// </param>
        /// <param name="y2">
        /// The y coordinate of the second point.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public static bool IsVerticalLine(double y1, double y2)
        {
            return y1 == y2;
        }
    }
}