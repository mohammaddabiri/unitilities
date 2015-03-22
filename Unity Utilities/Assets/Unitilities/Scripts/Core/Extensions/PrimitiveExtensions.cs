﻿/// <summary>
/// PrimitiveExtensions v1.0 by Christian Chomiak, christianchomiak@gmail.com
/// 
/// Functions that facilitate the use of C# primitives. 
/// </summary>

using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

namespace Unitilities
{

    public static class PrimitiveExtensions
    {

        #region int

        /// <summary>
        /// Returns the bool-equivalent of the value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if the value is positive, else false</returns>
        public static bool ToBool(this int value)
        {
            return value > 0;
        }

        #endregion

        #region float

        /// <summary>
        /// Given an original value, returns the value inside a range.
        /// </summary>
        /// <param name="value">Value to be wrapped</param>
        /// <param name="min">Min boundary of the range</param>
        /// <param name="max">Max boundary of the range</param>
        /// <returns></returns>
        public static float Wrapped(this float value, float min, float max)
        {
            if (value > max)
                return (value - max) + min;

            if (value < min)
                return max - (min - value);

            return value;
        }

        #endregion

        #region bool

        /// <summary>
        /// Returns the bool-equivalent of the value
        /// </summary>
        /// <param name="value"></param>
        /// <returns>True if the value is positive, else false</returns>
        public static int ToInt(this bool value)
        {
            if (value)
                return 1;
            else
                return 0;
        }
        #endregion

        #region string

        /// <summary>
        /// Determines if a string has a valid email address structure
        /// </summary>
        /// <param name="s">String to be tested</param>
        /// <returns>'True' if is a valid address, otherwise 'False'</returns>
        public static bool IsValidEmailAddress(this string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }

        /// <summary>
        /// Count all words in a given string
        /// </summary>
        /// <param name="input">string to begin with</param>
        /// <returns>int</returns>
        public static int WordCount(this string input)
        {
            var count = 0;
            try
            {
                // Exclude whitespaces, Tabs and line breaks
                var re = new Regex(@"[^\s]+");
                var matches = re.Matches(input);
                count = matches.Count;
            }
            catch
            {
            }
            return count;
        }
        #endregion

    }

}