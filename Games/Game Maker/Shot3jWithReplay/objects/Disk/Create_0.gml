var __b__;
__b__ = action_if_variable(x, 320, 1);
if __b__
{
{
action_set_hspeed(+3+random(10));
}
}
else
{
{
action_set_hspeed(-3-random(10));
}
}
action_set_alarm(10, 0);
action_sound(MusicaDisco, 1);
