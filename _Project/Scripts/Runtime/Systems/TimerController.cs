
using UnityEngine;
using UnityEngine.Events;

public class TimerController : MonoBehaviour
{
    [Min(0)] public float durationSeconds = 60f;
    public bool autoStart = false;
    public UnityEvent onTimerStart;
    public UnityEvent<float> onTimerTick; // remaining seconds
    public UnityEvent onTimerEnd;

    private float _remaining;
    private bool _running;

    private void Start()
    {
        if (autoStart) StartTimer(durationSeconds);
    }

    public void StartTimer(float seconds)
    {
        _remaining = Mathf.Max(0f, seconds);
        _running = true;
        onTimerStart?.Invoke();
    }

    public void StopTimer()
    {
        _running = false;
    }

    private void Update()
    {
        if (!_running) return;
        _remaining -= Time.deltaTime;
        onTimerTick?.Invoke(Mathf.Max(0f, _remaining));
        if (_remaining <= 0f)
        {
            _running = false;
            onTimerEnd?.Invoke();
        }
    }
}
