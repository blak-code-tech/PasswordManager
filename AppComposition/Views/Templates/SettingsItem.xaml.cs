using CommunityToolkit.Mvvm.Input;
using PasswordManager.AppComposition.Views.MainPages;

namespace PasswordManager.AppComposition.Views.Templates;

public partial class SettingsItem : ContentView
{
	public SettingsItem()
	{
		InitializeComponent();
	}

    #region Bindable Properties
    public static readonly BindableProperty ItemTextProperty =
            BindableProperty.Create("ItemText", typeof(string), typeof(SettingsItem), "");


    public static readonly BindableProperty ItemCommandProperty =
           BindableProperty.Create("ItemCommand", typeof(IRelayCommand), typeof(SettingsItem));

    public static readonly BindableProperty ItemCommandParameterProperty =
            BindableProperty.Create("ItemCommandParameter", typeof(string), typeof(SettingsItem), "");

    #endregion

    #region Properties
    public string ItemText
    {
        get { return (string)GetValue(ItemTextProperty); }
        set { SetValue(ItemTextProperty, value); }
    }

    public IRelayCommand ItemCommand
    {
        get { return (IRelayCommand)GetValue(ItemCommandProperty); }
        set { SetValue(ItemCommandProperty, value); }
    }

    public string ItemCommandParameter
    {
        get { return (string)GetValue(ItemCommandParameterProperty); }
        set { SetValue(ItemCommandParameterProperty, value); }
    }
    #endregion
}