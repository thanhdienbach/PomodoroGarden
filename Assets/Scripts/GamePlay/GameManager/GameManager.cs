using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager instance;

    [Header("Manager")]
    public ShadowMoteManager shadowMoteManager;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
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
        if (shadowMoteManager != null)
        {
            shadowMoteManager.Init();
        }
    }

    private void Start()
    {
        if (shadowMoteManager != null)
        {
            shadowMoteManager.StartManager();
        }
    }
}
