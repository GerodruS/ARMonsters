using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Kudan.AR;


public class PlaceMarkerlessObject : MonoBehaviour
{
    public KudanTracker _kudanTracker;
    
    public void PlaceClick()
    {
        Vector3 position;
        Quaternion rotation;
        
        _kudanTracker.FloorPlaceGetPose(out position, out rotation);
        _kudanTracker.ArbiTrackStart(position, rotation);
    }
}