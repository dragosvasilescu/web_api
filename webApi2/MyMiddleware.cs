﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace webApi2
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class MyMiddleware
    {
        private readonly RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public Task Invoke(HttpContext httpContext)
        {

            return _next(httpContext);
        }
    }

    // Edit this comment 12 14
    //This is a development change
    //This are new changes on development branch
    //bla bla
    //new changes on development 1.0
    //new change only on de velopment
    //new changes on development 2.0
    //new change only on de velopment
    //new changes on development 3.0
    //new change only on de velopment
    //new changes on development 4.0
    //new change only on de velopment
    //new changes on development 5.0
    //new change only on de velopment
    //new master change
    //new master change 1.0
    //new master change 2.0

    public static class MyMiddlewareExtensions
    {
        public static IApplicationBuilder UseMyMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyMiddleware>();
        }
    }
}
