using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueText : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform placeToShow;
    private RectTransform rectTransform;
    public Text uiText;
    void Start()
    {
        this.rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 screenSpaceLoc = Camera.main.ScreenToWorldPoint(placeToShow.position);
        //.rotation = placeToShow.rotation;
    }

    public void setText(int infectionLevel, float infection)
    {
        string text = DialogeGenerator.getText(infectionLevel, infection);
        if(text != null)
            uiText.text = text;

    }
}
