<Window x:Class="GoodManagement.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:GoodManagement"
        mc:Ignorable="d"
        Height="700" Width="1200"
        Title="MainWindow" WindowStyle="None" ResizeMode="NoResize" WindowStartupLocation="CenterScreen" WindowState="Maximized" Background="#FF5C5C5C" >
    <Grid >
        <Grid.RowDefinitions>
            <RowDefinition Height="6*"/>
            <RowDefinition Height="1*"/>
        </Grid.RowDefinitions>
        <Grid>
            <Grid.RowDefinitions>
                <RowDefinition Height="*"/>
                <RowDefinition Height="8*"/>
            </Grid.RowDefinitions>
            <Grid.ColumnDefinitions>
                <ColumnDefinition Width="3*"/>
                <ColumnDefinition Width="5*"/>
            </Grid.ColumnDefinitions>
            <Border Background="#FF995038">
                <TextBlock Text="BOSS Revolution -- For a limted time, unlimited calls to Mexico for $5/month!" FontSize="22" TextWrapping="WrapWithOverflow" Foreground="White" HorizontalAlignment="Center" VerticalAlignment="Stretch" />
            </Border>
            <Grid Grid.Row="1">
                <Grid.RowDefinitions>
                    <RowDefinition Height="5*"/>
                    <RowDefinition Height="2*"/>
                    <RowDefinition Height="4*"/>
                </Grid.RowDefinitions>
                <Image Source="/Resources/logo-7.png" Stretch="Uniform" StretchDirection="Both" />
                <Grid Grid.Row="1">
                    <TextBlock Text="Ask the Customer for their BR Club Account Number" FontSize="24" TextWrapping="Wrap" HorizontalAlignment="Center" VerticalAlignment="Center" Foreground="White" TextAlignment="Center" />
                </Grid>
                <Grid Grid.Row="2">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                        <ColumnDefinition Width="*"/>
                    </Grid.ColumnDefinitions>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="*"/>
                    </Grid.RowDefinitions>
                    <Button Content="" />

                </Grid>
            </Grid>


        </Grid>
    </Grid>
</Window>
