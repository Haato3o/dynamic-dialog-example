using DynamicPopupExample.Service;
using DynamicPopupExample.Service.Model;
using DynamicPopupExample.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace DynamicPopupExample;

public class MainViewModel : ViewModel
{
    private int _count;
    public int Count
    {
        get => _count;
        set => SetValue(ref _count, value);
    }

    public ObservableCollection<string> Results { get; } = new();

    public void OpenDialog()
    {
        Results.Clear();

        Input[] inputs = Enumerable.Range(0, Count)
            .Select(it => new Input(InputType.Text, $"Label {it + 1}"))
            .ToArray();

        List<InputResult> results = DialogService.Display(inputs);

        foreach (InputResult result in results)
            Results.Add(result.Value.ToString()!);
    }
}