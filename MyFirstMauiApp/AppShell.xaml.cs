namespace MyFirstMauiApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		//18 route
		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
	}
}
