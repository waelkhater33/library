namespace My_Data
{
    public class program
    {
        public static int Main()
        {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddControllersWithViews();
            WebApplication app = builder.Build();
            app.MapDefaultControllerRoute();
            app.UseStaticFiles();
            app.Run();
            return 0;

        }
    }
}
