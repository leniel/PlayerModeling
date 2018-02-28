/// @author Leniel Macaferi
/// @description Insert description here

// Exit the game if ESC is pressed
if (keyboard_check(vk_escape))
    game_end();
    
// Restart the room if F5 is pressed
if (keyboard_check(vk_f5))
    room_restart();