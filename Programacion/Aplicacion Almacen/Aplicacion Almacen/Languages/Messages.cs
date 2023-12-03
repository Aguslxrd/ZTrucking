using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Almacen.Languages
{
    public static class Messages
    {
        public static string ProductFound => LanguageManager.GetString("ProductFound");
        public static string ProductNotFound => LanguageManager.GetString("ProductNotFound");
        public static string Error => LanguageManager.GetString("Error");
        public static string ErrorSyntax => LanguageManager.GetString("ErrorSyntax");
        public static string CompleteAllBoxAndStatus => LanguageManager.GetString("CompleteAllBoxAndStatus");
        public static string Successful => LanguageManager.GetString("Successfull");
        public static string SelectAnIndex => LanguageManager.GetString("SelectAnIndex");
        public static string LotFound => LanguageManager.GetString("LotFound");
        public static string LotNotFound => LanguageManager.GetString("LotNotFound");
        public static string UserFound => LanguageManager.GetString("UserFound");
        public static string UserNotFound => LanguageManager.GetString("UserNotFound");
        public static string InvalidID => LanguageManager.GetString("InvalidID");
        public static string VerifyData => LanguageManager.GetString("VerifyData");
        public static string ViewMap => LanguageManager.GetString("ViewMap");
        public static string Job => LanguageManager.GetString("Job");
        public static string Name => LanguageManager.GetString("Name"); 
    }

}
