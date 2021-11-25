using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CMS.DocumentEngine;
using DotStark_LLP.Models.Story;
using DotStark_LLP.Services;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace DotStark_LLP.Controllers
{
    public class StoryController : Controller
    {
        // GET: Story
        public ActionResult Index()
        {
            //var storyView = new StoryViewModel();
            var storyService = new StoryService();
            var model = new IndexViewModel()
            {
                //StorySections = 
                Storys = storyService.GetStorys().ToList()
            };
            return View(model);
        }
    }
}