
using UnityEngine;

public class ResetManager : MonoBehaviour
{
    private IResettable[] _resettables;

    private void Awake()
    {
        _resettables = FindObjectsOfType<MonoBehaviour>(true) as MonoBehaviour[];
        // Filter to IResettable
        System.Collections.Generic.List<IResettable> list = new System.Collections.Generic.List<IResettable>();
        foreach (var mb in _resettables)
        {
            if (mb is IResettable r) list.Add(r);
        }
        _resettables = null;
        _resetTargets = list.ToArray();
    }

    private IResettable[] _resetTargets;

    [ContextMenu("Reset All")]
    public void ResetAll()
    {
        if (_resetTargets == null) return;
        foreach (var r in _resetTargets)
        {
            if (r != null) r.ResetState();
        }
        Debug.Log("[ResetManager] All resettables have been reset.");
    }
}
