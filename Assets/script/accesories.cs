using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class accesories : MonoBehaviour
{
    public GameObject weapon;
    public GameObject weapon2;
    public GameObject weapon3;
    public GameObject weapon4;

    public GameObject hair;
    public GameObject hair2;
    public GameObject hair3;
    public GameObject hair4;

    public GameObject acchead;
    public GameObject acchead2;
    public GameObject acchead3;
    public GameObject acchead4;

    void Update()
    {
        Transform weaponChild = transform.Find("weapon");

        if (weaponChild != null)
        {
            if (weapon != null && !weapon.activeSelf)
            {

                weapon.SetActive(true);
            }
        }
        else
        {
            if (weapon != null && weapon.activeSelf)
            {

                weapon.SetActive(false);
            }
        }

        Transform weaponChild2 = transform.Find("weapon2");

        if (weaponChild2 != null)
        {
            if (weapon2 != null && !weapon2.activeSelf)
            {

                weapon2.SetActive(true);
            }
        }
        else
        {
            if (weapon2 != null && weapon2.activeSelf)
            {

                weapon2.SetActive(false);
            }
        }
        
        Transform weaponChild3 = transform.Find("weapon3");

        if (weaponChild3 != null)
        {
            if (weapon3 != null && !weapon3.activeSelf)
            {

                weapon3.SetActive(true);
            }
        }
        else
        {
            if (weapon3 != null && weapon3.activeSelf)
            {

                weapon3.SetActive(false);
            }
        }

        Transform weaponChild4 = transform.Find("weapon4");

        if (weaponChild4 != null)
        {
            if (weapon4 != null && !weapon4.activeSelf)
            {

                weapon4.SetActive(true);
            }
        }
        else
        {
            if (weapon4 != null && weapon4.activeSelf)
            {

                weapon4.SetActive(false);
            }
        }


        
        
        
        
        Transform hairchild = transform.Find("hair");

        if (hairchild != null)
        {
            if (hair != null && !hair.activeSelf)
            {

                hair.SetActive(true);
            }
        }
        else
        {
            if (hair != null && hair.activeSelf)
            {

                hair.SetActive(false);
            }
        }

        Transform hairchild2 = transform.Find("hair2");

        if (hairchild2 != null)
        {
            if (hair2 != null && !hair2.activeSelf)
            {

                hair2.SetActive(true);
            }
        }
        else
        {
            if (hair2 != null && hair2.activeSelf)
            {

                hair2.SetActive(false);
            }
        }

        Transform hairchild3 = transform.Find("hair3");

        if (hairchild3 != null)
        {
            if (hair3 != null && !hair3.activeSelf)
            {

                hair3.SetActive(true);
            }
        }
        else
        {
            if (hair3 != null && hair3.activeSelf)
            {

                hair3.SetActive(false);
            }
        }

        Transform hairchild4 = transform.Find("hair4");

        if (hairchild4 != null)
        {
            if (hair4 != null && !hair4.activeSelf)
            {

                hair4.SetActive(true);
            }
        }
        else
        {
            if (hair4 != null && hair4.activeSelf)
            {

                hair4.SetActive(false);
            }
        }

        
        
        
        
        
        
        
        Transform accheadChild = transform.Find("acchead");

        if (accheadChild != null)
        {
            if (acchead != null && !acchead.activeSelf)
            {

                acchead.SetActive(true);
            }
        }
        else
        {
            if (acchead != null && acchead.activeSelf)
            {

                acchead.SetActive(false);
            }
        }

        Transform accheadChild2 = transform.Find("acchead2");

        if (accheadChild2 != null)
        {
            if (acchead2 != null && !acchead2.activeSelf)
            {

                acchead2.SetActive(true);
            }
        }
        else
        {
            if (acchead2 != null && acchead2.activeSelf)
            {

                acchead2.SetActive(false);
            }
        }

        Transform accheadChild3 = transform.Find("acchead3");

        if (accheadChild3 != null)
        {
            if (acchead3 != null && !acchead3.activeSelf)
            {

                acchead3.SetActive(true);
            }
        }
        else
        {
            if (acchead3 != null && acchead3.activeSelf)
            {

                acchead3.SetActive(false);
            }
        }

        Transform accheadChild4 = transform.Find("acchead4");

        if (accheadChild4 != null)
        {
            if (acchead4 != null && !acchead4.activeSelf)
            {

                acchead4.SetActive(true);
            }
        }
        else
        {
            if (acchead4 != null && acchead4.activeSelf)
            {

                acchead4.SetActive(false);
            }
        }

    }

}