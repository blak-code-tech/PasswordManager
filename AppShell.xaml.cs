using PasswordManager.AppComposition.Views.Auth;
using PasswordManager.AppComposition.Views.MainPages;

namespace PasswordManager;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("forgotpassword", typeof(ForgotPassword));
        Routing.RegisterRoute("resetpassword", typeof(ResetPassword));
        Routing.RegisterRoute("profile", typeof(Profile));
        Routing.RegisterRoute("newpassword", typeof(NewPassword));
        Routing.RegisterRoute("details", typeof(PasswordDetails)); 
    }
}
