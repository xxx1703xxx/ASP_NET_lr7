using System.ComponentModel.DataAnnotations;

namespace YourApp.Models
{
    public class DownloadFileModel
    {
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "File Name is required.")]
        public string FileName { get; set; }
    }
}
