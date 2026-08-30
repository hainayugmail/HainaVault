using System;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine.Localization.Settings;

namespace DaemonHunter.Localization
{
    /// <summary>
    /// Thin async wrapper around UnityEngine.Localization so call sites
    /// don't have to touch AsyncOperationHandle directly.
    ///
    /// Conceptually this mirrors the .resx "same key, per-language value" model:
    /// LocalizationSettings.StringDatabase is the runtime lookup, and each
    /// StringTableCollection is the equivalent of one "resource file group".
    /// </summary>
    public static class LocalizationHelper
    {
        /// <summary>Fetch a localized string by table + key.</summary>
        public static async Task<string> Get(string table, string key)
        {
            var handle = LocalizationSettings.StringDatabase.GetLocalizedStringAsync(table, key);
            return await handle.Task;
        }

        /// <summary>
        /// Fetch a localized string with Smart String arguments.
        /// e.g. table value "我感受到了你的不安,{0}。" + args: npcName
        /// </summary>
        public static async Task<string> Get(string table, string key, params object[] args)
        {
            var handle = LocalizationSettings.StringDatabase.GetLocalizedStringAsync(table, key, args);
            return await handle.Task;
        }

        /// <summary>Switch the active locale by code, e.g. "zh-Hans" or "en".</summary>
        public static void SetLocale(string localeCode)
        {
            var locale = LocalizationSettings.AvailableLocales.Locales
                .FirstOrDefault(l => l.Identifier.Code == localeCode);

            if (locale == null)
            {
                UnityEngine.Debug.LogWarning($"[Localization] No locale found for code '{localeCode}'.");
                return;
            }

            LocalizationSettings.SelectedLocale = locale;
        }

        public static string CurrentLocaleCode => LocalizationSettings.SelectedLocale.Identifier.Code;

        /// <summary>Raised whenever the active language changes, e.g. to refresh non-bound UI.</summary>
        public static event Action LocaleChanged;

        // Call once at startup (e.g. from a bootstrap scene) to wire the event above.
        public static void Init()
        {
            LocalizationSettings.SelectedLocaleChanged -= OnSelectedLocaleChanged;
            LocalizationSettings.SelectedLocaleChanged += OnSelectedLocaleChanged;
        }

        private static void OnSelectedLocaleChanged(UnityEngine.Localization.Locale _)
            => LocaleChanged?.Invoke();
    }
}
