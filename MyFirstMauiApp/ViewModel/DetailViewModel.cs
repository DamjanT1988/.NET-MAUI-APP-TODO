
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Runtime.CompilerServices;

namespace MyFirstMauiApp.ViewModel
{
    //23 second parameter is the query identifier, in main view "?Text="
    [QueryProperty("Text", "Text")]

    //15
    public partial class DetailViewModel : ObservableObject
    {
        //24 save text
        [ObservableProperty]
        string text;

        //25 go-back method
        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
