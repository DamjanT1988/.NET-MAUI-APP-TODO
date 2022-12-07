﻿using CommunityToolkit.Mvvm.ComponentModel;
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

    //method
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        Items.Add(Text);
        //add item
        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if(Items.Contains(s))
        {
            Items.Remove(s);
        }
    }

    //20
    [RelayCommand]
    async Task Tap(string s)
    {
        //22
        await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
    }
}



/*
public class MainViewModel : INotifyPropertyChanged
{
    string text;

    public string Text
    {
        get => text;
        set
        {
            text = value;
            OnPropertyChanged(nameof(Text));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}
*/