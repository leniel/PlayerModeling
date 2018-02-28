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
