using UnityEngine;

[CreateAssetMenu(fileName = "KeySetStorage", menuName = "KeySetStorage")]
public class keySetScriptableOBJ : ScriptableObject
{
    //EX: public Keyset WalkLeft, WalkRight, Jump;
    public Keyset replace;

    public KeyCode StringTakeKeyCode(string keySting)
    {

        KeyCode keyKeyCode = KeyCode.None;

        switch (keySting)
        {

            /*EX
            case "WalkLeft":
                keyKeyCode = WalkLeft.KeyCodeSet;
                break;
            case "WalkRight":
                keyKeyCode = WalkRight.KeyCodeSet;
                break;
            case "Jump":
                keyKeyCode = Jump.KeyCodeSet;
                break;
            */
            default:
                Debug.LogWarning("Any key was finded");
                break;
        }

        return keyKeyCode;

    }

    public Keyset StringTakeKeySet(string keySting)
    {

        Keyset keyKeyCode = null;

        switch (keySting)
        {

            /*EX
            case "WalkLeft":
                keyKeyCode = WalkLeft;
                break; 
            case "WalkRight":
                keyKeyCode = WalkRight;
                break; 
            case "Jump":
                keyKeyCode = Jump;
                break; 
            */
            default:
                Debug.LogWarning("Any key was finded");
                break;

        }

        return keyKeyCode;

    }

}
