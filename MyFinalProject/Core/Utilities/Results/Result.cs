using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool succes)
        {

        }
        public Result(bool succes,string messages):this(succes) 
        {
            Message = messages;
        }

        public bool Succes { get; }

        public string Message { get; }

    }
}
