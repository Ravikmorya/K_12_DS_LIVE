using CMS.DocumentEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Models.Jobs
{
    public class JobsViewModel
    {
        public string JobOpenings { get; set; }
        public DocumentAttachment Image { get; set; }
        public string Text { get; set; }
        public string Graduation { get; set; }
        public string GraduationAsp { get; set; }
        public string GraduationAsp1 { get; set; }
        public string ASPNET { get; set; }
        public string Talent { get; set; }
        public string EXPERIENCED { get; set; }
        public string EXPERIENCED1 { get; set; }
        public string EXPERIENCED2 { get; set; }
        public string EXPERIENCED3 { get; set; }
        public string EXPERIENCEDRICH { get; set; }
        public DocumentAttachment EXPERIENCEDFile { get; set; }
        public string EXPERIENCEDManual { get; set; }
        public string STUDENTS { get; set; }
        public DocumentAttachment STUDENTSFILE { get; set; }
        public string STUDENTSRICH { get; set; }
        public string STUDENTS1 { get; set; }
        public string STUDENTS2 { get; set; }
        public DocumentAttachment File { get; set; }
        public DocumentAttachment Img_Pen { get; set; }
    }
}