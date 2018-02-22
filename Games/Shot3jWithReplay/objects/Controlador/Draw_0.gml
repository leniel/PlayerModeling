action_set_relative(1);

action_font(Letras, 0);

action_color(8454143);

action_draw_score(0, 0, "Score: ");

action_draw_life_images(450, 0, sprNave);

var __b__;

__b__ = action_if_variable(global.debug, 0, 2);

if __b__
{
{
{
action_set_relative(0);
//action_draw_variable(Raiz.instance_count, 100, 100);
action_set_relative(1);
}
{

action_set_relative(0);

action_draw_variable(global.teste1, 100, 150);

action_set_relative(1);
}
}
}

action_set_relative(0);
