using MyFirstMauiApp.ViewModel;

namespace MyFirstMauiApp;

public partial class DetailPage : ContentPage
{
	//16
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}