using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal interface IHandler
    {

        public void HandleRequest(Request request);

        public void SetNextHandler(IHandler handler);

    }
}
