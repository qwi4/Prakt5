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

namespace Prakt5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Triad triada = new Triad(); // общий создание объект класса  класса 

        private void Sravnenie(object sender, RoutedEventArgs e)
        {
            try
            {
                Triad triada2 = new Triad();// внутри скобок создаание объект класса  класса 
                Int32.TryParse(FirstChis.Text, out int first); Int32.TryParse(SecondChis.Text, out int second); Int32.TryParse(ThreeChis.Text, out int three);
                triada.First = first; triada.Second = second; triada.Three = three; // заполнение  триады (свойства) 
                Int32.TryParse(FirSecondTriada.Text, out int firstt2); Int32.TryParse(SecSecondTriada.Text, out int secondt2); Int32.TryParse(ThrSecondTriada.Text, out int threet2);
                triada2.First = firstt2; triada2.Second = secondt2; triada2.Three = threet2; //заполнение  2 триады 
                if (triada.Srav(triada2))
                {
                    MessageBox.Show("Первая триада больше второй триады");
                }
                else MessageBox.Show("Вторая триада больше первой триады");
            }
            catch
            {
                MessageBox.Show("Введите корректные значения");
            }
        }

        private void Parametr(object sender, RoutedEventArgs e)
        {
            try//Замена
            {
                Int32.TryParse(NovF.Text, out int novfirst); Int32.TryParse(NovS.Text, out int novsecond); Int32.TryParse(NovT.Text, out int novthree);
                if (NovF.Text != "" && NovS.Text != "" && NovT.Text != "") triada.SetParams(novfirst, novsecond, novthree);
                if (NovF.Text != "" && NovS.Text != "") triada.SetParams(novfirst, novsecond);
                if (NovF.Text != "") triada.SetParams(novfirst);
                NovF.Clear();NovS.Clear();NovT.Clear();
                FirstChis.Text = Convert.ToString(triada.First); SecondChis.Text = Convert.ToString(triada.Second); ThreeChis.Text = Convert.ToString(triada.Three);
            }
            catch
            {
                MessageBox.Show("Введите верные данные");
            }
        }
        private void Uvelich(object sender,RoutedEventArgs e)
        {
            try
            {
                triada.SetParams();// на 10
                FirstChis.Text = Convert.ToString(triada.First); SecondChis.Text = Convert.ToString(triada.Second); ThreeChis.Text = Convert.ToString(triada.Three);
            }
            catch
            {
                MessageBox.Show("как тут возникла ошибка???");
            }
        }

        private void Quit(object sender,RoutedEventArgs e)
        {
            this.Close();
        }

        private void Spravka(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31 Вариант 7\nСоздать класс Triad (тройка чисел). Создать необходимые методы и свойства. " +
                "Определить метод сравнения триад: триада p1 больше триады р2, если (first.pl > \r\nfirst.р2) или (first.pl = first.р2)" +
                "и (second.pl > second.р2) и (three.pl > three.р2).Создать перегруженные методы SetParams, для установки параметров объекта, в " +
                "том числе увеличения всех чисел на 10.");
        }
    }
}
