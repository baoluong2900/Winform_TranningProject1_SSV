//---------------------------------------------------------------------------
//	System		:	Personal Information Management
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
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#endregion using

namespace DesginP1
{
	/// <summary>
	/// Chức năng phần mềm
	/// </summary>
	public partial class DesginP1 : Form
	{
		#region const

		/// <summary>FORMAT_YYYYMMDD</summary>
		const string FORMAT_YYYYMMDD = "yyyy/MM/dd";

		/// <summary>MSG_FAILURE_ENTER_CUSTNO</summary>
		const string MSG_FAILURE_ENTER_CUSTNO = "Chưa nhập CustNo";

		/// <summary>MSG_FAILURE_ENTER_NAME</summary>
		const string MSG_FAILURE_ENTER_NAME = "Chưa nhập Name";

		/// <summary>MSG_FAILURE_ENTER_NAMEKANA</summary>
		const string MSG_FAILURE_ENTER_NAMEKANA = "Chưa nhập Name Kana";

		/// <summary>MSG_FAILURE_ENTER_BIRTHDAY</summary>
		const string MSG_FAILURE_ENTER_BIRTHDAY = "Chưa nhập Ngày sinh";

		/// <summary>MSG_SUCCESS_ADD_PERSON</summary>
		const string MSG_SUCCESS_ADD_PERSON = "Thêm thành công";

		/// <summary>MSG_FAILURE_CHECK_ISNUMBER</summary>
		const string MSG_FAILURE_CHECK_ISNUMBER = "Mã phải là kiểu số";

		/// <summary>SG_SUCCESS_UPDATE_PERSON </summary>
		const string MSG_SUCCESS_UPDATE_PERSON = "Update thành công";

		/// <summary>MSG_SUCCESS_DELETE_PERSON </summary>
		const string MSG_SUCCESS_DELETE_PERSON = "Xóa thành công";

		/// <summary>MSG_FAILURE_DELETE_PERSON</summary>
		const string MSG_FAILURE_DELETE_PERSON = "Xóa thất bại";

		/// <summary>MSG_FAILURE_ENTER_PERSON</summary>
		const string MSG_FAILURE_ENTER_PERSON = "Vui lòng nhập ngày ";

		/// <summary>MSG_FAILURE_SELECT_PERSON</summary>
		const string MSG_FAILURE_SELECT_PERSON = "Vui lòng chọn ";

		/// <summary>MSG_SUCCESS_SEARCH_PERSON</summary>
		const string MSG_SUCCESS_SEARCH_PERSON = "Tìm kiếm thành công";

		/// <summary>MSG_FAILURE_SEARCH_PERSON</summary>
		const string MSG_FAILURE_SEARCH_PERSON = "Không tìm thấy";

		/// <summary>NUMER_VALUE</summary>
		const string NUMER_VALUE = "0";

		/// <summary>MSG_FAILURE_SEARCH_CUSTNO_OR_DATE</summary>
		const string MSG_FAILURE_SEARCH_CUSTNO_OR_DATE = "Chưa nhập Cust No hoặc ngày tìm kiếm ";

		/// <summary>MSG_FAILURE_ENTER_COMPARE_DATE</summary>
		const string MSG_FAILURE_ENTER_COMPARE_DATE = "Ngày trước lớn hơn ngày sau";

		/// <summary>MSG_FAILURE_SELECT_QUERY</summary>
		const string MSG_FAILURE_SELECT_QUERY = "Vui lòng chọn thông cần truy vấn";

		/// <summary>MSG_FAILURE_ADD_EXIST</summary>
		const string MSG_FAILURE_ADD_EXIST = "Thông tin người dùng đã tồn tại";

		/// <summary>FORMAT_HHMMSS</summary>
		const string FORMAT_HHMMSS = "hh:mm:ss";

		/// <summary>VALUE_MALE</summary>
		const string VALUE_MALE = "Nam";

