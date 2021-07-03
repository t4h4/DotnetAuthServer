using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Dtos
{
    public class ErrorDto
    {
        //only in class property set with ctor
        public List<String> Errors { get; private set; } = new List<string>(); // Colloction; because to be multiple error
        //only in class property set with ctor
        public bool IsShow { get; private set; } // show error user or don't show error user.

        //

        public ErrorDto(string error, bool isShow) 
        {
            Errors.Add(error);
            IsShow = isShow;
        }

        public ErrorDto(List<string> errors, bool isShow)
        {
            Errors = errors;
            IsShow = isShow;
        }
    }
}
