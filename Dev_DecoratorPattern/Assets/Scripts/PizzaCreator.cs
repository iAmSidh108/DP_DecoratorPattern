using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaCreator : MonoBehaviour
{
    private void Start()
    {
        IPizza pizza = new Pizza();
        //IPizza cheeseDecorator = new CheeseDecorator(pizza);
        //IPizza tomatoDecorator = new TomatoDecorator(cheeseDecorator);
        //IPizza onionDecorator = new OnionDecorator(tomatoDecorator);

        pizza = new CheeseDecorator(new TomatoDecorator(new OnionDecorator(pizza)));

        Debug.Log(pizza.GetPizzaType());
    }


}
