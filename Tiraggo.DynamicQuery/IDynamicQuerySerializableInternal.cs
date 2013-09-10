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

namespace Tiraggo.DynamicQuery
{
    public interface IDynamicQuerySerializableInternal
    {
        /// <summary>
        /// Guid DataID.
        /// </summary>
        /// <returns>Guid DataID.</returns>
        Guid DataID { get; set; }

        /// <summary>
        /// Taken from the Connection just before the request is made
        /// </summary>
        string Catalog { get; set; }

        /// <summary>
        /// Taken from the Connection just before the request is made
        /// </summary>
        string Schema { get; set; }

        /// <summary>
        /// 
        /// </summary>
        bool IsInSubQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        bool HasSetOperation { get; }

        /// <summary>
        /// 
        /// </summary>
        string SubQueryAlias { get; }

        /// <summary>
        /// 
        /// </summary>
        string JoinAlias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string LastQuery { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string QuerySource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        tgSubquerySearchCondition SubquerySearchCondition { get; }

        /// <summary>
        /// List&lt;tgJoinItem&gt; InternalSelectColumns.
        /// </summary>
        /// <returns>List&lt;tgExpression&gt; InternalSelectColumns.</returns>
        List<tgExpression> InternalSelectColumns { get; set; }

        /// <summary>
        /// The From SubQuery
        /// </summary>
        tgDynamicQuerySerializable InternalFromQuery { get; }

        /// <summary>
        /// List&lt;tgJoinItem&gt; InternalJoinItems.
        /// </summary>
        /// <returns>List&lt;tgJoinItem&gt; InternalJoinItems.</returns>
        List<tgJoinItem> InternalJoinItems { get; }

        /// <summary>
        /// List&lt;tgComparison&gt; InternalWhereItems.
        /// </summary>
        /// <returns>List&lt;tgComparison&gt; InternalWhereItems.</returns>
        List<tgComparison> InternalWhereItems { get; }

        /// <summary>
        /// List&lt;tgJoinItem&gt; InternalOrderByItems.
        /// </summary>
        /// <returns>List&lt;tgOrderByItem&gt; InternalOrderByItems.</returns>
        List<tgOrderByItem> InternalOrderByItems { get; set; }

        /// <summary>
        /// List&lt;tgComparison&gt; InternalHavingItems.
        /// </summary>
        /// <returns>List&lt;tgComparison&gt; InternalHavingItems.</returns>
        List<tgComparison> InternalHavingItems { get; }

        /// <summary>
        /// List&lt;tgComparison&gt; InternalGroupByItems.
        /// </summary>
        /// <returns>List&lt;tgGroupByItem&gt; InternalGroupByItems.</returns>
        List<tgGroupByItem> InternalGroupByItems { get; set; }

        /// <summary>
        /// The Set Operation, if any, Union, UnionAll, Intersect, Except
        /// </summary>
        /// <returns>List&lt;tgGroupByItem&gt; InternalGroupByItems.</returns>
        List<tgSetOperation> InternalSetOperations { get; set; }

        /// <summary>
        /// This is used because tgDynamicQuerySerializable.AssignProviderMetadata is
        /// not public and tgJoinItem needs to be able to execute it
        /// </summary>
        void HookupProviderMetadata(tgDynamicQuerySerializable query);

        /// <summary>
        /// This is used internally
        /// </summary>
        Dictionary<string, tgDynamicQuerySerializable> queries { get; }

        /// <summary>
        /// The number of rows to skip in the result set (starting from the beginning)
        /// </summary>
        int? Skip { get; }

        /// <summary>
        /// The number of rows to take from the result set (starting from the Skip)
        /// </summary>
        int? Take { get; }
    }
}
