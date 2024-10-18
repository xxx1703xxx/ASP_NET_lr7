using Microsoft.AspNetCore.Mvc;
using YourApp.Models;
using System.IO;

namespace YourApp.Controllers
{
    public class FileController : Controller
    {
        // Action to display the download form
        public IActionResult DownloadFileForm()
        {
            return View();
        }

        // Action to handle form submission and file download
        [HttpPost]
        public IActionResult DownloadFile(DownloadFileModel model)
        {
            if (ModelState.IsValid)
            {
                var fileContent = $"{model.FirstName} {model.LastName}";
                var fileName = model.FileName.EndsWith(".txt") ? model.FileName : $"{model.FileName}.txt"; // Ensure file has .txt extension
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

                System.IO.File.WriteAllText(filePath, fileContent); // Create the file

                // Return the file for download
                return File(System.IO.File.OpenRead(filePath), "text/plain", fileName);
            }

            return View("DownloadFileForm", model); // Show the form again with validation errors
        }
    }
}
