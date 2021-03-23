using AirPortDataLayer.Crud.InterFace;
using AirPortDataLayer.Data;
using AirPortDataLayer.Crud;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace AirportWebRazor
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.Cookie.Name = ".Jimboo.Session";
                options.IdleTimeout = TimeSpan.FromSeconds(120);
                options.Cookie.IsEssential = true;
            });
            services.AddMvc();
            #region dbcontext
            services.AddDbContext<AppDatabaseContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DbConnection")));
            #endregion
            #region transient
            services.AddTransient<IAddress, Address>();
            services.AddTransient<IAirline, Airline>();
            services.AddTransient<IAirPort, AirPortDataLayer.Crud.AirPort>();
            services.AddTransient<IAirPlane, AirPlane>();
            services.AddTransient<IArticle, Article>();
            services.AddTransient<IBrand, Brand>();
            services.AddTransient<ICategory, Category>();
            services.AddTransient<ICity, City>();
            services.AddTransient<ICustomer, Customer>();
            services.AddTransient<ICustomerFlight, CustomerFlight>();
            services.AddTransient<IDetail, Detail>();
            services.AddTransient<IDetailValue, DetailValue>();
            services.AddTransient<IEntertainment, Entertainment>();
            services.AddTransient<IFaq, Faq>();
            services.AddTransient<IFeatrue, Featrue>();
            services.AddTransient<IFlight, Flight>();
            services.AddTransient<IFlightStatus, FlightStatus>();
            services.AddTransient<IFlightToDo, FlightToDo>();
            services.AddTransient<IGallery, Gallery>();
            services.AddTransient<IGalleryImage, GalleryImage>();
            services.AddTransient<IGate, Gate>();
            services.AddTransient<ILinks, Links>();
            services.AddTransient<IPlace, Place>();
            services.AddTransient<IRequest, Request>();
            services.AddTransient<IRequestType, RequestType>();
            services.AddTransient<IState, State>();
            services.AddTransient<ITerminal, Terminal>();
            services.AddTransient<ITypeDetail, TypeDetail>();
            services.AddTransient<IUser, User>();
            services.AddTransient<IWeather, Weather>();
            services.AddTransient<IRaiting, Rairing>();

            #endregion



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
