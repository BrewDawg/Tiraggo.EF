using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Tiraggo.DynamicQuery
{
    public class StandardProviderParameters
    {
        public IDbCommand cmd;
        public int pindex;

        // Hack, if we run into any more of these special conditions we'll
        // turn this into a dictionary that can hold any number of values.
        // However, for now, for performance stake we're add this as is.
        public bool needsStringParameter;
        public bool needsIntegerParameter;
        public bool needsDoubleParameter;
    }
}
