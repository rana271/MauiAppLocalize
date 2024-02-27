using MauiAppLocalize.Resources.String;
using System.Globalization;

namespace MauiAppLocalize;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        AppResources.Culture = new CultureInfo("en");
    }
}
