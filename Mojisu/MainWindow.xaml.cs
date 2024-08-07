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

namespace Mojisu
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ReportText_TextChanged(object sender, TextChangedEventArgs e)
        {
            int rawCount = ReportText.Text.Length;
            int countWithoutRet = ReportText.Text.Replace(Environment.NewLine, string.Empty).Length;
            if (Counts != null)
                Counts.Text = $"文字数：{rawCount}  改行を除いた文字数：{countWithoutRet}";
        }
    }
}
