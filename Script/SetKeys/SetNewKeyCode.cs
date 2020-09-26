using UnityEngine;

public class SetNewKeyCode : MonoBehaviour
{

    Keyset KeySet;

    bool _input;

    IUINewValue _IUINewValue;

    private void Start()
    {

        _input = false;

        _IUINewValue = GetComponent<IUINewValue>();
         
    }

    public void SetNewKeycode(GameObject NewKeyset)
    {

        KeySet = NewKeyset.GetComponent<UISlot>()._Keyset;

        _input = true;

    }

    void OnGUI()
    {

        if (!_input) return;

        Event e = Event.current;

        if (e.isKey || e.shift)
        {

            if (e.shift)
            {

                KeySet.KeyCodeSet = KeyCode.LeftShift;

            }
            else
            {

                KeySet.KeyCodeSet = e.keyCode;

            }

            _input = false;

            _IUINewValue.IUAtualizer();

        }

    }

}
