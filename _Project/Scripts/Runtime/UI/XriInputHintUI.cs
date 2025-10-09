
using UnityEngine;

public class XriInputHintUI : MonoBehaviour
{
    [TextArea] public string hintText = "Press Trigger to interact";
    public Canvas worldSpaceCanvas;
    public TMPro.TextMeshProUGUI tmp;

    private void Reset()
    {
        worldSpaceCanvas = GetComponentInChildren<Canvas>();
        if (worldSpaceCanvas) tmp = worldSpaceCanvas.GetComponentInChildren<TMPro.TextMeshProUGUI>();
    }

    public void SetHint(string text)
    {
        hintText = text;
        if (tmp) tmp.text = hintText;
    }

    private void OnValidate()
    {
        if (tmp) tmp.text = hintText;
    }
}
