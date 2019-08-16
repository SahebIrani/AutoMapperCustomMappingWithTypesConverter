using AutoMapper;

using System;

namespace Simple.Models.TypesConverter
{
    /// <summary>
    /// مثال اول
    /// </summary>
    public class DateTimeConverterForString : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context) =>
            System.Convert.ToDateTime(source);
    }

    /// <summary>
    /// مثال دوم
    /// </summary>
    public class StringToDateTimeConverter : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context) =>
            DateTime.TryParse(source, out DateTime dateTime) ? dateTime : default;
    }
}
