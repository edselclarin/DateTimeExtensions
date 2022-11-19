﻿#region MIT LICENSE
// MIT License
//
// Copyright (c) [2022][Edsel Clarin]
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.
#endregion

namespace DateTimeExtensions
{
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Returns the date of the specified day of week after the given date.
        /// <br/>
        /// <br/>
        /// Usage:
        /// <br/>
        /// <br/>
        /// DateTime dtFrom = new DateTime(2022, 11, 19);
        /// <br/>
        /// DateTime dtNext = dtFrom.GetDateOfTarget(DayOfWeek.Thursday);
        /// <br/>
        /// <br/>
        /// Result: 11/24/2022
        /// </summary>
        public static DateTime GetDateOfTarget(this DateTime dateTime, DayOfWeek targetDayOfWeek)
        {
            int iEndOfWeek = (int)DayOfWeek.Saturday;
            int iCurr = (int)dateTime.DayOfWeek;
            int iTarg = (int)targetDayOfWeek;
            int nTarg;

            if (iCurr < iTarg)
            {
                // If the current DOW falls before the target DOW, jump forward to it.
                nTarg = iTarg - iCurr;
            }
            else
            {
                // If the current DOW falls on or after the target DOW,
                // jump to the end of the week and then jump to the target.
                int nEndOfWeek = iEndOfWeek - iCurr;
                nTarg = nEndOfWeek + (iTarg + 1);
            }

            return dateTime.AddDays(nTarg);
        }
    }
}
