﻿namespace RiotApi.Net.RestClient.Helpers
{
    /// <summary>
    /// All enumerations for the REST api needs
    /// </summary>
    public class Enums
    {
        public enum GameMode
        {
            CLASSIC,
            ODIN,
            ARAM,
            TUTORIAL,
            ONEFORALL,
            ASCENSION,
            FIRSTBLOOD,
            KINGPORO
        }

        public enum GameType
        {
            CUSTOM_GAME,
            MATCHED_GAME,
            TUTORIAL_GAME
        }
    }
}