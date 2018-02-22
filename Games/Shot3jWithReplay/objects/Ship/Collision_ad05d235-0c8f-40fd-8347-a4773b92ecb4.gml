action_set_relative(0);
with (other) {
action_kill_object();
}
global.bonus = 1;
{
action_set_relative(1);
action_set_alarm(100+random(200), 0);
action_set_relative(0);
}
action_set_relative(0);
