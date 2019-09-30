using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class EventProcessor
    {
        public static int CreateEvent(string eventName, DateTime startDate, string location, string info)
        {
            EventModel data = new EventModel
            {
                EventName = eventName,
                StartDate = startDate,
                Location = location,
                Info = info
            };

            string sql = @"insert into dbo.Event (EventName, StartDate, Location, Info)
                            values (@EventName, @StartDate, @Location, @Info);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<EventModel> LoadEvents()
        {
            string sql = @"select Id, EventName, StartDate, Location, Info
                            from dbo.Event;";

            return SqlDataAccess.LoadData<EventModel>(sql);
        }

        public static List<EventModel>  LoadEventById(int id)
        {
            string sql = $"select Id    , EventName, StartDate, Location, Info " +
                $"from dbo.Event where id = {id};";

            return SqlDataAccess.LoadData<EventModel>(sql);
        }
    }
}
