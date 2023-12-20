using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

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
            textGO = A.transform.GetChild(0).gameObject;
            TMP_Text KeyIdUi = textGO.GetComponent<TMP_Text>();
            KeyIdUi.text = (key.keyID + 1).ToString();
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
                //Destroy(Objnul);
                Objnul.SetActive(false);
            }
            //offsetUi += 69.0f;
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
