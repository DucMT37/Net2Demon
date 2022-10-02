using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Net2Demo.Models;
using Net2Demo.Models.Process

namespace Net2Demo.Controllers
{
    public class HomeController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        StringProcess strPro = new StringProcess();
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Create(string FullName)
        {
            string Message = "Hello" + FullName;
            //su dung ViewBag de gui du lieu Controller
            ViewBag.ThongBao = Message;
            return View();
        }

        //[HttpGet]

        public IActionResult GiaiPhuongTrinh()
        {
            return view();
        }

        [HttpPost]
        
        public IActionResult GiaiPhuongTrinh1(String heSoA, string heSoB, string heSoC)
        {
            string thongbaobacnhat = gpt.GiaiPhuongTrinh1(heSoA, heSoB);
            ViewBag.Message = ThongBaoBacNhat;
            return View();
           

        }

        [HttpPost]

        public IActionResult GiaiPhuongTrinh2(String heSoA, string heSoB, string heSoC)
        {
            string thong baobachai = gpt.GiaiPhuongTrinh2(heSoA, heSoB, heSoC);
            ViewBag.PT2 = ThongBaoBacHai;
            return View();
        }

        public IActionResult XuLyChuoi()
        {
            return View();
        }

        [HttpPost]

        Public IActionResult XuLyChuoi()
        {
            ViewBag.thongTin = strPro.RemoveRemaningWhiteSpace(strInput);
            ViewBag.thongTin = strPro.LowerToUpper(strInput);
            ViewBag.thongTin = strPro.UpperToLower(strInput);
            ViewBag.thongTin = strPro.CapitalizeOneFirstCharacter(strInput);
            ViewBag.thongTin = strPro.CapitalizeFirstCharacter(strInput);
            ViewBag.thongTin = strPro.RemoveVietnameseAccents(strInput);
            return View();
        }

    
    }
    
}
