using UnityEngine;
using UnityEngine.UI;

public class random_example : MonoBehaviour
{
    [SerializeField] private Text example;
    [SerializeField] private Text answerR;
    [SerializeField] private Text answerW1;
    [SerializeField] private Text answerW2;

    private int _answer;

    private void Start()
    {
        GetExample();
        GetAnswers();
    }
    private string NewExampleText(int a, int b)
    {
        string str = a.ToString() + " * " + b.ToString();
        return str;
    }

    public void GetExample()
    {
        int a = 0;

        while(a == 0 | a== A_B.first | a == A_B.second)
        {
            a = Random.Range(2, 11);
        }
        int b = Random.Range(2, 11); 
        
        A_B.first = a;
        A_B.second = b;
        
        example.text = NewExampleText(a, b);

        _answer = a * b;
    }

    public void GetAnswers()
    {
        answerR.text = _answer.ToString();

        //////////////////////////////////////////////////////////////////////////////

        int x = Random.Range(_answer - 10, _answer + 11);

        while (x == _answer | x <= 0)
        {
            x = Random.Range(_answer - 10, _answer + 11);
        }

        answerW1.text = x.ToString();

        ///////////////////////////////////////////////////////////////////////////////

        int y = Random.Range(_answer - 10, _answer + 11);

        while (y == _answer | y == x | y <= 0)
        {
            y = Random.Range(_answer - 10, _answer + 11);
        }

        answerW2.text = y.ToString();
    }
}
