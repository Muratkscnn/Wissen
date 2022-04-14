using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_02
{
    public class Program
    {
        //EFcore ile oluþturacaðýmýz ef projelerinde ef.netframeworkde yaptýgýmýz gibi
        //sihirbaz ile ef'i projeye dahil edemeyiz bunun için kod yazmalýyýz..
        //Yazacaðýmýz kod context ve entity classlarýný oluþturarak modelimizi yaratacak.
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
