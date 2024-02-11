using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class FileController : ControllerBase
{
    private IConfiguration _configuration;
    public FileController(IConfiguration configuration)
    {
        _configuration = configuration;
    }
    [HttpPost("upload-pdf")]
    public async Task<IActionResult> UploadPdf([FromForm] FileUploadModel model)
    {
        try
        {
            if (model == null || model.PdfFile == null)
            {
                return BadRequest("PDF file is required.");
            }
            // Save the uploaded file
            var studentId = model.StudentId;
            var uploadsFolderPath = _configuration.GetValue<string>("React:FileUploadUrl");
            var fileExtension = "." + model.PdfFile.FileName.Split('.')[1];
            var fileName = model.PdfFile.FileName;
            var filePath = Path.Combine(uploadsFolderPath, Guid.NewGuid().ToString() + fileExtension);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await model.PdfFile.CopyToAsync(fileStream);
            }

            return Ok(new { FilePath = filePath });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    public class FileUploadModel
    {
        public IFormFile PdfFile { get; set; }
        public string StudentId { get; set; }
    }
}
