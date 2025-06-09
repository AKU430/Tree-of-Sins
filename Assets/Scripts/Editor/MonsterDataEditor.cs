using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(MonsterData))]
public class NewMonoBehaviourScript : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        MonsterData stat = (MonsterData)target;
        
        int max = Mathf.Max(stat.hp, stat.attack, stat.defense, stat.speed, stat.karma, stat.karmaAttack, stat.karmaDefense);

        DrawStatBar("HP", stat.hp, max, Color.green);
        DrawStatBar("카르마", stat.karma, max, Color.cyan);
        DrawStatBar("공격", stat.attack, max, new Color(1f, 0.5f, 0f));
        DrawStatBar("방어", stat.defense, max, Color.blue);
        DrawStatBar("카르마 공격", stat.karmaAttack, max, Color.magenta);
        DrawStatBar("카르마 방어", stat.karmaDefense, max, Color.gray);
        DrawStatBar("스피드", stat.speed, max, Color.yellow);

        EditorGUILayout.Space();
        EditorGUILayout.LabelField("스탯 총합", stat.totalStat.ToString());
    }

    void DrawStatBar(string label, int value, int max, Color color)
    {
        EditorGUILayout.LabelField(label + ": " + value);
        Rect rect = GUILayoutUtility.GetRect(100, 16);
        float width = Mathf.Clamp01(value / (float)max) * rect.width;
        EditorGUI.DrawRect(new Rect(rect.x, rect.y, width, rect.height), color);
        EditorGUI.DrawRect(new Rect(rect.x + width, rect.y, rect.width - width, rect.height), new Color(0, 0, 0, 0.2f));
    }
}