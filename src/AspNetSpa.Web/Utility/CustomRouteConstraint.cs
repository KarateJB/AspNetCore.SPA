using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

public class CustomRouteConstraint : IRouteConstraint
{
    private readonly string[] constraints = new string[]{"peter","jack","mary"}; 
    public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
    {
        object value;
        if (values.TryGetValue(routeKey, out value) && value != null)
        {
            return constraints.Contains(value.ToString().ToLower());
        }
        return false;
    }
}