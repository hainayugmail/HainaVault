using System.Linq;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.UI;

namespace DaemonHunter.Localization
{
    /// <summary>
    /// Wire this to a settings-menu button. Flipping the locale here is enough -
    /// every TMP_Text with a LocalizeStringEvent refreshes itself automatically
    /// via LocalizationSettings.SelectedLocaleChanged, no manual UI refresh needed.
    /// </summary>
    public class LanguageToggle : MonoBehaviour
    {
        [SerializeField] private Button toggleButton;

        private void Awake() => toggleButton.onClick.AddListener(ToggleLanguage);

        private void ToggleLanguage()
        {
            var current = LocalizationSettings.SelectedLocale.Identifier.Code;
            var next = current.StartsWith("zh") ? "en" : "zh-Hans";
            LocalizationHelper.SetLocale(next);
        }
    }
}
