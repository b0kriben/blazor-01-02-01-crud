using Blazored.LocalStorage;
using Kreta.Components.Layout;
using Kreta.HttpService;
using Kreta.ViewModelProject;
using MudBlazor.Services;

namespace Kreta.Extension
{
    public static class AddBlazorExtension
    {
        public static void AddBlazor(this IServiceCollection services)
        {
            services.AddMudServices();
            services.AddBlazoredLocalStorage();
            services.AddServices();
            services.SetupHttpClient();
        }

        private static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ThemeService>();

            services.AddScoped<IStudentHttpService,StudentHttpService>();

            services.AddScoped<IStudentViewModelBase,StudentViewModelBase>();
        }

        private static void SetupHttpClient(this IServiceCollection services)
        {
            services.AddHttpClient("KretaApi", options =>
            {
                options.BaseAddress = new Uri("https://localhost:7090/");
            });
        }
    }
}
