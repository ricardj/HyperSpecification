using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Pipeline;
using UnityEngine;


public class SpecificationAmount
{
    public ScriptableObject specification;
    public float amount;

    public bool TryGetSpecification<T>(out T targetSpecification) where T : ScriptableObject
    {
        if (specification is T)
        {
            targetSpecification = (T)specification;
            return true;
        }
        else
        {
            targetSpecification = null;
        }

        return targetSpecification != null;
    }

    public T TryGetSpecification<T>() where T : ScriptableObject
    {
        if (specification is T)
        {
            return (T)specification;
        }

        return default;
    }

    public ScriptableObject GetSpecification()
    {
        return specification;
    }

    public float GetAmount()
    {
        return amount;
    }
    public string GetFormattedAmount(string format)
    {
        return amount.ToString(format);
    }
}
