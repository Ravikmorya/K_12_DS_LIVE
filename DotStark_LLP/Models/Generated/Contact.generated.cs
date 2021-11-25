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

[assembly: RegisterDocumentType(Contact.CLASS_NAME, typeof(Contact))]

namespace CMS.DocumentEngine.Types.DotStark
{
	/// <summary>
	/// Represents a content item of type Contact.
	/// </summary>
	public partial class Contact : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "DotStark.Contact";


		/// <summary>
		/// The instance of the class that provides extended API for working with Contact fields.
		/// </summary>
		private readonly ContactFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ContactID.
		/// </summary>
		[DatabaseIDField]
		public int ContactID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ContactID"), 0);
			}
			set
			{
				SetValue("ContactID", value);
			}
		}


		/// <summary>
		/// Banner.
		/// </summary>
		[DatabaseField]
		public Guid ContactBanner
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ContactBanner"), Guid.Empty);
			}
			set
			{
				SetValue("ContactBanner", value);
			}
		}


		/// <summary>
		/// Phone.
		/// </summary>
		[DatabaseField]
		public string ContactPhone
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ContactPhone"), @"");
			}
			set
			{
				SetValue("ContactPhone", value);
			}
		}


		/// <summary>
		/// Email.
		/// </summary>
		[DatabaseField]
		public string ContactEmail
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ContactEmail"), @"");
			}
			set
			{
				SetValue("ContactEmail", value);
			}
		}


		/// <summary>
		/// OurLocation.
		/// </summary>
		[DatabaseField]
		public string ContactOurLocation
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ContactOurLocation"), @"");
			}
			set
			{
				SetValue("ContactOurLocation", value);
			}
		}


		/// <summary>
		/// Consider.
		/// </summary>
		[DatabaseField]
		public string ContactConsider
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ContactConsider"), @"");
			}
			set
			{
				SetValue("ContactConsider", value);
			}
		}


		/// <summary>
		/// Development.
		/// </summary>
		[DatabaseField]
		public string ContactDevelopment
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ContactDevelopment"), @"");
			}
			set
			{
				SetValue("ContactDevelopment", value);
			}
		}


		/// <summary>
		/// CountryName.
		/// </summary>
		[DatabaseField]
		public string ContactCountryName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ContactCountryName"), @"");
			}
			set
			{
				SetValue("ContactCountryName", value);
			}
		}


		/// <summary>
		/// Address.
		/// </summary>
		[DatabaseField]
		public string ContactAddress
		{
			get
			{
				return ValidationHelper.GetString(GetValue("ContactAddress"), @"");
			}
			set
			{
				SetValue("ContactAddress", value);
			}
		}


		/// <summary>
		/// Img Pen.
		/// </summary>
		[DatabaseField]
		public Guid ContactImgPen
		{
			get
			{
				return ValidationHelper.GetGuid(GetValue("ContactImgPen"), Guid.Empty);
			}
			set
			{
				SetValue("ContactImgPen", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with Contact fields.
		/// </summary>
		[RegisterProperty]
		public ContactFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with Contact fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ContactFields : AbstractHierarchicalObject<ContactFields>
		{
			/// <summary>
			/// The content item of type Contact that is a target of the extended API.
			/// </summary>
			private readonly Contact mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ContactFields" /> class with the specified content item of type Contact.
			/// </summary>
			/// <param name="instance">The content item of type Contact that is a target of the extended API.</param>
			public ContactFields(Contact instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ContactID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ContactID;
				}
				set
				{
					mInstance.ContactID = value;
				}
			}


			/// <summary>
			/// Banner.
			/// </summary>
			public DocumentAttachment Banner
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ContactBanner");
				}
			}


			/// <summary>
			/// Phone.
			/// </summary>
			public string Phone
			{
				get
				{
					return mInstance.ContactPhone;
				}
				set
				{
					mInstance.ContactPhone = value;
				}
			}


			/// <summary>
			/// Email.
			/// </summary>
			public string Email
			{
				get
				{
					return mInstance.ContactEmail;
				}
				set
				{
					mInstance.ContactEmail = value;
				}
			}


			/// <summary>
			/// OurLocation.
			/// </summary>
			public string OurLocation
			{
				get
				{
					return mInstance.ContactOurLocation;
				}
				set
				{
					mInstance.ContactOurLocation = value;
				}
			}


			/// <summary>
			/// Consider.
			/// </summary>
			public string Consider
			{
				get
				{
					return mInstance.ContactConsider;
				}
				set
				{
					mInstance.ContactConsider = value;
				}
			}


			/// <summary>
			/// Development.
			/// </summary>
			public string Development
			{
				get
				{
					return mInstance.ContactDevelopment;
				}
				set
				{
					mInstance.ContactDevelopment = value;
				}
			}


			/// <summary>
			/// CountryName.
			/// </summary>
			public string CountryName
			{
				get
				{
					return mInstance.ContactCountryName;
				}
				set
				{
					mInstance.ContactCountryName = value;
				}
			}


			/// <summary>
			/// Address.
			/// </summary>
			public string Address
			{
				get
				{
					return mInstance.ContactAddress;
				}
				set
				{
					mInstance.ContactAddress = value;
				}
			}


			/// <summary>
			/// Img Pen.
			/// </summary>
			public DocumentAttachment ImgPen
			{
				get
				{
					return mInstance.GetFieldDocumentAttachment("ContactImgPen");
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="Contact" /> class.
		/// </summary>
		public Contact() : base(CLASS_NAME)
		{
			mFields = new ContactFields(this);
		}

		#endregion
	}
}