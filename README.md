# AR-Data-Visualization-
Repository for ASU Capstone project in 2022, will be used to hold progress on AR data visualization application.

# Start Here

## Install Unity
Download is [here](https://store.unity.com/#plans-individual).<br />
Go ahead and use the student version, install the `Unity Hub` for easier installations.  

### Unity Version
Recommended: 2021.3 LTS, Currently is 2021.3.11 LTS
This link will allow mrtk to be setup on unity.
https://learn.microsoft.com/en-us/windows/mixed-reality/develop/unity/new-openxr-project-with-mrtk#resolving-incompatible-settings
Building it and deploy app to hololens
https://learn.microsoft.com/en-us/windows/mixed-reality/develop/unity/build-and-deploy-to-hololens
Using visual studios to deploy
https://learn.microsoft.com/en-us/windows/mixed-reality/develop/advanced-concepts/using-visual-studio?tabs=hl2
Allow a windows device to deploy to Hololens
https://www.youtube.com/watch?v=konhPz0D07w
## Install Visual Studio 2022 Community

Download is [here](https://visualstudio.microsoft.com/vs/).  

### Workloads for VS

● Visual Studio Extension Development<br />
● .NET desktop development<br />
● Desktop development with C++<br />
● Universal Windows Platform (UWP) development<br />
● Game development with Unity<br />

## How to Access Project so Far
When first entering Visual Studio, it will ask you to create a project. <br />
&emsp; Choose "clone a repository": <br />
&emsp; 	Repository Location: navigate to github page [here](https://github.com/Logan-Bock/Love-and-War) <br />
&emsp; On the top right, select the green `Code` button, link shown is the repository location.<br />
<br />
Now, your visual studios will have all of the current files in the Solution Explorer<br />
Be sure to run `git pull` in terminal periodically to update code.<br />

## How to Open  
In Unity, open the `unity-AR-visualization` folder as your project. For VS, open the folder which holds the entire repository.

## How to Commit
First, go to "view->terminal" in Visual Studios (Look top left)<br />
How to test Git is installed: <br />
&emsp; Type `git`, terminal should respond with Git options.<br /><br />
How to Commit to Repository (In VS terminal):<br />
&emsp; 1. `git add .` <br />
&emsp; 2. `git commit` <br /> 
&emsp; 3. VIM text editor will open in terminal, press `i` to insert and type commit message, then hit "esc" and type `:wq` to save and quit. <br />
&emsp; 4. `git push` <br />
