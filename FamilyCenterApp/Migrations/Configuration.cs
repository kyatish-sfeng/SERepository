namespace FamilyCenterApp.Migrations
{
    using FamilyCenterApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FamilyCenterApp.Models.FamilyCenterAppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "FamilyCenterApp.Models.FamilyCenterAppContext";
        }

        protected override void Seed(FamilyCenterApp.Models.FamilyCenterAppContext context)
        {
            //context.RelationshipModels.AddOrUpdate(new RelationshipModel()
            //{
            //    RelationshipId=1,
            //    RelationshipText = "Mother"
            //});
            //context.RelationshipModels.AddOrUpdate(new RelationshipModel()
            //{
            //    RelationshipId = 2,
            //    RelationshipText = "Father"
            //});
            //context.RelationshipModels.AddOrUpdate(new RelationshipModel()
            //{
            //    RelationshipId = 3,
            //    RelationshipText = "Spouse"
            //});
            //context.RelationshipModels.AddOrUpdate(new RelationshipModel()
            //{
            //    RelationshipId = 4,
            //    RelationshipText = "Son"
            //});
            //context.RelationshipModels.AddOrUpdate(new RelationshipModel()
            //{
            //    RelationshipId = 5,
            //    RelationshipText = "Daughter"
            //});
            //context.RelationshipModels.AddOrUpdate(new RelationshipModel()
            //{
            //    RelationshipId = 6,
            //    RelationshipText = "Relative"
            //});
            //context.RelationshipModels.AddOrUpdate(new RelationshipModel()
            //{
            //    RelationshipId = 7,
            //    RelationshipText = "US Holiday"
            //});

            context.CalendarModels.AddOrUpdate(new CalendarModel()
            {
                EventDate = new DateTime(2015, 10, 30),
                EventText = "John Doe's Birthday",
                TimeStamp = new DateTime(2015, 9, 15)
                //RelationshipId=4
            });
            context.CalendarModels.AddOrUpdate(new CalendarModel()
            {
                EventDate = new DateTime(2015, 9, 30),
                EventText = "Jane Doe's Birthday",
                TimeStamp = new DateTime(2015, 9, 15)
                //RelationshipId=1
            });
            context.CalendarModels.AddOrUpdate(new CalendarModel()
            {
                EventDate = new DateTime(2015, 10, 12),
                EventText = "Columbus Day",
                TimeStamp = new DateTime(2015, 9, 30)
                //RelationshipId=7
            });
            context.CalendarModels.AddOrUpdate(new CalendarModel()
            {
                EventDate = new DateTime(2015, 10, 31),
                EventText = "Halloween",
                TimeStamp = new DateTime(2015, 10, 1)
                //RelationshipId = 7
            });

            base.Seed(context);
        }
    }
}
