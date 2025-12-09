using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    [Header("Manager")]
    public ShadowMoteManager shadowMoteManager;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
            return;
        }
    }
    private void InitManager()
    {
        UIManager.Instance.Init();
    }

    private void Start()
    {
        UIManager.Instance.StartManager();
    }
}
