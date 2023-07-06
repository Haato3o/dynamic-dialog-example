using System.Windows;

namespace DynamicPopupExample.Popup.Views;
/// <summary>
/// Interaction logic for DialogView.xaml
/// </summary>
public partial class DialogView : Window
{
    public DialogView()
    {
        InitializeComponent();
    }

    private void OnCloseButtonClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}
