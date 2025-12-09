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
            UIManager.Instance.plantSelectPanle.gameObject.SetActive(true);
            UIManager.Instance.plantSelectPanle.selectedSlot = this;
        }
    }

    public void Planting(PlantData data)
    {
        currentPlant = data;
        isEmpty = false;

        if (data.plantObject != null)
        {
            Instantiate(data.plantObject, plantSpawnPoint.position, Quaternion.identity, transform);
        }
    }
}
