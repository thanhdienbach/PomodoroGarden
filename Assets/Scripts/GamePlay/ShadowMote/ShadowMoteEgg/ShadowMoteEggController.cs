using UnityEngine;

public class ShadowMoteEggController : MonoBehaviour
{
    [Header("Shadow mote egg component")]
    [SerializeField] ShadowMoteEggMovement movement;
    [SerializeField] ShadowMoteEggBreath breath;
    [SerializeField] ShadowMoteGrowth growth;
    [SerializeField] ShadowMoteEggHatch hatch;

    [Header("Hatch variable")]
    [SerializeField] float hatchScaleThreshold = 0.3f;

    private void Awake()
    {
        movement = GetComponent<ShadowMoteEggMovement>();
        breath = GetComponent<ShadowMoteEggBreath>();
        growth = GetComponent<ShadowMoteGrowth>();
        hatch = GetComponent<ShadowMoteEggHatch>();
    }

    private void Start()
    {
        BeginMovementPhase();
    }

    private void BeginMovementPhase()
    {
        movement.StartMovement(OnMoveMentFinished);
        breath.StartBreathing();
        growth.StopGrowth();
    }
    private void OnMoveMentFinished()
    {
        breath.StopBreathing();
        growth.StartGrowth(OnGrowthFinished);
    }

    private void OnGrowthFinished(float finalScale)
    {
        if (finalScale >= hatchScaleThreshold)
        {
            hatch.Hatch();
        }
        else
        {
            BeginMovementPhase();
        }
    }
}
