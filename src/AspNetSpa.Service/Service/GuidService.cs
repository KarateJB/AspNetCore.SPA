using System;

namespace AspNetSpa.Service
{
    /// <summary>
    /// GUID Service
    /// </summary>
    public class GuidService : IGuidService, IGuidServiceTransient, IGuidServiceScoped, IGuidServiceSingleton, IGuidServiceSingletonInstance
    {
        public GuidService(Guid guid)
        {
            if (!guid.Equals(Guid.Empty))
                this.Id = guid;
            else
                this.Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}