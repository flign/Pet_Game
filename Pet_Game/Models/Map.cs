namespace Pet_Game.Models
{
    public class Map
    {
        public string Mode { get; set; }
        public int MapX { get; set; }
        public int MapY { get; set; }
        public Map(string Mode, int MapX, int MapY)
        {
            this.Mode = this.Mode;
            this.MapX = this.MapX;
            this.MapY = this.MapY;
        }
    }
}
