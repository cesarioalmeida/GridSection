namespace GridSection.Controls
{
    using System.Windows;
    using System.Windows.Controls;

    public class GridSection : ContentControl
    {
        public static readonly DependencyProperty HeaderProperty = DependencyProperty.Register(
            "Header",
            typeof(GridSectionHeader),
            typeof(GridSection),
            new PropertyMetadata(default(GridSectionHeader)));

        static GridSection()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GridSection), new FrameworkPropertyMetadata(typeof(GridSection)));
        }

        public GridSectionHeader Header
        {
            get => (GridSectionHeader)this.GetValue(HeaderProperty);
            set => this.SetValue(HeaderProperty, value);
        }
    }
}