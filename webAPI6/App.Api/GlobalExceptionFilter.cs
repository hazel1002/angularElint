using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api
{
    public class GlobalExceptionFilter : Attribute, IExceptionFilter
    {
        private readonly ILogger<GlobalExceptionFilter> _logger;

        public GlobalExceptionFilter(
             ILogger<GlobalExceptionFilter> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        public void OnException(ExceptionContext context)
        {
            ContentResult result = new ContentResult
            {
                StatusCode = 500,
                ContentType = "text/json;charset=utf-8;"
            };

            _logger.LogError($"錯誤訊息:{context.Exception.Message} {Environment.NewLine} StackTrace: {context.Exception.StackTrace}");
            result.Content = "系統發生錯誤了!"; //context.Exception.Message;

            context.Result = result;
            context.ExceptionHandled = true;
        }

    }
}
