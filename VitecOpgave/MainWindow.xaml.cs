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

namespace VitecOpgave
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly TextAnalyzer textAnalyzer = new TextAnalyzer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonAnalyzeText_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtField.Text))
            {
                List<string> list = textAnalyzer.TextToSubstring(txtField.Text);
                Dictionary<string, int> dictionary = textAnalyzer.SubstringFrequency(list);
                List<KeyValuePair<string, int>> keyValueList = textAnalyzer.DictonarySorter(dictionary);

                foreach (var pair in keyValueList)
                {
                    lstResult.Items.Add(pair);
                }
            }
        }
    }
}
