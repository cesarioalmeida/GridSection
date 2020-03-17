namespace GridSection.Controls
{
    using System.Windows;
    using System.Windows.Controls;

    public class GridSectionHeaderTextButton : Button
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(GridSectionHeaderTextButton),
            new PropertyMetadata(default(string)));

        public static readonly DependencyProperty ShowBorderProperty = DependencyProperty.Register(
            "ShowBorder",
            typeof(bool),
            typeof(GridSectionHeaderTextButton),
            new PropertyMetadata(true));

        static GridSectionHeaderTextButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GridSectionHeaderTextButton), new FrameworkPropertyMetadata(typeof(GridSectionHeaderTextButton)));
        }

        public bool ShowBorder
        {
            get => (bool)GetValue(ShowBorderProperty);
            set => SetValue(ShowBorderProperty, value);
        }

        public string Text
        {
            get => (string)this.GetValue(TextProperty);
            set => this.SetValue(TextProperty, value);
        }
    }
}