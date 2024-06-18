using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/TextData/TextDataSO")]
public class TextDataSO : ScriptableObject
{
    public int id;
    [TextArea]
    public List<string> text;
}