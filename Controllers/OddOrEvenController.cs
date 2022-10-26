//Jeremy Lapham
//10-25-22
//Odd or even -Endpoint
//This will have the user type in a number in the url and will tell them if that number is odd even or equal to
//Peer Review Carlos Felipe: This program had a good response for every input I coudl think of. If I didn't put in a number it would say "Wrong try again" that was a cool data validation. When I entered a negative integer however the result would always be even regardless if it was -3, -5 etc. Other than that the program works well.
//Issue has been fixed*

using Microsoft.AspNetCore.Mvc;

namespace LaphamJOddOrEven_EndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class OddOrEvenController : ControllerBase
{
    [HttpGet]
    [Route("OddEven/{num}")]

    public string OddOrEven(string num)
    {
        string text = "";
        bool isNumber;
        int validNum = 0;
        isNumber = Int32.TryParse(num, out validNum);
        if (isNumber == false)
        {
            text = "That is not a number my guy";
        }
        else if(validNum < 0)
        {
            int ifNegative = Math.Abs(validNum);
            int remain = ifNegative % 2;
            if (remain == 1)
            {
                text = "Your number is odd!";
            }
            else
            {
                text = "Your number is Even!";
            }
        }
        else
        {
           
            int remain = validNum % 2;
            if (remain == 1)
            {
                text = "Your number is odd!";
            }
            else
            {
                text = "Your number is Even!";
            }
        }
        return text;
    }
}
