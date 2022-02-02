using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class MyNetworkPlayer : NetworkBehaviour
{
    [SyncVar]
    [SerializeField]
    private string displayName;

    [SyncVar]
    [SerializeField]
    private Color displayColour;

    [Server]
    public void SetDisplayName(string newDisplayName)
    {
        displayName = newDisplayName;
    }

    [Server]
    public void SetDisplayColour(Color newDisplayColour)
    {
        displayColour = newDisplayColour;
    }
}
