using UnityEngine;
using UnityEngine.UI;

public class ButtonService : ScriptableObject
{
    public void SetText(Button button, string text)
    {
        button.GetComponentInChildren<Text>().text = text;
    }
}