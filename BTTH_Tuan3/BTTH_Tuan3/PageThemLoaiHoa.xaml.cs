using Hoas.Data;
using LoaiHoa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH_Tuan3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageThemLoaiHoa : ContentPage
	{
		public PageThemLoaiHoa ()
		{
			InitializeComponent ();
		}
        private void cmdGhi_Clicked(Object sender, EventArgs e)
        {
            HoaDatabase db = new HoaDatabase();
            Loaihoa l = new Loaihoa { Tenloai = txtTenLoai.Text };
            if (db.InsertLoaiHoa(l) == true)
                DisplayAlert("Thông báo", "Thêm loại hoa thành công", "OK");
            else
                DisplayAlert("Thông báo", "Thêm hoa bị lỗi", "OK");

        }
	}
}