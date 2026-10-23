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

namespace MyHub.view
{
    /// <summary>
    /// HomeView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class HomeView : UserControl
    {

        private bool isEditing = false;

        public HomeView()
        {
            InitializeComponent();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            isEditing = !isEditing;
            EditButton.Content = isEditing ? "완료" : "편집";

            AddLinkButton.Visibility = isEditing ? Visibility.Visible : Visibility.Collapsed;
        }

        private void AddLinkButton_Click(object sender, RoutedEventArgs e)
        {
            AddLinkWindow dialog = new AddLinkWindow();
            dialog.ShowDialog();
        }
    }
}
