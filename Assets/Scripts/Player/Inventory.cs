using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class Inventory : MonoBehaviour
{
    public List<Key> keys = new List<Key>();
    private Dictionary<Key, GameObject> UIDico = new Dictionary<Key, GameObject>();
    [SerializeField] private GameObject UIprefab;
    [SerializeField] private GameObject Canvas;
    private GameObject textGO;
    float offsetUi =0f;

    public void AddKey(Key key)
    {
        keys.Add(key);
        AddUiWidget(key);
    }
    private void AddUiWidget(Key key)
    {
        if (UIprefab != null)
        {
            GameObject A = Instantiate(UIprefab, new Vector3(46 + offsetUi, 43, 0), Quaternion.identity);
            A.transform.SetParent(Canvas.transform, false);

            switch(key.keyID)
            {
                case 0:
                    A.GetComponent<UnityEngine.UI.Image>().color = new Color32(255, 255, 255, 255);
                    break;
                case 1:
                    A.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 255, 0, 255);
                    break;
                case 2:
                    A.GetComponent<UnityEngine.UI.Image>().color = new Color32(255, 255, 0, 255);
                    break;
                case 3:
                    A.GetComponent<UnityEngine.UI.Image>().color = new Color32(0, 0, 255, 255);
                    break;
                case 4:
                    A.GetComponent<UnityEngine.UI.Image>().color = new Color32(255,0,0, 255);
                    break;
                case 5:
                    A.GetComponent<UnityEngine.UI.Image>().color = new Color32(255, 0, 255, 255);
                    break;
                default:
                    print("Va crever golum");
                    break;

            }
            UIDico.Add(key,A);

            offsetUi += 69.0f;
        }
    }
    private void RemoveUiWidget(Key key)
    {
        if (UIprefab != null)
        {
            if(UIDico.Count != 0)
            {
                GameObject Objnul = UIDico[key];
                UIDico.Remove(key);
                Destroy(Objnul);
            }
        }
    }
    public bool HasKey(Key key)
    {
        return keys.Contains(key);
    }

    public void RemoveKey(Key key)
    { 
        RemoveUiWidget(key);
        keys.Remove(key);
       
    }
}
