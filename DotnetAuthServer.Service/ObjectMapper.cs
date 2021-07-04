using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetAuthServer.Service
{
    public static class ObjectMapper
    {
        private static readonly Lazy<IMapper> lazy = new Lazy<IMapper>(() => // ihtiyaca gore, zamani geldiginde lazy.
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoMapper>();
            });

            return config.CreateMapper();
        });

        public static IMapper Mapper => lazy.Value; // mapper cagrilana kadar memory'ye yuklenmeyecek, calismayacak. object mapper'in mapper'i cagrildigi anda var config memory'ye yuklenecek. burda lambda ile get yapildi alternatif olarak.
    }
}
