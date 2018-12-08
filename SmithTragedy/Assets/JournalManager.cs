using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalManager : MonoBehaviour {
    public Inventory inv;

    public GameObject murderWeaponUI, letterUI, brochureUI, poisonUI, robPhoneUI, mattphoneUI, rileyphoneUI, laptopUI, mattBodyUI, rileyBodyUI, jenBodyUI, robBodyUI;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(inv.murderWeapon)
        {
            murderWeaponUI.SetActive(true);


        }
        if(inv.letter)
        {


            letterUI.SetActive(true);

        }
        if(inv.brochure)
        {

            brochureUI.SetActive(true);


        }

        if(inv.poison)
        {


            poisonUI.SetActive(true);

        }

        if(inv.robPhone)
        {


            robPhoneUI.SetActive(true);
        }

        if(inv.mattPhone)
        {


            mattphoneUI.SetActive(true);


        }
        if(inv.rileyPhone)
        {


            rileyphoneUI.SetActive(true);

        }
        if(inv.laptop)
        {



            laptopUI.SetActive(true);
        }

        if(inv.mattBody)
        {


            mattBodyUI.SetActive(true);
        }

        if(inv.rileyBody)
        {

            rileyBodyUI.SetActive(true);

        }

        if(inv.jenBody)
        {


            jenBodyUI.SetActive(true);

        }
        if(inv.robBody)
        {



            robBodyUI.SetActive(true);
        }
	}
}
