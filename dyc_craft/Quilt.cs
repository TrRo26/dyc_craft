using System;
using System.Collections;
using System.Collections.Generic;

namespace dyc_craft
{
    public class Quilt
    {
        public int Id { get; set; }
        public int DisplayOrder { get; set; }
        public string Name { get; set; }
        public string OriginDate { get; set; }
        public string Dimensions { get; set; }
        public string Description { get; set; }
        public string LocaleOfInspiration { get; set; }
        public string MaterialAndTechnique { get; set; }
        public string ArtistName { get; set; }
        public string ImageURL { get; set; }

        public static object QuiltsDB()
        {
            var quilts = new List<Quilt>
            {
                new Quilt {
                    Id = 1,
                    DisplayOrder = 1,
                    Name = "Canadian Tranquility (AKA TestQuilt.jpg)",
                    OriginDate = "2020/01/01",
                    Dimensions = "5 x 9",
                    Description = "Quilt of Canadian backcountry",
                    LocaleOfInspiration = "Canada",
                    MaterialAndTechnique = "Hand basted, machine sewn",
                    ArtistName = "Darley Clevenger",
                    ImageURL = "~/Content/Images/TestQuilt.jpg"
                },
                new Quilt {
                    Id = 2,
                    DisplayOrder = 2,
                    Name = "United States Rivers",
                    OriginDate = "2015/05/05",
                    Dimensions = "3 x 6",
                    Description = "Quilt of a US river",
                    LocaleOfInspiration = "US",
                    MaterialAndTechnique = "Hand basted, machine sewn",
                    ArtistName = "Darley Clevenger",
                    ImageURL = "/?"
                }
            };
            return quilts;
        }
    }
}
