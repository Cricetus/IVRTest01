using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Button : MonoBehaviour {
    [SerializeField] private Controller controller;

    public void OnMouseDown() {
        controller.SelectSort();
    }
}
