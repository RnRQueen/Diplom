using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class AddApartamentForm : Form
    {
        public AddApartamentForm()
        {
            InitializeComponent();
            }

        private void AddApartamentForm_Load(object sender, EventArgs e)
        {
            string [] type = new string[4];
            type[0] = "Квартира";
            type[1] = "Комната";
            type[2] = "Койко-место";
            type[3] = "Дом";
            cbType.Items.AddRange(type);
            
             var lines = new List<MetroLine>();
            
             lines.Add(new MetroLine("Сокольническая", new string[] {"Бульвар Рокоссовского (Улица Подбельского)","Преображенская площадь",
                                                                     "Красносельская","Красные ворота","Лубянка","Библиотека имени Ленина",
                                                                     "Парк культуры","Спортивная","Университет","Юго-Западная","Черкизовская",
                                                                     "Сокольники","Комсомольская","Чистые пруды","Охотный ряд","Кропоткинская",
                                                                     "Фрунзенская","Воробьевы горы","Проспект Вернандского","Тропарёво"}));
              
            lines.Add(new MetroLine("Замоскворецкая", new string[] { "Алма-Атинская","Домодедовская","Царицыно","Каширская","Автозаводская","Новокузнецкая","Тверская", 
                                                                      "Белорусская","Аэропорт","Войковская","Речной вокзал","Красногвардейская","Орехово",
                                                                      "Кантемировская","Коломенская","Павелецкая","Театральная","Маяковская","Динамо",
                                                                      "Сокол","Водный стадион"}));
               
                
            lines.Add(new MetroLine( "Арбатско-Покровская",new string[]{ "Щёлковская","Измайловская","Семёновская",
                                                                         "Бауманская","Площадь Революции","Смоленская","Парк Победы","Кунцевская","Крылатское","Мякинино",
                                                                         "Митино","Первомайская","Партизанская","Электрозаводская","Курская","Арбатская","Киевская",
                                                                         "Славянский бульвар","Молодёжная","Строгино","Волоколамская","Пятницкое шоссе"}));
               
            lines.Add(new MetroLine("Филёвская", new string[]{"Кунцевская","Филевский парк","Фили","Студенческая","Смоленская","Александровский сад",
                                                                "Международная","Пионерская","Багратионовская","Кутузовская","Киевская",
                                                                "Арбатская","Выставочная"}));
               
            lines.Add(new MetroLine( "Кольцевая", new string[]{ "Парк культуры", "Добрынинская",  "Таганская", "Комсомольская","Новослободская","Краснопресненская",
                                                                "Октябрьская","Павелецкая","Курская","Проспект Мира","Белорусская","Киевская" }));    
                
            lines.Add(new MetroLine("Калужско-Рижская",new string[]{"Медведково","Свиблово","ВДНХ","Рижская","Сухаревская","Китай-город","Октябрьская",
                                                                     "Ленинский проспект", "Профсоюзная", "Калужская","Коньково","Ясенево","Бабушкинская",
                                                                     "Ботанический сад","Алексеевская", "Проспект Мира", "Тургеневская","Третьяковская",
                                                                     "Шаболовская","Академическая","Новые Черёмушки","Беляево","Тёплый стан", "Новоясеневская" }));   
            
            lines.Add(new MetroLine("Таганско-Краснопресненская",new string[]{ "Планерная","Тушинская","Щукинская", "Полежаевская","Улица 1905 года", "Пушкинская", "Китай-город",
                                                                                "Пролетарская","Текстильщики", "Рязанский проспект","Лермонтовский проспект", "Сходненская","Спартак",
                                                                                "Октябрьское поле", "Беговая", "Баррикадная", "Кузнецкий мост", "Таганская", "Волгоградский проспект",
                                                                                "Кузьминки","Выхино", "Жулебино"}));   
              
            lines.Add(new MetroLine("Калининско-Солнцевская",new string[]{ "Новокосино","Перово","Авиамоторная","Марксистская","Волхонка","Кутузовский проспект",
                                                                               "Парк Победы","Новогиреево","Шоссе Энтузиастов","Площадь Ильича","Третьяковская",
                                                                               "Плющиха","Деловой центр" }));
 
            lines.Add(new MetroLine("Серпуховско-Тимирязевская",new string[]{ "Алтуфьево","Отрадное","Петровско-Разумовская","Дмитровская","Менделеевская","Чеховская",
                                                                              "Полянка","Тульская","Нагорная","Севастопольская","Южная","Улица академика Янгеля",
                                                                              "Бульвар Дмитрия Донского","Биберево","Владыкино","Тимирязевская","Савёловская","Цветной бульвар",
                                                                               "Боровицкая","Серпуховская","Нагатинская","Нахимовский проспект","Чертановская","Пражская","Аннино"}));
                 
            lines.Add(new MetroLine("Люблинско-Дмитровская", new string[]{"Марьина роща","Трубная", "Чкаловская","Крестьянская застава","Кожуховская","Волжская","Братиславская",
                                                                          "Борисово","Зябликово","Достоевская","Сретенский бульвар","Римская","Дубровка","Печатники","Люблино",
                                                                          "Марьино","Шипиловская"}));
               
           lines.Add(new MetroLine("Каховская", new string[]{ "Каширская", "Каховская","Варшавская"}));

           lines.Add(new MetroLine("Бутовская", new string[]{ "Битцевский парк","Улица Старокачаловская","Бульвар адмирала Ушакова", "Бунинская аллея", "Лесопарковая",
                                                              "Улица Скобелевская","Улица Горчакова"}));

            cbMetroLine.DataSource = lines;
            cbMetroLine.DisplayMember = "LineName";
        }

        private void cbMetroLine_SelectedChanged(object sender, EventArgs e)
        {
            var selectedItem = cbMetroLine.SelectedItem as MetroLine;
           cbMetro.DataSource = selectedItem.StationName;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbType.SelectedIndex < 0)
            {
                MessageBox.Show("Ошибка!", "Выберите тип объекта!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DBHelper.Context.Apartaments.Add(
              new ApartmentData
              {
                  Address = tbAddress.Text,
                  Status = tbStatus.Text,
                  Date = dtpDate.Value.ToShortDateString(),
                  Type = cbType.SelectedItem.ToString(),
                  Price = tbPrice.Text,
                  NumRooms = int.Parse(nudNumRooms.Text),
                  Area = int.Parse(nudArea.Text),
                  Floor = int.Parse(nudFloor.Text),
                  NumFloor = int.Parse(nudNumFloor.Text),
                  Description = tbDescription.Text,
                  Phone = tbPhone.Text,
                  Name  = tbName.Text,
                  Link = tbLink.Text,
                  Metro = cbMetro.SelectedItem.ToString(),
                  MetroLine = cbMetroLine.SelectedItem.ToString(),
                  Transport = tbTransport.Text,
                  Comment = tbComments.Text,
                  
                  
                  });
            DBHelper.Context.SaveChanges();
            Close();
        }

        
        
    }
}
