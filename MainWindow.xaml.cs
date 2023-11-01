using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace shambala_dz_Task_Manager_01_11_2023
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Process[] processes = Process.GetProcesses();
        // список для вывода в листбокс
        public List<string> stProc = new List<string>();
        // список для вывода в message box
        public List<string> stFiveParametr = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            ReadProcess();
        }
        public void ReadProcess()
        {

            foreach (Process process in processes)
            {
                stProc.Add(process.Id.ToString() + " " + process.ProcessName.ToString());

                stFiveParametr.Add($" номер : {process.Id.ToString()}\n " +
                    $"имя процесса:  {process.ProcessName.ToString()}\n" +
                    $"имя компьютера: {process.MachineName.ToString()}\n" +
                    $"размер памяти: {process.WorkingSet64.ToString()} \n" +
                    $"базовый приоритет: {process.BasePriority.ToString()}");

            }
            // listbox = new ListBox();
            foreach (string strings in stProc)
            {
                listbox.Items.Add(strings);
            }
        }
        private void LoadProc_Click(object sender, RoutedEventArgs e)
        {
            listbox.Items.Clear();
            ReadProcess();
        }
        private void listbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int strIdName = listbox.SelectedIndex;
                MessageBox.Show(stFiveParametr[strIdName]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
//Задание.
//1.Прочитать урок 1 по предмету. Главы 1 – 4 включительно.
//2. Поизучать спецификации и возможности класса Process:
//	https://learn.microsoft.com/ru-ru/dotnet/api/system.diagnostics.process?view=net-7.0
//3.Реализовать приложение согласно заданию:
//Написать десктопную утилиту, выводящую список запущенных процессов.
//В списке выводится имя процесса и его PID.
//При клике на элемент списка в доп окне открывается более детальная информация о данном процессе.
//Список процессов обновляется по клику либо по таймеру.
//За основу взять пример со стр. 26 урока№ 1.
