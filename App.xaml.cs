using Project_ShoppingApp.Database;
using Project_ShoppingApp.Views;

namespace Project_ShoppingApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new LoginPage();
    }
    static LoginDatabase database;

    // Create the database connection as a singleton.
    public static LoginDatabase Database
    {
        get
        {
            if (database == null)
            {
                database = new LoginDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SQLLiteSample.db"));
            }
            return database;
        }
    }
}
