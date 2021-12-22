using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {


        public Result(bool success, string message):this(success)
        {
            Message = message; // constructor içerisinde readonlyler set edilebiliyor.
            Success = success;
        }

        public Result(bool success)
        {
           
            Success = success;
        }

        public Result()
        {
        }

        public bool Success { get; }

        public string Message { get; } // constructor içinde readonly'ler set edilemez.
    }
}
