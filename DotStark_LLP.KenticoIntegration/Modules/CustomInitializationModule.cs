//using CMS;
//using CMS.IO;
//using DotStark_LLP.KenticoIntegration.Modules;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using CMS.Base;
//using CMS.DataEngine;
//using Module = CMS.DataEngine.Module;


//// Registers the custom module into the system (name matches the class we want to init)
//[assembly: RegisterModule(typeof(CustomInitializationModule))]


//namespace DotStark_LLP.KenticoIntegration.Modules
//{
//    public class CustomInitializationModule : Module
//    {
//        public CustomInitializationModule()
//            : base("CustomInit")
//        {
//        }

//        // Contains initialization code that is executed when the application starts
//        protected override void OnInit()
//        {
//            base.OnInit();

//            // Creates a new StorageProvider instance for Azure
//            var mediaProvider = StorageProvider.CreateAzureStorageProvider();

//            //Specifies the target container name in Azure Storage
//            mediaProvider.CustomRootPath = "cms";

//            // Makes the container publicly accessible
//            mediaProvider.PublicExternalFolderObject = true;

//            // Maps a directory to the provider
//            // Full path of this code CustomRootPath and MapStoragePath == "~/dancinggoatmvc/media/"
//            // For multisite installations loop through all of the Sites and make a call to MapStoragePath for each site
//            StorageHelper.MapStoragePath("~/DotStark_LLP/Media", mediaProvider);
//        }
//    }
//}