		/// <summary>VALUE_FEMALE</summary>
		const string VALUE_FEMALE = "Nữ";

		#endregion

		/// <summary>
		/// Danh sách chứa thông tin người dùng
		/// </summary>
		private List<Person> persons = new List<Person>();

		#region Hàm khởi tạo phương trước chạy đầu tiên

		/// <summary>
		/// Hàm gọi các chức năng
		/// </summary>
		public DesginP1()
		{
			InitializeComponent();
			LoadListPerson();
		}

		#endregion Hàm khởi tạo phương trước chạy đầu tiên

		#region Hàm đếm số lượng hàng của bảng thông tin người dùng

		/// <summary>
		/// Trả về số dòng có trong bảng
		/// </summary>
		private void NumberRows()
		{
			txtNumberRows.Text = lvPersonTable.Items.Count.ToString();
		}

		#endregion Hàm đếm số lượng hàng của bảng thông tin người dùng

		#region Hàm kiểm tra chuỗi có phải số

		/// <summary>
		/// Kiểm tra chuỗi đó có phải số nguyên không nếu không phải về true và ngược lại trở false
		/// </summary>
		/// <param name="s"></param>
		/// <returns>Trả về true/ false</returns>
		private static bool IsNumeric(string s)
		{
			/// <summary>
			/// Ép kiểu chuỗi dữ liệu nhập vào thành kiểu double
			/// Nếu chuyển về không được thì chuỗi ký tự nhập vào là số chuỗi 
			/// Ngược lại là số
			/// </summary>
			double retNum;
			bool isNum = Double.TryParse( Convert.ToString(s.Trim()), System.Globalization.NumberStyles.Any,
											System.Globalization.NumberFormatInfo.InvariantInfo, out retNum );
			return isNum;
		}

		#endregion Hàm kiểm tra chuỗi có phải số

		#region Hàm mới thông tin người dùng

		/// <summary>
		/// Thêm mới thông tin người dùng
		/// </summary>
		private void AddPerson()
		{
			if ( String.IsNullOrEmpty ( txtCusNo.Text.Trim() ) )
			{
				MessageBox.Show( MSG_FAILURE_ENTER_CUSTNO );
				txtCusNo.BackColor = Color.Red;
			}
			else if ( String.IsNullOrEmpty ( txtName.Text.Trim() ) )
			{
				MessageBox.Show( MSG_FAILURE_ENTER_NAME );
				txtName.BackColor = Color.Red;
			}
			else if (String.IsNullOrEmpty ( txtNameKana.Text.Trim() ) )
			{
				MessageBox.Show( MSG_FAILURE_ENTER_NAME );
				txtNameKana.BackColor = Color.Red;
			}
			else if (dtpBirthDay.Text == " ")
			{
				MessageBox.Show( MSG_FAILURE_ENTER_NAME );
				dtpBirthDay.ForeColor = Color.Red;
				lblBirthDay.ForeColor = Color.Red;
			}
			else if (IsNumeric( txtCusNo.Text.Trim() ) == false)
			{
				MessageBox.Show( MSG_FAILURE_CHECK_ISNUMBER );
				txtCusNo.BackColor = Color.Red;
			}
			else
			{
				try
				{
					Person per = new Person();
					per.ICustNo = int.Parse( txtCusNo.Text );
					per.StrName = txtName.Text;
					per.StrNameKana = txtNameKana.Text;
					per.DtBirthDay = dtpBirthDay.Value;
					if ( dmcbSex.Checked )
					{
						per.StrSex = VALUE_MALE;
					}
					else
					{
						per.StrSex = VALUE_FEMALE;
					}
					persons.Add( per );
					GetListPerson( persons );
					MessageBox.Show( MSG_SUCCESS_ADD_PERSON );
				}
				catch
				{
					MessageBox.Show( MSG_FAILURE_CHECK_ISNUMBER );
				}
			}
		}

		#endregion Hàm mới thông tin người dùng

