using UnityEngine;

[CreateAssetMenu(fileName = "ElementType", menuName = "Scriptable Objects/ElementType")]
public class ElementSystem : ScriptableObject
{
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

    public ElementType elementType;
    public Sprite icon;
    public string displayName;
}
