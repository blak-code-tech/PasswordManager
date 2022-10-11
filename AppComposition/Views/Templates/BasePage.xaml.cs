using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.Input;
using PasswordManager.AppComposition.Services;

namespace PasswordManager.AppComposition.Views.MainPages;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class BasePage : ContentPage
{
    #region Constructor
    public BasePage()
	{
		InitializeComponent();
    }
    #endregion

    #region Bindable Properties
    public static readonly BindableProperty ShowHeadSectionProperty =
            BindableProperty.Create("ShowHeadSection", typeof(bool),
                typeof(BasePage), true);

    public static readonly BindableProperty IsMainPageProperty =
            BindableProperty.Create("IsMainPage", typeof(bool), typeof(BasePage), false);

    public static readonly BindableProperty IsShowTitleRightIconProperty =
            BindableProperty.Create("IsShowTitleRightIcon", typeof(bool), typeof(BasePage), true);


    public static readonly BindableProperty PageTitleProperty =
            BindableProperty.Create("PageTitle", typeof(string), typeof(BasePage), "");

    public static readonly BindableProperty MenuReturnCommandProperty =
           BindableProperty.Create("MenuReturnCommand", typeof(IRelayCommand), typeof(BasePage));

    public static readonly BindableProperty MenuReturnCommandParameterProperty =
            BindableProperty.Create("MenuReturnCommandParameter", typeof(string), typeof(BasePage), "");


    public static readonly BindableProperty AddPasswordCommandProperty =
           BindableProperty.Create("AddPasswordCommand", typeof(IRelayCommand), typeof(BasePage));

    public static readonly BindableProperty AddPasswordCommandParameterProperty =
            BindableProperty.Create("AddPasswordCommandParameter", typeof(string), typeof(BasePage), "");
    #endregion

    #region Properties
    public View Body
    {
        get => BodyContent.Content;
        set => BodyContent.Content = value;
    }

    public bool ShowHeadSection
    {
        get { return (bool)GetValue(ShowHeadSectionProperty); }
        set { SetValue(ShowHeadSectionProperty, value); }
    }

    public bool IsMainPage
    {
        get { return (bool)GetValue(IsMainPageProperty); }
        set { SetValue(IsMainPageProperty, value); }
    }

    public bool IsShowTitleRightIcon
    {
        get { return (bool)GetValue(IsShowTitleRightIconProperty); }
        set { SetValue(IsShowTitleRightIconProperty, value); }
    }

    public string PageTitle
    {
        get { return (string)GetValue(PageTitleProperty); }
        set { SetValue(PageTitleProperty, value); }
    }

    public IRelayCommand MenuReturnCommand
    {
        get { return (IRelayCommand)GetValue(MenuReturnCommandProperty); }
        set { SetValue(MenuReturnCommandProperty, value); }
    }

    public string MenuReturnCommandParameter
    {
        get { return (string)GetValue(MenuReturnCommandParameterProperty); }
        set { SetValue(MenuReturnCommandParameterProperty, value); }
    }

    public IRelayCommand AddPasswordCommand
    {
        get { return (IRelayCommand)GetValue(AddPasswordCommandProperty); }
        set { SetValue(AddPasswordCommandProperty, value); }
    }

    public string AddPasswordCommandParameter
    {
        get { return (string)GetValue(AddPasswordCommandParameterProperty); }
        set { SetValue(AddPasswordCommandParameterProperty, value); }
    }

    #endregion

    protected override void OnAppearing()
    {
        base.OnAppearing();
    }
}