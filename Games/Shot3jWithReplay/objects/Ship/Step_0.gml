/// @author Leniel Macaferi
/// @description Gameplay Logic

var moveSpeed = 4;

// Movement in all directions. Accepts multiple inputs.
// NOTE: Moves faster on diagonals, but that's an easy fix.
if (_kLeft && !place_meeting(x - moveSpeed, y, Meteor))
{
    x -= moveSpeed;
    image_speed = 0.5;
}
    
if (_kRight && !place_meeting(x + moveSpeed, y, Meteor))
{
    x += moveSpeed;
    image_speed = 0.5;
}
    
if (_kUp && !place_meeting(x, y - moveSpeed,  Meteor))
{
    y -= moveSpeed;
    image_speed = 0.5;
}
    
if (_kDown && !place_meeting(x, y + moveSpeed,  Meteor))
{
    y += moveSpeed;
    image_speed = 0.5;
}

// Go back to the idle position in the animation and stop it when there are no inputs
if (!_kLeft && !_kRight && !_kDown && !_kUp)
{
    image_index = 1;
    image_speed = 0;
}

// Shot
if (_kAction)
{
  action_set_relative(1);
var __b__;
__b__ = action_if(global.bonus=1);
if __b__
{
{
action_create_object(Shot, 14, 0);
action_create_object(Shot, 36, 0);
}
}
else
{
{
action_create_object(Shot, 26, 0);
}
}
action_sound(laser, 0);
action_set_relative(0);
}
