using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Theseus
{
    [Serializable]
    public class GameEngineConsole : IGameEngine
    {
        private static Dictionary<Color, ConsoleColor> _colorMap;
        private static Color _defaultForeground;
        private static Color _defaultBackground;

        static GameEngineConsole() {
            _defaultBackground = Color.Black;
            _defaultForeground = Color.White;

            _colorMap = new Dictionary<Color, ConsoleColor>() {
                { Color.Black, ConsoleColor.Black },
                { Color.Blue, ConsoleColor.Blue },
                { Color.Cyan, ConsoleColor.Cyan },
                { Color.DarkBlue, ConsoleColor.DarkBlue },
                { Color.DarkCyan, ConsoleColor.DarkCyan },
                { Color.DarkGray, ConsoleColor.DarkGray },
                { Color.DarkGreen, ConsoleColor.DarkGreen },
                { Color.DarkMagenta, ConsoleColor.DarkMagenta },
                { Color.DarkRed, ConsoleColor.DarkRed },
                { Color.DarkOrange, ConsoleColor.DarkYellow }, // c'est voulu
                { Color.Gray, ConsoleColor.Gray },
                { Color.Green, ConsoleColor.Green },
                { Color.Magenta, ConsoleColor.Magenta },
                { Color.Red, ConsoleColor.Red },
                { Color.White, ConsoleColor.White },
                { Color.Yellow, ConsoleColor.Yellow },
            };
        }

        public void Draw(System.Drawing.Point coord, char c)
        {
            Draw(coord, c, _defaultForeground, _defaultBackground);
        }

        public void Draw(System.Drawing.Point coord, char c, Color foreground, Color background)
        {
            ConsoleColor fc = (_colorMap.ContainsKey(foreground)) 
                ? _colorMap[foreground]
                : _colorMap[_defaultForeground];

            ConsoleColor bc = (_colorMap.ContainsKey(background)) 
                ? _colorMap[background]
                : _colorMap[_defaultBackground];

            Console.BackgroundColor = bc;
            Console.ForegroundColor = fc;
            Console.SetCursorPosition(coord.Y, coord.X);
            Console.Write(c);
        }
    }
}
