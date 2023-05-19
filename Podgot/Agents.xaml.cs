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
        }
    }
}
