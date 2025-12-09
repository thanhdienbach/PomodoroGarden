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
    public int cyclesPerLeft; // How much cycles to one leaft full grow
    public PlanStageRule[] plantStageRule;

    [Header("Stage Sprites")]
    public Sprite seedSprite;
    public Sprite growingSprite;
    public Sprite matureSprite;

    [TextArea]
    public string description;
}
