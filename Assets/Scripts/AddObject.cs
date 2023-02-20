using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectAdder : MonoBehaviour, IPointerDownHandler
{
    public GameObject spawnerToSpawn;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(UIManager.activeAdder == false)
        {
            UIManager.activeAdder = true;
            spawnerToSpawn.gameObject.SetActive(true);
        }
        else
        {
            UIManager.activeAdder = false;
            spawnerToSpawn.gameObject.SetActive(false);
        }   
    }
}
