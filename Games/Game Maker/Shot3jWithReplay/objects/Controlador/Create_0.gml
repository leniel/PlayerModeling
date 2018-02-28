random_set_seed(7);

// Setting variables
global.frame = 0;
global.bonus = 0;
global.standard_score = 5000;
global.debug = 0;
global.max_angle = 90;
global.teste1 = 0;
action_set_life(2); // 2 lifes
action_set_score(0);
action_set_alarm(30, 0);
action_set_alarm(random(300), 3);
action_set_alarm(random(400), 4);
action_partsyst_create(0);
action_parttype_create(0, 8, -1, .2, .2, 0);
action_parttype_color(0, 1, 255, 65535, 1, 1);
action_parttype_life(0, 10, 30);
action_parttype_create(1, 4, -1, .05, .15, 0);
action_parttype_speed(1, 5, 20, 270, 270, 0);
action_partemit_create(1, 3, 0, 640, 0, 1);
action_partemit_stream(1, 1, -5);
action_timeline_set(tlTimeBonus, 0, 0, 1);
action_set_score(0);
