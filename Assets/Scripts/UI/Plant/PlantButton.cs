using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantButton : MonoBehaviour
{
  
    public PlantData data;

    public void OnClick()
    {
        UIPlantSelect.Instance.SelectPlant(data);
    }

}
