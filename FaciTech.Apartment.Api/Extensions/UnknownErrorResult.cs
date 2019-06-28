using Microsoft.AspNetCore.Mvc;
using System;

namespace FaciTech.Apartment.Api.Extenstion
{
    public class UnknownErrorResult : StatusCodeResult
    {
        public UnknownErrorResult(Exception exception=null):base(501)
        {

        }
    }
}
