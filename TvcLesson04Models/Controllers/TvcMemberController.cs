using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using TvcLesson04Models.Models.DataModels;

namespace TvcLesson04Models.Controllers
{
    public class TvcMemberController : Controller
    {
        private static readonly List<TvcMember> _tvcMembers = new List<TvcMember>()
        {
            new TvcMember
            {
                TvcMemberId = Guid.NewGuid().ToString(),
                TvcUserName = "admin",
                TvcPassword = "Admin@123",
                TvcFullName = "Trịnh Văn Chung",
                TvcEmail = "chungtrinhj@gmail.com"
            },
            new TvcMember
            {
                TvcMemberId = Guid.NewGuid().ToString(),
                TvcUserName = "chungtv",
                TvcPassword = "Chung@123",
                TvcFullName = "Trịnh Văn Chung",
                TvcEmail = "chungtv@gmail.com"
            },
            new TvcMember
            {
                TvcMemberId = Guid.NewGuid().ToString(),
                TvcUserName = "nguyenvanbinh",
                TvcPassword = "Binh@123",
                TvcFullName = "Nguyễn Văn Bình",
                TvcEmail = "nguyenvanbinh@gmail.com"
            },
            new TvcMember
            {
                TvcMemberId = Guid.NewGuid().ToString(),
                TvcUserName = "tranthihoa",
                TvcPassword = "Hoa@123",
                TvcFullName = "Trần Thị Hoa",
                TvcEmail = "tranthihhoa@gmail.com"
            },
            new TvcMember
            {
                TvcMemberId = Guid.NewGuid().ToString(),
                TvcUserName = "leminhduc",
                TvcPassword = "Duc@123",
                TvcFullName = "Lê Minh Đức",
                TvcEmail = "leminhduc@gmail.com"
            }
        };
        public IActionResult Index()
        {
            return View(_tvcMembers);
        }

        public IActionResult GetMember()
        {
            var tvcMember = new TvcMember();
            tvcMember.TvcMemberId = Guid.NewGuid().ToString();
            tvcMember.TvcFullName= "Chung Trịnh";
            tvcMember.TvcUserName = "chungtv";
            tvcMember.TvcPassword = "12345a@";
            tvcMember.TvcEmail = "chungtrinhj@gmail.com";

            ViewBag.TvcMember = tvcMember;

            return View(tvcMember);
        }

        // GET:
        public ActionResult Create()
        {
            var member = new TvcMember();
            return View(member);
        }

        [HttpPost]
        public ActionResult Create(TvcMember member)
        {
            member.TvcMemberId = Guid.NewGuid().ToString();
            _tvcMembers.Add(member);

            return RedirectToAction("Index");

        }
    }
}