		#region Hàm nạp dữ liệu vào danh sách người dùng

		/// <summary>
		/// Nạp dữ liệu vào object
		/// </summary>
		private void LoadListPerson()
		{
			persons.Add( new Person { ICustNo = 1, StrName = "Nguyen Van A", StrNameKana = "Ten tieng nhat", DtBirthDay = DateTime.Parse( "2000/05/01" ), StrSex = "Nữ" } );
			persons.Add( new Person { ICustNo = 2, StrName = "Nguyen Van B", StrNameKana = "Ten tieng nhat", DtBirthDay = DateTime.Parse( "1999/08/01" ), StrSex = "Nam" } );
			persons.Add( new Person { ICustNo = 3, StrName = "Nguyen Van C", StrNameKana = "Ten tieng nhat", DtBirthDay = DateTime.Parse( "2018/01/15" ), StrSex = "Nữ" } );
			persons.Add( new Person { ICustNo = 4, StrName = "Nguyen Van C", StrNameKana = "Ten tieng nhat", DtBirthDay = DateTime.Parse( "2020/01/15" ), StrSex = "Nam" } );
		}

		#endregion Hàm nạp dữ liệu vào danh sách người dùng

		#region Hàm Hiển thị thôn tin người dùng được thêm vào

		/// <summary>
		/// Hiển thị danh sách người dùng và cập nhật số lượng hàng khi thêm mới vào
		/// </summary>
		/// <param name="list"></param>
		private void GetListPerson ( List<Person> list )
		{
			lvPersonTable.Items.Clear();
			list.ForEach
			( listPerson =>
				{
					ListViewItem item = new ListViewItem( ( lvPersonTable.Items.Count + 1 ) + "" );
					item.SubItems.Add( listPerson.ICustNo + "" );
					item.SubItems.Add( listPerson.StrName );
					item.SubItems.Add( listPerson.StrNameKana );
					item.SubItems.Add( listPerson.DtBirthDay.ToString( FORMAT_YYYYMMDD ) );
					item.SubItems.Add( listPerson.StrSex );
					lvPersonTable.Items.Add( item );
				}
			);
		}

		#endregion Hàm Hiển thị thôn tin người dùng được thêm vào

		#region Hàm đếm tất cả tên người dùng theo một mã bất kỳ

		/// <summary>
		///Đếm tên người theo mã được truyền vào
		/// </summary>
		/// <param name="strNameSearchCount"></param>
		private void CountPersonByName( String strNameSearchCount )
		{
			var varResult = persons.Where( x => x.StrName == strNameSearchCount ).ToList();
			txtCountCustNo.Text = varResult.Count().ToString();
		}

		#endregion Hàm đếm tất cả tên người dùng theo một mã bất kỳ

		#region Hàm cập nhật thông tin người dùng

		/// <summary>
		/// Hàm cập nhật thông tin người dùng
		/// </summary>
		private void UpdatePerson()
		{
			if ( String.IsNullOrEmpty( txtCusNo.Text.Trim() ) )
			{
				MessageBox.Show( MSG_FAILURE_ENTER_CUSTNO );
				txtCusNo.BackColor = Color.Red;
			}
			else if ( String.IsNullOrEmpty( txtName.Text.Trim() ) )
			{
				MessageBox.Show( MSG_FAILURE_ENTER_NAME );
				txtName.BackColor = Color.Red;
			}
			else if ( String.IsNullOrEmpty( txtNameKana.Text.Trim() ) )
			{
				MessageBox.Show( MSG_FAILURE_ENTER_NAMEKANA );
				txtNameKana.BackColor = Color.Red;
			}
			else if ( String.IsNullOrEmpty( dtpBirthDay.Text ) )
			{
				MessageBox.Show( MSG_FAILURE_ENTER_BIRTHDAY );
				dtpBirthDay.ForeColor = Color.Red;
			}
			else if ( IsNumeric( txtCusNo.Text.Trim() ) == false )
			{
				MessageBox.Show( MSG_FAILURE_CHECK_ISNUMBER );
				txtCusNo.BackColor = Color.Red;
			}
			else
			{
				lvPersonTable.SelectedItems[0].SubItems[1].Text = txtCusNo.Text;
				lvPersonTable.SelectedItems[0].SubItems[2].Text = txtName.Text;
				lvPersonTable.SelectedItems[0].SubItems[3].Text = txtNameKana.Text;
				lvPersonTable.SelectedItems[0].SubItems[4].Text = dtpBirthDay.Text;
				if ( dmcbSex.Checked )
				{
					lvPersonTable.SelectedItems[0].SubItems[5].Text = VALUE_MALE;
				}
				else
				{
					lvPersonTable.SelectedItems[0].SubItems[5].Text = VALUE_FEMALE;
				}
				MessageBox.Show( MSG_SUCCESS_UPDATE_PERSON );
				ResetDelete();
			}
		}

