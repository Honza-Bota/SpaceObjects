using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace SpaceObjects.Model
{
    class Objects
    {
        public ObservableCollection<Object> AllObjects { get; set; }

        public Objects()
        {
            AllObjects = new ObservableCollection<Object>();

            AllObjects.Add(new Object { Name = "Slunce",    Type = "star",  Age = 20210500 });
            AllObjects.Add(new Object { Name = "Merkur",    Type = "planet", Age = 15208 });
            AllObjects.Add(new Object { Name = "Venuše",    Type = "planet", Age = 2524521 });
            AllObjects.Add(new Object { Name = "Země",      Type = "planet", Age = 3251145 });
            AllObjects.Add(new Object { Name = "Mars",      Type = "planet", Age = 28514 });
            AllObjects.Add(new Object { Name = "Jupiter",   Type = "planet", Age = 182984 });
            AllObjects.Add(new Object { Name = "Saturn",    Type = "planet", Age = 24894511 });
            AllObjects.Add(new Object { Name = "Uran",      Type = "planet", Age = 3559844 });
            AllObjects.Add(new Object { Name = "Neptun",    Type = "planet", Age = 355474 });

            AllObjects.Add(new Object { Name = "Ceres",     Type = "exoplanet", Age = 353384 });
            AllObjects.Add(new Object { Name = "Pluto",     Type = "exoplanet", Age = 3571517 });
            AllObjects.Add(new Object { Name = "Haumea",    Type = "exoplanet", Age = 3538487 });
            AllObjects.Add(new Object { Name = "Makemake",  Type = "exoplanet", Age = 3565191 });
            AllObjects.Add(new Object { Name = "Eris",      Type = "exoplanet", Age = 35118 });

            AllObjects.Add(new Object { Name = "Hubbleův teleskop",             Type = "space_probe",   Age = 30 });
            AllObjects.Add(new Object { Name = "Mezinárodní vesmírná stanice",  Type = "space_station", Age = 22 });

        }
    }
}
