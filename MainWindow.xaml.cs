using shambala_dz_Task_Manager_01_11_2023;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace shambala_dz_Task_Manager_01_11_2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Name = artists.ToString();

        }

        List<string> strings = new List<string> { "xxx", "yyy", "zzz" };
        Process[] processes = Process.GetProcesses();
        ObservableCollection<process> artists = new ObservableCollection<process>();
        // считывание процесса

        private void LoadProc_Click(object sender, RoutedEventArgs e)
        {

        }

        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
//Задание.
//1.Прочитать урок 1 по предмету. Главы 1 – 4 включительно.
//2. Поизучать спецификации и возможности класса Process:
//	https://learn.microsoft.com/ru-ru/dotnet/api/system.diagnostics.process?view=net-7.0
//3.Реализовать приложение согласно заданию:
//Написать десктопную утилиту, выводящую список запущенных процессов. В списке выводится имя процесса и его PID. При клике на элемент списка в доп окне открывается более детальная информация о данном процессе. Список процессов обновляется по клику либо по таймеру. За основу взять пример со стр. 26 урока№ 1.
