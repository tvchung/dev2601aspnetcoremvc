using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TvcLesson04Models.Models.DataModels;

namespace TvcLesson04Models.Controllers
{
    public class TvcMembersController : Controller
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

        // GET: TvcMembersController => hiển thị danh sách thành viên
        public ActionResult Index()
        {
            return View(_tvcMembers);
        }

        /// <summary>
        ///  Xem chi tiết thành viên
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: TvcMembersController/Details/5
        public ActionResult Details(string id)
        {
            TvcMember tvcMember = _tvcMembers.FirstOrDefault(x => x.TvcMemberId == id);
            return View(tvcMember);
        }

        /// <summary>
        /// Form thêm mới
        /// </summary>
        /// <returns></returns>
        // GET: TvcMembersController/Create
        public ActionResult Create()
        {
            TvcMember tvcMember = new TvcMember();
            return View(tvcMember);
        }

        /// <summary>
        /// Xử lý khi submit form
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: TvcMembersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TvcMember tvcMember)
        {
            try
            {
                tvcMember.TvcMemberId = Guid.NewGuid().ToString();
                _tvcMembers.Add(tvcMember);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(tvcMember);
            }
        }

        /// <summary>
        /// Form sửa thành  viên
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: TvcMembersController/Edit/5
        public ActionResult Edit(string id)
        {
            var tvcmember = _tvcMembers.Where(x=>x.TvcMemberId.Equals(id)).FirstOrDefault();
            return View(tvcmember);
        }

        /// <summary>
        /// Xử lý khi người dùng submit form (cập nhật)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="collection"></param>
        /// <returns></returns>
        // POST: TvcMembersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, TvcMember  tvcMember)
        {
            try
            {
                for(int i = 0;i < _tvcMembers.Count; i++)
                {
                    if (_tvcMembers[i].TvcMemberId.Equals(id))
                    {
                        _tvcMembers[i].TvcMemberId = id;
                        _tvcMembers[i].TvcUserName = tvcMember.TvcUserName;
                        _tvcMembers[i].TvcFullName = tvcMember.TvcFullName;
                        _tvcMembers[i].TvcPassword = tvcMember.TvcPassword;
                        _tvcMembers[i].TvcEmail = tvcMember.TvcEmail;

                        break;
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        /// <summary>
        /// Mở form trước khi xóa
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET: TvcMembersController/Delete/5
        public ActionResult Delete(string id)
        {
            var tvcmember = _tvcMembers.Where(x => x.TvcMemberId.Equals(id)).FirstOrDefault();
            return View(tvcmember);
        }

        // POST: TvcMembersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, TvcMember tvcMember)
        {
            try
            {
                foreach (var member in _tvcMembers)
                {
                    if (member.TvcMemberId.Equals(id))
                    {
                        _tvcMembers.Remove(member);
                        break;
                    }
                }
               
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
