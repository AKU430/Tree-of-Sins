using UnityEngine;

[CreateAssetMenu(fileName = "Ability", menuName = "Scriptable Objects/AbilityData")]
public class AbilityData : ScriptableObject
{
    [Header("특성 정보")]
    [Space(10)]
    public string abilityName;
    [TextArea(3,2)]
    public string abilityDescription;
}
