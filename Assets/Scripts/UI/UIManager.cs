using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour, IManager
{

    #region Instance
    public static UIManager Instance;
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
    #endregion

    public PlantSelectPanle plantSelectPanle;

    public void Init()
    {
        plantSelectPanle = GetComponentInChildren<PlantSelectPanle>();
    }

    public void StartManager()
    {
        plantSelectPanle.gameObject.SetActive(false);
    }
}
