using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using emeal.Models;
using emeal.Services;

namespace emeal.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<MsqlRecipeDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MsqlRecipeDb context)
        {
            Product pomidor = new Product() { Name = "pomidor", PathToImage = "path to image" };
            Product pomidorBezSkórki = new Product() { Name = "pomidor bez skórki", PathToImage = "path to image" };
            Product makaronPenne = new Product() { Name = "makaron penne", PathToImage = "path to image" };
            Product pomarancza = new Product() { Name = "pomarańcza", PathToImage = "path to image" };
            Product serKozi = new Product() { Name = "ser kozi", PathToImage = "path to image" };
            Product kapar = new Product() { Name = "kapar", PathToImage = "path to image" };
            Product czosnek = new Product() { Name = "czosnek", PathToImage = "path to image" };
            Product oliwaZOliwek = new Product() { Name = "oliwa z oliwek", PathToImage = "path to image" };
            Product rozmaryn = new Product() { Name = "rozmaryn", PathToImage = "path to image" };
            Product tymianek = new Product() { Name = "tymianek", PathToImage = "path to image" };
            Product sol = new Product() { Name = "sól", PathToImage = "path to image" };
            Product pieprz = new Product() { Name = "pieprz", PathToImage = "path to image" };
            Product marchew = new Product() { Name = "marchew", PathToImage = "path to image" };
            Product cebula = new Product() { Name = "cebula", PathToImage = "path to image" };
            Product selerNaciowy = new Product() { Name = "seler naciowy", PathToImage = "path to image" };
            Product bulionWarzywny = new Product() { Name = "bulion warzywny", PathToImage = "path to image" };
            Product przecierPomidorowy = new Product() { Name = "przecier pomidorowy", PathToImage = "path to image" };
            Product cukier = new Product() { Name = "cukier", PathToImage = "path to image" };
            Product oregano = new Product() { Name = "oregano", PathToImage = "path to image" };
            Product pomidorKoktajlowy = new Product() { Name = "pomidor koktajlowy", PathToImage = "path to image" };
            Product czarneOliwki = new Product() { Name = "czarne oliwki", PathToImage = "path to image" };
            Product bazylia = new Product() { Name = "bazylia", PathToImage = "path to image" };
            Product parmezan = new Product() { Name = "parmezan", PathToImage = "path to image" };
            Product papryczkaChili = new Product() { Name = "papryczka chili", PathToImage = "path to image" };
            Product oliwkiZCzosnkiem = new Product() { Name = "oliwki nadziewane czosnkiem", PathToImage = "path to image" };
            Product serFeta = new Product() { Name = "ser feta", PathToImage = "path to image" };
            Product jogurtNaturalny = new Product() { Name = "jogurt naturalny", PathToImage = "path to image" };
            Product cukierBrazowy = new Product() { Name = "cukier brązowy", PathToImage = "path to image" };
            Product espressoWProszku = new Product() { Name = "espresso w proszku", PathToImage = "path to image" };
            Product cynamonMielony = new Product() { Name = "cynamon mielony", PathToImage = "path to image" };
            Product kolendraMielona = new Product() { Name = "kolendra mielona", PathToImage = "path to image" };
            Product mleko = new Product() { Name = "mleko", PathToImage = "path to image" };
            Product smietana18 = new Product() { Name = "śmietana 18%", PathToImage = "path to image" };
            Product pieprzCayenne = new Product() { Name = "pieprz cayenne", PathToImage = "path to image" };
            Product limonka = new Product() { Name = "limonka", PathToImage = "path to image" };
            Product miod = new Product() { Name = "miód", PathToImage = "path to image" };
            Product kielbasaGrillowa = new Product() { Name = "kiełbasa grillowa", PathToImage = "path to image" };
            Product fasolaCzerwonaZPuszki = new Product() { Name = "fasola czerwona", PathToImage = "path to image" };
            Product cebulaCzerwona = new Product() { Name = "cebula czerwona", PathToImage = "path to image" };
            Product awokado = new Product() { Name = "awokado", PathToImage = "path to image" };
            Product tortillaPszenna = new Product() { Name = "tortilla pszenna", PathToImage = "path to image" };
            Product rzezucha = new Product() { Name = "rzeżucha", PathToImage = "path to image" };
            Product serekGrani = new Product() { Name = "serek grani", PathToImage = "path to image" };
            Product smietanka30 = new Product() { Name = "śmietanka 30%", PathToImage = "path to image" };
            Product skorkaZCytryny = new Product() { Name = "skórka z cytryny", PathToImage = "path to image" };
            Product jajko = new Product() { Name = "jajko", PathToImage = "path to image" };
            Product chlebTostowy = new Product() { Name = "chleb tostowy", PathToImage = "path to image" };
            Product maslo = new Product() { Name = "masło", PathToImage = "path to image" };
            Product kawiorZPstraga = new Product() { Name = "kawior z pstrąga", PathToImage = "path to image" };
            Product imbir = new Product() { Name = "imbir", PathToImage = "path to image" };
            Product olejSlonecznikowy = new Product() { Name = "olej słonecznikowy", PathToImage = "path to image" };
            Product dorsz = new Product() { Name = "dorsz", PathToImage = "path to image" };
            Product kapustaBiala = new Product() { Name = "kapusta biała", PathToImage = "path to image" };
            Product olejRzepakowy = new Product() { Name = "olej rzepakowy", PathToImage = "path to image" };
            Product kremBalsamiczny = new Product() { Name = "krem balsamiczny", PathToImage = "path to image" };
            Product musztardaDijon = new Product() { Name = "musztarda Dijon", PathToImage = "path to image" };
            Product maka = new Product() { Name = "mąka", PathToImage = "path to image" };
            Product serGranaPadano = new Product() { Name = "ser Grana Padano", PathToImage = "path to image" };
            Product cytryna = new Product() { Name = "cytryna", PathToImage = "path to image" };
            Product krewetki = new Product() { Name = "krewetki", PathToImage = "path to image" };
            Product paprykaCzerwona = new Product() { Name = "czerwona papryka", PathToImage = "path to image" };
            Product natkaPietruszki = new Product() { Name = "natka pietruszki", PathToImage = "path to image" };
            Product miesoMieloweWieprzowe = new Product() { Name = "mieso mielone wieprzowe", PathToImage = "path to image" };
            Product sosSojowy = new Product() { Name = "sos sojowy", PathToImage = "path to image" };
            Product bulkaTarta = new Product() { Name = "bułka tarta", PathToImage = "path to image" };


            context.Recipes.AddOrUpdate(p => p.Name,
                new Recipe
                {
                    Name = "Makaron z pieczonymi pomidorami",
                    Description = "Pomidory po upieczeniu nabierają wyjątkowego aromatu! Spróbuj ich w połączeniu z makaronem i kozim serem!",
                    Author = new User { Name = "Stanislaw" },
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Product = pomidor, Amount = 1, UnitType = Unit.kg },
                        new Ingredient { Product = makaronPenne, Amount = 400, UnitType = Unit.g },
                        new Ingredient { Product = pomarancza, Amount = 1, UnitType = Unit.szt },
                        new Ingredient { Product = serKozi, Amount = 150, UnitType = Unit.g },
                        new Ingredient { Product = kapar, Amount = 2, UnitType = Unit.szt },
                        new Ingredient { Product = cebulaCzerwona, Amount = 2, UnitType = Unit.szt },
                        new Ingredient { Product = czosnek, Amount = 0.5, UnitType = Unit.szt },
                        new Ingredient { Product = oliwaZOliwek, Amount = 4, UnitType = Unit.łyż },
                        new Ingredient { Product = rozmaryn, Amount = 2, UnitType = Unit.szt },
                        new Ingredient { Product = tymianek, Amount = 1, UnitType = Unit.szt },
                        new Ingredient { Product = sol, Amount = 1, UnitType = Unit.g },
                        new Ingredient { Product = pieprz, Amount = 1, UnitType = Unit.g },
                    },
                    Steps = new List<Step>
                    {
                        new Step {Name = "PRZYGOTUJ",Order = 1,Description = "blachę piekarnikową i piekarnik rozgrzany do temperatury 200°C"},
                        new Step {Name = "KROK 1: PIECZEMY POMIDORY",Order = 2,Description = "Pomidory oczyszczamy, myjemy i – w zależności od wielkości – pozostawiamy w całości, kroimy na pół lub w ćwiartki. Cebulę obieramy i kroimy w piórka. Czosnek rozdzielamy na ząbki, ale nie obieramy. Blachę do pieczenia smarujemy 1 łyżką oliwy, rozkładamy na niej przygotowane składniki. Całość posypujemy solą i pieprzem, dodajemy gałązki ziół i skrapiamy pozostałą oliwą z oliwek. Pieczemy w piekarniku rozgrzanym do temperatury 200°C przez 20 minut."},
                        new Step {Name = "KROK 2: GOTUJEMY MAKARON",Order = 3,Description = "Makaron gotujemy zgodnie z instrukcją podaną na opakowaniu. Pomarańczę obieramy, by pozostał sam miąższ, który następnie kroimy na kawałki. Ser kozi osączamy i kruszymy. Kapary osączamy i grubo siekamy. Mieszamy z serem i pomarańczą."},
                        new Step {Name = "KROK 3: ŁĄCZYMY SKŁADNIKI DANIA",Order = 4,Description = "Makaron odcedzamy. Z upieczonych warzyw usuwamy gałązki ziół. Czosnek wyłuskujemy ze skórki, grubo siekamy i dodajemy do mieszanki na bazie sera koziego. Pomidory, cebulę i powstały sok mieszamy z makaronem i rozkładamy na talerzach. Ma wierzch dodajemy kozi ser z dodatkami."},
                    },
                    PathToImage = "https://i.imgur.com/y45l7o6.png",
                    DifficultyLevel = Difficulty.Medium,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 30,
                    Popularity = 1,
                    Rating = 3
                }
            );

            context.Recipes.AddOrUpdate(p => p.Name,
                new Recipe
                {
                    Name = "Penne z wegetariańskim bolognese",
                    Description = "Bolognese z mnóstwem warzyw, pełnych słońca pomidorów i aromatycznych przypraw. Bez mięsa smakuje równie wyśmienicie.",
                    Author = new User { Name = "Claudia" },
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Product = marchew, Amount = 400, UnitType = Unit.g },
                        new Ingredient { Product = cebula, Amount = 2, UnitType = Unit.szt },
                        new Ingredient { Product = selerNaciowy, Amount = 250, UnitType = Unit.g },
                        new Ingredient { Product = oliwaZOliwek, Amount = 2, UnitType = Unit.łyż },
                        new Ingredient { Product = bulionWarzywny, Amount = 250, UnitType = Unit.ml },
                        new Ingredient { Product = pomidorBezSkórki, Amount = 200, UnitType = Unit.g },
                        new Ingredient { Product = czosnek, Amount = 2, UnitType = Unit.szt },
                        new Ingredient { Product = przecierPomidorowy, Amount = 1, UnitType = Unit.łyż },
                        new Ingredient { Product = sol, Amount = 1, UnitType = Unit.g },
                        new Ingredient { Product = pieprz, Amount = 1, UnitType = Unit.g },
                        new Ingredient { Product = cukier, Amount = 10, UnitType = Unit.g },
                        new Ingredient { Product = oregano, Amount = 1, UnitType = Unit.łyż },
                        new Ingredient { Product = pomidorKoktajlowy, Amount = 125, UnitType = Unit.g },
                        new Ingredient { Product = czarneOliwki, Amount = 75, UnitType = Unit.g },
                        new Ingredient { Product = makaronPenne, Amount = 600, UnitType = Unit.g },
                        new Ingredient { Product = bazylia, Amount = 2, UnitType = Unit.szt },
                        new Ingredient { Product = parmezan, Amount = 80, UnitType = Unit.g },

                    },
                    Steps = new List<Step>
                    {
                        new Step {Name = "KROK 1: SMAŻYMY SELER Z CEBULĄ",Order = 1,Description = "Marchew i cebule obieramy, selera oczyszczamy i w razie potrzeby usuwamy włókna. Marchew i selera kroimy w kostkę o wielkości ok. 1 cm, cebulę kroimy w drobną kostkę. Wszystko smażymy na rozgrzanej oliwie przez ok. 5 minut aż do zeszklenia. Rozcieńczamy bulionem i pomidorami, pomidory lekko rozdrabniamy widelcem. Dodajemy czosnek przeciśnięty przez praskę. Doprawiamy solą, pieprzem, szczyptą cukru i oregano. Doprowadzamy do wrzenia."},
                        new Step {Name = "KROK 2: DODAJEMY POMIDORY DO SOSU",Order = 2,Description = "Bolognese gotujemy na w pół przykryte na małym ogniu przez ok. 45 minut, aż zgęstnieje, od czasu do czasu przy tym mieszając. Pomidory koktajlowe myjemy i kroimy na pół lub w ćwiartki. Oliwki kroimy w grube krążki. Oba składniki dodajemy pod koniec gotowania sosu, krótko w nim podgrzewamy i doprawiamy do smaku."},
                        new Step {Name = "KROK 3: PODAJEMY Z MAKARONEM",Order = 3,Description = "Makaron gotujemy w dużej ilości wrzącej, osolonej wody zgodnie z instrukcją podaną na opakowaniu. Bazylię osuszamy, listki obrywamy i siekamy. Mieszamy z sosem i podajemy z odcedzonym makaronem i startym serem."},
                       
                    },
                    PathToImage = "https://i.imgur.com/XXX21CQ.png",
                    DifficultyLevel = Difficulty.Medium,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 35,
                    Popularity = 2,
                    Rating = 4
                }
            );
            context.Recipes.AddOrUpdate(p => p.Name,
                new Recipe
                {
                    Name = "Pasta z sera feta z oliwkami",
                    Description = "Ostre chili, oliwki nadziewane czosnkiem, ser feta i jogurt naturalny – z tych składników przygotujesz pastę idealną do kanapek.",
                    Author = new User { Name = "Mieczysław" },
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Product = papryczkaChili, Amount = 100, UnitType = Unit.g },
                        new Ingredient { Product = oliwkiZCzosnkiem, Amount = 60, UnitType = Unit.g },
                        new Ingredient { Product = serFeta, Amount = 250, UnitType = Unit.g },
                        new Ingredient { Product = jogurtNaturalny, Amount = 100, UnitType = Unit.g },
                        new Ingredient { Product = oregano, Amount = 0.5, UnitType = Unit.łyż },
                        new Ingredient { Product = sol, Amount = 1, UnitType = Unit.g },
                        new Ingredient { Product = pieprz, Amount = 1, UnitType = Unit.g },
                    },
                    Steps = new List<Step>
                    {
                        new Step {Name = "PRZYGOTUJ",Order = 1,Description = "mikser lub blender"},
                        new Step {Name = "KROK 1: SIEKAMY PAPRYCZKĘ",Order = 2,Description = "Paprykę oczyszczamy, pozbawiamy nasion i kroimy w drobną kostkę. Oliwki osączamy i siekamy wraz z nadzieniem."},
                        new Step {Name = "KROK 2: ŁĄCZYMY SKŁADNIKI PASTY",Order = 3,Description = "Fetę osączamy, kruszymy na małe kawałki i miksujemy wraz z jogurtem na gładką masę. Doprawiamy oregano, pieprzem i odrobiną soli. Dodajemy paprykę i oliwki. Podajemy z chlebem pita."},
                    },
                    PathToImage = "https://i.imgur.com/kq6iCbl.png",
                    DifficultyLevel = Difficulty.Easy,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 10,
                    Popularity = 3,
                    Rating = 5
                }
            );
            context.Recipes.AddOrUpdate(p => p.Name,
                new Recipe
                {
                    Name = "Kawa po portugalsku",
                    Description = "Mielony cynamon, kolendra, duża ilość spienionego mleka i oczywiście mocne espresso – z tych składników przygotujesz kawę po portugalsku!",
                    Author = new User { Name = "Katarzyna" },
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Product = cukierBrazowy, Amount = 25, UnitType = Unit.g },
                        new Ingredient { Product = espressoWProszku, Amount = 50, UnitType = Unit.g },
                        new Ingredient { Product = cynamonMielony, Amount = 0.25, UnitType = Unit.łyż },
                        new Ingredient { Product = kolendraMielona, Amount = 0.25, UnitType = Unit.łyż },
                        new Ingredient { Product = mleko, Amount = 1, UnitType = Unit.l },
                    },
                    Steps = new List<Step>
                    {
                        new Step {Name = "PRZYGOTUJ",Order = 1,Description = "moździerz"},
                        new Step {Name = "KROK 1: UCIERAMY CUKIER",Order = 2,Description = "Cukier ucieramy w moździerzu. Espresso w proszku mieszamy z cynamonem i kolendrą. Zaparzamy ok. 250 ml mocnego espresso z przyprawami."},
                        new Step {Name = "KROK 2: PODGRZEWAMY MLEKO",Order = 3,Description = "Mleko podgrzewamy. Połowę przelewamy do 4 szklanek. Resztę mleka spieniamy i również rozlewamy do szklanek."},
                        new Step {Name = "KROK 3: DEKORUJEMY GALAO",Order = 3,Description = "Espresso ostrożnie dolewamy do mleka, tak aby utworzyło środkową warstwę. Galao posypujemy cukrem i podajemy natychmiast posypane odrobiną cynamonu."},

                    },
                    PathToImage = "https://i.imgur.com/ScMaV1x.png",
                    DifficultyLevel = Difficulty.Easy,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 8,
                    Popularity = 4,
                    Rating = 6
                }
            );
            context.Recipes.AddOrUpdate(p => p.Name,
                new Recipe
                {
                    Name = "Śniadaniowe burrito",
                    Description = "Tortille z mięsem, awokado, fasolą i ostrym dipem! Zobacz, jak przygotować śniadanie inspirowane kuchnią meksykańską!",
                    Author = new User { Name = "Huanito" },
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Product = smietana18, Amount = 150, UnitType = Unit.g },
                        new Ingredient { Product = pieprzCayenne, Amount = 1, UnitType = Unit.g },
                        new Ingredient { Product = limonka, Amount = 0.5, UnitType = Unit.szt },
                        new Ingredient { Product = miod, Amount = 1, UnitType = Unit.łyż },
                        new Ingredient { Product = kielbasaGrillowa, Amount = 400, UnitType = Unit.g },
                        new Ingredient { Product = fasolaCzerwonaZPuszki, Amount =255, UnitType = Unit.g },
                        new Ingredient { Product = cebulaCzerwona, Amount = 1, UnitType = Unit.szt },
                        new Ingredient { Product = czosnek, Amount = 2, UnitType = Unit.szt },
                        new Ingredient { Product = awokado, Amount = 1, UnitType = Unit.szt },
                        new Ingredient { Product = tortillaPszenna, Amount =6, UnitType = Unit.szt },
                        new Ingredient { Product = sol, Amount = 1, UnitType = Unit.g },
                    },
                    Steps = new List<Step>
                    {
                        new Step {Name = "KROK 1: PRZYGOTOWUJEMY SOS",Order = 1,Description = "Śmietanę mieszamy z solą, pieprzem cayenne i skórką z limonki, możemy także doprawić miodem. Cebulę oraz czosnek obieramy i kroimy w drobną kostkę. Fasolę odcedzamy, płuczemy i odsączamy."},
                        new Step {Name = "KROK 2: SMAŻYMY MIĘSNY FARSZ",Order = 2,Description = "Kiełbasę grillową nacinamy i wyciskamy mięso z osłonki. Smażymy na gorącej patelni przez ok. 4 minuty, rozdrabniając je. Dodajemy cebulę i czosnek, smażymy razem przez 3 minuty. Dodajemy fasolę i podgrzewamy przez 2-3 minuty, doprawiamy do smaku."},
                        new Step {Name = "KROK 3: ZWIJAMY TORTILLE",Order = 3,Description = "Awokado obieramy, kroimy na pół, pozbawiamy pestki i kroimy w plasterki. Skrapiamy sokiem z limonki. Tortille kolejno podgrzewamy na dużej patelni bez tłuszczu przez 20-30 sekund. Smarujemy śmietaną, układamy awokado i mięsny farsz, zwijamy."},
                    },
                    PathToImage = "https://i.imgur.com/4gCqqEd.png",
                    DifficultyLevel = Difficulty.Easy,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 30,
                    Popularity = 6,
                    Rating = 5
                }
            );
            context.Recipes.AddOrUpdate(p => p.Name,
                new Recipe
                {
                    Name = "Jajka po wiedeńsku z kremem z rzeżuchy i tostowymi paluszkami",
                    Description = "Krem z rzeżuchy i tostowe paluszki to świetne dodatki do jajek. Wypróbuj koniecznie!",
                    Author = new User { Name = "Bogumiła" },
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Product = rzezucha, Amount = 1, UnitType = Unit.szt },
                        new Ingredient { Product = serekGrani, Amount = 150, UnitType = Unit.g },
                        new Ingredient { Product = smietanka30, Amount = 2, UnitType = Unit.łyż},
                        new Ingredient { Product = skorkaZCytryny, Amount = 1, UnitType = Unit.szt},
                        new Ingredient { Product = jajko, Amount = 8, UnitType = Unit.szt },
                        new Ingredient { Product = sol, Amount = 1, UnitType = Unit.g },
                        new Ingredient { Product = pieprz, Amount = 1, UnitType = Unit.g },
                        new Ingredient { Product = chlebTostowy, Amount = 4, UnitType = Unit.szt },
                        new Ingredient { Product = maslo, Amount = 3, UnitType = Unit.łyż },
                        new Ingredient { Product = kawiorZPstraga, Amount = 4, UnitType = Unit.łyż, Description = "opcjonalnie" },
                    },
                    Steps = new List<Step>
                    {
                        new Step {Name = "KROK 1: PRZYGOTOWUJEMY KREM Z RZEŻUCHY",Order = 1,Description = "Rzeżuchę obcinamy i mieszamy z serkiem grani i śmietanką, doprawiamy solą, pieprzem i skórką z cytryny."},
                        new Step {Name = "KROK 2: GOTUJEMY JAJKA I SMAŻYMY CHLEB",Order = 2,Description = "Jajka gotujemy na miękko we wrzącej wodzie przez 5-6 minut. W międzyczasie każdą kromkę chleba kroimy na 4 paski i podsmażamy na gorącym maśle ok. 1 minuty z każdej strony."},
                        new Step {Name = "KROK 3: NAKŁADAMY KREM NA JAJKA",Order = 3,Description = "Jajka przelewamy zimną wodą, obieramy ze skorupki i przekładamy po 2 sztuki do szklanki. Lekko nacinamy, doprawiamy solą i pieprzem i rozkładamy na nich krem z rzeżuchy. Dodajemy po 1 łyżeczce kawioru z pstrąga (opcjonalnie). Podajemy z tostowymi paluszkami."},
                    },
                    PathToImage = "https://i.imgur.com/bWCN3wq.png",
                    DifficultyLevel = Difficulty.Easy,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 20,
                    Popularity = 1,
                    Rating = 1
                }
            );
           
        }
    }
}