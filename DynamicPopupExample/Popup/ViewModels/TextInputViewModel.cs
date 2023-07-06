using DynamicPopupExample.ViewModels;

namespace DynamicPopupExample.Popup.ViewModels;

public class TextInputViewModel : ViewModel, IInputViewModel
{
    private string _text = string.Empty;
    public string Text
    {
        get => _text;
        set => SetValue(ref _text, value);
    }

    private string _label = string.Empty;
    public string Label
    {
        get => _label;
        set => SetValue(ref _label, value);
    }

    public object? GetResult()
    {
        return Text;
    }
}