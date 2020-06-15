using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{
    private inventory inventory;

    public GameObject itemButton;
    void Start() 
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<inventory>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){

        for (int i = 0; i < inventory.slots.Length; i++)
        {
            if(inventory.isfull[i]==false){

                inventory.isfull[i] = true;

                Instantiate(itemButton,inventory.slots[i].transform,false);
                Destroy(gameObject);
        

               


                break;
            }
        }


    }

}
