using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Button StartButton;
    public Button SettingsButton;
    public Button ExitButton;

    public GameObject MainMenuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        ServiceLocator.ButtonService.SetText(StartButton, "Start");
        StartButton.onClick.AddListener(() => StartOnClick());

        ServiceLocator.ButtonService.SetText(SettingsButton, "Settings");
        SettingsButton.onClick.AddListener(() => SettingsOnClick()); 

        ServiceLocator.ButtonService.SetText(ExitButton, "Exit game");
        ExitButton.onClick.AddListener(() => ExitOnClick());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartOnClick()
    {
        SceneManager.LoadSceneAsync("Level1");
    }

    public void SettingsOnClick()
    {
        Debug.Log("Start onclick");

        // Do something
    }

    public void ExitOnClick()
    {
        Application.Quit();
    }
}