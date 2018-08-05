using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectNet : MonoBehaviour {

    //public bool is_appear = true; 
    // Use this for initialization
    public bool catch_net;
    void Start()
    {
        catch_net = false;
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Net")
            {
                catch_net = true;
                Destroy(gameObject);
            }
        }
        /*
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Ray2D ray = new Ray2D(wp, Vector2.zero);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            if (hit.collider.name == "Net")
            {
                catch_net = true;
                Destroy(gameObject);
            }
        }*/
        /*
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        { 
            if (hit.collider.name == "Net")
            {

               // RawImage r = GetComponent<RawImage>();
               // r.enabled = false;

                Destroy(gameObject);        //물체 사라짐
                // is_appear = false;
            }
        }*/
    }
}
