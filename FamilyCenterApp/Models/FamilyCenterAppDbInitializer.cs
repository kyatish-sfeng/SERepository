using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FamilyCenterApp.Models
{
    public class FamilyCenterAppDbInitializer : DropCreateDatabaseIfModelChanges<FamilyCenterAppContext>
    {
        protected override void Seed(FamilyCenterAppContext context)
        {
            context.CalendarModels.Add(new CalendarModel()
            {
                EventDate = new DateTime(2015, 10, 30),
                EventText = "John Doe's Birthday",
                TimeStamp = new DateTime(2015, 9, 15)
            });
            context.CalendarModels.Add(new CalendarModel()
            {
                EventDate = new DateTime(2015, 9, 30),
                EventText = "Jane Doe's Birthday",
                TimeStamp = new DateTime(2015, 9, 15)
            });
            context.CalendarModels.Add(new CalendarModel()
            {
                EventDate = new DateTime(2015, 10, 12),
                EventText = "Columbus Day",
                TimeStamp = new DateTime(2015, 9, 30)
            });
            context.CalendarModels.Add(new CalendarModel()
            {
                EventDate = new DateTime(2015, 10, 31),
                EventText = "Halloween",
                TimeStamp = new DateTime(2015, 10, 1)
            });
            base.Seed(context);
        }
    }
}