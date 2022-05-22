using UnityEngine;

public class LongDistanceTransition : Transition
{
    [SerializeField] private float _nominalTransitionDistance;
    [SerializeField] private float _distanceSpread;

    private float _transitionDistance;

    private void Start() => _transitionDistance = _nominalTransitionDistance + Random.Range(-_distanceSpread, _distanceSpread);

    private void Update()
    {
        if (Target != null)
        {
            if (Vector2.Distance(transform.position, Target.transform.position) > _transitionDistance)
            {
                IsTransitNeeded = true;
            }
        }
    }
}