{
var a,maxa,max_angle;
maxa=min(global.max_angle*global.standard_score/max(score*global.diffLevel,1),global.max_angle);
a=random(maxa);
return a-maxa/2
}
