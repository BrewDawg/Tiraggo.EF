﻿/*  New BSD License
-------------------------------------------------------------------------------
Copyright (c) 2006-2012, EntitySpaces, LLC
All rights reserved.

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are met:
    * Redistributions of source code must retain the above copyright
      notice, this list of conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright
      notice, this list of conditions and the following disclaimer in the
      documentation and/or other materials provided with the distribution.
    * Neither the name of the EntitySpaces, LLC nor the
      names of its contributors may be used to endorse or promote products
      derived from this software without specific prior written permission.

THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
DISCLAIMED. IN NO EVENT SHALL EntitySpaces, LLC BE LIABLE FOR ANY
DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
(INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
-------------------------------------------------------------------------------
*/

using System;
using System.Collections.Generic;
#if (!MonoTouch)
using System.Windows.Data;
#endif

namespace Tiraggo.DynamicQuery
{
    public class tgExtraPropertyBinder 
#if (!MonoTouch)
		: IValueConverter
#endif
    {
        Dictionary<string, object> extraColumns = null;

        public tgExtraPropertyBinder()
        {

        }

        #region IValueConverter Members

        /// <summary>
        /// Converts values on their way to the UI for display
        /// </summary>
        /// <param name="value">The value to be formatted</param>
        /// <param name="targetType">The target type of the conversion</param>
        /// <param name="parameter">A format string to be used in the 
        /// formatting of the value</param>
        /// <param name="culture">The culture to use for formatting</param>
        /// <returns>The converted or formatted object</returns>
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                extraColumns = value as Dictionary<string, object>;

                string column = (string)parameter;
                return extraColumns[column];
            }
            catch 
            {
                return ""; // ex.Message + " " + (string)parameter + " " + extraColumns.Count.ToString() + " " + parameter.ToString();
            }
        }

        /// <summary>
        /// Converts values on their way back from the UI to the backend.
        /// </summary>
        /// <param name="value">The value to be formatted</param>
        /// <param name="targetType">The target type of the conversion</param>
        /// <param name="parameter">A format string to be used in the 
        /// formatting of the value</param>
        /// <param name="culture">The culture to use for formatting</param>
        /// <returns>The converted or formatted object</returns>
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                extraColumns[(string)parameter] = value;
                return extraColumns[(string)parameter];
            }
            catch
            {
                return "";
            }
        }

        #endregion
    }
}
