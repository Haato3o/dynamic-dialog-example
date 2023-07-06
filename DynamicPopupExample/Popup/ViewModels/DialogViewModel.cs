using DynamicPopupExample.ViewModels;
using System.Collections.ObjectModel;

namespace DynamicPopupExample.Popup.ViewModels;

public class DialogViewModel : ViewModel
{
    public ObservableCollection<IInputViewModel> Inputs { get; } = new();

    public DialogViewModel(IInputViewModel[] inputs)
    {
        foreach (IInputViewModel input in inputs)
            Inputs.Add(input);
    }
}