using UnityEngine;
using TMPro;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class JsInteropBase : MonoBehaviour
{
//we only ever want this to be a thing in the wasm build
#if UNITY_WEBGL
    [SerializeField]
    private TMP_InputField urlAppend;



    //First, make a .jslib library of javascript functions in the Plugins/ folder in Unity Assets.

    //Then, import that library and define the functions as they are saved there.
    [DllImport("__Internal")]
    private static extern void Hello(string path);


    public void InputFieldSubmit()
    {
            Hello(urlAppend.text);
    }
#endif
}
