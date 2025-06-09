using System.ComponentModel;
using UnityEngine;

[CreateAssetMenu(fileName = "Monster", menuName = "Scriptable Objects/Monster")]
public class MonsterData : ScriptableObject
{
    [Header("몬스터 정보")]
    [Space(10)]
    public Sprite icon;
    public string name;
    public  ElementSystem type; //몬스터 타입 : 오만, 탐욕, 질투, 분노, 색욕, 폭식, 나태
    public  AttackTypeSystem atkType; //몬스터 공격유형 : 참격, 타격, 관통, 죄업
    
    [Header("종족값")]
    [Space(10)]
    public int hp;
    public int karma;
    public int attack;
    public int defense;
    public int karmaAttack;
    public int karmaDefense;
    public int speed;
    
    public int totalStat => hp + karma + attack + defense + karmaAttack + karmaDefense + speed;
}
