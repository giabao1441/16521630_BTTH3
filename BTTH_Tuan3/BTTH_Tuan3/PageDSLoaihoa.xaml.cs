using Hoas.Data;
using LoaiHoa;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTTH_Tuan3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PageDSLoaihoa : ContentPage
	{
        HoaDatabase db;
        List<Loaihoa> dsl;
		public PageDSLoaihoa ()
		{
			InitializeComponent ();
            db = new HoaDatabase();
            dsl = db.selectLoaihoa();
            lstdsloai.ItemsSource = dsl;

        }
	}
}