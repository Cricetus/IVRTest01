﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
    [SerializeField] private GameObject[] container;
    [SerializeField] private TextMesh[] text;
	// Use this for initialization
	void Start () {
        for (int i = 0; i < container.Length; i++) { 
            Debug.Log(container[i].name);
            
            text[i].text = container[i].name;
        }      
    }
	
	// Update is called once per frame
	void Update () {
        
    }
   public void SelectSort() {
        Debug.Log("\n");
        
        for (int i = 0; i < container.Length-1; i++) {
            int min = i;
            for (int j = i + 1; j < container.Length; j++) {
                if (System.Convert.ToInt32(container[j].name) < System.Convert.ToInt32(container[i].name))
                {
                    Debug.Log(string.Format("{0} compare with {1}", container[j].name, container[min].name));
                    Swap(container[j], container[i]);
                    SwapT(text[j], text[i]);
                }
                
            }
          
        }
        foreach (GameObject item in container) {
            Debug.Log(item.name);
        }
    }
    void SwapT(TextMesh c,TextMesh x) {
        string nm;
       
        string text;

        nm = c.name;
        c.name = x.name;
        x.name = nm;

        text = c.text;
        c.text = x.text;
        x.text = text;
    }
    void Swap(GameObject a, GameObject b) {
        string name;
       Vector3 position;
        Material material;

        name = a.name;
        a.name = b.name;
        b.name = name;

        //position = a.transform.position;
        //a.transform.position = b.transform.position;
       // b.transform.position = position;

        material = a.GetComponent<MeshRenderer>().material;
        Debug.Log(material);
        Debug.Log(a.GetComponent<MeshRenderer>().material);
        a.GetComponent<MeshRenderer>().material = b.GetComponent<MeshRenderer>().material;
        Debug.Log(a.GetComponent<MeshRenderer>().material);
        b.GetComponent<MeshRenderer>().material = material;
        Debug.Log(b.GetComponent<MeshRenderer>().material);

        position = a.transform.position;
        a.transform.position = b.transform.position;
        b.transform.position = position;
    }
    void Copy(GameObject a, GameObject b) {
        a.name = b.name;
        a.transform.position = b.transform.position;
        a.GetComponent<MeshRenderer>().material = b.GetComponent<MeshRenderer>().material;
    }
}
