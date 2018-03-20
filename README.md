# GridSection
A simple WPF Section control

## Use
```
	<Grid Margin="10">
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*" />
            <ColumnDefinition Width="4" />
            <ColumnDefinition Width="*" />
        </Grid.ColumnDefinitions>
        <Grid.RowDefinitions>
            <RowDefinition Height="*" />
            <RowDefinition Height="4" />
            <RowDefinition Height="2*" />
        </Grid.RowDefinitions>

        <controls:GridSection Grid.Row="0"
                              Grid.RowSpan="3"
                              Grid.Column="0">
            <controls:GridSection.Header>
                <controls:GridSectionHeader HorizontalContentAlignment="Right"
                                            Label="Latest News">
                    <controls:GridSectionHeader.Items>
                        <controls:GridSectionHeaderButton Glyph="Assets/Eye.png"
                                                          ToolTip="View" />
                        <controls:GridSectionHeaderButton Glyph="Assets/Erase.png"
                                                          ToolTip="Delete" />
                    </controls:GridSectionHeader.Items>
                </controls:GridSectionHeader>
            </controls:GridSection.Header>
            <controls:GridSection.Content>
                <Grid>
                    <TextBlock FontSize="30"
                               Text="latest news" />
                </Grid>
            </controls:GridSection.Content>
        </controls:GridSection>

        <controls:GridSection Grid.Row="0"
                              Grid.Column="2">
            <controls:GridSection.Header>
                <controls:GridSectionHeader HorizontalContentAlignment="Right"
                                            Label="Other News"
                                            ShowLine="False">
                    <controls:GridSectionHeader.Items>
                        <controls:GridSectionHeaderButton Glyph="Assets/Eye.png"
                                                          ToolTip="View" />
                    </controls:GridSectionHeader.Items>
                </controls:GridSectionHeader>
            </controls:GridSection.Header>
            <controls:GridSection.Content>
                <Grid>
                    <TextBlock FontSize="30"
                               Text="old news" />
                </Grid>
            </controls:GridSection.Content>
        </controls:GridSection>

        <controls:GridSection Grid.Row="2"
                              Grid.Column="2">
            <controls:GridSection.Header>
                <controls:GridSectionHeader HorizontalContentAlignment="Right"
                                            Label="More" />
            </controls:GridSection.Header>
            <controls:GridSection.Content>
                <Grid>
                    <Button Width="100"
                            Height="40"
                            Content="more" />
                </Grid>
            </controls:GridSection.Content>
        </controls:GridSection>
    </Grid>

```

