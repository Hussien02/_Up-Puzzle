using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName ="SO/Players Manager ")]
public class PlayersManager : ScriptableObject
{
    [Range(0,1)]
    public int selecetedPLayer;
    public int playersnumber = 2;
}
