using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetSpawnerScript : MonoBehaviour
{
    public GameManager gameManager;
    public GameObject target;
    GameObject targetParent;
    Canvas canvas;

    private void Start() {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        targetParent = GameObject.Find("TargetParent");
        InvokeRepeating("SpawnTarget", 1f, 0.05f);
        RectTransform objectRectTransform = canvas.GetComponent<RectTransform>();
        Debug.Log("w: " + objectRectTransform.rect.width + " h: " + objectRectTransform.rect.height);
    }

    void SpawnTarget() {
        float xVal = Random.Range(0f, 1081f);
        float yVal = Random.Range(0f, 1921f);

        Instantiate(target, new Vector2(xVal / 200, yVal / 200), transform.rotation, targetParent.transform);
    }
}
