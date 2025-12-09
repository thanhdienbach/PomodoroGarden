using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSelectPanle : MonoBehaviour
{
    public PlantInfoPanel plantInfoPanle;
    public PlantSlot selectedSlot;
    public GameObject panel;

    public void Open(PlantSlot _selectedSlot)
    {
        panel.SetActive(true);
        selectedSlot = _selectedSlot;
    }

    public void Close()
    {
        selectedSlot = null;
        panel.SetActive(false);
    }

    public void Planting(PlantData plant)
    {
        selectedSlot.Planting(plant);
        Close();
    }
}
