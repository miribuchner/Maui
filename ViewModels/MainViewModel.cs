using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppZufall.ViewModels;

public partial class MainViewModel : ObservableObject
{

    [ObservableProperty] // macht was auf der oberfläche stehen soll ig???
    int _zahl = 0;

    string _title = "hallo";
    // DAs passiert mit ObservableProperty
public string Title
{
    get => _title;
    set => SetProperty(ref _title, value);
}

    void ChangeText()
    {
        this.Title = "Hallo Welt";
    }
}
