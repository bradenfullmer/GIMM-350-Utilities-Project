using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utilities 
{

    public static string ProcessText(string textIn)
    {
        if(textIn != null)
        {
            try
            {
                float numbers;
                numbers = float.Parse(textIn);
                textIn = "You entered the number: " + numbers;
                return textIn;
            }
            catch
            {
                return ("The string you entered was: " + textIn);
            }
        }
        return null;
    }
}
