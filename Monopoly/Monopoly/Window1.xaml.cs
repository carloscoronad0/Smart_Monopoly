using Monopoly.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Monopoly
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            List<Player> items = new List<Player>();
            items =  ((App)Application.Current).app.gamePlayers;
           

            lbTodoList.ItemsSource = items;

        }
        private void Label_Loaded(object sender, RoutedEventArgs e)
        {
            // ... Get label.
            var label = sender as Label;
            var label2 = sender as Label;

            // ... Set date in content.
            label.Content = ((App)Application.Current).app.totalGames;
            label2.Content = ((App)Application.Current).app.currentPlayer;
            label2.Content = ((App)Application.Current).app.gamePlayers;


        }

    }
}
