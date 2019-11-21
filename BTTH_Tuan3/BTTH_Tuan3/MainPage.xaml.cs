using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTTH_Tuan3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Cmdthemloaihoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageThemLoaiHoa());

        }
        private void Cmdthemhoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageThemHoa());

        }
        private void Cmddsloaihoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageDSLoaihoa());

        }
    }
}
