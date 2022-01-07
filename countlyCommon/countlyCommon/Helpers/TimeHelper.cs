﻿/*
Copyright (c) 2012, 2013, 2014, 2015, 2016, 2017 Countly

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/

using System;

namespace CountlySDK.Helpers
{
    internal class TimeHelper
    {

        //variable to hold last used timestamp
        private long _lastMilliSecTimeStamp = 0;

        internal TimeHelper() { }

        /// <summary>
        /// Converts DateTime to Unix time format
        /// </summary>
        /// <param name="date">DateTime object</param>
        /// <returns>Unix timestamp</returns>
        public long ToUnixTime(DateTime date)
        {
            TimeSpan ts = date.Subtract(new DateTime(1970, 1, 1));
            long calculatedMillis = (long)ts.TotalMilliseconds;

            if (_lastMilliSecTimeStamp >= calculatedMillis) {
                ++_lastMilliSecTimeStamp;
            } else {
                _lastMilliSecTimeStamp = calculatedMillis;
            }
            
            return _lastMilliSecTimeStamp;
        }

        public long UnixTimeNow()
        {
            return ToUnixTime(DateTime.Now.ToUniversalTime());
        }
    }
}
