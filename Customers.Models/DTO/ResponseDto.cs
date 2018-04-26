using System.Collections.Generic;

namespace Customers.Models.DTO
{
    public class ResponseDto<TResponseType>
    {
        public TResponseType Data { get; set; }
        
        public IEnumerable<ErrorDto> Errors { get; set; }

        public ResponseDto(TResponseType data)
        {
            Data = data;
        }

        public ResponseDto(IEnumerable<ErrorDto> errors)
        {
            Errors = errors;
        }

        public ResponseDto(ErrorDto error)
        {
            Errors = new List<ErrorDto> { error };
        }
    }
}