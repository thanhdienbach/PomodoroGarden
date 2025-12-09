using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantController : MonoBehaviour
{
    public PlantData plantData;

    private int currentEclipseCycles = 0;
    private int currentLeaves = 0;
    private PlanStage currentStage;

    private SpriteRenderer currentRenderer;

    private void Start()
    {
        currentRenderer = transform.Find("Visual").GetComponent<SpriteRenderer>();
        SetStage(PlanStage.Seed);
    }

    public void AddEclipseCycle()
    {
        currentEclipseCycles++;

        if (currentEclipseCycles >= plantData.cyclesPerLeft)
        {
            currentEclipseCycles = 0;
            currentLeaves++;
            CheckStage();
        }
    }
    private void CheckStage()
    {
        PlanStage newStage = currentStage;
        foreach(var rule in plantData.plantStageRule)
        {
            if (currentLeaves >= rule.leavesRequest)
            {
                newStage = rule.planStage;
            }
        }

        if (newStage != currentStage)
        {
            SetStage(newStage);
        }
    }

    private void SetStage(PlanStage plantStage)
    {
        currentStage = plantStage;

        switch (plantStage)
        {
            case PlanStage.Seed:
                currentRenderer.sprite = plantData.seedSprite;
                break;
            case PlanStage.Grow:
                currentRenderer.sprite = plantData.growingSprite;
                break;
            case PlanStage.Mature:
                currentRenderer.sprite = plantData.matureSprite;
                break;
        }
    }
}
