namespace Customers.Models.DTO
{
    public class ErrorDto
    {
        public string Title { get; set; }

        public string ErrorMessage { get; set; }

        public ErrorDto(string title, string errorMessage)
        {
            Title = title;
            ErrorMessage = errorMessage;
        }

        public ErrorDto(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}