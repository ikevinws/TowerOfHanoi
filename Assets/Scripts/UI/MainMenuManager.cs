using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject creditsGameObj;
    [SerializeField] private GameObject mainMenuGameObj;
    [SerializeField] private GameObject settingsGameObj;
    [SerializeField] private SceneController sceneController;
    [SerializeField] private SoundManager soundManager;
    private void Awake()
    {
        creditsGameObj.SetActive(false);
        settingsGameObj.SetActive(false);
        mainMenuGameObj.SetActive(true);
    }
    public void EnterCredits()
    {
        mainMenuGameObj.SetActive(false);
        creditsGameObj.SetActive(true);
    }
    public void ExitCredits()
    {
        mainMenuGameObj.SetActive(true);
        creditsGameObj.SetActive(false);
    }
    public void EnterSettings()
    {
        settingsGameObj.SetActive(true);
        mainMenuGameObj.SetActive(false);
    }
    public void ExitSettings()
    {
        settingsGameObj.SetActive(false);
        mainMenuGameObj.SetActive(true);
        soundManager.SaveSoundSetting();
    }
    public void PlayButtonClicked()
    {
        sceneController.LoadGameScene();
    }

}