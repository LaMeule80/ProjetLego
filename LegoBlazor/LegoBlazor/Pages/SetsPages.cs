using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Threading.Tasks;
using LegoBlazor.Tools;
using Microsoft.AspNetCore.Mvc.Routing;
using Newtonsoft.Json;

namespace LegoBlazor.Data
{
    public class SetsPages : Pages<Set>
    {
        public override IEnumerable<Set> GetItems()
        {
            return SetCache.Values;
        }
    }
}
