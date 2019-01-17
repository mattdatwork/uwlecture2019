﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleInteractable : MonoBehaviour
{
    protected Material previousMat = null;
    protected Vector3 interactorHitPosition = Vector3.zero;
    protected bool selected = false;

    // Start is called before the first frame update
    public virtual void OnSelectEnter()
    {
        var meshRenderer = this.GetComponent<MeshRenderer>();
        if(meshRenderer != null)
        {
            previousMat = meshRenderer.material;
            meshRenderer.material = selectedMat;
        }
        selected = true;
    }

    public virtual void OnSelectExit()
    {
        var meshRenderer = this.GetComponent<MeshRenderer>();
        if (meshRenderer != null && previousMat != null)
        {
            meshRenderer.material = previousMat;
        }
        selected = false;
    }


    public virtual void InteractorPosition(Vector3 position)
    {
        interactorHitPosition = position;
    }

    public virtual void OnInteract()
    {
        return;
    }

    public Material selectedMat = null;
}
