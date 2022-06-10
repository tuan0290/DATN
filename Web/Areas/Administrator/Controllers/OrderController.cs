using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Services.Common;
using Services.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    public class OrderController : BaseController
    {
        private readonly ICommonService commonService;
        private readonly IOrderService orderService;
        private readonly IWebHostEnvironment hostingEnvironment;
        private IConfiguration iConfig;
        public OrderController(ICommonService commonService, IOrderService newsService, IWebHostEnvironment hostingEnvironment, IConfiguration iConfig)
        {
            this.commonService = commonService;
            this.orderService = newsService;
            this.hostingEnvironment = hostingEnvironment;
            this.iConfig = iConfig;
        }
        public IActionResult Index(int status)
        {
            if (status == 0)
            {
                ViewBag.TitleForm = "Danh sách đơn hàng";
            }
            else if (status == 1)
            {
                ViewBag.TitleForm = "Danh sách đơn hàng chờ xác nhận";
            }
            else if (status == 2)
            {
                ViewBag.TitleForm = "Danh sách đơn hàng chờ giao hàng";
            }
            else if (status == 3)
            {
                ViewBag.TitleForm = "Danh sách đơn hàng đang được giao";
            }
            else if (status == 4)
            {
                ViewBag.TitleForm = "Danh sách đơn hàng đã được giao";
            }
            else if (status == -1)
            {
                ViewBag.TitleForm = "Danh sách đơn hàng đã hủy";
            }
            else if (status == -2)
            {
                ViewBag.TitleForm = "Danh sách đơn hàng giao thất bại";
            }
            ViewBag.CurrentStatus = status;
            var data = orderService.GetOrders(status);
            data = data.OrderByDescending(x => x.CreatedDate).ToList();
            return View(data);
        }
        [HttpGet]
        public IActionResult ChangeStatus(int order, int status, int current)
        {
            if (status != 1 && status != 2 && status != 3 && status != 4 && status != -1 && status != -2)
            {
                SetAlert("error", "Thao tác không đúng!");
                return RedirectToAction("Index", "Order", new { status = current });
            }
            var change = orderService.ChangeStatus(order, status);
            if (change)
            {
                SetAlert("success", "Cập nhật trạng thái đơn thành công!");
                return RedirectToAction("Index", "Order", new { status = current });
            }
            else
            {
                SetAlert("error", "Có lỗi trong quá trình cập nhật dữ liệu!");
                return RedirectToAction("Index", "Order", new { status = current });
            }
        }
        public IActionResult Details(int id, int current)
        {
            var data = orderService.GetDetailsOrderByOrderId(id);
            if(data == null)
            {
                SetAlert("error", "Không tìm thấy dữ liệu!");
                return RedirectToAction("Index", "Order", new { status = 1 });
            }
            ViewBag.CurrentStatus = current;
            return View(data);
        }
    }
}
