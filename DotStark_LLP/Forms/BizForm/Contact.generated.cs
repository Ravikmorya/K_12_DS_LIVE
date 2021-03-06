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
using CMS.OnlineForms.Types;
using CMS.OnlineForms;

[assembly: RegisterBizForm(ContactItem.CLASS_NAME, typeof(ContactItem))]

namespace CMS.OnlineForms.Types
{
	/// <summary>
	/// Represents a content item of type ContactItem.
	/// </summary>
	public partial class ContactItem : BizFormItem
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "BizForm.Contact";


		/// <summary>
		/// The instance of the class that provides extended API for working with ContactItem fields.
		/// </summary>
		private readonly ContactItemFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// First Name.
		/// </summary>
		[DatabaseField]
		public string FirstName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("FirstName"), @"");
			}
			set
			{
				SetValue("FirstName", value);
			}
		}


		/// <summary>
		/// Email.
		/// </summary>
		[DatabaseField]
		public string EmailInput
		{
			get
			{
				return ValidationHelper.GetString(GetValue("EmailInput"), @"");
			}
			set
			{
				SetValue("EmailInput", value);
			}
		}


		/// <summary>
		/// Last Name.
		/// </summary>
		[DatabaseField]
		public string LastName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("LastName"), @"");
			}
			set
			{
				SetValue("LastName", value);
			}
		}


		/// <summary>
		/// Phone.
		/// </summary>
		[DatabaseField]
		public string Phone
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Phone"), @"");
			}
			set
			{
				SetValue("Phone", value);
			}
		}


		/// <summary>
		/// Your Massage.
		/// </summary>
		[DatabaseField]
		public string YourMassage
		{
			get
			{
				return ValidationHelper.GetString(GetValue("YourMassage"), @"");
			}
			set
			{
				SetValue("YourMassage", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with ContactItem fields.
		/// </summary>
		[RegisterProperty]
		public ContactItemFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with ContactItem fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ContactItemFields : AbstractHierarchicalObject<ContactItemFields>
		{
			/// <summary>
			/// The content item of type ContactItem that is a target of the extended API.
			/// </summary>
			private readonly ContactItem mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ContactItemFields" /> class with the specified content item of type ContactItem.
			/// </summary>
			/// <param name="instance">The content item of type ContactItem that is a target of the extended API.</param>
			public ContactItemFields(ContactItem instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// First Name.
			/// </summary>
			public string FirstName
			{
				get
				{
					return mInstance.FirstName;
				}
				set
				{
					mInstance.FirstName = value;
				}
			}


			/// <summary>
			/// Email.
			/// </summary>
			public string EmailInput
			{
				get
				{
					return mInstance.EmailInput;
				}
				set
				{
					mInstance.EmailInput = value;
				}
			}


			/// <summary>
			/// Last Name.
			/// </summary>
			public string LastName
			{
				get
				{
					return mInstance.LastName;
				}
				set
				{
					mInstance.LastName = value;
				}
			}


			/// <summary>
			/// Phone.
			/// </summary>
			public string Phone
			{
				get
				{
					return mInstance.Phone;
				}
				set
				{
					mInstance.Phone = value;
				}
			}


			/// <summary>
			/// Your Massage.
			/// </summary>
			public string YourMassage
			{
				get
				{
					return mInstance.YourMassage;
				}
				set
				{
					mInstance.YourMassage = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactItem" /> class.
		/// </summary>
		public ContactItem() : base(CLASS_NAME)
		{
			mFields = new ContactItemFields(this);
		}

		#endregion
	}
}