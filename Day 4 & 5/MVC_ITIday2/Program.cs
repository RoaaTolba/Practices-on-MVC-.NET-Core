namespace MVC_ITIday2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            
            builder.Services.AddControllersWithViews();//.AddSessionStateTempDataProvider();will put the info into the session not the client
            //the session will end in 20 minutes by defult
            builder.Services.AddSession(config =>
            config.IdleTimeout = TimeSpan.FromMinutes(20));
            var app = builder.Build();

            //app.Use(async (httpContext, next) => 
            //{
            //    await httpContext.Response.WriteAsync("Middleware 1");
            //    await next.Invoke();
            //    await httpContext.Response.WriteAsync("\n(3)Middleware 1");

            //});
            //app.Use(async (httpContext, next) => 
            //{
            //    await httpContext.Response.WriteAsync("\nMiddleware 2");
            //    await next.Invoke();
            //    await httpContext.Response.WriteAsync("\n(2)Middleware 1");

            //});
            //app.Run(async (httpContext) => 
            //{
            //    await httpContext.Response.WriteAsync("\nTerminate");
            //});
            //app.Use(async (httpContext, next) =>
            //{
            //    await httpContext.Response.WriteAsync("\nMiddleware 3");
            //    await next.Invoke();
            //});

            //Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseSession();
            
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // بتوقف الابلكيشن ومبتقفلهوش
            app.Run();
        }
    }
}
