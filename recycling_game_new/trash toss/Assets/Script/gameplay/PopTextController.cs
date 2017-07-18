using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopTextController : MonoBehaviour {
    private static PopText popText;

    private static Canvas canvas;

    public static void Initialize()
    {
        if(canvas == null)
        canvas = FindObjectOfType<Canvas>();
        if(popText == null)
        popText = Resources.Load<PopText>("Prefab/PopUpTextParent");
    }

	public static void createFloatingText(string text,Transform location)
    {
        Initialize();

        PopText instance = Instantiate(popText);
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(new Vector2(location.position.x + Random.Range(-.5f, .5f), location.position.y + Random.Range(-.5f, .5f)));
        instance.transform.SetParent(canvas.transform, false);
        instance.transform.position = screenPosition;
        instance.setText(text);
    }
}
