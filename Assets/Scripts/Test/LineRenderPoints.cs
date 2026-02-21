using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LineRenderPoints : MonoBehaviour
{
    public Transform[] points;

    LineRenderer lr;

    void Awake()
    {
        lr = GetComponent<LineRenderer>();
    }

    void LateUpdate()
    {
        if (points == null || points.Length == 0) return;

        lr.positionCount = points.Length;
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i].position);
        }
    }
}
