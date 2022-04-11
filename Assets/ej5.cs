using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ej5 : MonoBehaviour
{

    public int num1;
    public int num2;
    public int res;
    // Start is called before the first frame update
    void Start()
    {
       

       res=  num1/num2 ;
       

        if ( num2 == 0 )
            {

            Debug.Log("no se puede dividir por cero");

        }

        else

            Debug.Log(num1 + "/" + num2 + "=" + res);



    }


}
