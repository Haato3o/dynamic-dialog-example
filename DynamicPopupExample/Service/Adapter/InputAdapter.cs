using DynamicPopupExample.Popup.ViewModels;
using DynamicPopupExample.Service.Model;
using System;

namespace DynamicPopupExample.Service.Adapter;

public static class InputAdapter
{
    public static IInputViewModel Adapt(Input input)
    {
        return input.Type switch
        {
            InputType.Text => new TextInputViewModel
            {
                Label = input.Label
            },
            InputType.Label => new LabelInputViewModel
            {
                Label = input.Label
            },
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}