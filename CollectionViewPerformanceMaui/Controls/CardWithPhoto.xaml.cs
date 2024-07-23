using CollectionViewPerformanceMaui.Models;
using CommunityToolkit.Mvvm.Input;

namespace CollectionViewPerformanceMaui.Controls;

public partial class CardWithPhoto : Grid {
    public CardWithPhoto() {
        InitializeComponent();
    }

    public static readonly BindableProperty SourceProperty = BindableProperty.Create(nameof(Source), typeof(Data), typeof(ComplexCard));

    public Data Source {
        get => (Data)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    [RelayCommand]
    private async Task OpenLink() {
        if (Application.Current?.MainPage is null) {
            return;
        }

        await Application.Current.MainPage.DisplayAlert(
            "Ahoy",
            "The link was tapped",
            "Close");
    }
}