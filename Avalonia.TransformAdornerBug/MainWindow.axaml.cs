using System;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Threading;

namespace Avalonia.TransformAdornerBug
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            var adornerLayer = AdornerLayer.GetAdornerLayer(Button);
            var control1 = new ControlWithPopup();
            var control2 = new ControlWithPopup();
            Panel.Children.Add(control2);
                
            adornerLayer.Children.Add(control1);
            AdornerLayer.SetAdornedElement(control1, Button);

            DispatcherTimer.RunOnce(() =>
            {
                control1.IsDropDownOpen = true;
                control2.IsDropDownOpen = true;
            }, TimeSpan.FromMilliseconds(1));
        }
    }
}