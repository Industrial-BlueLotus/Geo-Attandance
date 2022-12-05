using Attandance_App.Views.Mobile;
using Attandance_App.Views.Desktop;

namespace Attandance_App;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();


#if ANDROID 
        MainPage = new NavigationPage(new MobileStartupPage());

#else
	     MainPage = new NavigationPage(new DesktopStartupPage());
#endif

    }

}
