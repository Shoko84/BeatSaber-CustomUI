using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BeatSaberCustomUI.UIElements
{
    public class ToggleVisualActivator : MonoBehaviour
    {
        private Button _ButtonInstance;

        public bool IsOn = false;

        private void Update()
        {
            if (IsOn && _ButtonInstance != null)
            {
                _ButtonInstance.transform.Find("Wrapper/BG").gameObject.SetActive(true);
                _ButtonInstance.transform.Find("Wrapper/Content/Text").GetComponent<TextMeshProUGUI>().color = new Color(0, 0, 0);
            }
        }

        //private IEnumerator _EnableBGForToggleButton()
        //{
        //    yield return new WaitForEndOfFrame();
        //    _ButtonInstance.transform.Find("Wrapper/BG").gameObject.SetActive(true);
        //    _ButtonInstance.transform.Find("Wrapper/Content/Text").GetComponent<TextMeshProUGUI>().color = new Color(0, 0, 0);
        //}

        //private void Ntb_selectionStateDidChangeEvent(HMUI.NoTransitionsButton.SelectionState selectionState)
        //{
        //    if (selectionState == HMUI.NoTransitionsButton.SelectionState.Normal)
        //        StartCoroutine(_EnableBGForToggleButton());
        //}

        //public void EnableToggle(HMUI.NoTransitionsButton ntb)
        //{
        //    ntb.selectionStateDidChangeEvent += Ntb_selectionStateDidChangeEvent;
        //    _ButtonInstance = ntb.GetComponent<Button>();
        //}

        //public void DisableToggle(HMUI.NoTransitionsButton ntb)
        //{
        //    ntb.selectionStateDidChangeEvent -= Ntb_selectionStateDidChangeEvent;
        //    _ButtonInstance = ntb.GetComponent<Button>();
        //}

        public void SetToggleState(bool state, Button btn)
        {
            IsOn = state;
            _ButtonInstance = btn;
        }
    }
}
