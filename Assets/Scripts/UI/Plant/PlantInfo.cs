using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlantInfoPanel : MonoBehaviour
{

    [Header("UI Components")]
    public Image icon;
    public TMP_Text nameText;
    public TMP_Text descriptionText;
    public TMP_Text growthCycleText;
    public TMP_Text growStageText;
    public TMP_Text matureStageText;

    [SerializeField] PlantData currentData;
    [SerializeField] PlantSlot currentSlot;

    [SerializeField] Button platingButton;

    public void Show(PlantData data)
    {
        currentData = data;
        currentSlot = UIManager.Instance.plantSelectPanle.selectedSlot;

        icon.sprite = data.seedSprite;
        nameText.text = data.name;
        descriptionText.text = data.description;

        growthCycleText.text = $"Chu kỳ mỗi lá: {data.cyclesPerLeft}";
        growStageText.text = $"Lá để vào giai đoạn lớn: {data.plantStageRule[0].leavesRequest}";
        matureStageText.text = $"Lá để trưởng thành: {data.plantStageRule[1].leavesRequest}";

        gameObject.SetActive(true);
    }

    public void OnClick_Plant()
    {
        UIManager.Instance.plantSelectPanle.gameObject.SetActive(false);
        currentSlot.Planting(currentData);
        GameManager.Instance.shadowMoteManager.StartManager();

    }
}
