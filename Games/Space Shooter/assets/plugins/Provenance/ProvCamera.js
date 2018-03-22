#pragma strict
import System;
import System.IO;

var size : int = 2;
var screenshotName = "AngryBotsMap";
private var fileName = "ScreenshotCoordinates.txt";

private var topLeft : Vector3;


function Awake() {
	Debug.Log("SCREENSHOT");
	ScreenCapture.CaptureScreenshot(screenshotName + ".png", size);
	GetScreenShotPositions();
	WriteCoordinates();
}
	
function GetScreenShotPositions()
{
	topLeft = GetComponent.<Camera>().ViewportToWorldPoint (Vector3 (0,1, GetComponent.<Camera>().nearClipPlane));
}

function WriteCoordinates()
{
	var sr = File.CreateText(fileName);
	sr.WriteLine ("World Offset from (0,0)");
	sr.WriteLine ("offset x: " + transform.position.x + " / offset z: " + transform.position.z);
	sr.WriteLine ("Screenshot Border Coordinate");
	sr.WriteLine ("Top-left Corner: x = " + (topLeft.x - transform.position.x));
	sr.Close();
}