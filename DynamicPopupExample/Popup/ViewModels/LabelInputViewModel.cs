using DynamicPopupExample.ViewModels;

namespace DynamicPopupExample.Popup.ViewModels;

public class LabelInputViewModel : ViewModel, IInputViewModel
{
    private string _label = string.Empty;
    public string Label
    {
        get => _label;
        set => SetValue(ref _label, value);
    }

    public object? GetResult()
    {
        return null;
    }
}