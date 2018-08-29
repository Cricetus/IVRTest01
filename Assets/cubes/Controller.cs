using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    [SerializeField] private GameObject[] container;
    private int count;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < container.Length; i++)
        {
            Debug.Log(container[i].name);
        }
    }
    public void SelectSort()
    {
        int min = 0 ;
        int n = container.Length;
        for (int i = 0; i < n - 1; ++i) {
            min = i;
            for (int j = i + 1; j < n; ++j)
            {
                if (System.Convert.ToInt32(container[j].name) < System.Convert.ToInt32(container[min].name)) { min = j;  }
                 
            }
            if (min != i) { Swap(container[i], container[min]); }
        }
    }
 

    void Swap(GameObject a, GameObject b) {
        string name;

        Material material;
        material = a.GetComponent<MeshRenderer>().material;
        Debug.Log(material);
        Debug.Log(a.GetComponent<MeshRenderer>().material);
        a.GetComponent<MeshRenderer>().material = b.GetComponent<MeshRenderer>().material;
        Debug.Log(a.GetComponent<MeshRenderer>().material);
        b.GetComponent<MeshRenderer>().material = material;
        Debug.Log(b.GetComponent<MeshRenderer>().material);
        
        Debug.Log("Names:" + " " + a.name + " " + b.name);
        name = a.name;
        Debug.Log("Names:" + " " + a.name + " " + b.name);
        a.name = b.name;
        Debug.Log("Names:" + " " + a.name + " " + b.name);
        b.name = name;
        Debug.Log("Names:" + " " + a.name + " " + b.name);

        GameObject g = a;
        a = b;
        b = g;
       

        Component AText = a.GetComponentInChildren<TextMesh>();
        Component BText = b.GetComponentInChildren(typeof(TextMesh));
        TextMesh A = AText as TextMesh;
        TextMesh B = BText as TextMesh;

        Debug.Log("Text:" + " " + A.text + " " + B.text);
        string text = A.text;
        Debug.Log("Text:" + " " + A.text + " " + B.text);
        A.text = B.text;
        Debug.Log("Text:" + " " + A.text + " " + B.text);
        B.text = text;

        Debug.Log("Text name:" + " " + A.text + " " + B.text);
        string tname = A.name;
        Debug.Log("Text name:" + " " + A.text + " " + B.text);
        A.name = B.name;
        Debug.Log("Text name:" + " " + A.text + " " + B.text);
        B.name = tname;

    }



}
