using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YTS.ClientApp.Requests
{
    using Base;

    public class ListRequest : IRequest
    {


        public Uri BuildRequestUri() => new Uri("https://yts.am/api/v2/list_movies.json");
    }
}
