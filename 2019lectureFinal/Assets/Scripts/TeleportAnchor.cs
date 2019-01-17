using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportAnchor : SimpleInteractable
{
    public Transform teleportAnchor;

    public override void OnInteract()
    {
        GameObject player = null;
        player = GameObject.Find("XRRig");
        if(player != null)
        {
            player.transform.SetPositionAndRotation(teleportAnchor.position, teleportAnchor.rotation);
        }
    }

}
