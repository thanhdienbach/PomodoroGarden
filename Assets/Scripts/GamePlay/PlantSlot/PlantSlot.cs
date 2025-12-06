using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlantSlot : MonoBehaviour
{
    

    public bool isEmpty = true;
    public Plants currentPlant;

    public void OnSlotClicked()
    {
        if (isEmpty)
        {
            Debug.Log("Mở danh sách cây trồng");
            UIPlantSelect.Instance.Open(this);
        }
        else
        {
            Debug.Log("Slot đã có cây");
        }
    }
}
