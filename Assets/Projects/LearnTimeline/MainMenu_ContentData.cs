using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Main Menu Content Data", menuName = "Main Menu/New Content Data")]
public class MainMenu_ContentData : ScriptableObject
{
    [SerializeField] private List<GameObject> _pagesPrefab;
}
