namespace OwnershipApp.MAUI.Models
{
    public class PropertyRepo
    {
        public static List<Property> AllProperties = new List<Property>
        {
            new Property
            {
                DefaultImage = "https://cdn.pixabay.com/photo/2017/04/10/22/28/residence-2219972_1280.jpg",
                Address = "Manhattan, New York",
                Price = 350550,
                Images = new List<string>
                {
                    "https://cdn.pixabay.com/photo/2016/12/30/07/59/kitchen-1940174_1280.jpg",
                    "https://cdn.pixabay.com/photo/2020/06/25/10/21/architecture-5339245_1280.jpg",
                    "https://cdn.pixabay.com/photo/2021/10/03/03/48/living-room-6676758_1280.jpg"
                }
            },

            new Property
            {
                DefaultImage = "https://cdn.pixabay.com/photo/2016/11/29/03/53/house-1867187_1280.jpg",
                Address = "Queens, New York",
                Price = 550950,
                Images = new List<string>
                {
                    "https://cdn.pixabay.com/photo/2016/11/18/17/20/living-room-1835923_1280.jpg",
                    "https://cdn.pixabay.com/photo/2019/05/24/11/00/interior-4226020_1280.jpg",
                    "https://cdn.pixabay.com/photo/2018/01/11/21/50/contemporary-3077021_1280.jpg"
                }
            },

            new Property
            {
                DefaultImage = "https://cdn.pixabay.com/photo/2017/07/18/03/50/sgt-2514669_1280.jpg",
                Address = "Williamsburg, New York",
                Price = 291000,
                Images = new List<string>
                {
                    "https://cdn.pixabay.com/photo/2016/09/19/17/20/home-1680800_1280.jpg",
                    "https://cdn.pixabay.com/photo/2017/08/27/10/16/interior-2685521_960_720.jpg",
                    "https://cdn.pixabay.com/photo/2014/12/27/14/37/living-room-581073_1280.jpg"
                }
            },

            new Property
            {
                DefaultImage = "https://cdn.pixabay.com/photo/2017/09/02/13/21/guggenheim-museum-2707258_1280.jpg",
                Address = "Jersey City, New York",
                Price = 1500000,
                Images = new List<string>
                {
                    "https://cdn.pixabay.com/photo/2018/06/01/18/23/bilbao-3446931_1280.jpg",
                    "https://cdn.pixabay.com/photo/2019/07/21/18/15/museum-4353303_1280.jpg",
                    "https://cdn.pixabay.com/photo/2014/09/23/23/25/museum-458321_1280.jpg",
                }
            },

            new Property
            {
                DefaultImage = "https://cdn.pixabay.com/photo/2016/06/24/10/47/house-1477041_1280.jpg",
                Address = "Island Park, New York",
                Price = 733000,
                Images = new List<string>
                {
                    "https://cdn.pixabay.com/photo/2018/06/01/18/23/bilbao-3446931_1280.jpg",
                    "https://cdn.pixabay.com/photo/2019/07/21/18/15/museum-4353303_1280.jpg",
                    "https://cdn.pixabay.com/photo/2020/04/17/12/28/pool-5055009_1280.jpg",
                }
            },

            new Property
            {
                DefaultImage = "https://cdn.pixabay.com/photo/2020/05/08/15/39/new-york-5146247_1280.jpg",
                Address = "Brooklyn, New York",
                Price = 410200,
                Images = new List<string>
                {
                    "https://cdn.pixabay.com/photo/2017/03/28/12/10/chairs-2181947_1280.jpg",
                    "https://cdn.pixabay.com/photo/2016/11/19/11/36/chairs-1838776_1280.jpg",
                    "https://cdn.pixabay.com/photo/2017/03/19/01/43/living-room-2155376_1280.jpg",
                }
            }
        };
    }
}
