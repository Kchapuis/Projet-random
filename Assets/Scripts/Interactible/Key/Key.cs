using UnityEngine;

[CreateAssetMenu(fileName = "Key", menuName = "ScriptableObjects/Key", order = 1)]
public class Key : ScriptableObject
{
    public string keyName;
    public Sprite keySprite;
    public int keyID;
}