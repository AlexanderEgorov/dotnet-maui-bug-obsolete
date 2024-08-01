using System;
using Microsoft.Maui.Graphics;
using Microsoft.Maui.Controls;
using System.ComponentModel;

namespace DXMauiApp;

public partial class MainPage : ContentPage {
    public MainPage() {
        InitializeComponent();
    }
}

public class Class1 : Grid {
    [Obsolete("[Obsolete message]: BP1Property", error: false), EditorBrowsable(EditorBrowsableState.Never)]
    public static readonly BindableProperty BP1Property = 
        BindableProperty.Create(nameof(BP1), typeof(string), typeof(Class1), null);
    [Obsolete("[Obsolete message]: BP2Property", error: true), EditorBrowsable(EditorBrowsableState.Never)]
    public static readonly BindableProperty BP2Property = 
        BindableProperty.Create(nameof(BP2), typeof(string), typeof(Class1), null);

    [Obsolete("[Obsolete message]: BP1", error: false), EditorBrowsable(EditorBrowsableState.Never)]
    public string BP1 { get => (string)GetValue(BP1Property); set => SetValue(BP1Property, value); }
    [Obsolete("[Obsolete message]: BP2", error: true), EditorBrowsable(EditorBrowsableState.Never)]
    public string BP2 { get => (string)GetValue(BP2Property); set => SetValue(BP2Property, value); }


    [Obsolete("[Obsolete message]: P1", error: false), EditorBrowsable(EditorBrowsableState.Never)]
    public string P1 { get; set; }
    [Obsolete("[Obsolete message]: P2", error: true), EditorBrowsable(EditorBrowsableState.Never)]
    public string P2 { get; set; }
}

[Obsolete("[Obsolete message]: ObsoleteClass2", error: false), EditorBrowsable(EditorBrowsableState.Never)]
public class ObsoleteClass2 : Grid { }

[Obsolete("[Obsolete message]: ObsoleteClass3", error: true), EditorBrowsable(EditorBrowsableState.Never)]
public class ObsoleteClass3 : Grid { }
