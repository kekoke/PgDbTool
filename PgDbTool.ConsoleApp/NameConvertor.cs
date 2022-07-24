using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PgDbTool.ConsoleApp
{
    /// <summary>
    /// 命名格式转换
    /// </summary>
    public static class NameConvertor
    {
        /// <summary>
        /// 大驼峰转下划线分割
        /// </summary>
        /// <param name="camelCaseName">例如：FirstName </param>
        /// <returns>例如：first_name</returns>
        public static string ConvertCamelCaseToCapsWithUnderscores(string camelCaseName)
        {
            var rgx = @"([A-Z])([A-Z][a-z])|([a-z0-9])([A-Z])";
            var result = Regex.Replace(camelCaseName, rgx, "$1$3_$2$4").ToLower();
            return result;
        }
    }
}