		#endregion Hàm cập nhật thông tin người dùng

		#region Hàm xóa thông tin người dùng

		/// <summary>
		/// Hàm xóa thông tin người dùng
		/// </summary>
		private void DeletePerson()
		{
			if ( lvPersonTable.SelectedIndices.Count == 0 )
			{
				MessageBox.Show( MSG_FAILURE_SELECT_PERSON );
				return;
			}
			else
			{
				MessageBox.Show( MSG_SUCCESS_DELETE_PERSON );
				var remove = persons.Where( s => s.ICustNo == int.Parse( txtCusNo.Text ) );
				persons = persons.Except( remove ).ToList();
				GetListPerson( persons );
			}
		}

		#endregion Hàm xóa thông tin người dùng

		#region Hàm lấy giờ ngày/tháng/năm hiện tại

		/// <summary>
		/// Hàm lấy giờ ngày/tháng/năm hiện tại
		/// </summary>
		private void GetDateTimeNow()
		{
			var onlineDate = DateTime.Now;
			txtDateNow.Text = onlineDate.ToString( FORMAT_YYYYMMDD );
		}

		#endregion Hàm lấy giờ ngày/tháng/năm hiện tại

		#region Hàm kiểm tra ngày trước có lớn hơn ngày sau không

		/// <summary>
		/// Hàm kiểm tra ngày trước có lớn hơn ngày sau không
		/// </summary>
		/// <param name="DateStart"></param>
		/// <param name="DateEnd"></param>
		/// <returns>trả về true/false khi kiểm tra</returns>
		private Boolean CheckDate( String DateStart, String DateEnd )
		{
			try
			{
				DateTime dt1 = DateTime.Parse( DateStart );
				DateTime dt2 = DateTime.Parse( DateEnd );
				if ( dt1.Date > dt2.Date )
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		#endregion Hàm kiểm tra ngày trước có lớn hơn ngày sau không

		#region Hàm reset lại màu sau khi tìm kiếm
		private void ResetColorSearch()
		{
			lblSearchBirthDay.ForeColor = Color.Black;
			txtSearchCustNo.BackColor = Color.White;
		}
		#endregion Hàm reset lại màu

		#region Hàm tìm kiếm người theo theo mã người dùng và khoảng thời gian

		/// <summary>
		/// Hàm tìm kiếm người theo theo mã người dùng và khoảng thời gian
		/// </summary>
		private void SearchInformationPerson()
		{
			if ( (dtpStartDay.Text != " " && dtpEndDay.Text != " " ) && String.IsNullOrEmpty(txtSearchCustNo.Text.Trim() ) )
			{
				if (CheckDate(dtpStartDay.Text.ToString(), dtpEndDay.Text.ToString()))
				{
					MessageBox.Show(MSG_FAILURE_ENTER_COMPARE_DATE);
					lvPersonTable.Items.Clear();
					dtpEndDay.ForeColor = Color.Orange;
				}
				else {
					List<Person> ResultDate = persons.Where( x => ( x.DtBirthDay >= DateTime.Parse( dtpStartDay.Text )
																&& x.DtBirthDay <= DateTime.Parse( dtpEndDay.Text ) ) ).ToList();
					bool CheckSearchDate = persons.Any( x => ( x.DtBirthDay >= DateTime.Parse( dtpStartDay.Text )
																&& x.DtBirthDay <= DateTime.Parse( dtpEndDay.Text ) )  );
					if ( CheckSearchDate == true )
					{
						MessageBox.Show( MSG_SUCCESS_SEARCH_PERSON );
						GetListPerson( ResultDate );
						NumberRows();
						ResetColorSearch();
					}
					else
					{
						MessageBox.Show( MSG_FAILURE_SEARCH_PERSON );
						ResetColorSearch();
						lvPersonTable.Items.Clear();
						txtNumberRows.Text = NUMER_VALUE;
						txtSelectCustNo.Text = NUMER_VALUE;
					}
				}
			}
			else if ( ( dtpStartDay.Text != " " && dtpEndDay.Text != " " ) && !String.IsNullOrEmpty( txtSearchCustNo.Text.Trim() ) )
			{
				if ( CheckDate( dtpStartDay.Text.ToString(), dtpEndDay.Text.ToString() ) )
				{
					MessageBox.Show( MSG_FAILURE_ENTER_COMPARE_DATE );
					lvPersonTable.Items.Clear();
					dtpEndDay.ForeColor = Color.Orange;
				}
				else
				{
					List<Person> ResultAll = persons.Where( x => x.ICustNo == int.Parse( txtSearchCustNo.Text )
														&& ( x.DtBirthDay >= DateTime.Parse( dtpStartDay.Text )
														&& x.DtBirthDay <= DateTime.Parse( dtpEndDay.Text ) ) ).ToList();
					bool CheckSearchAll = persons.Any( x => x.ICustNo == int.Parse( txtSearchCustNo.Text )
															&& ( x.DtBirthDay >= DateTime.Parse( dtpStartDay.Text )
															&& x.DtBirthDay <= DateTime.Parse( dtpEndDay.Text ) ) );
					if ( CheckSearchAll )
					{
						MessageBox.Show( MSG_SUCCESS_SEARCH_PERSON );
						GetListPerson( ResultAll );
						NumberRows();
						ResetColorSearch();
					}
					else
					{
						MessageBox.Show( MSG_FAILURE_SEARCH_PERSON );
						lvPersonTable.Items.Clear();
						txtNumberRows.Text = NUMER_VALUE;
						ResetColorSearch();
						txtSelectCustNo.Text = NUMER_VALUE;
					}
				}
			}
			else if ( ( dtpStartDay.Text == " " && dtpEndDay.Text == " " ) && !String.IsNullOrEmpty( txtSearchCustNo.Text.Trim() ) )
			{
				bool CheckSearchPerson = persons.Any( x => x.ICustNo == int.Parse( txtSearchCustNo.Text ) );
				List<Person> ResultCustNo = persons.Where(x => x.ICustNo == int.Parse( txtSearchCustNo.Text ) ).ToList();
				bool CheckSearchCustNo = persons.Any( x => x.ICustNo == int.Parse( txtSearchCustNo.Text ) );
				if ( CheckSearchCustNo )
				{
					MessageBox.Show( MSG_SUCCESS_SEARCH_PERSON );
					GetListPerson( ResultCustNo );
					NumberRows();
					ResetColorSearch();
				}
				else
				{
					MessageBox.Show( MSG_FAILURE_SEARCH_PERSON );
					lvPersonTable.Items.Clear();
					txtNumberRows.Text = NUMER_VALUE;
					ResetColorSearch();
					txtSelectCustNo.Text = NUMER_VALUE;
				}
			}
			else if ( String.IsNullOrEmpty( txtSearchCustNo.Text ) || dtpStartDay.Text == " " || dtpEndDay.Text == " " )
			{
				if ( String.IsNullOrEmpty( txtSearchCustNo.Text  ) )
				{
					MessageBox.Show( MSG_FAILURE_SEARCH_CUSTNO_OR_DATE );
					lvPersonTable.Items.Clear();
					txtSearchCustNo.BackColor = Color.Orange;
				}
				else
				{
					dtpStartDay.ForeColor = Color.Orange;
					dtpEndDay.ForeColor = Color.Orange;
				}
			}
		}

		#endregion Hàm tìm kiếm người theo theo mã người dùng và khoảng thời gian

		#region Hàm thiết lập chức năng và trạng thái cho phần mềm

		/// <summary>
		/// Hàm thiết lập chức năng và trạng thái cho phần mềm
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_Load(object sender, EventArgs e)
		{
			this.KeyPreview = true;
			GetDateTimeNow();
			btnDelete.Enabled = false;
			btnUpdate.Enabled = false;
			btnAdd.Enabled = true;
			txtCountCustNo.ReadOnly = true;
			txtSelectCustNo.ReadOnly = true;
			txtNumberRows.ReadOnly = true;
		}

		#endregion Hàm thiết lập chức năng và trạng thái cho phần mềm

		#region Hàm làm mới thông tin

		/// <summary>
		/// Hàm làm mới thông tin
		/// </summary>
		private void Reset ()
		{
			var dateTime = DateTime.Now;
			txtCusNo.Text = "";
			txtCountCustNo.Text = "";
			txtSelectCustNo.Text = "";
			txtName.Text = "";
			txtNameKana.Text = "";
			dtpBirthDay.Format = DateTimePickerFormat.Custom;
			dtpBirthDay.CustomFormat = " ";
			dmcbSex.Text = "";
			txtSearchCustNo.Text = "";
			dtpEndDay.Format = DateTimePickerFormat.Custom;
			dtpEndDay.CustomFormat = " ";
			dtpStartDay.Format = DateTimePickerFormat.Custom;
			dtpStartDay.CustomFormat = " ";
			txtNumberRows.Text = "";
			lvPersonTable.Items.Clear();
			dmcbSex.Checked = false;
			btnAdd.Enabled = true;
		}

		#endregion Hàm làm mới thông tin

		#region Hàm làm mới thông tin khi xóa

		/// <summary>
		/// Hàm làm mới thông tin khi xóa
		/// </summary>
		private void ResetDelete ()
		{
			txtCusNo.Text = "";
			txtSelectCustNo.Text = "";
			txtCountCustNo.Text = "";
			txtName.Text = "";
			txtNameKana.Text = "";
			dtpBirthDay.Format = DateTimePickerFormat.Custom;
			dtpBirthDay.CustomFormat = " ";
			dmcbSex.Checked = false;
			lvPersonTable.Refresh();
		}

		#endregion Hàm làm mới thông tin khi xóa

		#region Chức năng làm mới

		/// <summary>
		/// Chức năng làm mới
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button5_Click(object sender, EventArgs e)
		{
			Reset();
		}

		#endregion Chức năng làm mới

		#region Kiểm tra thông tin user có tồn tại không 
		public bool CheckExist()
		{
			string check;
			if ( dmcbSex.Checked )
			{
				check = VALUE_MALE;
			}
			else
			{
				check = VALUE_FEMALE;
			}
			bool checkUser = persons.Any( x => ( x.ICustNo == int.Parse( txtCusNo.Text ) )
											&& ( x.StrName == txtName.Text )
											&& ( x.StrNameKana == txtNameKana.Text )
											&& ( x.DtBirthDay == dtpBirthDay.Value )
											&& ( x.StrSex == check )
										);
			return checkUser;
		}

		#endregion

		#region Chức năng thêm mới

		/// <summary>
		/// Chức năng thêm mới
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button8_Click(object sender, EventArgs e)
		{
			if ( CheckExist() )
			{
				MessageBox.Show( MSG_FAILURE_ADD_EXIST );
			}
			else
			{
				AddPerson();
				NumberRows();
				ResetDelete();
			}
		}

		#endregion Chức năng thêm mới

		#region Chức năng đóng back ( pause )

		/// <summary>
		/// Chức năng đóng back (pause)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		#endregion Chức năng đóng back ( pause )

		#region Hàm chọn thông tin người dùng

		/// <summary>
		/// Hàm chọn thông tin người dùng
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click_1(object sender, EventArgs e)
		{
			if ( lvPersonTable.SelectedIndices.Count > 0 )
			{
				ListViewItem item = lvPersonTable.SelectedItems[0];
				txtCusNo.Text = item.SubItems[1].Text;
				txtName.Text = item.SubItems[2].Text;
				txtNameKana.Text = item.SubItems[3].Text;
				dtpBirthDay.Text = item.SubItems[4].Text;
				if ( item.SubItems[5].Text== VALUE_MALE )
				{
					dmcbSex.Checked = true;
				}
				else
				{
					
					dmcbSex.Checked = false;
				}
				CountPersonByName( txtName.Text );
				btnDelete.Enabled = true;
				btnUpdate.Enabled = true;
				btnAdd.Enabled = false;
			}
			else
			{
				MessageBox.Show( MSG_FAILURE_SELECT_QUERY );
			}
		}

		#endregion Hàm chọn thông tin người dùng

		#region Tạo đồng hồ tự động theo giờ:phút:giây

		/// <summary>
		/// Tạo đồng hồ tự động theo giờ:phút:giây
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick(object sender, EventArgs e)
		{
			var timeNow = DateTime.Now;
			txtTimeNow.Text = timeNow.ToString( FORMAT_HHMMSS );
		}

		#endregion Tạo đồng hồ tự động theo giờ:phút:giây

		#region Chức năng sữa

		/// <summary>
		/// Tạo đồng hồ tự động theo giờ:phút:giây
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			UpdatePerson();
		}

		#endregion Chức năng sữa

		#region Chức năng tìm kiếm

		/// <summary>
		/// Chức năng tìm kiếm
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			SearchInformationPerson();
		}

