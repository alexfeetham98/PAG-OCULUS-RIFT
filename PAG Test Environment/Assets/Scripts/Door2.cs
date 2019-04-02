using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    public GameObject[] Slots;
    public GameObject[] Keys;

    public bool GearDoor;
    bool red = false;
    bool green = false;
    bool blue = false;
    bool orange = false;
    bool yellow = false;
    bool pink = false;

    GearStay GSSR;
    GearStay GSSG;
    GearStay GSSB;
    GearStay GSSO;
    GearStay GSSY;
    GearStay GSSP;

    private float timer = 0f;

    void Start()
    {

        GSSR = Keys[0].GetComponent<GearStay>();
        GSSG = Keys[1].GetComponent<GearStay>();
        GSSB = Keys[2].GetComponent<GearStay>();
        GSSO = Keys[3].GetComponent<GearStay>();
        GSSY = Keys[4].GetComponent<GearStay>();
        GSSP = Keys[5].GetComponent<GearStay>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Keys[0].transform.position == Slots[0].transform.position)
        {
            red = true;
            Slots[0].layer = 0;
            Keys[0].layer = 0;
        }
        if (Keys[1].transform.position == Slots[1].transform.position)
        {
            green = true;
            Slots[1].layer = 0;
            Keys[1].layer = 0;
        }
        if (Keys[2].transform.position == Slots[2].transform.position)
        {
            blue = true;
            Slots[2].layer = 0;
            Keys[2].layer = 0;
        }
        if (Keys[3].transform.position == Slots[3].transform.position)
        {
            orange = true;
            Slots[3].layer = 0;
            Keys[3].layer = 0;
        }
        if (Keys[4].transform.position == Slots[4].transform.position)
        {
            yellow = true;
            Slots[4].layer = 0;
            Keys[4].layer = 0;
        }
        if (Keys[5].transform.position == Slots[5].transform.position)
        {
            pink = true;
            Slots[5].layer = 0;
            Keys[5].layer = 0;
        }




        if (red && green && blue && orange && yellow && pink)
        {
            if (GearDoor)
            {
                timer += Time.deltaTime;
                if (timer > 0.5f)
                {
                    GSSR.rotate = true;
                    GSSG.rotate = true;
                    GSSB.rotate = true;
                    GSSO.rotate = true;
                    GSSY.rotate = true;
                    GSSP.rotate = true;
                    Destroy(this.gameObject);
                }
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
    }
}
