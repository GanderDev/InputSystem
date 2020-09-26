using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    static IInputFuctions internalKeys;

    private void Start()
    {

        internalKeys = GetComponent<IInputFuctions>();

    }

    #region InputCalls

    /// <summary> these functions simulate the standard inputsystem </summary>
    /// 
    /// EX:
    /// Standard:Input.GetKeyDown(KeyCode.W);
    /// New:InputManager.GetKeyDown("TesteWalkForwad");
    /// 
    /// <param name="keyString"></param> Name of Keyset(keySetScriptableOBJ)
    /// 
    /// <returns>Return if Key Was press</returns>

    public static bool GetKeyDown(string keyString)
    {

        return internalKeys.GetKeyDowns(keyString);
        
    }

    public static bool GetKey(string keyString)
    {

        return internalKeys.GetKeys(keyString);

    }

    public static bool GetKeyUp(string keyString)
    {

        return internalKeys.GetKeyUps(keyString);

    }

    #endregion

}

