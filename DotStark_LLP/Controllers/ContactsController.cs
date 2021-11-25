using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.DocumentEngine;
using DotStark_LLP.Models.Contact;
using DotStark_LLP.Services;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace DotStark_LLP.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            // Retrieves the page from the Kentico database
            TreeNode page = DocumentHelper.GetDocuments()
                .Path("/Contacts")
                .OnCurrentSite()
                .TopN(1)
                .FirstOrDefault();

            // Returns a 404 error when the retrieving is unsuccessful
            if (page == null)
            {
                return HttpNotFound();
            }

            // Initializes the page builder with the DocumentID of the page
            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            var bannerService = new BannerService();
            var contactService = new ContactService();
            var model = new IndexViewModel()
            {
                Images = contactService.GetImages().ToList(),
                Contacts = contactService.GetContacts().ToList()
            };
            return View(model);
        }
    }
}