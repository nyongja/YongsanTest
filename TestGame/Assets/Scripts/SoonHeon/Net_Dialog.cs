using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Net_Dialog : MonoBehaviour {
    public RawImage NetInfo;
    public RawImage GetNet;

    public SelectBox_Pond box;
    public SelectNet net;
    // Use this for initialization
    void Start()
    {
        RawImage ni = NetInfo.GetComponent<RawImage>();
        ni.enabled = false;

        RawImage gn = GetNet.GetComponent<RawImage>();
        gn.enabled = false;
    }

    void Update()
    {
        if (box.is_click)//뜰채 안내 메세지
        {
            RawImage ni = NetInfo.GetComponent<RawImage>();
            ni.enabled = true;
            Destroy(NetInfo, 2f);
        }

        if (net.catch_net)//뜰채 획득 메세지
        {
            RawImage gn = GetNet.GetComponent<RawImage>();
            gn.enabled = true;
            Destroy(gn, 2f);

        }
    }
}