		#endregion Chức năng tìm kiếm

		#region Chức năng xóa

		/// <summary>
		/// Chức năng xóa
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button6_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show( "Bạn có chắc chắn muốn xóa thông tin người dùng không ?", "Xóa thông tin người dùng", MessageBoxButtons.YesNo );
			if ( dialogResult == DialogResult.Yes )
			{
				if ( CheckExist() )
				{
					DeletePerson();
					NumberRows();
					ResetDelete();
				}
				else
				{
					MessageBox.Show( MSG_FAILURE_DELETE_PERSON );
				}
			}
			else if ( dialogResult == DialogResult.No )
			{
			}
		}

		#endregion Chức năng xóa

		#region Hàm hiển thị mã lên khi chọn

		/// <summary>
		///  Hàm hiển thị mã lên khi chọn
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void lvPersonTable_SelectedIndexChanged(object sender, EventArgs e)
		{
			if ( lvPersonTable.SelectedItems.Count > 0 )
			{
				ListViewItem item = lvPersonTable.SelectedItems[0];
				txtSelectCustNo.Text = item.SubItems[0].Text;
			}
		}

		#endregion Hàm hiển thị mã lên khi chọn

		#region Hàm cài đặt chức năng bằng phím tắt

		/// <summary>
		/// Hàm cài đặt chức năng bằng phím tắt
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch ( e.KeyCode )
			{
				case Keys.F12:
					btnAdd.PerformClick();
					break;
				case Keys.F11:
					btnUpdate.PerformClick();
					break;
				case Keys.D:
					btnDelete.PerformClick();
					break;
				case Keys.F8:
					btnClear.PerformClick();
					break;
				case Keys.Pause:
					btnBack.PerformClick();
					break;
				case Keys.S:
					btnSelect.PerformClick();
					break;
				case Keys.F1:
					btnSearch.PerformClick();
					break;
				default:
					break;
			}
		}

		#endregion Hàm cài đặt chức năng bằng phím tắt

		#region Hàm Xử lí lỗi màu ngày bắt đầu

		/// <summary>
		/// Hàm Xử lí lỗi màu ngày bắt đầu
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dtpStartDay_ValueChanged(object sender, EventArgs e)
		{
			dtpStartDay.Format = DateTimePickerFormat.Custom;
			dtpStartDay.CustomFormat = FORMAT_YYYYMMDD;
			if ( dtpStartDay.CustomFormat !=" " )
			{
				dtpStartDay.ForeColor = Color.Black;
			}
		}

		#endregion Hàm Xử lí lỗi màu ngày bắt đầu

		#region Hàm xử lí lỗi màu ngày kết thúc

		/// <summary>
		/// Hàm xử lí lỗi màu ngày kết thúc
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dtpEndDay_ValueChanged(object sender, EventArgs e)
		{
			dtpEndDay.Format = DateTimePickerFormat.Custom;
			dtpEndDay.CustomFormat = FORMAT_YYYYMMDD;
			if (dtpEndDay.CustomFormat != " " )
			{
				dtpEndDay.ForeColor = Color.Black;
			}
		}

		#endregion Hàm xử lí lỗi màu ngày kết thúc

		#region Hàm xử lí lỗi màu ngày sinh nhật

		/// <summary>
		/// Hàm xử lí lỗi màu ngày sinh nhật
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dtpBirthDay_ValueChanged(object sender, EventArgs e)
		{
			dtpBirthDay.Format = DateTimePickerFormat.Custom;
			dtpBirthDay.CustomFormat = FORMAT_YYYYMMDD;
			if ( dtpBirthDay.CustomFormat != " " )
			{
				lblBirthDay.ForeColor = Color.Black;
			}
		}

		#endregion Hàm xử lí lỗi màu ngày sinh nhật

		#region Hàm xử lí lỗi tên tiếng nhật 

		/// <summary>
		/// Hàm xử lí lỗi tên tiếng nhật 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtNameKana_TextChanged(object sender, EventArgs e)
		{
			if ( !String.IsNullOrEmpty( txtNameKana.Text.Trim() ) )
			{
				txtNameKana.BackColor = Color.White;
				lblNameKana.ForeColor = Color.Black;
			}
		}

		#endregion Hàm xử lí lỗi tên tiếng nhật

		#region Hàm xử lí lỗi tên

		/// <summary>
		/// Hàm xử lí lỗi tên 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtName_TextChanged(object sender, EventArgs e)
		{
			if ( !String.IsNullOrEmpty( txtName.Text.Trim() ) )
			{
				txtName.BackColor = Color.White;
			}
		}

		#endregion Hàm xử lí lỗi tên 

		#region Hàm xử lí lỗi giới tính

		/// <summary>
		/// Hàm xử lí lỗi giới tính
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dmcbSex_TextChanged(object sender, EventArgs e)
		{
			if ( !String.IsNullOrEmpty( dmcbSex.Text.Trim() ) )
			{
				dmcbSex.BackColor = Color.White;
			}
		}

		#endregion Hàm xử lí giới tính

		#region Hàm xử lí lỗi tìm kiếm theo mã

		/// <summary>
		/// Hàm xử lí lỗi tìm kiếm theo mã
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void txtSearchCustNo_TextChanged(object sender, EventArgs e)
		{
			if ( !String.IsNullOrEmpty( txtSearchCustNo.Text.Trim() ) )
			{
				txtSearchCustNo.BackColor = Color.White;
			}
		}

		#endregion Hàm xử lí lỗi tìm kiếm theo mã
	}
}