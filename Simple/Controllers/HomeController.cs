using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using Simple.Models.DTOs;
using Simple.Models.Entities;
using Simple.Models.Enums;

using System;

namespace Simple.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IMapper mapper) => Mapper = mapper;
        public IMapper Mapper { get; }

        /// <summary>
        /// یافتن مشخصات کاربر
        /// </summary>
        /// <returns>یافتن انتیتی به همراه دی تی او</returns>
        public OkObjectResult Index()
        {
            UserEntity userEntity = new UserEntity
            {
                Id = "12345678",
                FirstName = "Sinjul",
                LastName = "MSBH",
                Gender = Gender.Male,
                BirthDate = DateTime.UtcNow,
            };

            UserDto userDto = new UserDto
            {
                SIN = "12345678",
                FullName = "Sinjul MSBH",
                Gender = "Male",
                BirthDate = "8/16/2019 8:40:26"
            };

            UserEntity userEntityResult = Mapper.Map<UserEntity>(userDto);

            UserDto userDtoResult = Mapper.Map<UserDto>(userEntity);

            var result = new { userEntityResult, userDtoResult };

            return Ok(result);
        }
    }
}
