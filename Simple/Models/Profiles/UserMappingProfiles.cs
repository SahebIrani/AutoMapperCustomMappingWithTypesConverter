using AutoMapper;

using Simple.Models.DTOs;
using Simple.Models.Entities;
using Simple.Models.Enums;
using Simple.Models.TypesConverter;

using System;

namespace Simple.Models.Profiles
{
    public class UserMappingProfiles : Profile
    {
        public UserMappingProfiles()
        {
            CreateMap<UserEntity, UserDto>()
                .ForMember(dest => dest.FullName, options => options.MapFrom(source => $"{source.FirstName} {source.LastName}"))
                .ForMember(dest => dest.BirthDate, options => options.MapFrom(source => source.BirthDate.ToString()))
                .ForMember(dest => dest.Gender, options => options.MapFrom(source => source.Gender.ToString()))
                .ForMember(dest => dest.SIN, options => options.MapFrom(source => source.Id)
            )
            ;

            CreateMap<UserDto, UserEntity>()
                .ForMember(dest => dest.Id, options => options.MapFrom(sourse => sourse.SIN))
                .ForMember(dest => dest.FirstName, options => options.MapFrom(sourse => sourse.FullName.Split(' ', '\t')[0]))
                .ForMember(dest => dest.LastName, options => options.MapFrom(sourse => sourse.FullName.Split(' ', '\t')[1]))
                .ForMember(dest => dest.Gender, output => output.MapFrom(sourse => Enum.Parse(typeof(Gender), sourse.Gender))
            //.ForMember(dest => dest.BirthDate, output => output.MapFrom(sourse => Convert.ToDateTime(sourse.BirthDate))
            //.ForMember(d => d.BirthDate, opt => opt.MapFrom(s => DateTime.ParseExact(s.BirthDate, "dd.mm.yyyy", CultureInfo.InvariantCulture)))
            )
            ;

            // اگر نمیخواهید از قابلیت تبدیل نوع استفاده کنید میتوانید یکی از دو خط کامنت شده بالا رو از کامنت خارج کرده و استفاده کنید و از کدهای پایین صرف نظر کنید

            //CreateMap<string, DateTime>().ConvertUsing(new DateTimeConverterForString());
            CreateMap<string, DateTime>().ConvertUsing<StringToDateTimeConverter>();
        }
    }
}
