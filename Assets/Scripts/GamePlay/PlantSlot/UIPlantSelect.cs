using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIPlantSelect : MonoBehaviour
{
    public static UIPlantSelect Instance;
    private PlantSlot selectedSlot;
    public GameObject panel;

    private void Awake()
    {
        Instance = this;
    }

    public void Open(PlantSlot slot)
    {
        selectedSlot = slot;
        panel.SetActive(true);
    }

    public void Close()
    {
        panel.SetActive(false);
        selectedSlot = null;
    }

    public void SelectPlant(PlantData plant)
    {
        selectedSlot.Plant(plant);
        Debug.Log("Đã trồng cây");
        Close();
    }
}
