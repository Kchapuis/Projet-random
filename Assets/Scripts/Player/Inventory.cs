using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private List<Key> keys = new List<Key>();

    public void AddKey(Key key)
    {
        keys.Add(key);
    }

    public bool HasKey(Key key)
    {
        return keys.Contains(key);
    }

    public void RemoveKey(Key key)
    {
        keys.Remove(key);
    }
}
