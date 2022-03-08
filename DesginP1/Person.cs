//---------------------------------------------------------------------------
//	System		:	Personal Management
//	Class Name	:	MST020160P
//	Overview	:	Dự án tranning
//	Designer	:	baolv＠SSV
//	Programmer	:	baolv＠SSV
//	Created Date:	2022/01/06
//
#region ----------< History >------------------------------------------------
//	ID			:	
//	Designer	:	
//	Programmer	:	
//	Updated Date:	
//	Comment		:	
//	Version		:	
//---------------------------------------------------------------------------
#endregion

#region using

// Microsoft.NET Framework
using System;

#endregion using

namespace DesginP1
	{
		/// <summary>
		///Thông tin người dùng
		/// </summary>
		class Person
		{
			#region Mã người dùnng
			
			/// <summary>
			///Trường  hiển thị mã người dùng
			/// </summary>
			private int iCustNo;
			/// <summary>
			/// Phương thức khởi mã người dùng
			/// </summary>
			public int ICustNo
			{
				get { return iCustNo; }
				set { iCustNo = value; }
			}

			#endregion Mã người dùnng

			#region Tên người dùng

			/// <summary>
			/// Trường hiển thị tên người dùng
			/// </summary>
			private String strName;
			/// <summary>
			/// Phương thức khởi tạo người dùng
			/// </summary>
			public String StrName
			{
				get { return strName; }
				set { strName = value; }
			}

			#endregion Tên người dùng

			#region Tên tiếng nhật

			/// <summary>
			/// Trường hiển thị tên tiếng nhất người dùng
			/// </summary>
			private String strNameKana;
			/// <summary>
			/// Phương thức khởi tạo tên tiếng nhật người dùng
			/// </summary>
			public String StrNameKana
			{
				get { return strNameKana; }
				set { strNameKana = value; }
			}

			#endregion Tên tiếng nhật

			#region Ngày sinh nhật

			/// <summary>
			///Trường hiển thị sinh nhật 
			/// </summary>
			private DateTime dtBirthDay;
			/// <summary>
			/// Phương thức khởi tạo sinh nhật
			/// </summary>
			public DateTime DtBirthDay
			{
				get { return dtBirthDay; }
				set { dtBirthDay = value; }
			}

			#endregion Ngày sinh nhật

			#region Giới tính

			/// <summary>
			/// Trường hiển thị giới tính
			/// </summary>
			private String strSex;
			/// <summary>
			/// Phương thức khởi tạo giới tính
			/// </summary>
			public String StrSex
			{
				get { return strSex; }
				set { strSex = value; }
			}

			#endregion Giới tính
		}
	}
