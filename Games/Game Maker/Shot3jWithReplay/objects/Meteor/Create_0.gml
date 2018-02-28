var __b__;
__b__ = action_if(irandom(1)=1);
if __b__
{
{
action_sprite_set(sprMiniAst, 0, 1);
}
}
__b__ = action_if_dice(3);
if __b__
{
{
action_sprite_set(sprBigAst, 0, 1);
}
}
action_set_vspeed(3+random(10)*global.diffLevel);
