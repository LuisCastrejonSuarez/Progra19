using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public DIalogueController dialogueController;

    public float speed = 5;
    public float rotationspeed = 100;
    private Vector3 movement=Vector3.zero;
    private Vector3 rotation = Vector3.zero;
    private CharacterController controller;

    /// <summary>
    /// UI
    /// </summary>
    public Text txtCrystal;
    public Text txtHeatlh;
    int crystals = 0;
    int health;
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        movement = transform.forward * Input.GetAxis("Vertical");
        rotation = new Vector3(0,Input.GetAxis("Horizontal"), 0);
    }
    private void FixedUpdate()
    {
        controller.Move(movement * Time.deltaTime * speed);
        transform.Rotate(rotation * Time.deltaTime * rotationspeed);
    }

    public void Collect()
    {
        Debug.Log("vida extra!");
        ++crystals;
        txtCrystal.text = "Cristales: " + crystals;
    }
    public void recover()
    {
        if(health<100)
            ++health;
        txtHeatlh.text = "Energía: " + health;
    }
    public void ShowDialogue(string name, string dialogue)
    {
        dialogueController.ShowText(name, dialogue);
    }
}
