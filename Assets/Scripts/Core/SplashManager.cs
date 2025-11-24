using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashManager : MonoBehaviour
{
    [SerializeField] private LogoFader logoFader;
    private void Start()
    {
        logoFader.PlaySequence();
    }
}
