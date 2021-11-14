using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChocoColorDecider : MonoBehaviour
{
    private Dropdown dropdown;

     // Start is called before the first frame update
    void Start()
    {
        dropdown = GetComponent<Dropdown>();
        dropdown.onValueChanged.AddListener(delegate {
            decideColor(dropdown);
        });
    }

    public void decideColor(Dropdown change)
    {
        switch(change.value)
        {
            case 0:
                setBrown();
                break;
            case 1:
                setWhite();
                break;
            case 2:
                setRed();
                break;
            case 3:
                setGreen();
                break;
            case 4:
                setBlue();
                break;
            case 5:
                setYellow();
                break;
        }
    }
    public void setBrown()
    {
        StatsKeeper.chocoColor = new Color(154.0f/255.0f, 86.0f/255.0f, 0.0f/255.0f, 244.0f/255.0f);
    }

    public void setWhite()
    {
        StatsKeeper.chocoColor = new Color(255.0f/255.0f, 255.0f/255.0f, 255.0f/255.0f, 244.0f/255.0f);
    }

    public void setRed()
    {
        StatsKeeper.chocoColor = new Color(255.0f/255.0f, 0.0f/255.0f, 0.0f/255.0f, 244.0f/255.0f);
    }

    public void setGreen()
    {
        StatsKeeper.chocoColor = new Color(0.0f/255.0f, 255.0f/255.0f, 0.0f/255.0f, 244.0f/255.0f);
    }

    public void setBlue()
    {
        StatsKeeper.chocoColor = new Color(0.0f/255.0f, 0.0f/255.0f, 255.0f/255.0f, 244.0f/255.0f);
    }

    public void setYellow()
    {
        StatsKeeper.chocoColor = new Color(255.0f/255.0f, 255.0f/255.0f, 0.0f/255.0f, 244.0f/255.0f);
    }
}
