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
using Xceed.Wpf.AvalonDock.Layout;
using System.IO;
using System.Net.Http;

namespace la800ux120421
{
    /// <summary>
    /// (C) Copyright 2021 Justin Staines
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

  

    public class Position
    {
        public int Horiz { get; set; }
        public int Vert { get; set; }

        public static Position GetPosition()
        {

            

            var pos = new Position()
            {
               
                Horiz = 10,
                Vert = 10
            };
            return pos;
        }
    }

    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            

            InitializeComponent();
            DataContext = Position.GetPosition();
           


        }

  

    }
}
