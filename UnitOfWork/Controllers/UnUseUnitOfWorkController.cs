using Microsoft.AspNetCore.Mvc;
using UnitOfWork.Servises;

namespace UnitOfWork.Controllers
{
    public class UnUseUnitOfWorkController : Controller
    {
        private readonly IClassDb1Repository _classDb1;
        private readonly IClassDb2Repository _classDb2;
        private readonly IClassDb3Repository _classDb3;
        private readonly IClassDb4Repository _classDb4;
        private readonly IClassDb5Repository _classDb5;

        public UnUseUnitOfWorkController(IClassDb1Repository classDb1, IClassDb2Repository classDb2, IClassDb3Repository classDb3, IClassDb4Repository classDb4, IClassDb5Repository classDb5)
        {
            _classDb1 = classDb1;
            _classDb2 = classDb2;
            _classDb3 = classDb3;
            _classDb4 = classDb4;
            _classDb5 = classDb5;
        }

        public IActionResult Index()
        {
            //ViewBag.ClassDb1Information = _classDb1.Add();
            //ViewBag.ClassDb2Information = _classDb2.GetById();
            //ViewBag.ClassDb3Information = _classDb3.Delete();
            //ViewBag.ClassDb4Information = _classDb4.Update();
            //ViewBag.ClassDb5Information = _classDb5.Exist();
            return View();
        }
    }
}
