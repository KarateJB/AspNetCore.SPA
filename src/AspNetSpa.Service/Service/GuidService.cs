using System;
using AspNetSpa.Infra.Utility;

namespace AspNetSpa.Service
{
    /// <summary>
    /// GUID Service
    /// </summary>
    public class GuidService : IGuidService, IGuidServiceTransient, IGuidServiceScoped, IGuidServiceSingleton, IGuidServiceSingletonInstance
    {
        public GuidService(string title, Guid? guid = null)
        {
            this.Title = title;

            if (guid != null && !guid.Equals(Guid.Empty))
                this.Id = (Guid)guid;
            else
                this.Id = Guid.NewGuid();

            LogUtility.Logger.Warn($"{title} : completed constructor.");
        }

        public string Title { get; set; }
        public Guid Id { get; set; }

    }
}