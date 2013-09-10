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
using System.Collections;
using System.Collections.Generic;

using System.Diagnostics;

namespace Tiraggo.DynamicQuery
{
    /// <summary>
    /// This is the collection used to house the onboard metadata created during 
    /// code generation.
    /// </summary>
    /// <remarks>
    /// This collection contains one <see cref="tgColumnMetadata"/> for each column in 
    /// the table or view. This data is used by EntitySpaces data providers to create dynamic
    /// sql and by EntitySpaces during databinding.
    /// <code>
    /// public partial class EmployeesCollection : esEmployeesCollection
    ///	{
    ///		public void CheckoutTheMetadata()
    ///		{
    ///			foreach(tgColumnMetadata esCol in this.Meta.Columns)
    ///			{
    ///				Console.WriteLine(esCol.IsInPrimaryKey.ToString());
    ///			}
    ///		}
    ///	}
    /// </code>
    /// </remarks>
    [Serializable]
    public partial class tgColumnMetadataCollection : IEnumerable
    {
        public tgColumnMetadataCollection()
        {

        }

        /// <summary>
        /// The number of <see cref="tgColumnMetadata"/> objects in the collection.
        /// </summary>
        public System.Int32 Count
        {
            get { return list.Count; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<tgColumnMetadata> PrimaryKeys
        {
            get
            {
                return this.primaryKeys;
            }
        }

        /// <summary>
        /// Provides direct access into the collection by column name. 
        /// </summary>
        /// <param name="columnName">The name of the desired column. This parameter is expected
        /// to be the physical name of the column as in the table or view, for example, 
        /// Employees.ColumnNames.LastName</param>
        /// <returns></returns>
        public tgColumnMetadata this[System.String columnName]
        {
            get
            {
                tgColumnMetadata col = null;

                if (this.hashByColumnName.ContainsKey(columnName))
                {
                    col = this.hashByColumnName[columnName];
                }

                return col;
            }
        }

        /// <summary>
        /// Provides sequential access into the collection.
        /// </summary>
        /// <param name="ordinal"></param>
        /// <returns></returns>
        public tgColumnMetadata this[System.Int32 ordinal]
        {
            get { return this.list[ordinal]; }
        }

        /// <summary>
        /// Used internally by Tiraggo. This should never be called by user code
        /// </summary>
        /// <param name="column">The new tgColumnMetadata to add to the array</param>
        public void Add(tgColumnMetadata column)
        {
            list.Add(column);
            hashByColumnName[column.Name] = column;
            hashByPropertyName[column.PropertyName] = column;

            if (column.IsInPrimaryKey)
            {
                this.primaryKeys.Add(column);
            }
        }

        /// <summary>
        /// Searches for an tgColumnMetadata by the propery name. This method is the same as
        /// using the indexer.
        /// </summary>
        /// <param name="columnName">The high level PropertyName, for example, Employees.ColumnNames.LastName</param>
        /// <returns>The tgColumnMetadata or null if not found.</returns>
        public tgColumnMetadata FindByColumnName(string columnName)
        {
            tgColumnMetadata col = null;

            if (this.hashByColumnName.ContainsKey(columnName))
            {
                col = this.hashByColumnName[columnName];
            }

            return col;
        }

        /// <summary>
        /// Searches for an tgColumnMetadata by the propery name.
        /// </summary>
        /// <param name="propertyName">The high level PropertyName, for example, Employees.PropertyNames.LastName</param>
        /// <returns>The tgColumnMetadata or null if not found.</returns>
        public tgColumnMetadata FindByPropertyName(string propertyName)
        {
            tgColumnMetadata col = null;

            if (this.hashByPropertyName.ContainsKey(propertyName))
            {
                col = this.hashByPropertyName[propertyName];
            }

            return col;
        }

        #region IEnumerable Members

        /// <summary>
        /// Supports the foreach() syntax over the collection.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            return this.list.GetEnumerator();
        }

        #endregion

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<tgColumnMetadata> list = new List<tgColumnMetadata>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<tgColumnMetadata> primaryKeys = new List<tgColumnMetadata>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<System.String, tgColumnMetadata> hashByColumnName = new Dictionary<string, tgColumnMetadata>(StringComparer.OrdinalIgnoreCase);

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<System.String, tgColumnMetadata> hashByPropertyName = new Dictionary<string, tgColumnMetadata>();
    }
}
