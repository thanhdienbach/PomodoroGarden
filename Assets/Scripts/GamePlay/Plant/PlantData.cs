using UnityEngine;


[CreateAssetMenu(fileName = "NewPlant", menuName = "CloundGraden/Plant Data")]
public class PlantData : ScriptableObject
{
    [Header("Basic Info")]
    public string PlantName;
    public Sprite icon;
    public PlantType plantType;

    [Header("Prefabs")]
    public GameObject plantObject;

    [Header("Grow Setting")]
    public int fullGrowTime;
    public int cyclesPerLeaft;

    [TextArea]
    public string description;
}
