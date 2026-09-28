using Microsoft.AspNetCore.Mvc;
using LdnkThDay06.Models.DataModels;

namespace LdnkThDay06.Controllers
{
    public class MembersController : Controller
    {
        public static readonly List<Member> Members = new List<Member>();

        public IActionResult Index()
        {
            return View(Members);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(Member member)
        {
            string msg = null;
            bool isValid = true;
            if (member.Username.Length < 3 || member.Username.Length > 20)
            {
                msg = "<li>Username phai tu 3 den 20 ky tu.</li>";
                isValid = false;
            }
            string parternemail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(member.Email, parternemail))
            {
                msg += "<li>Email khong hop le.</li>";
                isValid = false;
            }
            if (member.Birthday.AddYears(18) > DateTime.Now)
            {
                msg += "<li>Ban chua du 18 tuoi.</li>";
                isValid = false;
            }
            string patternphone = @"^\d{10}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(member.Phone, patternphone))
            {
                msg += "<li>So dien thoai khong hop le.</li>";
                isValid = false;
            }
            if (isValid)
            {
                member.Id = Guid.NewGuid().ToString();
                Members.Add(member);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Msg = "<div class='alert alert-danger'>" + msg + "</div>";
                return View();
            }
        }

    }
}
