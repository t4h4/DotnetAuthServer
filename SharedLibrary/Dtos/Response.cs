using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

// detail:https://www.t4h4.net/wp-content/uploads/2021/07/123124t123123.png

namespace SharedLibrary.Dtos
{
    public class Response<T> where T : class // will take generic T and T class referance
    {
        public T Data { get; private set; } // private because in class internal set. 
        public int StatusCode { get; private set; }

        [JsonIgnore] // serialize islemi gerceklestirilirken, asagidaki property yok sayilacak. Bu propery bilgisi developer ozelinde olacak.
        public bool IsSuccessful { get; private set; } // private because in class internal set. 

        public ErrorDto Error { get; private set; } // private because in class internal set. 


        //


        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response<T> Success(int statusCode) // data donmeyecegimiz durumlar icin. 
        {
            return new Response<T> { Data = default, StatusCode = statusCode, IsSuccessful = true };
        }

        public static Response<T> Fail(ErrorDto errorDto, int statusCode) // multiple error message
        {
            return new Response<T>
            {
                Error = errorDto,
                StatusCode = statusCode,
                IsSuccessful = false
            };
        }

        public static Response<T> Fail(string errorMessage, int statusCode, bool isShow) // overload func. single error message
        {
            var errorDto = new ErrorDto(errorMessage, isShow);

            return new Response<T> { Error = errorDto, StatusCode = statusCode, IsSuccessful = false };
        }
    }
}
