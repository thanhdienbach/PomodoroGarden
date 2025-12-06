using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlantSelect : MonoBehaviour
{
    public static UIPlantSelect Instance;
    private PlantSlot currentSlot;
    public GameObject panel;

    private void Awake()
    {
        Instance = this;
    }

    public void Open(PlantSlot slot)
    {
        currentSlot = slot;
        panel.SetActive(true);
    }

    public void Close()
    {
        panel.SetActive(false);
    }

    public void SelectPlant()
    {
        currentSlot.isEmpty = true;
        //currentSlot.currentPlant = plant;
        // Todo; Spawn cây trồng lên slot
        Debug.Log("Đã trồng cây");
        Close();
    }
}
