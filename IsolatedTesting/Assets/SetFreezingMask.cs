using System;
using TMPro;
using UnityEngine;

public class SetFreezingMask : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;
    [SerializeField] private Material _screenOverlayMaterial;
    [SerializeField] private string _useOverlayParameter = "_Use_Overlay";
    [SerializeField] private string _edgeMaskPowerParameter = "_Ice_Edge_Mask_Power";


    private void OnDisable()
    {
        _screenOverlayMaterial.SetFloat(_edgeMaskPowerParameter, 100);
        _screenOverlayMaterial.SetFloat(_useOverlayParameter, 0);
    }

    public void SetEdgeMaskValue()
    {
        int.TryParse(_inputField.text, out var value);
        _screenOverlayMaterial.SetFloat(_edgeMaskPowerParameter, value);
    }

    public void EnableOverlay()
    {
        _screenOverlayMaterial.SetFloat(_useOverlayParameter, 1);
    }
}