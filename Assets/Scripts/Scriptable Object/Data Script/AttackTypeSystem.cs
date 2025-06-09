using UnityEngine;

[CreateAssetMenu(fileName = "AttackType", menuName = "Scriptable Objects/AttackType")]
public class AttackTypeSystem : ScriptableObject
{
    public enum AttackType
    {
        Slash,
        Blow,
        Pierce,
        Karma
    }

    public AttackType attackType;
    public Sprite icon;
    public string displayName;
    
}
