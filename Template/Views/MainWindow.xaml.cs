// Bishmillah //
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Template.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("MainWindow initialized.");
        }
        
        static class Navigator
        {
            private static ContentControl MainContent => ((MainWindow)Application.Current.MainWindow).MainContent;

            public static void Navigate(UIElement content)
            {
                MainContent.Content = content;
            }
        }
        
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        
        private void Instellingen_Click(object sender, RoutedEventArgs e)
        {
            Navigator.Navigate(new Instellingen());
        }

        private void Nothing(object sender, RoutedEventArgs e)
        {
            Navigator.Navigate(new Content());
        }
        
        private void Minimaliseren_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }
        
        private void Afsluiten_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Wil je de applicatie afsluiten?", "Bevestiging",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
// Elhamdulillah //