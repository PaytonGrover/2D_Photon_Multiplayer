using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using Photon;
using Photon.Chat;

public class PhotonManager : MonoBehaviourPunCallbacks
{
    [Tooltip("The prefab to use for representing the player")]
    public GameObject playerPrefab1;
    public GameObject playerPrefab2;
    public GameObject playerPrefab3;
    public GameObject playerPrefab4;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
               
    }

    
    void Update()
    {
        
    }
    public override void OnConnectedToMaster()
    {
        PhotonNetwork.JoinLobby();
    }
    public override void OnJoinedLobby()
    {
        
        PhotonNetwork.JoinOrCreateRoom("Room", new RoomOptions { MaxPlayers = 4 }, TypedLobby.Default);
    }
    public override void OnJoinedRoom()
    {
        if(PhotonNetwork.LocalPlayer.ActorNumber == 1)
        {
            PhotonNetwork.Instantiate(this.playerPrefab1.name, new Vector3(10f, 0f, 0f), Quaternion.identity, 0);
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
        {
            PhotonNetwork.Instantiate(this.playerPrefab1.name, new Vector3(10f, 0f, 0f), Quaternion.identity, 0);
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 3)
        {
            PhotonNetwork.Instantiate(this.playerPrefab3.name, new Vector3(10f, 0f, 0f), Quaternion.identity, 0);
        }
        if (PhotonNetwork.LocalPlayer.ActorNumber == 4)
        {
            PhotonNetwork.Instantiate(this.playerPrefab4.name, new Vector3(10f, 0f, 0f), Quaternion.identity, 0);
        }
        //PhotonNetwork.Instantiate(this.playerPrefab1.name, new Vector3(0f, 5f, 0f), Quaternion.identity, 0);
        //PhotonNetwork.Instantiate("Player1", transform.position, Quaternion.identity);
    }
}