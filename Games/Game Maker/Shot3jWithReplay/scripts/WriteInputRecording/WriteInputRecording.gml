/// @author Alejandro Hitti
/// @description Writes the input sequence to a file

var file = file_text_open_write(argument0);

for (var i = 0; i < array_height_2d(_inputSequence); ++i)
{
    file_text_write_real(file, _inputSequence[i, 0]); // frame
    file_text_write_real(file, _inputSequence[i, 1]); // key pressed
    file_text_writeln(file);
}

_inputSequence = 0;

file_text_close(file);

game_restart();
