
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;
using System.Linq;

public class SceneSetupTool
{
    [MenuItem("Tools/XR Starter/Create Base Scene Hierarchy")]
    public static void CreateBaseScene()
    {
        // Root groups
        var xrOrigin = Ensure("XR Origin");
        var locomotion = Ensure("Locomotion System");
        var xriManager = Ensure("XR Interaction Manager");
        var systems = Ensure("Systems");
        var environment = Ensure("Environment");
        var exhibits = Ensure("Exhibits");
        var ui = Ensure("UI");
        var audio = Ensure("Audio");

        // Camera child under XR Origin
        var cameraOffset = EnsureChild(xrOrigin.transform, "Camera Offset");
        var mainCam = EnsureChild(cameraOffset.transform, "Main Camera");
        var cam = mainCam.GetComponent<Camera>();
        if (!cam) cam = mainCam.AddComponent<Camera>();
        mainCam.tag = "MainCamera";

        // Place basic components that won't error if XRI isn't imported yet
        // (We just create placeholders; user will assign real providers later)

        Selection.objects = new Object[] { xrOrigin };
        Debug.Log("XR base scene hierarchy created. Now add XRI packages and assign providers.");
    }

    private static GameObject Ensure(string name)
    {
        var go = GameObject.Find(name);
        if (!go) go = new GameObject(name);
        return go;
    }

    private static GameObject EnsureChild(Transform parent, string name)
    {
        var child = parent.Cast<Transform>().FirstOrDefault(t => t.name == name);
        if (!child)
        {
            var go = new GameObject(name);
            go.transform.SetParent(parent, false);
            return go;
        }
        return child.gameObject;
    }
}
#endif
