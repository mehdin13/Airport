using System;
using System.Text;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AirPortDataLayer.Crud;
using AirPortDataLayer.Crud.InterFace;
using AirPortDataLayer.Data;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using AirPort.Model;
using Microsoft.IdentityModel.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AirPort
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
            services.AddDbContext<AppDatabaseContext>(option => option.UseSqlServer(Configuration.GetConnectionString("DbConnection")));
            services.AddTransient<IAddress, Address>();
            services.AddTransient<IAdvertizment, Advertizment>();
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
            services.Configure<AppSettings>(Configuration.GetSection("TokenProvider"));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddControllers();
            #region Password Options
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 4;
            });
            #endregion
            #region JwtBearer

            var key = Encoding.UTF8.GetBytes(Configuration["TokenProvider:JWT_Token"].ToString());

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = false;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
            });

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("404 Not Found");
            });
        }
    }
}
