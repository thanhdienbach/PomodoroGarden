using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject settingPanle;

    public void PlayGame()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenSetting()
    {
        if (settingPanle != null)
        {
            settingPanle.SetActive(true);
        }
    }

    public void CloseSetting()
    {
        if (settingPanle != null)
        {
            settingPanle.SetActive(false);
        }
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
