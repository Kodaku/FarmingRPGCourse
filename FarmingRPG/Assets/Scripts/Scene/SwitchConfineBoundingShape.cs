using UnityEngine;
using Cinemachine;

public class SwitchConfineBoundingShape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SwitchBoundingShape();
    }

    /// <summary>
    /// Switch the collider that cinemachine uses to define the edges if tge screen
    /// </summary>
    private void SwitchBoundingShape()
    {
        // Get the polygon collider from the BoundingConfiner game object
        PolygonCollider2D polygonCollider2D = GameObject.FindGameObjectWithTag(Tags.BoundsConfiner).GetComponent<PolygonCollider2D>();

        CinemachineConfiner cinemachineConfiner = GetComponent<CinemachineConfiner>();
        cinemachineConfiner.m_BoundingShape2D = polygonCollider2D;

        // since the confiner bounds have changed need to call this to clear the cache
        cinemachineConfiner.InvalidatePathCache();
    }    

}
