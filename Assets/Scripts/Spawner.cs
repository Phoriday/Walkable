using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    public GameObject objectToSpawn;
    private GameObject spawnedGameObject;

    public void OnPointerDown(PointerEventData eventData)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnedGameObject = Instantiate(objectToSpawn, mousePos, Quaternion.identity);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition) - spawnedGameObject.transform.position;
        spawnedGameObject.transform.Translate(mousePos);
    }

}
