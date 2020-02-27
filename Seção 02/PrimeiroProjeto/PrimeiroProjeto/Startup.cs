using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PrimeiroProjeto.DataBase;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using PrimeiroProjeto.Repositories.Contracts;
using PrimeiroProjeto.Repositories;
using PrimeiroProjeto.Libraries.Sessao;
using PrimeiroProjeto.Models;
using PrimeiroProjeto.Libraries.Login;
using System.Net;
using System.Net.Mail;
using PrimeiroProjeto.Libranes.Email;
using PrimeiroProjeto.Libraries.Middieware;

namespace PrimeiroProjeto
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            //Padrão Repository  
            services.AddScoped<INewsletterRepository, NewsletterRepository>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IImagemRepository, ImagemRepository>();
            services.AddHttpContextAccessor();
            services.AddControllersWithViews();


            /*
            *SMTP
            */
            // SMTP -> Servidor que vai enviar a mensagem.
            services.AddScoped<SmtpClient>(options => {
                SmtpClient smtp = new SmtpClient() {
                    Host = Configuration.GetValue<String>("Email:ServerSMTP"),
                    Port = Configuration.GetValue<int>("Email:ServerPort"),
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(Configuration.GetValue<String>("Email:UserName"), Configuration.GetValue<String>("Email:Password")),
                    EnableSsl = true
                };
                return smtp;
            });
            services.AddScoped<GerenciarEmail>();
            

            /*
             *Session - Configuração
             */
            services.AddMemoryCache(); //Guardar os dados  na memoria
            services.AddSession(options =>
            {
                
            });
            services.AddScoped<Sessao>();
            services.AddScoped<LoginCliente>();
            services.AddScoped<LoginColaborador>();
            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Loja Virtual;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            services.AddDbContext<LojaVirtualContext>(options => options.UseSqlServer(connection));
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
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseMiddleware<ValidateAntiForgeryTokenMiddleware>();
            app.UseEndpoints(endpoints =>
            {
              
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
