using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowScriptable : MonoBehaviour
{
    public IntAttribute IntegerUpdatable;
    public bool NotifyPropertyChange = true;
    public string Label = "Value";

    private Text m_Text;

    // Start is called before the first frame update
    void Start()
    {
        m_Text = GetComponent<Text>();
        if (IntegerUpdatable != null && NotifyPropertyChange)
        {
            IntegerUpdatable.OnValueChanged = UpdateText;
        }
        m_Text.text = Label + " " + IntegerUpdatable.Value.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateText()
    {
        m_Text.text = Label + " " + IntegerUpdatable.Value.ToString();
    }
}
