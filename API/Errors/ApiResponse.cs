﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageforStatusCode(statusCode);
        }

       
        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageforStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request you have made",
                401 => "Not Authorized",
                404 => "Resource not found",
                500 => "Internal server error",
                _ => null
            };
        }

    }
}
