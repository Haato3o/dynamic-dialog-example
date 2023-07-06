using DynamicPopupExample.Popup.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

namespace DynamicPopupExample.Popup.Presentation;

public class DialogInputDataTemplateSelector : DataTemplateSelector
{
    public DataTemplate TextInputTemplate { get; set; }
    public DataTemplate DefaultTemplate { get; set; }

    public override DataTemplate SelectTemplate(object? item, DependencyObject container)
    {
        return item switch
        {
            TextInputViewModel => TextInputTemplate,
            IInputViewModel => DefaultTemplate,
            _ => throw new ArgumentException($"Expected {typeof(IInputViewModel)} and got {item?.GetType()}")
        };
    }
}