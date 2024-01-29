using UnityEngine;


[CreateAssetMenu(fileName = "Colors", menuName = "GameData/Colors")]
public class Colors : ScriptableObject
{
    [SerializeField] public Color[] Colours;

    public Color GetColor(int index)
    {
        return Colours[index - 1];
    }
}
