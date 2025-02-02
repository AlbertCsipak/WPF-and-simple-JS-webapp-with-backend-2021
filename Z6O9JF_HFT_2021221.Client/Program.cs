﻿namespace Z6O9JF_HFT_2021221.Client
{
    class Program
    {
        static void Init()
        {
            RestService restService = new("http://localhost:11111");

            Menu menu = new();

            UIMethods ui = new();

            menu.write += ui.Writer;
            menu.writeLine += ui.LineWriter;
            menu.uiInput += ui.UIConsoleInput;
            menu.cursorPos += ui.CursorPos;
            menu.cursorVis += ui.CursorVis;
            menu.consoleClear += ui.ConsoleClear;

            menu.Start(restService);
        }
        static void Main(string[] args)
        {
            Init();
        }
    }
}
