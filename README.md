# Mixpanel Actions for Unity Playmaker
Adds actions to Unity [Playmaker](http://www.hutonggames.com) to work with Mixpanel.


## How to use these actions?
The following is a step by step tutorial on how to get these actions running, including an example of usage. Since this is an addition to playmaker i am guessing you already own unity, and got playmaker installed before following these steps and know how to use it.

### Step 1. - Download
Download [Walt Destler's Mixpanel-Unity-CSharp scripts](https://github.com/waltdestler/Mixpanel-Unity-CSharp) and
[my Playmaker Mixpanel Actions](https://github.com/FRickReich/playmaker-mixpanel-actions).

### Step 2. - Create a new Project
Create a new project in unity and add playmaker, then drag and drop the downloaded unitypackages into your project.

### Step 3. - Create a new FSM
Create a new empty object in your default scene and add a playmaker FSM to it.

### Step 4. - Add Mixpanel
Under your action browser you will find a new group called "Mixpanel", find "Mixpanel Setup" in there and add it to your start state.

### Step 5. - Fill in the Token
Put your Mixpanel project's token into the token field, you can find it on your mixpanel dashboard under settings.

### Step 6. - Add a Button
Add a GUI BUTTON to the current state and make it call Finished when clicked, add the FINISHED event to the current state also.

### Step 7. - Create an event
Create a new state that is called after the FINISHED event is called, add a "Mixpanel String Event" and fill in the blanks.

### Step 8. - Test it
When you test the scene and click the button, you can see it added the event to your mixpanel timeline, when you refresh the page.


## Todo
Add multiple Event sender.


## License
Copyright (c) 2013 F. Rick Reich. Licensed under the terms of the MIT license.
http://frickreich.mit-license.org/
