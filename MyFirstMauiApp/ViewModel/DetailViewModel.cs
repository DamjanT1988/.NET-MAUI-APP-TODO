
using CommunityToolkit.Mvvm.ComponentModel;

namespace MyFirstMauiApp.ViewModel
{
    //23 - second parameter is the query identifier, in main view "?Text="
    [QueryProperty("Text", "Text")]

    //15
    public partial class DetailViewModel : ObservableObject
    {
        //24
        [ObservableProperty]
        string text;
    }
}
