using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public Text mainText;
    public Button option1;
    public Button option2;
    class StoryBlock {

        public string story;
        public string option1Text;
        public string option2Text;
        public StoryBlock option1Block;
        public StoryBlock option2Block;

        public StoryBlock(string story="",string option1Text="",string option2Text="",StoryBlock option1Block=null,
            StoryBlock option2Block=null)
        {
            this.story = story;
            this.option1Text = option1Text;
            this.option2Text = option2Text;
            this.option1Block = option1Block;
            this.option2Block = option2Block;
        }
    }

    StoryBlock currentBlock;

    static StoryBlock block8 = new StoryBlock("H", "1", "2");

    static StoryBlock block7 = new StoryBlock("G", "1", "2");

    static StoryBlock block6 = new StoryBlock("F", "1", "2", block7, block8);

    static StoryBlock block5 = new StoryBlock("E", "1", "2", block6, block3);

    static StoryBlock block4 = new StoryBlock("D", "1", "2", block6, block5);

    static StoryBlock block3 = new StoryBlock("C", "1", "2", block6, block8);

    static StoryBlock block2 = new StoryBlock("B", "1", "2", block4, block3);

    static StoryBlock block1 = new StoryBlock("A", "1", "2", block2, block3);

    // Start is called before the first frame update
    void Start()
    {
        DisplayBlock(block1);
    }

    void DisplayBlock(StoryBlock block)
    {
        mainText.text = block.story;
        option1.GetComponentInChildren<Text>().text = block.option1Text;
        option2.GetComponentInChildren<Text>().text = block.option2Text;

        currentBlock = block;
       

    }


    public void Button1Clicked()
    {
        DisplayBlock(currentBlock.option1Block);
    }

    public void Button2Clicked()
    {
        DisplayBlock(currentBlock.option2Block);
        
    }

    public void BackButton()
    {
        SceneManager.LoadScene("MainMenuUI");
    }
}
