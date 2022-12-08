using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace MyFirstMauiApp.ViewModel;

//12 - create and fill the bindings
public partial class MainViewModel : ObservableObject
{

    public MainViewModel()
    {   //bind #2
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    //bind #1
    string text;


    [RelayCommand]
    //add a TO-DO object - AddCommand-bind
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        Items.Add(Text);
        //add item
        Text = string.Empty;
    }

    [RelayCommand]
    //delete a TO-DO object - DeleteCommand-path
    void Delete(string s)
    {
        if(Items.Contains(s))
        {
            Items.Remove(s);
        }
    }

    //20 navigate to page by tap - TapCommand-path
    [RelayCommand]
    async Task Tap(string s)
    {
        //22
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
    }
}