using System.ComponentModel.DataAnnotations;

namespace GGlease.Model.ViewModel
{
    public class ErrorModel
    {
        public ErrorModel(string errorMessage)
        {
            Title = errorMessage;
        }

        [Required]
        public string Title { get; set; } = null!;
    }
}