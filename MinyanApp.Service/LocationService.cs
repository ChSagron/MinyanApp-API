using MinyanApp.Core.Entities;
using MinyanApp.Core.Repositories;
using MinyanApp.Core.Services;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinyanApp.Service
{
    public class LocationService : ILocationService
    {

        private readonly ISynagogueRepository _synagogueRepository;

        private readonly IMinyanRepository _minyanRepository;

        private readonly ILocationRepository _locationRepository;


        public LocationService(ISynagogueRepository synagogueRepository, IMinyanRepository minyanRepository, ILocationRepository locationRepository)
        {
            _synagogueRepository = synagogueRepository;
            _minyanRepository = minyanRepository;
            _locationRepository = locationRepository;
        }



        // Calculate distance between points
        public double CalculateDistance(Core.Entities.Location l1, Core.Entities.Location l2)
        {
            var point1 = new Point(l1.Latitude, l1.Longitude);
            var point2 = new Point(l2.Latitude, l2.Longitude);

            return point1.Distance(point2);


            //without NetTopologySuite
            //var d1 = point1.Latitude * (Math.PI / 180.0);
            //var num1 = point1.Longitude * (Math.PI / 180.0);
            //var d2 = point2.Latitude * (Math.PI / 180.0);
            //var num2 = point2.Longitude * (Math.PI / 180.0) - num1;
            //var d3 = Math.Pow(Math.Sin((d2 - d1) / 2.0), 2.0) +
            //         Math.Cos(d1) * Math.Cos(d2) * Math.Pow(Math.Sin(num2 / 2.0), 2.0);
            //return 6376500.0 * (2.0 * Math.Atan2(Math.Sqrt(d3), Math.Sqrt(1.0 - d3)));
        }

        public IEnumerable<Synagogue> GetTop10Synagogue(Core.Entities.Location current /*, List<Synagogue> list*/)
        {
            // Return the list sorted by distance
            var list = _synagogueRepository.GetAll();
            foreach (var item in list)
            {
                _locationRepository.SetDistance(item.Id, CalculateDistance(current, item.Location));
                //item.Location.Distance = CalculateDistance(current, item.Location);
            }
            return list.OrderBy(synagogue => synagogue.Location.Distance).Take(10);
        }



        //without prop of distance
        //var locationsWithDistance = list.Select(
        //synagogue.Location => new Location
        //{
        //    Latitude = synagogue.Location.Latitude,
        //    Longitude = synagogue.Location.Longitude,
        //    Distance = CalculateDistance(current, synagogue.Location)
        //}).OrderBy(synagogue.Location => location.Distance);

    }
}
