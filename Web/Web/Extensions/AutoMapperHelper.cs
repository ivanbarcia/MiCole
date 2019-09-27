using AutoMapper;
using Web.DAL.Models;

namespace Web.Extensions
{
    public class AutoMapperHelper
    {
        public static void Configure()
        {
            ConfigureUserMapping();
        }

        private static void ConfigureUserMapping()
        {
            Mapper.Initialize(cfg =>
            {
                //cfg.CreateMap<AuditableEntity, AccionDTO>();
            });
        }
    }
}
