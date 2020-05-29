using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

//https://stackoverflow.com/questions/26157154/store-data-in-array-object-struct-list-or-class-c-sharp/26157240

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

        public static List<Quilt> QuiltsDB()
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
                    ImageURL = "~/Content/Images/lake_trees.jpg"
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
                    ImageURL = "~/Content/Images/stream_flowers_no_background.png"
                },
                new Quilt {
                    Id = 3,
                    DisplayOrder = 3,
                    Name = "Abstractia",
                    OriginDate = "2030/010/10",
                    Dimensions = "2 x 16",
                    Description = "Like nothing you've ever seen before",
                    LocaleOfInspiration = "The deepest void of the human mind",
                    MaterialAndTechnique = "Telekinesis",
                    ArtistName = "The Profit",
                    ImageURL = "~/Content/Images/no_image.png"
                }
            };

            List<Quilt> quiltsSortedByDisplayOrder = quilts.OrderBy(o => o.DisplayOrder).ToList();

            return quiltsSortedByDisplayOrder;
        }
    }
}
