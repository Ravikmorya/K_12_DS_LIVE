//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.DotStark;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(HomeFolder.CLASS_NAME, typeof(HomeFolder))]

namespace CMS.DocumentEngine.Types.DotStark
{
	/// <summary>
	/// Represents a content item of type HomeFolder.
	/// </summary>
	public partial class HomeFolder : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DotStark.HomeFolder";


		/// <summary>
		/// The instance of the class that provides extended API for working with HomeFolder fields.
		/// </summary>
		private readonly HomeFolderFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// Gets an object that provides extended API for working with HomeFolder fields.
		/// </summary>
		[RegisterProperty]
		public HomeFolderFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with HomeFolder fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class HomeFolderFields : AbstractHierarchicalObject<HomeFolderFields>
		{
			/// <summary>
			/// The content item of type HomeFolder that is a target of the extended API.
			/// </summary>
			private readonly HomeFolder mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="HomeFolderFields" /> class with the specified content item of type HomeFolder.
			/// </summary>
			/// <param name="instance">The content item of type HomeFolder that is a target of the extended API.</param>
			public HomeFolderFields(HomeFolder instance)
			{
				mInstance = instance;
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="HomeFolder" /> class.
		/// </summary>
		public HomeFolder() : base(CLASS_NAME)
		{
			mFields = new HomeFolderFields(this);
		}

		#endregion
	}
}