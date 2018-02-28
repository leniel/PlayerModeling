var __b__;

__b__ = action_if_number(Ship, 0, 2);

if __b__
{
{
  action_create_object(Disk, 640 * irandom(1), random(240));
  
  action_set_alarm(random(300) + 1, 3);
}
}
