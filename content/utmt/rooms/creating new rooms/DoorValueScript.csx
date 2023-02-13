 using System.Linq;

void checkForCancel(string text)
{
    if (text is null)
    {
        throw new ScriptException("User has cancelled the script");
    }
}

var roomName = SimpleTextInput("Enter name of the room you want to come out of", "Enter name of the room of the room you want to come out of", "", false).Trim();
checkForCancel(roomName);
var doorID = SimpleTextInput("Enter Door Instance ID of the door you want to come out of", "Enter Door Instance ID of the door you want to come out of", "", false).Trim();
checkForCancel(doorID);
var directionInput = SimpleTextInput("Enter the door direction",
    "Enter the door direction.",
    "Valid input is: \"RL\", \"LR\", \"UD\", \"DU\".\n (Right to Left, Left to Right, Up to Down and Down to Up respectively. First is always where you walk in the door, second is always where you appear after the transition.)",
    true).Trim().ToUpper();
checkForCancel(directionInput);
var validDirectionInput = new[] { "RL", "LR", "UD", "DU" };
if (!validDirectionInput.Contains(directionInput))
    throw new ScriptException("Invalid direction");
string heightText = directionInput is "LR" or "RL" ? "high" : "wide";
var heightInput = SimpleTextInput("How " + heightText + " in tiles do you want your Door/Transition to be?",
    "How " + heightText + " in tiles do you want your Door/Transition to be?",
    "", false).Trim();
checkForCancel(heightText);

var targetRoom = Data.Rooms.ByName(roomName);
var targetDoor = targetRoom.GameObjects.First(o => o.InstanceID == UInt32.Parse(doorID));
var roomID = Data.Rooms.IndexOf(targetRoom);
int xMod = 0;
int yMod = 0;
int finalDirection = 0;
var camYMod = 0;
int transX = 0;
int transY = 0;
switch (directionInput)
{
    case "RL":
        xMod = 16;
        finalDirection = 0;
        camYMod = -120;
        transX = 4;
        transY = targetDoor.Y;
        break;
    case "LR":
        xMod = -16;
        finalDirection = 180;
        camYMod = 120;
        transX = 316;
        transY = targetDoor.Y;
        break;
    case "UD":
        yMod = - 16;
        finalDirection = 90;
        camYMod = 160;
        transX = targetDoor.X % 320;
        transY = 4;
        break;
    case "DU":
        yMod = 16;
        finalDirection = 270;
        camYMod = -160;
        transX = targetDoor.X % 320;
        transY = 236;
        break;
}

var targetX = targetDoor.X + xMod;
var targetY = targetDoor.Y + yMod;

var finalHeight = Int32.Parse(heightInput) * 16;

var camStartX = targetDoor.X + (xMod * 10);
var camStartY = targetDoor.Y + camYMod;

SimpleTextOutput("Transition door variables", "Here are your variables",
    $@"targetroom = {roomID}
targetx = {targetX}
targety = {targetY}
height = {finalHeight}
direction = {finalDirection}
camstartx = {camStartX}
camstarty = {camStartY}
transitionx = {transX}
transitiony = {transY}
", true);
