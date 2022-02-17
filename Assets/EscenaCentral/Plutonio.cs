using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Plutonio
{
    private static int plutonio = 0;

    public static void AñadirPlutonio()
    {
        plutonio++;

    }

    public static int getPlutonio()
    {
        return plutonio;
    }

}
