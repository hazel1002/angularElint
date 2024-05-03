using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NLog;
using App.Common;
using App.EF.EF.dbTemplate;
using System.Runtime.InteropServices;
using App.Enum;
//#Addusing
namespace App.BLL
{
    public interface IServiceBase
    {

    }
    public abstract class ServiceBase
    {
        internal ILogger _logger = NLog.LogManager.GetCurrentClassLogger();
        internal IConfigurationSection appSetting = AppSettingHelper.GetSection("ConnectionStrings");


        protected virtual dbTemplateContext dbTemplate([Optional] ConnectionMode connectionMode)
        {
            string connectionString = connectionMode.Equals(ConnectionMode.Slave)? appSetting.GetSection("dbConnectionString-Slave").Value : appSetting.GetSection("dbConnectionString-Master").Value;
            var optionsBuilder = new DbContextOptionsBuilder<dbTemplateContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new dbTemplateContext(optionsBuilder.Options);
        }

        //#AddService
    }
}
