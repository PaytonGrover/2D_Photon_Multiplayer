using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerManagement : MonoBehaviour
{
    public MonoBehaviour[] scriptsToIgnore;

    private PhotonView photonView;

    private Photon.Pun.Demo.PunBasics.CameraWork cameraWork;
    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        cameraWork = this.gameObject.GetComponent<Photon.Pun.Demo.PunBasics.CameraWork>();


        if (cameraWork != null)
        {
            if (photonView.IsMine)
            {
                cameraWork.OnStartFollowing();
            }
        }
        else
        {
            Debug.LogError("<Color=Red><a>Missing</a></Color> CameraWork Component on playerPrefab.", this);
        }
        if (!photonView.IsMine)
        {
            foreach (var script in scriptsToIgnore)
            {
                script.enabled = false;
            }
        }

    }
}