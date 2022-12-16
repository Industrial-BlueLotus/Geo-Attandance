using Attandance_App.Views.Mobile;
using Attandance_App.Views.Desktop;

namespace Attandance_App;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        MainPage = new DesktopStartupPage();

#if ANDROID
        //  

#else
        //   MainPage = new NavigationPage(new DesktopStartupPage());
#endif

    }

}
