using Microsoft.Extensions.Logging;

namespace MauiAppHotel
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Kalam-Bold.ttf", "KalamBold");
                    fonts.AddFont("Kalam-Light.ttf", "KalamLight");
                    fonts.AddFont("Kalam-Regular.ttf", "Kalam");
                    fonts.AddFont("Roboto-Bold.ttf", "RobotoBold");
                    fonts.AddFont("Roboto-Thin.ttf", "RobotoThin");
                    fonts.AddFont("Roboto-Regular.ttf", "Roboto");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
