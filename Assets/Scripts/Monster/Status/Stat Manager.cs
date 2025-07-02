using UnityEngine;

public class StatManager : MonoBehaviour
{
    public MonsterData monsterData;
    public static StatManager Instance;
    private void Awake()
    {
        Instance = this;
    }
    
    //(2 * 종족값) * 레벨/100 + 10
    public int HpCaculate(Stat stat)
    {
        var inGameHp = (2 * monsterData.hp) * (stat.monsterLevel / 100) + 10;
        return inGameHp;
    }
}