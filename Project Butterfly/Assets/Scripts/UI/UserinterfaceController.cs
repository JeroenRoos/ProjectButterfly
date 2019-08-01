using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class UserinterfaceController : MonoBehaviour
{
    public Canvas pauseMenuCanvas;
    public Button modalBackground;
    public Button resumeButton;
    public Button hamburgerButton;
    public Canvas gameoverMenuCanvas;

    private void Start()
    {
        pauseMenuCanvas.gameObject.SetActive(false);
        gameoverMenuCanvas.gameObject.SetActive(false);

        InitializeUserInterface();
    }
    public static void DeathStart()
    {
        //Time.timeScale = 0;
        UserinterfaceController yo = new UserinterfaceController();
        yo.DeathSecond();

         
    }
    public  void DeathSecond()
    {
        Time.timeScale = 0;
        gameoverMenuCanvas.gameObject.SetActive(true);

         
    }

    private void InitializePauseMenu()
    {
        Time.timeScale = 0;
        pauseMenuCanvas.gameObject.SetActive(true);
    }

    private void InitializeUserInterface()
    {
        ServiceLocator.ButtonService.SetText(resumeButton, "Resume");
        resumeButton.onClick.AddListener(() => ResumeOnClick());

        ServiceLocator.ButtonService.SetText(hamburgerButton, string.Empty);
        hamburgerButton.onClick.AddListener(() => HamburgerOnClick());

        var backgroundColor = "#D3D3D399".ConvertToHexColor();
        modalBackground.image.color = backgroundColor;
        ServiceLocator.ButtonService.SetText(modalBackground, string.Empty);
        modalBackground.onClick.AddListener(() => BackgroundOnClick());
    }

    private void ResumeOnClick()
    {
        Time.timeScale = 1;
        pauseMenuCanvas.gameObject.SetActive(false);
    }

    private void HamburgerOnClick()
    {
        InitializePauseMenu();
    }

    private void BackgroundOnClick()
    {
        ResumeOnClick();
    }
}
