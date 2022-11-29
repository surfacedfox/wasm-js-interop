using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class JsInteropReceiver : MonoBehaviour
{
    [SerializeField]
    private TMP_Text textLabel;

    // Update is called once per frame
    public void UpdateGUIText(string inText)
    {
        if(inText == null)
        {
            textLabel.text = "no text was passed.";
        }
        else
        {
            textLabel.text = inText;
        }
    }
}
