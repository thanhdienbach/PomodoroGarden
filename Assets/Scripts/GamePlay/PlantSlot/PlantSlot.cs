using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class PlantSlot : MonoBehaviour
{
    

    public bool isEmpty = true;
    public PlantData currentPlant;
    public Transform plantSpawnPoint;


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

    public void Plant(PlantData data)
    {
        currentPlant = data;
        isEmpty = false;

        if (data.plantObject != null)
        {
            Instantiate(data.plantObject, plantSpawnPoint.position, Quaternion.identity, transform);
        }
    }
}
