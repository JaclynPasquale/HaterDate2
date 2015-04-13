namespace HaterDate2.Migrations
{
    using HaterDate2.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HaterDate2.Data.HaterDateContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            //Switch this after development
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "HaterDate2.Data.HaterDateContext";
        }

        protected override void Seed(HaterDate2.Data.HaterDateContext context)
        {
            context.Hates.AddOrUpdate(i => i.Id,
                new Hate
                {
                    Description = "Dave Matthews Band"
                },
                new Hate
                {
                    Description = "Patchouli"
                },
                new Hate 
                {
                    Description = "Dudes in skinny jeans"
                },
                new Hate
                {
                    Description = "Camping"
                },
                new Hate
                {
                    Description = "Cats"
                }
            );
        }
    }
}
