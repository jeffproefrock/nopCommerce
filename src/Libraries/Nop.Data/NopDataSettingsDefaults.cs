﻿namespace Nop.Data
{
    /// <summary>
    /// Represents default values related to data settings
    /// </summary>
    public static partial class NopDataSettingsDefaults
    {
        /// <summary>
        /// Gets a path to the file that was used in old nopCommerce versions to contain data settings
        /// </summary>
        public static string ObsoleteFilePath => "~/App_Data/Settings.txt";

        /// <summary>
        /// Gets a path to the file that contains data settings (old version)
        /// </summary>
        public static string FilePath => "~/App_Data/dataSettings.json";

        /// <summary>
        /// Gets a path to the file that contains app settings
        /// </summary>
        public static string AppSettingsFilePath => "~/App_Data/appsettings.json";
    }
}