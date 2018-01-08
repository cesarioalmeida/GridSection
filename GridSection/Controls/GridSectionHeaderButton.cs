namespace GridSection.Controls
{
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;

    public class GridSectionHeaderButton : Button
    {
        public static readonly DependencyProperty GlyphProperty = DependencyProperty.Register(
            "Glyph",
            typeof(ImageSource),
            typeof(GridSectionHeaderButton),
            new PropertyMetadata(default(ImageSource)));

        static GridSectionHeaderButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GridSectionHeaderButton), new FrameworkPropertyMetadata(typeof(GridSectionHeaderButton)));
        }

        public ImageSource Glyph
        {
            get => (ImageSource)this.GetValue(GlyphProperty);
            set => this.SetValue(GlyphProperty, value);
        }
    }
}