using Microsoft.AspNetCore.Mvc;
using st10230365Poe.Data;
using st10230365Poe.Models;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace st10230365Poe.Controllers
{
    public class ImageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ImageController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var images = await _context.Images.ToListAsync();
            return View(images);
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile image)
        {
            if (image != null && image.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await image.CopyToAsync(memoryStream);
                    var imageData = memoryStream.ToArray();

                    var imageModel = new ImageModel
                    {
                        Name = image.FileName,
                        ImageData = imageData
                    };

                    _context.Images.Add(imageModel);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult DownloadImage(int id)
        {
            var image = _context.Images.FirstOrDefault(i => i.Id == id);
            if (image != null)
            {
                return File(image.ImageData, "image/jpeg", image.Name);
            }
            return NotFound();
        }
    }
}
