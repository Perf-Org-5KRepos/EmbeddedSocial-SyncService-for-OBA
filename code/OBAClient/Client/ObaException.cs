﻿/* Copyright 2014 Michael Braude and individual contributors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

namespace OBAService.OBAClient
{
    using System;
    using System.Globalization;

    /// <summary>
    /// Specific exception for OBA.
    /// </summary>
    public class ObaException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObaException"/> class.
        /// </summary>
        /// <param name="errorCode">error code</param>
        /// <param name="errorText">error text</param>
        public ObaException(int errorCode, string errorText)
            : base(string.Format(CultureInfo.CurrentCulture, "OBA Error {0}: {1}", errorCode, errorText))
        {
            this.ErrorCode = errorCode;
            this.ErrorText = errorText;
        }

        /// <summary>
        /// Gets error code
        /// </summary>
        public int ErrorCode
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets error text
        /// </summary>
        public string ErrorText
        {
            get;
            private set;
        }
    }
}