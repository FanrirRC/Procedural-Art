using UnityEngine;

[DisallowMultipleComponent]
public class BuildingSegment : MonoBehaviour
{
    [Tooltip("Visual height of this building segment (used for vertical stacking).")]
    public float segmentHeight = 1f;

    [Tooltip("Visual width of this segment along the X axis (used for horizontal spacing).")]
    public float segmentWidth = 1f;
}
