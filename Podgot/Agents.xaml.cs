using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Podgot
{
    /// <summary>
    /// Логика взаимодействия для Agents.xaml
    /// </summary>
    public partial class Agents : Page
    {
        public Frame frame1;
        List<Агент> агент = new List<Агент>();
        public Agents(Frame frame)
        {
            InitializeComponent();
            frame1 = frame;
            агент = Entities.GetContext().Агент.ToList();
            Gaz.ItemsSource = агент;
        }
        private void Poisk_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        public void Update()
        {
            var poisk = Entities.GetContext().Агент.ToList();
            poisk = poisk.Where(p => p.Наименование_агента.ToLower().Contains(Poisk.Text.ToLower())).ToList();
            Gaz.ItemsSource = poisk;
        }
        private async void Gaz_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            await Task.Delay(100);
            object j = Gaz.SelectedItem;
            //frame1.Navigate(new update(frame1, j)); //при нажтии переход на другую страницу(update)
        }
    }
}
