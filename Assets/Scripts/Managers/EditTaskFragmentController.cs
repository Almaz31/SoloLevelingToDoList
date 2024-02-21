using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EditTaskFragmentController : MonoBehaviour
{
    public EditTaskFragmentController Instance { get; private set; }

    [SerializeField] private Button applyChangesButton;
    [SerializeField] private TMP_InputField inputTaskName;
    [SerializeField] private TMP_InputField inputRepeatCount;
    [SerializeField] private TextMeshProUGUI errorText;
    [SerializeField] private GameObject EditTaskFragment;

    private TaskItem currentItem;
    private void Awake()
    {
        if(Instance == null)Instance = this;
    }
    private void Start()
    {
        applyChangesButton.onClick.AddListener(() => { SaveChanges(); });
        inputTaskName.onValueChanged.AddListener(CheckTaskName);
        inputRepeatCount.onValueChanged.AddListener(CheckRepeatCount);
    }
    public void ShowFragment(TaskItem item)
    {
        EditTaskFragment.SetActive(true);

        currentItem = item;
        inputTaskName.text = currentItem.taskName;
        inputRepeatCount.text = currentItem.repeatCount.ToString();
    }
    private void SaveChanges()
    {
        currentItem.taskName = inputTaskName.text;
        currentItem.repeatCount = int.Parse(inputRepeatCount.text);

        EditTaskFragment.SetActive(false);
    }

    private void CheckRepeatCount(string newRepeatCount)
    {
        int result = 0;

        if (int.TryParse(newRepeatCount,out result))
        {
            errorText.text = "";
            applyChangesButton.interactable = true;
        }
        else if (result < 100)
        {
            errorText.text = "Please enter more than 100 repeats";
            applyChangesButton.interactable = false;
        }
        else
        {
            errorText.text = "Please enter only number";
            applyChangesButton.interactable = false;
        }
    }

    private void CheckTaskName(string newText)
    {
        if (newText.Length >= 15)
        {
            errorText.text = "Please enter less than 15 symbols";
            applyChangesButton.interactable = false;
        }
        else
        {
            errorText.text = "";
            applyChangesButton.interactable = true;
        }
    }
}
