using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Models;
using UnitOfWork.Servises;

namespace UnitOfWork.Controllers
{
    public class UseUnitOfWorkController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UseUnitOfWorkController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            //ViewBag.ClassDb1Information = _unitOfWork.Class1Repositories.Add();
            //ViewBag.ClassDb2Information = _unitOfWork.Class2Repositories.GetById();
            //ViewBag.ClassDb3Information = _unitOfWork.Class3Repositories.Delete();
            //ViewBag.ClassDb4Information = _unitOfWork.Class4Repositories.Update();
            //ViewBag.ClassDb5Information = _unitOfWork.Class5Repositories.Exist();
            return View();
        }
    }
}
