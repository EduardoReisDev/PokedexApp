using CommunityToolkit.Maui;

namespace Pokedex;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>().ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Bold.ttf", "OpenSansBold");
            fonts.AddFont("OpenSans-BoldItalic.ttf", "OpenSansBoldItalic");

            fonts.AddFont("OpenSans-ExtraBold.ttf", "OpenSansExtraBold");
            fonts.AddFont("OpenSans-ExtraBoldItalic.ttf", "OpenSansExtraBoldItalic");

            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemiBold");
            fonts.AddFont("OpenSans-SemiboldItalic.ttf", "OpenSansSemiBoldItalic");

            fonts.AddFont("OpenSans-Light.ttf", "OpenSansLight");
            fonts.AddFont("OpenSans-LightItalic.ttf", "OpenSansLightItalic");

            fonts.AddFont("OpenSans-Medium.ttf", "OpenSansMedium");
            fonts.AddFont("OpenSans-MediumItalic.ttf", "OpenSansLight");

            fonts.AddFont("OpenSans-Italic.ttf", "OpenSansItalic");

            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            
        }).UseMauiCommunityToolkit();

        return builder.Build();
    }
}
