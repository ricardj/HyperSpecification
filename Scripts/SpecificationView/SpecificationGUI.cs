using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpecificationGUI : MonoBehaviour
{
    [SerializeField] Image _targetSpecification;
    [SerializeField] TextMeshProUGUI _targetAmount;

    public void Setup(SpecificationAmount specification)
    {
        SetupSpecificationAmount(specification);
        SetupSpecificationRepresentation(specification);
    }

    private void SetupSpecificationRepresentation(SpecificationAmount specification)
    {
        ScriptableObject specificationObject = specification.GetSpecification();
        if (specificationObject is IVisibleSpecification)
        {
            IVisibleSpecification visibleSpecification = (IVisibleSpecification)specification;
            _targetSpecification.sprite = visibleSpecification.GetSprite();
        }

    }

    private void SetupSpecificationAmount(SpecificationAmount specification)
    {
        _targetAmount.text = specification.GetFormattedAmount("0.");
    }
}
