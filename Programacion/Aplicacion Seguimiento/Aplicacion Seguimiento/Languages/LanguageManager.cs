using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion_Seguimiento.Languages
{
    public static class LanguageManager
    {
        private static ResourceManager resourceManager;

        public static void Initialize(Type resourceType)
        {
            resourceManager = new ResourceManager(resourceType);
        }

        public static string GetString(string key)
        {
            return resourceManager.GetString(key, CultureInfo.CurrentCulture);
        }

    }
}
