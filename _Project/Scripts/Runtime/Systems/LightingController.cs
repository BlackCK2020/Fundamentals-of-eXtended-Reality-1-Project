
using UnityEngine;

public class LightingController : MonoBehaviour
{
    [SerializeField] private Light[] lights;
    [SerializeField] private float pulseSpeed = 1f;
    [SerializeField] private bool pulse = false;

    public void Toggle(bool on)
    {
        if (lights == null) return;
        foreach (var l in lights)
        {
            if (l) l.enabled = on;
        }
    }

    private void Update()
    {
        if (!pulse || lights == null) return;
        float v = (Mathf.Sin(Time.time * pulseSpeed) + 1f) * 0.5f;
        foreach (var l in lights)
        {
            if (!l) continue;
            if (l.type == LightType.Point || l.type == LightType.Spot)
                l.intensity = Mathf.Lerp(0.5f, 1.5f, v);
        }
    }
}
