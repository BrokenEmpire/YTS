using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTS.ClientApp.Base
{
    public interface IRequest
    {
        Uri BuildRequestUri();
    }
}
