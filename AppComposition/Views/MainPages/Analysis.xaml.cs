using PasswordManager.AppComposition.ViewModels.MainPages;

namespace PasswordManager.AppComposition.Views.MainPages;

public partial class Analysis : BasePage
{
	public Analysis()
	{
		InitializeComponent();

		BindingContext = new AnalysisViewModel(this);
	}
}