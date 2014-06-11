using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XB.API
{
    public interface ICommandDispatcher
    {
        void DispatchMessage(string logId, string type, string message);
    }

}
