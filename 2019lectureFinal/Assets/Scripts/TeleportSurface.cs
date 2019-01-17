using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSurface : SimpleInteractable
{

    public GameObject positionIndicator = null;
    
    public void Update()
    {
        if(positionIndicator != null && interactorHitPosition != null && selected)
        {
            positionIndicator.SetActive(true);
            positionIndicator.transform.position = interactorHitPosition;
        }
        else if(positionIndicator != null)
        {
            positionIndicator.SetActive(false);
        }
    }

    // Update is called once per frame
    public override void OnInteract()
    {
        GameObject player = null;
        player = GameObject.Find("XRRig");
        if (player != null && interactorHitPosition != null)
        {
            player.transform.position = interactorHitPosition;
        }
    }
}
