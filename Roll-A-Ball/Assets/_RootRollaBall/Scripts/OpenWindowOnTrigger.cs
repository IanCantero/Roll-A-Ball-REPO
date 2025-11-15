using UnityEngine;

public class PressKeyOpenWindow : MonoBehaviour
{
    public GameObject Instruction;
    public GameObject AnimeObject;
    public GameObject ThisTrigger;
    public bool Action = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instruction.SetActive(false);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.tag == "Player");
        {
            Instruction.SetActive(true);
            Action = true;
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E));
        {
            if (Action == true)
            {
                Instruction.SetActive(false);
                AnimeObject.GetComponent<Animator>().Play("WindowOpen");
                ThisTrigger.SetActive(false);
                Action = false;
            }
        }
    }
  }      