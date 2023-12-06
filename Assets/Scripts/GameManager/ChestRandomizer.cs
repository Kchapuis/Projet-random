using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChestRandomizer : MonoBehaviour
{
    [SerializeField] private TMP_Text outputText;
    [SerializeField] private string seedRandom;

    [SerializeField] private List<Chest> firstSetOfChests = new List<Chest>();
    [SerializeField] private List<Chest> secondSetOfChests = new List<Chest>();
    [SerializeField] private List<Chest> thirdSetOfChests = new List<Chest>();
    
    [SerializeField] private List<Key> keys = new List<Key>();

    private void Awake()
    {
        Random.InitState(seedRandom.GetHashCode());
        RandomizeChest();
    }

    private void RandomizeChest()
    {
        int firstChest = Random.Range(0, firstSetOfChests.Count);
        int secondChest = Random.Range(0, secondSetOfChests.Count);
        int thirdChest = Random.Range(0, thirdSetOfChests.Count);

        firstSetOfChests[firstChest].DroppedKeyNumber = 0;
        secondSetOfChests[secondChest].DroppedKeyNumber = 1;
        thirdSetOfChests[thirdChest].DroppedKeyNumber = 2;

        outputText.text = $"First Chest: {firstSetOfChests[firstChest].name}\nSecond Chest: {secondSetOfChests[secondChest].name}\nThird Chest: {thirdSetOfChests[thirdChest].name}";
    }
}
