using TMPro;
using UnityEngine;
using UnityEngine.Localization.Components;

namespace DaemonHunter.Localization
{
    /// <summary>
    /// Attach next to a TMP_Text + LocalizeStringEvent component.
    /// Dialogue system calls SetLine(...) with a generated L10nKeys entry
    /// and any Smart String arguments (e.g. the NPC's display name).
    ///
    /// Usage:
    ///   line.SetLine(L10nKeys.Case01Cuojia.TableName,
    ///                L10nKeys.Case01Cuojia.DialogueDaoshiIntro,
    ///                npcName);
    /// </summary>
    [RequireComponent(typeof(TMP_Text))]
    public class LocalizedDialogueLine : MonoBehaviour
    {
        [SerializeField] private LocalizeStringEvent localizeEvent;
        [SerializeField] private TMP_Text label;

        private void Reset()
        {
            label = GetComponent<TMP_Text>();
            localizeEvent = GetComponent<LocalizeStringEvent>();
        }

        public void SetLine(string table, string key, params object[] args)
        {
            localizeEvent.StringReference.TableReference = table;
            localizeEvent.StringReference.TableEntryReference = key;
            localizeEvent.StringReference.Arguments = args;
            localizeEvent.RefreshString(); // triggers async fetch + label update
        }
    }
}
