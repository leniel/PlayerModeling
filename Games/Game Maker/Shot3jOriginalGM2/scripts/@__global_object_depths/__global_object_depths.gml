// Initialise the global array that allows the lookup of the depth of a given object
// GM2.0 does not have a depth on objects so on import from 1.x a global array is created
// NOTE: MacroExpansion is used to insert the array initialisation at import time
gml_pragma( "global", "__global_object_depths()");

// insert the generated arrays here
global.__objectDepths[0] = 0; // Ship
global.__objectDepths[1] = 0; // Shot
global.__objectDepths[2] = 5; // Disk
global.__objectDepths[3] = 0; // Meteor
global.__objectDepths[4] = 0; // Controlador
global.__objectDepths[5] = 0; // Explosao
global.__objectDepths[6] = 0; // Bomba
global.__objectDepths[7] = 0; // Raiz
global.__objectDepths[8] = 0; // Force
global.__objectDepths[9] = 0; // btButton
global.__objectDepths[10] = 0; // btHard
global.__objectDepths[11] = 0; // btNormal
global.__objectDepths[12] = 0; // btEasy


global.__objectNames[0] = "Ship";
global.__objectNames[1] = "Shot";
global.__objectNames[2] = "Disk";
global.__objectNames[3] = "Meteor";
global.__objectNames[4] = "Controlador";
global.__objectNames[5] = "Explosao";
global.__objectNames[6] = "Bomba";
global.__objectNames[7] = "Raiz";
global.__objectNames[8] = "Force";
global.__objectNames[9] = "btButton";
global.__objectNames[10] = "btHard";
global.__objectNames[11] = "btNormal";
global.__objectNames[12] = "btEasy";


// create another array that has the correct entries
var len = array_length_1d(global.__objectDepths);
global.__objectID2Depth = [];
for( var i=0; i<len; ++i ) {
	var objID = asset_get_index( global.__objectNames[i] );
	if (objID >= 0) {
		global.__objectID2Depth[ objID ] = global.__objectDepths[i];
	} // end if
} // end for