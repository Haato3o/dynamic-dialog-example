namespace DynamicPopupExample.Popup.ViewModels;

public interface IInputViewModel
{
    public string Label { get; set; }

    public object? GetResult();
}