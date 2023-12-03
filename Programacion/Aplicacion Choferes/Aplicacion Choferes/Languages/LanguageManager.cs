using System;
using System.Globalization;
using System.Resources;

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
