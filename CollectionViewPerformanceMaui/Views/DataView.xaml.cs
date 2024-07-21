using CollectionViewPerformanceMaui.ViewModels;

namespace CollectionViewPerformanceMaui.Views;

public partial class DataView : ContentPage
{
	public DataView(DataViewModel viewModel)
	{
		InitializeComponent();

		this.BindingContext = viewModel;
	}

	protected override void OnNavigatedTo(NavigatedToEventArgs args)
	{
		base.OnNavigatedTo(args);

		_ = ((DataViewModel)this.BindingContext).InitialiseAsync();
	}
}