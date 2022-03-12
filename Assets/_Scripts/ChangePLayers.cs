using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePLayers : MonoBehaviour
{
    public PlayersManager SOPlayersManager;
    public ButtonsClicked ButtonsClickedSO;

    public Animator GreenAnim;
    public Animator RedAnim;
    public Animator StairsAnim;
    private void Start()
    {
        ButtonsClickedSO.redButtonClicked = false;
        ButtonsClickedSO.greenButtonClicked = false;
        ButtonsClickedSO.YellowButtonClicked= false;
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (SOPlayersManager.selecetedPLayer == 1)
                SOPlayersManager.selecetedPLayer = 0;
            else
                SOPlayersManager.selecetedPLayer = 1;
        }

    }
    public void SetWining()
    {
        GreenAnim.SetTrigger("Win");
        GreenAnim.SetBool("Win",true);
        GreenAnim.SetBool("DropGreen", false);
        RedAnim.SetBool("Win", true);
        StairsAnim.SetBool("Win", true);
    }
}
