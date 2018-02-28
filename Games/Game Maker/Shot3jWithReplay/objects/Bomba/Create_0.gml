var __b__;
__b__ = action_if_number(Ship, 0, 2);
if __b__
{
{
action_set_motion(point_direction(x,y,Ship.x,Ship.y)+error_angle(), 4+score/3000*global.diffLevel);
}
}
action_parttype_speed(0, 1, 4, direction-5, direction+5, 0);
action_partemit_create(0, 0, x-4, x+4, y-4, y+4);
action_partemit_burst(0, 0, 30);
