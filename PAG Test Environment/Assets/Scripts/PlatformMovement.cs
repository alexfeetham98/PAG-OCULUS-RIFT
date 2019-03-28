using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public enum MovementType
    {
        MoveTowards,
        LerpTowards
    }

    public MovementType Type = MovementType.MoveTowards;
    public MovementPath MyPath;
    public float Speed = 1;
    public float MaxDistanceToGoal = 0.1f;

    private IEnumerator<Transform> pointInPath;
    public bool riding = false;

    void Start()
    {
        if (MyPath == null)
        {
            Debug.LogError("No Path Set", gameObject);
            return;
        }

        pointInPath = MyPath.GetNextPathPoint();
        pointInPath.MoveNext();

        if (pointInPath.Current == null)
        {
            Debug.LogError("No points", gameObject);
            return;
        }

        transform.position = pointInPath.Current.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            riding = true;
            other.collider.transform.SetParent(transform);
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            riding = false;
            other.collider.transform.SetParent(null);
        }
    }

    void Update()
    {
        if (riding)
        {
            gameObject.layer = 0;
            if (pointInPath == null || pointInPath.Current == null)
            {
                return;
            }

            if (Type == MovementType.MoveTowards)
            {
                transform.position = Vector3.MoveTowards(transform.position, pointInPath.Current.position, Time.deltaTime * Speed);
            }
            else if (Type == MovementType.LerpTowards)
            {
                transform.position = Vector3.Lerp(transform.position, pointInPath.Current.position, Time.deltaTime * Speed);
            }

            var distanceSquared = (transform.position - pointInPath.Current.position).sqrMagnitude;
            if (distanceSquared < MaxDistanceToGoal * MaxDistanceToGoal)
            {
                pointInPath.MoveNext();
            }
        }
    }
}
