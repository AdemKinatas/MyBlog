using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Shared.Constants.Messages
{
    public static class ValidationMessages
    {
        public static string NotEmpty = "boş geçilmemelidir!";

        public static string MustLessThen100 = "100 karakterden fazla olmamalıdır!";
        public static string MustLessThen200 = "200 karakterden fazla olmamalıdır!";
        public static string MustLessThen250 = "250 karakterden fazla olmamalıdır!";
        public static string MustLessThen500 = "500 karakterden fazla olmamalıdır!";

        public static string MustMoreThen3 = "en az 3 karakter olmalıdır!";
    }
}
