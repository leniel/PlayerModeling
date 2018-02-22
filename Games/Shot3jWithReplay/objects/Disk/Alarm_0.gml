action_set_relative(1);
var __b__;
__b__ = action_if_number(Disk, 0, 2);
if __b__
{
{
action_create_object(Bomba, 0, 0);
}
}
{
action_set_relative(0);
action_set_alarm(5+random(20), 0);
action_set_relative(1);
}
action_set_relative(0);
