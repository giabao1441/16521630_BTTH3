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
	public partial class PageThemHoa : ContentPage
	{
        HoaDatabase db;
        List<Loaihoa> dsl;
		public PageThemHoa ()
		{
			InitializeComponent ();
            db = new HoaDatabase();
            dsl = db.selectLoaihoa();
            listHoa.ItemsSource = dsl;
        }
        private void cmdGhi_Clicked(Object o, EventArgs e)
        {

        }

    }
}