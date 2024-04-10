using PKHeX.Core;

namespace ItemPrinterDeGacha.WinForms;

internal static class Program
{
    public const string TimeFormat = "yyyy-MM-dd HH:mm:ss";

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        var strings = GameInfo.GetStrings("en");
        GameInfo.Strings = strings;
        var fake = new SAV9SV();
        var src = new GameDataSource(strings);
        GameInfo.FilteredSources = new FilteredGameDataSource(fake, src);
        Application.Run(new Main());
    }
}
