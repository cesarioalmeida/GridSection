namespace GridSection.Controls
{
    using System.Collections.Generic;
    using System.Windows;
    using System.Windows.Controls;

    public class GridSectionHeader : ContentControl
    {
        public static readonly DependencyProperty LabelProperty = DependencyProperty.Register(
            "Label",
            typeof(string),
            typeof(GridSectionHeader),
            new PropertyMetadata(default(string)));

        public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register(
            "Items",
            typeof(List<FrameworkElement>),
            typeof(GridSectionHeader),
            new FrameworkPropertyMetadata(
                default(List<FrameworkElement>),
                FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.AffectsMeasure));

        public static readonly DependencyProperty ShowLineProperty = DependencyProperty.Register(
            "ShowLine",
            typeof(bool),
            typeof(GridSectionHeader),
            new PropertyMetadata(true));

        static GridSectionHeader()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GridSectionHeader), new FrameworkPropertyMetadata(typeof(GridSectionHeader)));
        }

        public string Label
        {
            get => (string)this.GetValue(LabelProperty);
            set => this.SetValue(LabelProperty, value);
        }

        public bool ShowLine
        {
            get => (bool)this.GetValue(ShowLineProperty);
            set => this.SetValue(ShowLineProperty, value);
        }

        public List<FrameworkElement> Items
        {
            get => (List<FrameworkElement>)this.GetValue(ItemsProperty);
            set => this.SetValue(ItemsProperty, value);
        }

        public override void BeginInit()
        {
            this.Items = new List<FrameworkElement>();
            base.BeginInit();
        }
    }
}