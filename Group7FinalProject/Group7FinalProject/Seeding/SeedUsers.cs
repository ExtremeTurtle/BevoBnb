
using Microsoft.AspNetCore.Identity;
using Group7FinalProject.DAL;
using Group7FinalProject.Models;
using System.Threading.Tasks;
using Group7FinalProject.Utilities;

namespace Group7FinalProject.Seeding
{
    public static class SeedUsers
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            // Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "cbaker@freezing.co.uk",
                    Email = "cbaker@freezing.co.uk",
                    PhoneNumber = "5125595133",
                    FirstName = "Christopher",
                    LastName = "Baker",
                    Address = "1245 Lake America Blvd.",
                    Birthday = new DateTime(1968, 11, 28),
                    HireStatus = HireStatus.Employed
                },
                Password = "hellothere",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mb@puppy.com",
                    Email = "mb@puppy.com",
                    PhoneNumber = "2102702860",
                    FirstName = "Michelle",
                    LastName = "Bradicus",
                    Address = "1300 Small Pine Lane",
                    Birthday = new DateTime(1988, 02, 07),
                    HireStatus = HireStatus.Employed
                },
                Password = "555533",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "fd@puppy.com",
                    Email = "fd@puppy.com",
                    PhoneNumber = "8175683686",
                    FirstName = "Franco",
                    LastName = "Broccoli",
                    Address = "62 Cookie Rd",
                    Birthday = new DateTime(1999, 11, 07),
                    HireStatus = HireStatus.Employed
                },
                Password = "666645",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "wendy@puppy.com",
                    Email = "wendy@puppy.com",
                    PhoneNumber = "5125967209",
                    FirstName = "Wendy",
                    LastName = "Charile",
                    Address = "202 Bellmoth Hall",
                    Birthday = new DateTime(1992, 10, 27),
                    HireStatus = HireStatus.Employed
                },
                Password = "Kansas",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "limchou@puppy.com",
                    Email = "limchou@puppy.com",
                    PhoneNumber = "2107748586",
                    FirstName = "Lim",
                    LastName = "Chou",
                    Address = "1600 Barbara Lane",
                    Birthday = new DateTime(1961, 11, 11),
                    HireStatus = HireStatus.Employed
                },
                Password = "Rockwall",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "444444.Dave@aool.com",
                    Email = "444444.Dave@aool.com",
                    PhoneNumber = "2142667242",
                    FirstName = "Shan",
                    LastName = "Dave",
                    Address = "234 Puppy Circle",
                    Birthday = new DateTime(1972, 12, 19),
                    HireStatus = HireStatus.Employed
                },
                Password = "444444",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "louann@puppy.com",
                    Email = "louann@puppy.com",
                    PhoneNumber = "8172580736",
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    Address = "700 S 9th Street W",
                    Birthday = new DateTime(1958, 08, 01),
                    HireStatus = HireStatus.Employed
                },
                Password = "longhorns",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tfreeley@puppy.com",
                    Email = "tfreeley@puppy.com",
                    PhoneNumber = "8173279674",
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    Address = "4334 Meanview Ave.",
                    Birthday = new DateTime(2001, 07, 12),
                    HireStatus = HireStatus.Employed
                },
                Password = "puppies",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mgar@puppy.com",
                    Email = "mgar@puppy.com",
                    PhoneNumber = "8176617531",
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    Address = "594 Puppyview",
                    Birthday = new DateTime(1956, 11, 17),
                    HireStatus = HireStatus.Employed
                },
                Password = "horses",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    PhoneNumber = "2148499570",
                    FirstName = "Charles",
                    LastName = "Harley",
                    Address = "One Ranger Pkwy",
                    Birthday = new DateTime(1998, 05, 29),
                    HireStatus = HireStatus.Employed
                },
                Password = "mycats",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "wjhearniii@umch.edu",
                    Email = "wjhearniii@umch.edu",
                    PhoneNumber = "2148989608",
                    FirstName = "John",
                    LastName = "Hearn",
                    Address = "4445 South First",
                    Birthday = new DateTime(1983, 12, 29),
                    HireStatus = HireStatus.Employed
                },
                Password = "posicles",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "hicks43@puppy.com",
                    Email = "hicks43@puppy.com",
                    PhoneNumber = "2105812952",
                    FirstName = "Mark",
                    LastName = "Hicks",
                    Address = "32 NE Mark Ln., Ste 910",
                    Birthday = new DateTime(1989, 12, 16),
                    HireStatus = HireStatus.Employed
                },
                Password = "guac45",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "bradsingram@mall.utexas.edu",
                    Email = "bradsingram@mall.utexas.edu",
                    PhoneNumber = "5124702808",
                    FirstName = "Brad",
                    LastName = "Ingram",
                    Address = "6548 La Chess St.",
                    Birthday = new DateTime(1958, 09, 18),
                    HireStatus = HireStatus.Employed
                },
                Password = "father",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "father.Ingram@aool.com",
                    Email = "father.Ingram@aool.com",
                    PhoneNumber = "5124677352",
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    Address = "4564 Palm St.",
                    Birthday = new DateTime(1975, 12, 09),
                    HireStatus = HireStatus.Employed
                },
                Password = "555897",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "victoria@puppy.com",
                    Email = "victoria@puppy.com",
                    PhoneNumber = "5129481386",
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    Address = "6639 Butterfly Ln.",
                    Birthday = new DateTime(1981, 05, 29),
                    HireStatus = HireStatus.Employed
                },
                Password = "something",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "lineback@flush.net",
                    Email = "lineback@flush.net",
                    PhoneNumber = "2102473963",
                    FirstName = "Brad",
                    LastName = "Lineback",
                    Address = "1300 Pirateland St",
                    Birthday = new DateTime(1973, 05, 19),
                    HireStatus = HireStatus.Employed
                },
                Password = "treelover",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",
                    PhoneNumber = "2105368614",
                    FirstName = "Evan",
                    LastName = "Lowe",
                    Address = "3201 Pineapple Drive",
                    Birthday = new DateTime(1993, 06, 07),
                    HireStatus = HireStatus.Employed
                },
                Password = "headear",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "luce_chuck@puppy.com",
                    Email = "luce_chuck@puppy.com",
                    PhoneNumber = "2107007535",
                    FirstName = "Chuck",
                    LastName = "Luce",
                    Address = "2345 Silent Clouds",
                    Birthday = new DateTime(1995, 06, 11),
                    HireStatus = HireStatus.Employed
                },
                Password = "gooseyloosey",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mackcloud@pimpdaddy.com",
                    Email = "mackcloud@pimpdaddy.com",
                    PhoneNumber = "5124772125",
                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    Address = "2504 Far East Blvd.",
                    Birthday = new DateTime(1965, 10, 11),
                    HireStatus = HireStatus.Employed
                },
                Password = "rainyday",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "liz@puppy.com",
                    Email = "liz@puppy.com",
                    PhoneNumber = "5124603832",
                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    Address = "7861 Chevy Mace Rd",
                    Birthday = new DateTime(1989, 06, 18),
                    HireStatus = HireStatus.Employed
                },
                Password = "ember22",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "mclarence@puppy.com",
                    Email = "mclarence@puppy.com",
                    PhoneNumber = "8174979188",
                    FirstName = "Clarence",
                    LastName = "Martin",
                    Address = "87 Alcedo St.",
                    Birthday = new DateTime(1984, 04, 28),
                    HireStatus = HireStatus.Employed
                },
                Password = "lamemartin",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "lamemartin.Martin@aool.com",
                    Email = "lamemartin.Martin@aool.com",
                    PhoneNumber = "8178770705",
                    FirstName = "Gregory",
                    LastName = "Martinez",
                    Address = "8295 Moon Blvd.",
                    Birthday = new DateTime(1981, 12, 27),
                    HireStatus = HireStatus.Employed
                },
                Password = "gregory",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "cmiller@mapster.com",
                    Email = "cmiller@mapster.com",
                    PhoneNumber = "8177482602",
                    FirstName = "Charles",
                    LastName = "Miller",
                    Address = "8962 Side St.",
                    Birthday = new DateTime(1987, 05, 05),
                    HireStatus = HireStatus.Employed
                },
                Password = "mucky44",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "nelson.Kelly@puppy.com",
                    Email = "nelson.Kelly@puppy.com",
                    PhoneNumber = "5122950953",
                    FirstName = "Kelly",
                    LastName = "Nelson",
                    Address = "2601 Green River",
                    Birthday = new DateTime(1969, 08, 03),
                    HireStatus = HireStatus.Employed
                },
                Password = "Tree34",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "jojoe@puppy.com",
                    Email = "jojoe@puppy.com",
                    PhoneNumber = "2143149884",
                    FirstName = "Joe",
                    LastName = "Nguyen",
                    Address = "1249 4th NW St.",
                    Birthday = new DateTime(1956, 02, 06),
                    HireStatus = HireStatus.Employed
                },
                Password = "jvb485bg",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",
                    PhoneNumber = "2103474912",
                    FirstName = "Bill",
                    LastName = "O'Reilly",
                    Address = "8800 Gringo Drive",
                    Birthday = new DateTime(1989, 03, 14),
                    HireStatus = HireStatus.Employed
                },
                Password = "Bobbygirl",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "or@puppy.com",
                    Email = "or@puppy.com",
                    PhoneNumber = "2142369553",
                    FirstName = "Anka",
                    LastName = "Radkovich",
                    Address = "1300 Freaky",
                    Birthday = new DateTime(1952, 10, 26),
                    HireStatus = HireStatus.Employed
                },
                Password = "radioactive",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",
                    PhoneNumber = "5123768733",
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    Address = "4587 Rightfield Rd.",
                    Birthday = new DateTime(1958, 03, 18),
                    HireStatus = HireStatus.Employed
                },
                Password = "gopigs",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "erynrice@puppy.com",
                    Email = "erynrice@puppy.com",
                    PhoneNumber = "5123900644",
                    FirstName = "Eryn",
                    LastName = "Rice",
                    Address = "3405 Rio Small",
                    Birthday = new DateTime(2000, 11, 02),
                    HireStatus = HireStatus.Employed
                },
                Password = "iloveme",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "jorge@hootmail.com",
                    Email = "jorge@hootmail.com",
                    PhoneNumber = "8178928361",
                    FirstName = "Jorge",
                    LastName = "Rodriguez",
                    Address = "6788 Cotten Street",
                    Birthday = new DateTime(1979, 01, 01),
                    HireStatus = HireStatus.Employed
                },
                Password = "565656",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",
                    PhoneNumber = "5128776930",
                    FirstName = "Allen",
                    LastName = "Rogers",
                    Address = "4965 Rabbit Hill",
                    Birthday = new DateTime(2000, 03, 12),
                    HireStatus = HireStatus.Employed
                },
                Password = "treeman",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "o_st-jean@home.com",
                    Email = "o_st-jean@home.com",
                    PhoneNumber = "2104169665",
                    FirstName = "Olivier",
                    LastName = "Saint-Jean",
                    Address = "255 Slap Dr.",
                    Birthday = new DateTime(1997, 05, 01),
                    HireStatus = HireStatus.Employed
                },
                Password = "55htrq",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ss34@puppy.com",
                    Email = "ss34@puppy.com",
                    PhoneNumber = "5123521797",
                    FirstName = "Sarah",
                    LastName = "Saunders",
                    Address = "332 Fish C",
                    Birthday = new DateTime(1994, 05, 31),
                    HireStatus = HireStatus.Employed
                },
                Password = "leaves",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "willsheff@email.com",
                    Email = "willsheff@email.com",
                    PhoneNumber = "5124534071",
                    FirstName = "William",
                    LastName = "Sewell",
                    Address = "2365 34st St.",
                    Birthday = new DateTime(1951, 12, 10),
                    HireStatus = HireStatus.Employed
                },
                Password = "borbj44",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "sheff44@puppy.com",
                    Email = "sheff44@puppy.com",
                    PhoneNumber = "5125503154",
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    Address = "3886 Road A",
                    Birthday = new DateTime(1993, 07, 02),
                    HireStatus = HireStatus.Employed
                },
                Password = "ldiul485",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "johnsmith187@puppy.com",
                    Email = "johnsmith187@puppy.com",
                    PhoneNumber = "2108345875",
                    FirstName = "John",
                    LastName = "Smith",
                    Address = "23 Known Forge Dr.",
                    Birthday = new DateTime(1985, 06, 13),
                    HireStatus = HireStatus.Employed
                },
                Password = "kribv75",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "jeff@puppy.com",
                    Email = "jeff@puppy.com",
                    PhoneNumber = "5127002600",
                    FirstName = "Jeffrey",
                    LastName = "Stark",
                    Address = "337 40th St.",
                    Birthday = new DateTime(1974, 05, 02),
                    HireStatus = HireStatus.Employed
                },
                Password = "jeffery",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "dustroud@mail.com",
                    Email = "dustroud@mail.com",
                    PhoneNumber = "2142370654",
                    FirstName = "Dustin",
                    LastName = "Stroud",
                    Address = "1212 Henrietta Rd",
                    Birthday = new DateTime(1974, 07, 14),
                    HireStatus = HireStatus.Employed
                },
                Password = "klavjkb48",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "eric_stuart@puppy.com",
                    Email = "eric_stuart@puppy.com",
                    PhoneNumber = "5128202322",
                    FirstName = "Eric",
                    LastName = "Stuart",
                    Address = "5576 Big Ring",
                    Birthday = new DateTime(1968, 06, 17),
                    HireStatus = HireStatus.Employed
                },
                Password = "vkb451",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",
                    PhoneNumber = "8174584890",
                    FirstName = "Peter",
                    LastName = "Stump",
                    Address = "1300 Kellen Square",
                    Birthday = new DateTime(2001, 07, 23),
                    HireStatus = HireStatus.Employed
                },
                Password = "kdsiu4",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tanner@puppy.com",
                    Email = "tanner@puppy.com",
                    PhoneNumber = "8174614916",
                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    Address = "4347 Palmstead",
                    Birthday = new DateTime(1973, 12, 28),
                    HireStatus = HireStatus.Employed
                },
                Password = "klrfbj45",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "taylordjay@puppy.com",
                    Email = "taylordjay@puppy.com",
                    PhoneNumber = "5124772439",
                    FirstName = "Allison",
                    LastName = "Taylor",
                    Address = "467 Nueces St.",
                    Birthday = new DateTime(1999, 09, 30),
                    HireStatus = HireStatus.Employed
                },
                Password = "lraggrhb854",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "lraggrhb854.Taylor@aool.com",
                    Email = "lraggrhb854.Taylor@aool.com",
                    PhoneNumber = "5124536618",
                    FirstName = "Rachel",
                    LastName = "Taylor",
                    Address = "345 Shortview Dr.",
                    Birthday = new DateTime(1956, 02, 24),
                    HireStatus = HireStatus.Employed
                },
                Password = "alsuib95",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tee_frank@hootmail.com",
                    Email = "tee_frank@hootmail.com",
                    PhoneNumber = "8178789530",
                    FirstName = "Frank",
                    LastName = "Tee",
                    Address = "5590 Big Dr.",
                    Birthday = new DateTime(1964, 11, 11),
                    HireStatus = HireStatus.Employed
                },
                Password = "kd1734",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tuck33@puppy.com",
                    Email = "tuck33@puppy.com",
                    PhoneNumber = "2148495141",
                    FirstName = "Clent",
                    LastName = "Tucker",
                    Address = "3132 Main St.",
                    Birthday = new DateTime(1990, 06, 25),
                    HireStatus = HireStatus.Employed
                },
                Password = "kjdb983",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "avelasco@puppy.com",
                    Email = "avelasco@puppy.com",
                    PhoneNumber = "2144009625",
                    FirstName = "Allen",
                    LastName = "Velasco",
                    Address = "634 W. 4th",
                    Birthday = new DateTime(1966, 12, 13),
                    HireStatus = HireStatus.Employed
                },
                Password = "odrb02",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "westj@pioneer.net",
                    Email = "westj@pioneer.net",
                    PhoneNumber = "2148499231",
                    FirstName = "Jake",
                    LastName = "West",
                    Address = "RR 3244",
                    Birthday = new DateTime(1968, 02, 06),
                    HireStatus = HireStatus.Employed
                },
                Password = "kndl847",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "louielouie@puppy.com",
                    Email = "louielouie@puppy.com",
                    PhoneNumber = "2145674085",
                    FirstName = "Louis",
                    LastName = "Winthorpe",
                    Address = "2500 Madre Blvd",
                    Birthday = new DateTime(1961, 07, 23),
                    HireStatus = HireStatus.Employed
                },
                Password = "lb2394",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "rwood@voyager.net",
                    Email = "rwood@voyager.net",
                    PhoneNumber = "5124569229",
                    FirstName = "Reagan",
                    LastName = "Wood",
                    Address = "447 Westlake Dr.",
                    Birthday = new DateTime(1988, 10, 24),
                    HireStatus = HireStatus.Employed
                },
                Password = "drai494",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "jacobs@yahoo.com",
                    Email = "jacobs@yahoo.com",
                    PhoneNumber = "8176663948",
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    Address = "4564 Elm St.",
                    Birthday = new DateTime(1978, 01, 29),
                    HireStatus = HireStatus.Employed
                },
                Password = "tj2245",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "rice@yahoo.com",
                    Email = "rice@yahoo.com",
                    PhoneNumber = "2148545987",
                    FirstName = "Eryn",
                    LastName = "Rice",
                    Address = "3405 Rio Grande",
                    Birthday = new DateTime(2003, 06, 11),
                    HireStatus = HireStatus.Employed
                },
                Password = "ricearoni",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "ingram@gmail.com",
                    Email = "ingram@gmail.com",
                    PhoneNumber = "5127049017",
                    FirstName = "John",
                    LastName = "Ingram",
                    Address = "6548 La Posada Ct.",
                    Birthday = new DateTime(1980, 06, 25),
                    HireStatus = HireStatus.Employed
                },
                Password = "ingram68",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "martinez@aol.com",
                    Email = "martinez@aol.com",
                    PhoneNumber = "2105859369",
                    FirstName = "Paul",
                    LastName = "Martinez",
                    Address = "8295 Sunset Blvd.",
                    Birthday = new DateTime(1969, 06, 25),
                    HireStatus = HireStatus.Employed
                },
                Password = "party1",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "tanner@utexas.edu",
                    Email = "tanner@utexas.edu",
                    PhoneNumber = "5129527803",
                    FirstName = "Jared",
                    LastName = "Tanner",
                    Address = "4347 Almstead",
                    Birthday = new DateTime(1979, 06, 02),
                    HireStatus = HireStatus.Employed
                },
                Password = "sandman",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "chung@yahoo.com",
                    Email = "chung@yahoo.com",
                    PhoneNumber = "2107053952",
                    FirstName = "Lauren",
                    LastName = "Chung",
                    Address = "234 RR 12",
                    Birthday = new DateTime(1976, 03, 24),
                    HireStatus = HireStatus.Employed
                },
                Password = "listen",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "loter@yahoo.com",
                    Email = "loter@yahoo.com",
                    PhoneNumber = "5124650249",
                    FirstName = "Wandavison",
                    LastName = "Loter",
                    Address = "3453 RR 3235",
                    Birthday = new DateTime(1966, 09, 23),
                    HireStatus = HireStatus.Employed
                },
                Password = "pottery",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "morales@aol.com",
                    Email = "morales@aol.com",
                    PhoneNumber = "8177529019",
                    FirstName = "Heather",
                    LastName = "Morales",
                    Address = "4501 RR 140",
                    Birthday = new DateTime(1971, 01, 16),
                    HireStatus = HireStatus.Employed
                },
                Password = "heckin",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "rankin@yahoo.com",
                    Email = "rankin@yahoo.com",
                    PhoneNumber = "5122997370",
                    FirstName = "Martin",
                    LastName = "Rankin",
                    Address = "340 Second St",
                    Birthday = new DateTime(1961, 05, 16),
                    HireStatus = HireStatus.Employed
                },
                Password = "rankmark",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "gonzalez@aol.com",
                    Email = "gonzalez@aol.com",
                    PhoneNumber = "2142415970",
                    FirstName = "Garth",
                    LastName = "Gonzalez",
                    Address = "103 Manor Rd",
                    Birthday = new DateTime(1993, 12, 10),
                    HireStatus = HireStatus.Employed
                },
                Password = "gg2017",
                RoleName = "Host"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "taylor@bevobnb.com",
                    Email = "taylor@bevobnb.com",
                    PhoneNumber = "2149036025",
                    FirstName = "Albert",
                    LastName = "Taylor",
                    Address = "467 Nueces St.",
                    Birthday = new DateTime(1954, 08, 14),
                    HireStatus = HireStatus.Employed
                },
                Password = "TRY563",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "sheffield@bevobnb.com",
                    Email = "sheffield@bevobnb.com",
                    PhoneNumber = "5124749225",
                    FirstName = "Molly",
                    LastName = "Sheffield",
                    Address = "3886 Avenue A",
                    Birthday = new DateTime(1986, 08, 27),
                    HireStatus = HireStatus.Employed
                },
                Password = "longsnores",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "macleod@bevobnb.com",
                    Email = "macleod@bevobnb.com",
                    PhoneNumber = "5124723769",
                    FirstName = "Jenny",
                    LastName = "MacLeod",
                    Address = "2504 Far West Blvd.",
                    Birthday = new DateTime(1984, 12, 05),
                    HireStatus = HireStatus.Employed
                },
                Password = "kittys",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "rhodes@bevobnb.com",
                    Email = "rhodes@bevobnb.com",
                    PhoneNumber = "2102520380",
                    FirstName = "Michelle",
                    LastName = "Rhodes",
                    Address = "4587 Enfield Rd.",
                    Birthday = new DateTime(1972, 07, 02),
                    HireStatus = HireStatus.Employed
                },
                Password = "puppies",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "stuart@bevobnb.com",
                    Email = "stuart@bevobnb.com",
                    PhoneNumber = "2105415031",
                    FirstName = "Evan",
                    LastName = "Stuart",
                    Address = "5576 Toro Ring",
                    Birthday = new DateTime(1984, 04, 17),
                    HireStatus = HireStatus.Employed
                },
                Password = "coolboi",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "swanson@bevobnb.com",
                    Email = "swanson@bevobnb.com",
                    PhoneNumber = "5124818542",
                    FirstName = "Ron",
                    LastName = "Swanson",
                    Address = "245 River Rd",
                    Birthday = new DateTime(1991, 07, 25),
                    HireStatus = HireStatus.Employed
                },
                Password = "swanbong",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "white@bevobnb.com",
                    Email = "white@bevobnb.com",
                    PhoneNumber = "8175025605",
                    FirstName = "Jabriel",
                    LastName = "White",
                    Address = "12 Valley View",
                    Birthday = new DateTime(1986, 03, 17),
                    HireStatus = HireStatus.Employed
                },
                Password = "456789",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "montgomery@bevobnb.com",
                    Email = "montgomery@bevobnb.com",
                    PhoneNumber = "8178817122",
                    FirstName = "Washington",
                    LastName = "Montgomery",
                    Address = "210 Blanco Dr",
                    Birthday = new DateTime(1961, 05, 04),
                    HireStatus = HireStatus.Employed
                },
                Password = "python4",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "walker@bevobnb.com",
                    Email = "walker@bevobnb.com",
                    PhoneNumber = "2143196301",
                    FirstName = "Lisa",
                    LastName = "Walker",
                    Address = "9 Bison Circle",
                    Birthday = new DateTime(2003, 04, 18),
                    HireStatus = HireStatus.Employed
                },
                Password = "walkameter",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "chang@bevobnb.com",
                    Email = "chang@bevobnb.com",
                    PhoneNumber = "2103521329",
                    FirstName = "Gregory",
                    LastName = "Chang",
                    Address = "9003 Joshua St",
                    Birthday = new DateTime(1958, 04, 26),
                    HireStatus = HireStatus.Employed
                },
                Password = "pupgang",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "derek@bevobnb.com",
                    Email = "derek@bevobnb.com",
                    PhoneNumber = "5125556789",
                    FirstName = "Derek",
                    LastName = "Dreibrodt",
                    Address = "4 Privet Dr",
                    Birthday = new DateTime(2001, 01, 01),
                    HireStatus = HireStatus.Employed
                },
                Password = "2cool4u",
                RoleName = "Admin"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    UserName = "rester@bevobnb.com",
                    Email = "rester@bevobnb.com",
                    PhoneNumber = "2103521329",
                    FirstName = "Amy",
                    LastName = "Rester",
                    Address = "2110 Speedway",
                    Birthday = new DateTime(2000, 01, 01),
                    HireStatus = HireStatus.Employed
                },
                Password = "KIzGreat",
                RoleName = "Admin"
            });

            // Create flag to help with errors
            string errorFlag = "Start";

            // Create an identity result
            IdentityResult result = new IdentityResult();

            try
            {
                foreach (AddUserModel aum in AllUsers)
                {
                    errorFlag = aum.User.Email;
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: "
                    + errorFlag, ex);
            }

            return result;
        }
    }

}