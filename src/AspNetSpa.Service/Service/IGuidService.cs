using System;

namespace AspNetSpa.Service
{
    public interface IGuidService
    {
        string Title {get;set;}
        Guid Id {get;set;}
    }

    public interface IGuidServiceTransient : IGuidService
    {
    }
    public interface IGuidServiceScoped : IGuidService
    {
    }
    public interface IGuidServiceSingleton : IGuidService
    {
    }

    public interface IGuidServiceSingletonInstance : IGuidService
    {
    }
}