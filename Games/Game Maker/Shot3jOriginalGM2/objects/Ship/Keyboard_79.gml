action_set_relative(0);
var __b__;
__b__ = action_if(quantosIndestrutiveis>0 and indestrutivel=0);
if __b__
{
{
indestrutivel = 1;
{
action_set_relative(1);
quantosIndestrutiveis += -1;
action_set_relative(0);
}
action_sprite_set(sprNaveDura, 0, 1);
action_set_alarm(150, 1);
}
}
action_set_relative(0);
