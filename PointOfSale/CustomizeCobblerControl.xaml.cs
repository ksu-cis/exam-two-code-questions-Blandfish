using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ExamTwoCodeQuestions.Data;

namespace ExamTwoQuestions.PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCobblerControl.xaml
    /// </summary>
    public partial class CustomizeCobblerControl : UserControl
    {
        Cobbler thisCobbler = new Cobbler();
        
        public CustomizeCobblerControl()
        {
            InitializeComponent();
            DataContext = thisCobbler;

            SelectPeach.Click += SelectFlavorClicked;
            SelectBlueberry.Click += SelectFlavorClicked;
            SelectCherry.Click += SelectFlavorClicked;

            SelectIceCream.Click += SelectIceCreamClicked;

            
        }

        public void SelectFlavorClicked(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {

                switch (button.Tag)
                {
                    case "Peach":
                        thisCobbler.Fruit = FruitFilling.Peach;
                        break;
                    case "Cherry":
                        thisCobbler.Fruit = FruitFilling.Cherry;
                        break;
                    case "BlueBerry":
                        thisCobbler.Fruit = FruitFilling.Blueberry;
                        break;
                }
            }
        }

        public void SelectIceCreamClicked(object sender, RoutedEventArgs e)
        {
            thisCobbler.WithIceCream = !(thisCobbler.WithIceCream);
        }
    }
}
