/*  New BSD License
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
using System.Data;
using System.Data.SqlClient;

using Tiraggo.DynamicQuery;

namespace Tiraggo.DynamicQuery
{
    class Shared
    {
        static private SqlParameter CloneParameter(SqlParameter p)
        {
            ICloneable param = p as ICloneable;
            return param.Clone() as SqlParameter;
        }

        static public string CreateFullName(tgDynamicQuerySerializable query)
        {
            IDynamicQuerySerializableInternal iQuery = query as IDynamicQuerySerializableInternal;

            tgMetadata meta = query;

            string name = String.Empty;

            string catalog = meta.Catalog ?? null;
            string schema = meta.Schema ?? null;

            if (catalog != null && schema != null)
            {
                name += Delimiters.TableOpen + catalog + Delimiters.TableClose + ".";
            }

            if (schema != null)
            {
                name += Delimiters.TableOpen + schema + Delimiters.TableClose + ".";
            }

            name += Delimiters.TableOpen;

            if (query.tg.QuerySource != null)
                name += query.tg.QuerySource;
            else
                name += meta.Destination;
            name += Delimiters.TableClose;

            return name;
        }



        static public tgConcurrencyException CheckForConcurrencyException(SqlException ex)
        {
            tgConcurrencyException ce = null;

            if (ex.Errors != null)
            {
                foreach (SqlError err in ex.Errors)
                {
                    if (err.Number == 532)
                    {
                        ce = new tgConcurrencyException(err.Message, ex);
                        ce.Source = err.Source;
                        break;
                    }
                }
            }

            return ce;
        }
    }
}
