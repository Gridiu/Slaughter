using UnityEngine;

public abstract class Transition : MonoBehaviour
{
    [SerializeField] private State _targetState;

    public State TargetState => _targetState;

    public bool IsTransitNeeded { get; protected set; }

    protected Player Target { get; private set; }

    private void OnEnable() => IsTransitNeeded = false;

    public void Init(Player target) => Target = target;
}