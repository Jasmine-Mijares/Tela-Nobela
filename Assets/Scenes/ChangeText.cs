using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    public Text changingText;
    //public GameObject changingText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TextChange(){
	changingText.text = "Before she began her work, she took off the beads from around her neck and the comb from";
	//changingText.text = "her hair, and hung them on the sky, which at that time looked like coral rock.";
        //changingText.GetComponent<Text>().text = "One day in the times when the sky was close to the ground a spinster went out to pound rice.";
    }
}
