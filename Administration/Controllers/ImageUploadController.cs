using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Text;

public class ImageUploadController : Controller
{
    private readonly IWebHostEnvironment _hostingEnvironment;

    public ImageUploadController(IWebHostEnvironment hostingEnvironment)
    {
        _hostingEnvironment = hostingEnvironment;
    }

    public string GetNewFileName(string fname)
    {
        if (string.IsNullOrEmpty(fname))
        {
            // Вернуть значение по умолчанию или сгенерировать новое имя файла
            return $"default_{DateTime.Now}.ext"; // Пример
        }

        string filePath = Path.Combine(_hostingEnvironment.WebRootPath, fname);
        if (!System.IO.File.Exists(filePath))
        {
            return fname;
        }

        // Генерация нового уникального имени файла
        string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(fname);
        string extension = Path.GetExtension(fname);
        string newFileName;
        int counter = 1;

        do
        {
            newFileName = $"{fileNameWithoutExtension}_{counter}{extension}";
            filePath = Path.Combine(_hostingEnvironment.WebRootPath, newFileName);
            counter++;
        } while (System.IO.File.Exists(filePath));

        return newFileName;
    }

    [HttpPost("upload-image"), ApiVersion("1")]
    public async Task<IActionResult> UploadImage(IFormFile file)
    {
        if (file == null || file.Length == 0)
            return BadRequest("Invalid file.");

        var targetDirectory = Path.Combine(_hostingEnvironment.WebRootPath, "uploaded-images");
        var newFName = GetNewFileName(file.FileName);
        var filePath = Path.Combine(targetDirectory, newFName);

        using (var fileStream = new FileStream(filePath, FileMode.Create))
        {
            await file.CopyToAsync(fileStream);
        }

        var fileUrl = $"{Request.Scheme}://{Request.Host}/uploaded-images/{newFName}";
        return Ok(new { imageUrl = fileUrl });
    }

}
