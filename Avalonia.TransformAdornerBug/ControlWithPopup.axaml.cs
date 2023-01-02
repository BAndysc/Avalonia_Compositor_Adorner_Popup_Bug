using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace Avalonia.TransformAdornerBug;

public class ControlWithPopup : TemplatedControl
{
    public static readonly StyledProperty<bool> IsDropDownOpenProperty = AvaloniaProperty.Register<ControlWithPopup, bool>("IsDropDownOpen");

    public bool IsDropDownOpen
    {
        get => (bool)GetValue(IsDropDownOpenProperty);
        set => SetValue(IsDropDownOpenProperty, value);
    }
}