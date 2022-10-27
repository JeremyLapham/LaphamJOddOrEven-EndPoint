# LaphamJOddOrEven-EndPoint

//Jeremy Lapham
//10-25-22
//Odd or even -Endpoint
//This will have the user type in a number in the url and will tell them if that number is odd even or equal to
//Peer Review Carlos Felipe: This program had a good response for every input I coudl think of. If I didn't put in a number it would say "Wrong try again" that was a cool data validation. When I entered a negative integer however the result would always be even regardless if it was -3, -5 etc. Other than that the program works well.
//Issue has been fixed*

So if you want to run this program we will be using Postman and you will be I assume at least if you're seeing this that you're also on my GitHub so you'll go to the green code button and copy the URL down

So once you have it copied down go to a new VS code. Once it is open click on the thingy that says "Clone Git repository..." now a place to put a URL will open and you will copy the link from GitHub to there

Then hit enter. Now it'll open up your files. If you have a folder for things like this perfect, if not create a new folder and then select that folder for your location of github stuff. A thing will pop up just click open and it'll open up all the code.

Once the code is open go to the top of your screen and go to the run thing at the top. Click on run and then click on Start Debugging

Now it should have opened up a tab saying local host not found. Go to the URL and copy it

Now go to post man and paste that local host thing into where you put a URL in Postman

Now go to the code and look at the controller name and the Route. after the local host type in the controller name without the word "controller" after the name there will be a backslash. after the backslash it should be the route name followed by another backslash after the backsalsh you will enter a number and the program will run

should look like: https://localhost:7031/oddoreven/oddeven/4
