using UnityEngine;

internal class InputSystem : MonoBehaviour, IInputFuctions
{

    public keySetScriptableOBJ KeyCodeList;

    #region InputFunctions

    bool IInputFuctions.GetKeyDowns(string keyString)
    {

        return Input.GetKeyDown(KeyCodeList.StringTakeKeyCode(keyString));

    }

    bool IInputFuctions.GetKeys(string keyString)
    {

        return Input.GetKey(KeyCodeList.StringTakeKeyCode(keyString));

    }
    
    bool IInputFuctions.GetKeyUps(string keyString)
    {

        return Input.GetKeyUp(KeyCodeList.StringTakeKeyCode(keyString));

    }

    #endregion

}


