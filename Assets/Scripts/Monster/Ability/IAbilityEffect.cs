using UnityEngine;

public interface IAbilityEffect
{
    void Apply(Unit unit);
    void OnTurnStart(Unit unit);
    void OnTurnEnd(Unit unit);
}

public class Unit : MonoBehaviour
{
    
}