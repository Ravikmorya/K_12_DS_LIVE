using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.DotStark;
using DotStark_LLP.Models.ImageFolder;
using DotStark_LLP.Models.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DotStark_LLP.Services
{
    public class JobsService
    {
        public IEnumerable<JobsViewModel> GetJobss()
        {
            return DocumentHelper.GetDocuments<JobsSection>().AddColumns("JobsSectionImage", "JobsSectionJobOpenings",
                "JobsSectionText", "JobsSectionFile", "JobsSectionGraduation", "JobsSectionGraduationASP", 
                "JobsSectionGraduationASP1", "JobsSectionGraduationASPNET", "JobsSectionGraduationTalent", "JobsSectionEXPERIENCED",
                "JobsSectionEXPERIENCEDFILE", "JobsSectionEXPERIENCED1", "JobsSectionEXPERIENCED2", "JobsSectionEXPERIENCED3", 
                "JobsSectionEXPERIENCEDManual", "JobsSectionEXPERIENCEDRICH",
                "JobsSectionSTUDENTS", "JobsSectionSTUDENTSFILE", "JobsSectionSTUDENTSRICH", "JobsSectionSTUDENTS1",
                "JobsSectionSTUDENTS2", "JobsSectionImg_pen")
                .TopN(10).Select(x => new JobsViewModel
                {
                    JobOpenings = x.Fields.JobOpenings,
                    Image = x.Fields.Image,
                    Text = x.Fields.Text,
                    Graduation = x.Fields.Graduation,
                    File = x.Fields.File,
                    GraduationAsp = x.Fields.GraduationASP,
                    GraduationAsp1 = x.Fields.GraduationASP1,
                    ASPNET = x.Fields.GraduationASPNET,
                    Talent = x.Fields.GraduationTalent,
                    EXPERIENCED = x.Fields.EXPERIENCED,
                    EXPERIENCED1 = x.Fields.EXPERIENCED1,
                    EXPERIENCED2 = x.Fields.EXPERIENCED2,
                    EXPERIENCED3 = x.Fields.EXPERIENCED3,
                    EXPERIENCEDManual = x.Fields.EXPERIENCEDManual,
                    EXPERIENCEDFile = x.Fields.EXPERIENCEDFILE,
                    EXPERIENCEDRICH = x.Fields.EXPERIENCEDRICH,
                    STUDENTS = x.Fields.STUDENTS,
                    STUDENTSFILE = x.Fields.STUDENTSFILE,
                    STUDENTSRICH = x.Fields.STUDENTSRICH,
                    STUDENTS1 = x.Fields.STUDENTS1,
                    STUDENTS2 = x.Fields.STUDENTS2,
                    Img_Pen = x.Fields.Img_pen
                });
        }
    }
}