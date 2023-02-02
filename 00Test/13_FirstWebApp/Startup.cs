namespace _13_FirstWebApp
{
    public class Startup
    {
        public void ConfigureServcies(IServiceCollection services)
        {
            services.AddRazorPages();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (!env.IsDevelopment())
            {
                app.UseHsts();
            }
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();


            app.UseDefaultFiles(); //index.html , index.htm, default.html
            app.UseStaticFiles();   //damit statische websiten behandelt werden können.

            
        }
    }
}
