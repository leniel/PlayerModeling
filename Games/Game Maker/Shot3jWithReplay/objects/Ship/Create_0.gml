
_kLeft   = false;
_kRight  = false;
_kUp     = false;
_kDown   = false;
_kAction = false;

action_set_relative(0);

action_set_alarm(90, 1);

indestrutivel = 1;
{
  action_set_relative(1);
  action_effect(1, 27, 26, 2, 65280, 0);
  action_set_relative(0);
}

canShot = 1;

quantosIndestrutiveis = 3;

congela = 3;

action_set_relative(0);