using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cloudsifter.TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            Cloudsifter.Data.Repositories.Link linkRepository = new Data.Repositories.Link();
            Cloudsifter.Data.Types.Link link = linkRepository.GetById(100);
            Cloudsifter.Data.Log.LogInfo("Starting up...");

            Exception e = new Exception("test exception");
            Cloudsifter.Data.Log.LogError("test error", e);
        }
    }
}
