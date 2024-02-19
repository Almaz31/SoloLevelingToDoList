using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainButtonManager : MonoBehaviour
{
    [Space(6), Header("Buttons")]
    [SerializeField] private GameObject ProfileButton;
    [SerializeField] private GameObject EditButton;
    [SerializeField] private GameObject MainButton;
    [SerializeField] private GameObject ShopButton;
    [SerializeField] private GameObject FriendsButton;

    [Space(6), Header("Pages")]
    [SerializeField] private GameObject ProfilePage;
    [SerializeField] private GameObject EditPage;
    [SerializeField] private GameObject MainPage;
    [SerializeField] private GameObject ShopPage;
    [SerializeField] private GameObject FriendsPage;

    private bool[] enabledPages=new bool[5] {false, false, false, false, false};
    private GameObject[] pages ;
    private GameObject[] buttons;
    private enum Pages
    {
        ProfilePage,
        EditPage,
        MainPage,
        ShopPage,
        FriendsPage
    }
    void Start()
    {
        
        pages = new GameObject[] { ProfilePage, EditPage, MainPage, ShopPage, FriendsPage };
        buttons = new GameObject[] { ProfileButton, EditButton, MainButton, ShopButton, FriendsButton };

        ProfileButton.GetComponent<Button>().onClick.AddListener(() => { OpenPage(ProfilePage); });
        EditButton.GetComponent<Button>().onClick.AddListener(() => { OpenPage(EditPage); });
        MainButton.GetComponent<Button>().onClick.AddListener(() => { OpenPage(MainPage); });
        ShopButton.GetComponent<Button>().onClick.AddListener(() => { OpenPage(ShopPage); });
        FriendsButton.GetComponent<Button>().onClick.AddListener(() => { OpenPage(FriendsPage); });

        OpenPage(MainPage);
    }
    private void OpenPage(GameObject page)
    {
        page.SetActive(true);
        for (int i = 0; i < pages.Length; i++)
        {
            RectTransform rectTransform = buttons[i].GetComponent<RectTransform>();
            if (page == pages[i])
            {
                enabledPages[i] = true;
                rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, 200f);
            }
            else
            {
                enabledPages[i] = false;
                rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, 160f);
                pages[i].SetActive(false);
            }
        }
    }
}