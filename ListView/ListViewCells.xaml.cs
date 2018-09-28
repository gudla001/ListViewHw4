using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using ListViewHw.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace ListViewHw
{
   public partial class ListViewCells : ContentPage
    {
        public ListViewCells()
        {
            InitializeComponent();
            PopulateListView();
        }



        private void PopulateListView()
        {
            var collection = new ObservableCollection<People>();

            var people1 = new People();
            people1.Name = "Messi";
            people1.Pics = new Uri("https://www.justpushstart.com/wp-content/uploads/2018/03/Lionel-Messi-924716.jpg");
            people1.WebsiteName = "Google";
            people1.Url = "https://www.futhead.com/18/players/58021/lionel-messi/";



            collection.Add(people1);



            var people2 = new People();
            people2.Name = "Ronaldo";
            people2.Pics = new Uri("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTc_w9AwD53D9VF8D1dldUsP4ZHCLaX7jdK6uJpPvdX-bXsMg99Ow");
            people2.Url = "https://www.futhead.com/18/players/58019/cristiano-ronaldo/";

            collection.Add(people2);

            var people3 = new People();
            people3.Name = "Salah";
            people3.Pics = new Uri("https://givemesport.azureedge.net/images/18/03/25/cb91de1b81c3de65084cb8cb9213bdab/960.jpg");
            people3.Url = "https://www.futhead.com/18/players/57864/mohamed-salah/";



            collection.Add(people3);

            var people4 = new People();
            people4.Name = "Mane";
            people4.Pics = new Uri("https://d3j2s6hdd6a7rg.cloudfront.net/v2/uploads/media/default/0001/27/thumb_26361_default_news_size_5.jpeg");
            people4.Url = "https://www.futhead.com/18/players/57888/sadio-mane/";



            collection.Add(people4);
            var people5 = new People();
            people5.Name = "Firmino";
            people5.Pics = new Uri("https://d3j2s6hdd6a7rg.cloudfront.net/v2/uploads/media/default/0001/63/thumb_62607_default_news_size_5.jpeg");
            people5.Url = "https://www.futhead.com/18/players/57883/roberto-firmino/";



            collection.Add(people5);

        
            CListViewCells.ItemsSource = collection;
             

        }




        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var listView = (ListView)sender;
            People itemTapped = (People)listView.SelectedItem;
            var uri = new Uri(itemTapped.Url);
            Device.OpenUri(uri);

           
        }
    }
}
