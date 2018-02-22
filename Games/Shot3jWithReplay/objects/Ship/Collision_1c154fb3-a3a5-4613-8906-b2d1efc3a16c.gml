action_set_relative(1);
var __b__;
__b__ = action_if(indestrutivel=0);
if __b__
{
{
action_kill_object();
with (other) {
action_kill_object();
}
action_sound(boom, 0);
action_effect(0, 29, 28, 1, 255, 1);
with (Controlador) {
action_set_relative(0);
action_set_alarm(30, 1);
action_set_relative(1);
}
with (Disk) {
action_set_relative(0);
action_set_alarm(0, 0);
action_set_relative(1);
}
__b__ = action_if_sound(MusicaDisco);
if __b__
{
{
action_end_sound(MusicaDisco);
}
}
}
}
else
{
{
with (other) {
action_reverse_xdir();
}
with (other) {
action_reverse_ydir();
}
}
}
action_set_relative(0);
