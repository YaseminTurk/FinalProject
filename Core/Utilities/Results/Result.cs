using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        

        public Result(bool success, string message) :this(success) //resultun tek parametreli constructor'una successi gönderir. //burası iki contsructorı da çalıştırır.
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success; //success i set etme işini buraya yazıyoruz çünkü burada mecburuz.
        }

        public bool Success { get; } //readonly ler constructer içinde set edilebilirler.

        public string Message { get;  }
    }
}
