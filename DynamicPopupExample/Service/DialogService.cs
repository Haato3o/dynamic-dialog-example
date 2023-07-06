using DynamicPopupExample.Popup.ViewModels;
using DynamicPopupExample.Popup.Views;
using DynamicPopupExample.Service.Adapter;
using DynamicPopupExample.Service.Model;
using System.Collections.Generic;
using System.Linq;

namespace DynamicPopupExample.Service;

public static class DialogService
{
    public static List<InputResult> Display(Input[] inputs)
    {
        IInputViewModel[] inputViewModels = inputs.Select(InputAdapter.Adapt)
            .ToArray();

        var viewModel = new DialogViewModel(inputViewModels);

        var dialog = new DialogView
        {
            DataContext = viewModel
        };

        dialog.ShowDialog();

        var results = inputViewModels.Select(it => it.GetResult())
            .Where(it => it is not null)
            .Select(it => new InputResult(it!))
            .ToList();

        return results;
    }
}