using Microsoft.Extensions.Configuration;
using Npgsql;
using ProgrammeringMotDatabaser.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringMotDatabaser.Models
{
    internal class Animal
    {
        
        public int AnimalId { get; set; } 
                                              
        /// <summary>
        /// the name of the animal, can be null
        /// </summary>
        public string CharacterName { get; set; }

        public AnimalSpecie AnimalSpecie { get; set; }


        #region DisplayMemberPath
    
        public string CountAnimalsInClass => $"Class: {AnimalSpecie.AnimalClass.AnimalClassName} Count: {AnimalId}";

        public string CountAnimalInEachSpecie => $"Specie: {AnimalSpecie.AnimalSpecieName} Count: {AnimalId}";

        public string AllAnimals => $"Charactername: {CharacterName}, Specie: {AnimalSpecie.AnimalSpecieName}, Latin name: {AnimalSpecie.LatinName}, Class: {AnimalSpecie.AnimalClass.AnimalClassName}";

        public string AnimalsInEachClass => $"Animal id: {AnimalId}, Specie: {AnimalSpecie.AnimalSpecieName}, Class: {AnimalSpecie.AnimalClass.AnimalClassName}";

        public string DeletedAnimals => $"Animal id: {AnimalId}, Charactername: {CharacterName}, Specie: {AnimalSpecie.AnimalSpecieName}";

        public string AnimalsInClass => $"Animal id: {AnimalId}, Charactername: {CharacterName}, Specie: {AnimalSpecie.AnimalSpecieName} Class: {AnimalSpecie.AnimalClass.AnimalClassName}";

        #endregion



    }

    
}
