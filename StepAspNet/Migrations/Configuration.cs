namespace StepAspNet.Migrations
{
    using StepAspNet.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StepAspNet.Models.QuestContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StepAspNet.Models.QuestContext context)
        {
            if(!context.QuestList.Any())
            {
                context.QuestList.Add(new Quest { Id = 1, Title = "DIAMOND HEIST", Description = "Think you’ve got what it takes to be the world’s greatest thief?", DifficultyLevel = 3, TeamNum = "5-12", Duration = 60, Address = "Almaty", Company = "BestQuest", Email = "questala@gmail.com", PlayerAge = 16, Phone = "+77772558786", Raiting = 5.5, FearLevel = 2, LogoImg = "https://i.pinimg.com/originals/5a/6b/e6/5a6be6119649810b3f17eea492e2ec46.jpg", Images = new List<string>() { "https://i.pinimg.com/originals/5a/6b/e6/5a6be6119649810b3f17eea492e2ec46.jpg" } });
                context.QuestList.Add(new Quest { Id = 2, Title = "CURSED CASTLE", Description = "Can you save the kingdom from eternal darkness?", DifficultyLevel = 4, TeamNum = "6-15", Duration = 60, Address = "Almaty", Company = "BestQuest", Email = "questala@gmail.com", PlayerAge = 16, Phone = "+77772558786", Raiting = 5.5, FearLevel = 2, LogoImg = "https://images.pexels.com/photos/316080/pexels-photo-316080.jpeg?cs=srgb&dl=pexels-pixabay-316080.jpg&fm=jpg", Images = new List<string>() { "https://images.pexels.com/photos/316080/pexels-photo-316080.jpeg?cs=srgb&dl=pexels-pixabay-316080.jpg&fm=jpg" } });
                context.QuestList.Add(new Quest { Id = 3, Title = "TAKEN", Description = "Can you escape before it's too late?", DifficultyLevel = 5, TeamNum = "2-10", Duration = 60, Address = "Almaty", Company = "BestQuest", Email = "questala@gmail.com", PlayerAge = 18, Phone = "+77772558786", Raiting = 5.5, FearLevel = 5, LogoImg = "https://vedtver.ru/wp-content/uploads/2021/07/71f5f2f9b23a.jpg", Images = new List<string>() { "https://vedtver.ru/wp-content/uploads/2021/07/71f5f2f9b23a.jpg" } });
                context.SaveChanges();
            }
        }
    }
}
