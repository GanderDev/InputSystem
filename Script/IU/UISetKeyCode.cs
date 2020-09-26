using UnityEngine;
using UnityEngine.UI;

internal class UISetKeyCode : MonoBehaviour, IUINewValue
{

    public GameObject[] IUKeyCodeChanger;

    private void Start()
    {

        GetComponent<IUINewValue>().IUAtualizer();

    }

    void IUINewValue.IUAtualizer()
    {

        for (int i = 0; IUKeyCodeChanger.Length >= i + 1; i++)
        {

            SetKeytext(IUKeyCodeChanger[i].GetComponent<UISlot>().KeyCodeText, IUKeyCodeChanger[i].GetComponent<UISlot>()._Keyset);

        }

    }

    public void SetKeytext(Text TextToAtualize, Keyset _Keyset)
    {

        TextToAtualize.text = "" + _Keyset.KeyCodeSet;

    }

}
