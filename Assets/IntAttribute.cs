using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "NewIntAttribute", menuName = "CustomSO/Attribute/IntAttribute")]
public class IntAttribute : ScriptableObject
{
    [SerializeField]
    private int value;
    public int Value
    {
        get
        {
            return value;
        }
        set
        {
            this.value = value;
            NotifyValueChanged();
        }
    }

    [Header("Value that will set on calling reset method")]
    public int InitialValue;

    public void ResetToInitialValue()
    {
        Value = InitialValue;
    }

    public UnityAction OnValueChanged;
    private void NotifyValueChanged()
    {
        OnValueChanged?.Invoke();
    }

}
