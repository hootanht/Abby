using Abby.DataAccess.Repository.IRepository;
using Abby.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Abby.Web.Pages.Admin.FoodTypes
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public IndexModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public List<FoodType> FoodTypes { get; set; }
        public void OnGet()
        {
            FoodTypes = _unitOfWork.FoodTypeRepository.GetAll().ToList();
        }
    }
}
