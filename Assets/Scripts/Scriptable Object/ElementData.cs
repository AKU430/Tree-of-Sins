using UnityEngine;

[CreateAssetMenu(fileName = "ElementType", menuName = "Scriptable Objects/ElementType")]
public class ElementData : ScriptableObject
{
    [Header("속성 정보")]
    [Space(10)]
    public string displayName;
    public Sprite displayIcon;
    public AbilityData typeAbilityData;
    public ElementType elementType;
    
    public enum ElementType
    {
        Pride,
        Greed,
        Envy,
        Sloth,
        Lust,
        Wrath,
        Sorrow
    }
}
