action_set_relative(1);

var __b__;
__b__ = action_if_life(1, 1);

if __b__
{
{
action_restart_game();
}
}
else
{
{

__b__ = action_if_number(Bomba, 0, 2);

if __b__
{
{
with (Meteor)
{
  action_kill_object();
}
}
}

__b__ = action_if_number(Meteor, 0, 2);
if __b__
{
{
with (Meteor) {
action_kill_object();
}
}
}
__b__ = action_if_number(Disk, 0, 2);
if __b__
{
{
with (Disk) {
action_kill_object();
}
}
}
action_set_life(-1);
{
action_set_relative(0);
action_create_object(Ship, 280, 240);
action_set_relative(1);
}
}
}
action_set_relative(0);
