using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models.Story
{
    public class StoryViewModel
    {
        public string Heading { get; set; }
        public string Text { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        public string Text4 { get; set; }
        public string Text5 { get; set; }
        public DocumentAttachment Image { get; set; }

        //public static StoryViewModel GetViewModel(StorySection storySection)
        //{
        //    return storySection == null ? null : new StoryViewModel
        //    {
        //        Heading = storySection.Fields.Heading,
        //        Text = storySection.Fields.Text,
        //        Text1 = storySection.Fields.Text1,
        //        Image = storySection.Fields.Image
        //    };
        //}
    }
}