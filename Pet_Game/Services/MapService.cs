using Pet_Game.Models;
using System;
using System.Collections.Generic;

namespace Pet_Game.Services
{
    public class MapService
    {
        public List<Map> MapList { get; set; }

        public MapService()
        {
            MapList = new List<Map>();
        }
        public void AddMap(string mode, int mapX, int mapY)
        {
            if (mode == "easy") mode = "Easy";
            if (mode == "normal") mode = "Normal";
            if (mode == "hard") mode = "Hard";
            if (mode != "Easy"|| mode != "Normal" || mode != "Hard")
            {
                Console.WriteLine(Constants.invalidParameterMessage);
                return;
            }
            Map map = new Map(mode, mapX, mapY);
            MapList.Add(map);
        }
        public void DeleteMap(Map map)
        {
            MapList.Remove(map);
        }
        public string GetMapData()
        {
            string mapData = string.Empty;

            foreach (Map map in MapList)
            {
                mapData += string.Format($"{map.Mode},{map.MapX},{map.MapY}\n");
            }

            return mapData;
        }
    }
}
