using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemeShark.Core.Common
{
    interface IDriver
    {
        public string Name { get; }
        public string Directory { get; }

        public void Run();
        public bool CheckForDriver();
    }
}
