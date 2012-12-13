using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.Data.Contracts
{
    public interface IEntity
    {
        IDictionary<string, object> SerializeToDictionary();
    }
}
