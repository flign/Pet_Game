using Pet_Game.Models;
using System;
using System.Collections.Generic;

namespace Pet_Game.Services
{
    public class PetService
    {
        public List<Pet> PetList { get; set; }

        public PetService()
        {
            PetList = new List<Pet>();
        }
        public void AddPet(string name, int bonusLuck)
        {
            if (PetList.Any(s => s.Name == name))
            {
                Console.WriteLine(Constants.invalidParameterMessage);
                return;
            }
            Pet pet = new Pet(name, bonusLuck);
            PetList.Add(pet);
        }
        public void DeletePet(Pet pet)
        {
            PetList.Remove(pet);
        }
    }
}
