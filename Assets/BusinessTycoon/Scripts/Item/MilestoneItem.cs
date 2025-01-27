using UnityEngine;
using UnityEngine.UI;

public class MilestoneItem : MonoBehaviour
{
    [HideInInspector]
    public Milestone milestone;
    public Image icon;
    public Text NameText;
    public Text DescriptionText;
    public Text Count;

    // Use this for initialization
    void Start()
    {

    }

    public void Initialize(Milestone milestoneData, LevelData level, bool subUnlock, Sprite sprite = null)
    {
        transform.localPosition = Vector3.zero;
        name = "Milestone_" + milestoneData.Id.ToString();
        if (sprite != null)
        {
            icon.sprite = sprite;
        }
        icon.preserveAspect = true;
        milestone = milestoneData;
        if (subUnlock == false)
        {
            NameText.text = level.GetBusinessNameById(milestoneData.BusinessId);
        }
        else
        {
            NameText.text = milestoneData.Count.ToString();
        }
        DescriptionText.text = EffectTypeDescription.GetDescription(milestoneData.EffectType, milestoneData.Effect, level.GetBusinessNameById(milestoneData.TargetId), level.GetBusinessNameByIdInPlural(milestoneData.TargetId));
    }
}