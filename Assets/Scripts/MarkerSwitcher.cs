using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class MarkerSwitcher : MonoBehaviour
{
    public string marker1Name = "marker1";
    public string marker2Name = "marker2";

    public GameObject marker1Object;
    public GameObject marker2Object;

    private ARTrackedImage trackedImage;

    void Awake()
    {
        trackedImage = GetComponent<ARTrackedImage>();
    }

    void Update()
    {
        if (trackedImage == null) return;

        string currentName = trackedImage.referenceImage.name;
        bool isTracking = trackedImage.trackingState == TrackingState.Tracking;

        if (marker1Object != null)
            marker1Object.SetActive(isTracking && currentName == marker1Name);

        if (marker2Object != null)
            marker2Object.SetActive(isTracking && currentName == marker2Name);
    }
}