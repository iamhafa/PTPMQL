using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PTPMQL.Models;
using PTPMQL.Models.ExcelProcess;

namespace PTPMQL.Controllers
{
    public class KhachHangsController : Controller
    {
        private DemoDbConText db = new DemoDbConText();
        ReadExcel excel = new ReadExcel();

        // GET: KhachHangs

        public ActionResult Index()
        {
            return View(db.KhachHangs.ToList());
        }

        // GET: KhachHangs/Details/5

        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = db.KhachHangs.Find(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // GET: KhachHangs/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: KhachHangs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]


        public ActionResult Create([Bind(Include = "IDKhachHang,TenKH,DiaChi,SoBan")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                db.KhachHangs.Add(khachHang);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(khachHang);
        }

        // GET: KhachHangs/Edit/5

        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = db.KhachHangs.Find(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHangs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]


        public ActionResult Edit([Bind(Include = "IDKhachHang,TenKH,DiaChi,SoBan")] KhachHang khachHang)
        {
            if (ModelState.IsValid)
            {
                db.Entry(khachHang).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(khachHang);
        }

        // GET: KhachHangs/Delete/5

        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            KhachHang khachHang = db.KhachHangs.Find(id);
            if (khachHang == null)
            {
                return HttpNotFound();
            }
            return View(khachHang);
        }

        // POST: KhachHangs/Delete/5
        [HttpPost, ActionName("Delete")]


        public ActionResult DeleteConfirmed(string id)
        {
            KhachHang khachHang = db.KhachHangs.Find(id);
            db.KhachHangs.Remove(khachHang);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //upload file excel controller
        [HttpPost]

        public ActionResult Upload(HttpPostedFileBase file)
        {
            // đặt tên cho file
            //[PHẢI DÙNG FILE EXCEL ĐUÔI .XLS]
            string _FileName = "KhachHang.xls";


            //đường dẫn lưu file
            string _path = Path.Combine(Server.MapPath("~/Uploads/Excels"), _FileName);

            //lưu file lên server
            file.SaveAs(_path);

            //doc DL tu file excel
            DataTable dt = excel.ReadDataFromExcelFile(_path);
            //CopyDataByBulk(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang kh = new KhachHang();
                kh.IDKhachHang = dt.Rows[i][0].ToString();
                kh.TenKH = dt.Rows[i][1].ToString();
                kh.DiaChi = dt.Rows[i][2].ToString();
                kh.SoBan = dt.Rows[i][3].ToString();
                db.KhachHangs.Add(kh);
                db.SaveChanges();
            }

            try
            {
                //upload file thành công và file có dữ liệu
                if (file.ContentLength > 0)
                {
                    //Your code doc file excel ban upload len va tra ve data table
                    CopyDataByBulk(excel.ReadDataFromExcelFile(_path));
                }
            }
            catch (Exception ex)
            {
                //nếu upload file thất bại
                ViewBag.ThongBao = "Ghi du lieu that bai";
            }
            return RedirectToAction("Index");
        }
        public ActionResult DownloadFile()
        {
            //duong dan chua file muon download
            string path = AppDomain.CurrentDomain.BaseDirectory + "Uploads/Excels/";
            //chuyen file sang dang byte
            byte[] fileBytes = System.IO.File.ReadAllBytes(path + "KhachHang.xls");
            //ten file khi download ve
            string fileName = "Alo.xls";
            //tra ve file
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

        private void CopyDataByBulk(DataTable dt) //day toan bo du lieu cua data Table len server
        {
            //lấy kết nối với database lưu trong file web.config

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ExcelDbConText"].ConnectionString);
            SqlBulkCopy bulkcopy = new SqlBulkCopy(con);
            bulkcopy.DestinationTableName = "KhachHangs";
            bulkcopy.ColumnMappings.Add(0, "IDKhachHang");
            bulkcopy.ColumnMappings.Add(1, "TenKH");
            bulkcopy.ColumnMappings.Add(2, "DiaChi");
            bulkcopy.ColumnMappings.Add(3, "SoBan");
            con.Open();
            bulkcopy.WriteToServer(dt);
            con.Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
