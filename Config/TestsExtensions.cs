using System;
using System.Linq;

namespace Acelero.BDD.Tests.Config
{
    public static class TestsExtensions
    {
        public static int ApenasNumeros(this string value)
        {
            return Convert.ToInt16(new string(value.Where(char.IsDigit).ToArray()));
        }
    }
}
