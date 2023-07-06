using System.Windows;

namespace DynamicPopupExample;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private MainViewModel ViewModel => (MainViewModel)DataContext;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnOpenDialogButtonClick(object sender, RoutedEventArgs e) => ViewModel.OpenDialog();
}