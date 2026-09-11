using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Learning : MonoBehaviour
{
    int number = 0;  // Integer (whole number) -2,147,483,648 to 2,147,483,647 For example this is Int value
    char letter = 'i';
    string str = "I lov\"e c#";
    bool isPlaying = false; // false/true
    double decimalnumber = 0.435; // Floating point number 5.0 * 10 ^ 324 to -1.7 * 10 ^ 308

    int[] numbers = { 12, 3423, 324, 324 };
    string[] myStrings = { "Tets", "ffsd", "fsf" };
    char[] myChars = { 'a', 'd', '5' };

    public int value = 1;
    [SerializeField] private int value2 = 4;
     [SerializeField] private GameObject obj;

     [SerializeField] private Slider slider;

    private void FirstFunction(int funcValue, string secondParam)
    {
        Debug.Log("Hello world from FirstFunction value: " + funcValue);
    }

     private string FunctionReturnString()
    {
        return "Hello";
        Debug.Log("fdfsdf");
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string testString = "Hello world!";
        string combined = "From Unity: " + testString;
        Debug.Log(myChars);
        SpriteRenderer sprite = gameObject.GetComponent<SpriteRenderer>();
        //obj.AddComponent<Rigidbody2D>();
        FirstFunction(1, "hello");

        // if (isPlaying)
        // {
        //     Debug.Log("Yes game is Playing");
        // } else if (value == 1)
        // {
        //     Debug.Log("Value is 1");
        // } else if (value == 4)
        // {
        //      Debug.Log("Value is 4");
        // } else
        // {
        //      Debug.Log("Nothing was true in if");
        // }
        
        // switch (value)
        // {
        //     case 0:
        //         Debug.Log("Value is 0");
        //         break;
        //     case 1:
        //         Debug.Log("Value is 1");
        //         break;
        // }

        // for (int i = 0; i < myStrings.Length; i++)
        // {
        //     string someString = myStrings[i];
        //     Debug.Log("I value: " + myStrings[i]);
        // }
        
        // foreach (string myString in myStrings)
        // {
        //     Debug.Log("My string value: " + myString);
        // }

        // while (value < 100)
        // {
        //     Debug.Log("Value is " + value);
        //     value++;
        // }

        // do
        // {
        //     Debug.Log("Value: " + value);
        //     value++;
        // } while (value < 10);

        BMW car = new BMW(150);
        Debug.Log("Car number plate: " + car.numberPlate);
          Debug.Log("Car power: " + car.horsePower);
    }

    // Update is called once per frame
    void Update()
    {
        // if (isPlaying)
        // {
        //     Debug.Log("Yes game is Playing");
        // } else if (value == 1)
        // {
        //     Debug.Log("Value is 1");
        // } else if (value == 4)
        // {
        //      Debug.Log("Value is 4");
        // } else
        // {
        //      Debug.Log("Nothing was true in if");
        // }

        //  switch (value)
        // {
        //     case 0:
        //         Debug.Log("Value is 0");
        //         break;
        //     case 1:
        //         Debug.Log("Value is 1");
        //         break;
        // }

        //  for (int i = 0; i < 5; i++)
        // {
        //     Debug.Log("I value: " + i);
        // }
        
        // while (value < 20)
        // {
        //     Debug.Log("Value is " + value);
        //     value++;
        // }

    //    do
    //     {
    //         Debug.Log("Value: " + value);
    //         value++; 
    //     } while (value < 10);

        // Debug.Log("Slider value: " + slider.value);
    }
}

class Car
{
    private string color;
    public string numberPlate;
    public int horsePower;

    public Car() {
        color = "Red";
        numberPlate = "HG34343";
        horsePower = 100;
    }

     public Car(string number) {
        color = "Red";
        numberPlate = number;
        horsePower = 100;
    }
}

class BMW : Car
{
    public BMW(int power)
    {
        horsePower = power;
    }
}
