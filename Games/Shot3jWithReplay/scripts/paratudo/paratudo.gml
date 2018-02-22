{

   for (i = 0; i < instance_count; i += 1)
   {
     iii = instance_find(Meteor, i);
     
	 if(iii == noone)
	   break;
     
	 iii.hspeed=0;
     iii.vspeed=0;
   }
   
}

      
