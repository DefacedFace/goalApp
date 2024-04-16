using Foundation;

namespace Primary;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp()
	{
		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("SetUpEntry", (handler, view) =>
		{
			handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
		});

		return MauiProgram.CreateMauiApp();
	}
}
