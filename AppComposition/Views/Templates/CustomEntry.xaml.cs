using CommunityToolkit.Mvvm.Input;

namespace PasswordManager.AppComposition.CustomControls;

public partial class CustomEntry : ContentView
{
	public CustomEntry()
	{
		InitializeComponent();
	}

    #region Bindable Property
    public static readonly BindableProperty FieldNameProperty =
            BindableProperty.Create("FieldName", typeof(string),
                typeof(CustomEntry), "");
    
    public static readonly BindableProperty PlaceholderTextProperty =
            BindableProperty.Create("PlaceholderText", typeof(string),
                typeof(CustomEntry), "");
    
    public static readonly BindableProperty FieldTextProperty =
            BindableProperty.Create("FieldText", typeof(string),
                typeof(CustomEntry), "", BindingMode.TwoWay);
    
    public static readonly BindableProperty IsPasswordFieldProperty =
            BindableProperty.Create("IsPasswordField", typeof(bool),
                typeof(CustomEntry), false);
    
    public static readonly BindableProperty IsSetCustomIconProperty =
            BindableProperty.Create("IsSetCustomIcon", typeof(bool),
                typeof(CustomEntry), false);
    
    public static readonly BindableProperty CustomIconProperty =
            BindableProperty.Create("CustomIcon", typeof(string),
                typeof(CustomEntry), "");
    
    public static readonly BindableProperty PasswordVisibleProperty =
            BindableProperty.Create("PasswordVisible", typeof(bool),
                typeof(CustomEntry), false);
    
    public static readonly BindableProperty PredictTextProperty =
            BindableProperty.Create("PredictText", typeof(bool),
                typeof(CustomEntry), true);
    
    public static readonly BindableProperty TogglePasswordCommandProperty =
            BindableProperty.Create("TogglePasswordCommand", typeof(IRelayCommand),
                typeof(CustomEntry));
    
    public static readonly BindableProperty KeyboardTypeProperty =
            BindableProperty.Create("KeyboardType", typeof(Keyboard),
                typeof(CustomEntry));

    public static readonly BindableProperty BorderBgColorProperty =
            BindableProperty.Create("BorderBgColor", typeof(Color),
                typeof(CustomEntry),Color.FromArgb("FFFFFF"));
    
    public static readonly BindableProperty PlaceHolderColorProperty =
            BindableProperty.Create("PlaceHolderColor", typeof(Color),
                typeof(CustomEntry),Color.FromArgb("FFFFFF"));
    #endregion

    #region Properties
    public string FieldName
    {
        get { return (string)GetValue(FieldNameProperty); }
        set { SetValue(FieldNameProperty, value); }
    }
    
    public string PlaceholderText
    {
        get { return (string)GetValue(PlaceholderTextProperty); }
        set { SetValue(PlaceholderTextProperty, value); }
    }
    
    public string FieldText
    {
        get { return (string)GetValue(FieldTextProperty); }
        set { SetValue(FieldTextProperty, value); }
    }
    
    public bool IsPasswordField
    {
        get { return (bool)GetValue(IsPasswordFieldProperty); }
        set { SetValue(IsPasswordFieldProperty, value); }
    }
    
    public bool IsSetCustomIcon
    {
        get { return (bool)GetValue(IsSetCustomIconProperty); }
        set { SetValue(IsSetCustomIconProperty, value); }
    }
    
    public string CustomIcon
    {
        get { return (string)GetValue(CustomIconProperty); }
        set { SetValue(CustomIconProperty, value); }
    }
    
    public bool PasswordVisible
    {
        get { return (bool)GetValue(PasswordVisibleProperty); }
        set { SetValue(PasswordVisibleProperty, value); }
    }
    
    public bool PredictText
    {
        get { return (bool)GetValue(PredictTextProperty); }
        set { SetValue(PredictTextProperty, value); }
    }
    
    public IRelayCommand TogglePasswordCommand
    {
        get { return (IRelayCommand)GetValue(TogglePasswordCommandProperty); }
        set { SetValue(TogglePasswordCommandProperty, value); }
    }
    
    public Keyboard KeyboardType
    {
        get { return (Keyboard)GetValue(KeyboardTypeProperty); }
        set { SetValue(KeyboardTypeProperty, value); }
    }
    
    public Color BorderBgColor
    {
        get { return (Color)GetValue(BorderBgColorProperty); }
        set { SetValue(BorderBgColorProperty, value); }
    }
    
    public Color PlaceHolderColor
    {
        get { return (Color)GetValue(PlaceHolderColorProperty); }
        set { SetValue(PlaceHolderColorProperty, value); }
    }
    #endregion
}