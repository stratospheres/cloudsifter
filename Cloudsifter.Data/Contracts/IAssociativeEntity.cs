using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Contracts
{
    public interface IAssociativeEntity
    {
        IDictionary<string, object> SerializeToDictionary();
    }
}
