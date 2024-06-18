using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/TextData/TextDataListSO")]
public class TextDataListSO : ScriptableObject
{
    public List<TextDataSO> list;
}