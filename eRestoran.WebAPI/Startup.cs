using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRestoran.Model.Request;
using eRestoran.WebAPI.Database;
using eRestoran.WebAPI.Security;
using eRestoran.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace eRestoran.WebAPI
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
            services.AddControllers();

            services.AddAutoMapper(typeof(Startup));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "eRestoran API", Version = "v1" });

                // basic auth swagger
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            var connection = @"Server=localhost;Database=eRestoran;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<eRestoranContext>(c => c.UseSqlServer(connection));

            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IService<Model.ItemType,object>, BaseService<Model.ItemType,object,ItemType>>();
            services.AddScoped<IService<Model.ItemCategory, object>, BaseService<Model.ItemCategory, object, ItemCategory>>();
            services.AddScoped<IService<Model.Quantity, object>, BaseService<Model.Quantity, object, Quantity>>();
            services.AddScoped<ICRUDService<Model.RestaurantMenuItem, MenuItemSearchRequest, Model.Request.RestaurantMenuItemUpsertRequest, Model.Request.RestaurantMenuItemUpsertRequest>, RestaurantMenuItemService>();
            services.AddScoped<ICRUDService<Model.Restaurant, object, Model.Request.RestaurantUpdateRequest, Model.Request.RestaurantUpdateRequest>, RestaurantService>();
            services.AddScoped<ICRUDService<Model.SuperOffer, Model.Request.SuperOfferSearchRequest, Model.Request.SuperOfferUpsertRequest, Model.Request.SuperOfferUpsertRequest>, SuperOfferService>();
            services.AddScoped<ICRUDService<Model.Award, object, Model.Request.AwardUpsertRequest, Model.Request.AwardUpsertRequest>, AwardService>();

            services.AddScoped<IService<Model.VisitorRole, object>, BaseService<Model.VisitorRole, object, UserRole>>();
            services.AddScoped<IService<Model.DiscountType, object>, BaseService<Model.DiscountType, object, DiscountType>>();
            services.AddScoped<ICRUDService<Model.Discount, object,Model.Request.DiscountUpsertRequest, Model.Request.DiscountUpsertRequest>, DiscountService>();
            services.AddScoped<ICRUDService<Model.VisitorRecommendation, object, Model.Request.VisitorRecommendationUpsertRequest, Model.Request.VisitorRecommendationUpsertRequest>, VisitorRecommendationService>();




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
