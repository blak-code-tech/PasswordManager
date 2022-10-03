using PasswordManager.AppComposition.Views.MainPages;

namespace PasswordManager.AppComposition.Views.Templates;

public partial class AnalysisCard : ContentView
{
	public AnalysisCard()
	{
		InitializeComponent();
	}

    #region Bindable Properties
    public static readonly BindableProperty NumberOfPasswordsProperty =
            BindableProperty.Create("NumberOfPasswords", typeof(int), typeof(AnalysisCard), 0);
    
    
    public static readonly BindableProperty GroupProperty =
            BindableProperty.Create("Group", typeof(string), typeof(AnalysisCard), "");

    #endregion

    #region Properties
    public int NumberOfPasswords
    {
        get { return (int)GetValue(NumberOfPasswordsProperty); }
        set { SetValue(NumberOfPasswordsProperty, value); }
    }
    
    public string Group
    {
        get { return (string)GetValue(GroupProperty); }
        set { SetValue(GroupProperty, value); }
    }
    #endregion
}