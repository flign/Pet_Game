using System;
using System.Collections.Generic;
using System.Text;

namespace Pet_Game.Services
{
    public class ConsoleUIService
    {
        private readonly MapService _mapService;
        private readonly PetService _petService;

        public ConsoleUIService(MapService mapService, PetService petService)
        {
            _mapService = mapService;
            _petService = petService;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
        public int GetInput()
        {
            bool success = int.TryParse(Console.ReadLine(), out int input);

            if (!success)
                PrintMessage(Constants.invalidParameterMessage);
            return input;
        }
        
    }
}
