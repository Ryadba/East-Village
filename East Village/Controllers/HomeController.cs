using East_Village.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return View(db.Categories.ToList());
        }

        public ActionResult Details(int ProductId)
        {
            var product = db.Products.Find(ProductId);

            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(ContactModel contact)
        {
            if (ModelState.IsValid)
            {
                var mail = new MailMessage();
                var loginInfo = new NetworkCredential("eastvillagemarketmpls@gmail.com", "kareem_123@");
                mail.From = new MailAddress(contact.Email);
                mail.To.Add(new MailAddress("eastvillagemarketmpls@gmail.com"));
                mail.Subject = contact.Subject;
                mail.IsBodyHtml = true;
                string body = "Name : " + contact.Name + "<br>" +
                            "Email : " + contact.Email + "<br>" +
                            "Subject : " + contact.Subject + "<br>" +
                            "Message : " + contact.Message;
                mail.Body = body;
                var smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = loginInfo;
                smtpClient.Send(mail);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string searchName)
        {
            var result = db.Products.Where(a => a.ProductTitle.Contains(searchName)
            || a.ProductContent.Contains(searchName)
            || a.Category.CategoryName.Contains(searchName)
            || a.Category.CategoryDescription.Contains(searchName)).ToList();
            return View(result);
        }

    }
}