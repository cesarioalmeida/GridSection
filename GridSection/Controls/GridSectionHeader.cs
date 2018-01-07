namespace GridSection.Controls
{
    using System.Windows;
    using System.Windows.Controls;

    public class GridSectionHeader : ContentControl
    {
        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
            "Label",
            typeof(string),
            typeof(GridSectionHeader),
            new PropertyMetadata(default(string)));

        static GridSectionHeader()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GridSectionHeader), new FrameworkPropertyMetadata(typeof(GridSectionHeader)));
        }

        public string Label
        {
            get => (string)this.GetValue(LabelProperty);
            set => this.SetValue(LabelProperty, value);
        }
    }
}