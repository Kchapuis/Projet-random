using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class ChestRandomizer : MonoBehaviour
{
    [SerializeField] private Seed seedRandom;

    [SerializeField] private GameObject _chests;

    [SerializeField] private List<Key> keys = new List<Key>();
    
    [SerializeField] private TMP_InputField seed;
    [SerializeField] private GameObject resetRun;
    
    private List<Chest> _chestsList = new List<Chest>();

    public void SetSeed()
    {
        seedRandom.seed = seed.text;
        Random.InitState(seedRandom.seed.GetHashCode());
    }

    private void Awake()
    { 
        if (seedRandom.seed == string.Empty)
        {
            seedRandom.seed = System.DateTime.Now.ToString();
        }
        Random.InitState(seedRandom.GetHashCode());
        _chestsList = _chests.GetComponentsInChildren<Chest>().ToList();
        RandomizeChest();
    }

    private void RandomizeChest()
    {
        List<int> rooms = new List<int>();
        Dictionary<string, List<Chest>> Rooms = new Dictionary<string, List<Chest>>();
        for (int i = 0; i < _chestsList.Count; i++)
        {
            string roomName = "Room_" + _chestsList[i].Room;
            if (!rooms.Contains(_chestsList[i].Room))
            {
                rooms.Add(_chestsList[i].Room);
                Rooms.Add(roomName, new List<Chest>());
                Rooms[roomName].Add(_chestsList[i]);
            }
            else
            {
                Rooms[roomName].Add(_chestsList[i]);
            }
        }
        for (int i = 0; i < 6; i++)
        {
            string roomName = "Room_" + i;
            int randomIndex = Random.Range(0, Rooms[roomName].Count);
            switch (i)
            {
                case 0:
                    Rooms[roomName].ElementAt(randomIndex).KeyDropped = keys[0];
                    break;
                case 1:
                    Rooms[roomName].ElementAt(randomIndex).KeyDropped = keys[1];
                    break;
                case 2:
                    Rooms[roomName].ElementAt(randomIndex).KeyDropped = keys[2];
                    break;
                case 3:
                    Rooms[roomName].ElementAt(randomIndex).KeyDropped = keys[2];
                    break;
                case 4:
                    Rooms[roomName].ElementAt(randomIndex).KeyDropped = keys[3];
                    break;
                case 5:
                    Rooms[roomName].ElementAt(randomIndex).KeyDropped = keys[3];
                    break;
                default:
                    break;
            }
        }
    }
}
