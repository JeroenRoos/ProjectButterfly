using UnityEngine.UI;

public class ButtonService 
{
    public void SetText(Button button, string text)
    {
        button.GetComponentInChildren<Text>().text = text;
    }
}