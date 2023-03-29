using Microsoft.VisualBasic.ApplicationServices;
using System.Linq;
using System.Windows.Forms;

namespace CinemaProjectWinForm
{
    public partial class Form1 : Form
    {
        List<Category> _categories;
        List<Film> _films;
        List<Room> _rooms;
        public Form1()
        {
            InitializeComponent();

            _rooms = new List<Room>()
            {
                new Room() {Id=1,RoomName="Salon1",NumOfRoom=12},
                new Room() {Id=2,RoomName="Salon2",NumOfRoom=12},
                new Room() {Id=3,RoomName="Salon3",NumOfRoom=12},
                new Room() {Id=4,RoomName="Salon4",NumOfRoom=12}
            };
            _categories = new List<Category>()
            {
                new Category(){Id=1,Name="Aksiyon"},
                new Category(){Id=2,Name="Gerilim"},
                new Category(){Id=3,Name="Dram"},
                new Category(){Id=4,Name="Animasyon" },
                new Category(){Id=5,Name="Fantastik" }
            };


            _films = new List<Film>()
            {
                new Film() { Id =1,Name="John Wick 4",CategotyId=1,Price=80,Time=" 169dk",FilmImage=@"C:\\Users\\ozder\\OneDrive\\Masaüstü\\images\\1.jpg",MovieTheaterId=1 },
                new Film() { Id =2,Name="Shazam!",CategotyId=5,Price=70,Time=" 190dk",FilmImage=@"C:\\Users\\ozder\\OneDrive\\Masaüstü\\images\\2.jpg" ,MovieTheaterId=2},
                new Film() { Id =3,Name="Çýðlýk 6",CategotyId=2,Price=80,Time=" 123dk",FilmImage=@"C:\\Users\\ozder\\OneDrive\\Masaüstü\\images\\3.jpg" ,MovieTheaterId=3},
                new Film() { Id =4,Name="Çizmeli Kedi",CategotyId=4,Price=80,Time=" 93dk",FilmImage=@"C:\\Users\\ozder\\OneDrive\\Masaüstü\\images\\4.jpg" ,MovieTheaterId=4},
            };



            listBox1.Items.Clear();
            foreach (var item in _films)
            {
                listBox1.Items.Add(item.Name);
            }


            comboBox2.Items.Add("Koltuk ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\\Users\\ozder\\Downloads\\images\\1.jpg");
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            textFilmName.Text = _films[listBox1.SelectedIndex].Name;
            textFilmCategory.Text = _films[listBox1.SelectedIndex].CategotyId.ToString();
            textTime.Text = _films[listBox1.SelectedIndex].Time;
            textPrice.Text = _films[listBox1.SelectedIndex].Price.ToString() + " TL";
            pictureBox1.Image = Image.FromFile(_films[listBox1.SelectedIndex].FilmImage);

            var result = _categories.Where(c => c.Id == _films[listBox1.SelectedIndex].CategotyId);
            foreach (var item in result)
            {
                textFilmCategory.Text = item.Name;
            }


            //var result2 = _rooms.Where(r => r.Id == _films[listBox1.SelectedIndex].MovieTheaterId);

            //foreach (var item in result2)
            //{
            //    for (int i = 0; i < item.NumOfRoom; i++)
            //    {
            //        comboBox2.Items.Add("Koltuk " + (i + 1));
            //    }
            //}

        }

        private void textFilmName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void comboBox2_MouseMove(object sender, MouseEventArgs e)
        {
          

        }
    }
}