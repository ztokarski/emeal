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
            Product czerwonaCebula = new Product() { Name = "czerwona cebula", PathToImage = "path to image" };
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
                        new Ingredient { Product = kapar, Amount = 2, UnitType = Unit.łyżeczka },
                        new Ingredient { Product = czerwonaCebula, Amount = 2, UnitType = Unit.szt },
                        new Ingredient { Product = czosnek, Amount = 0.5, UnitType = Unit.główka },
                        new Ingredient { Product = oliwaZOliwek, Amount = 4, UnitType = Unit.łyżka },
                        new Ingredient { Product = rozmaryn, Amount = 2, UnitType = Unit.gałązka },
                        new Ingredient { Product = tymianek, Amount = 1, UnitType = Unit.gałązka },
                        new Ingredient { Product = sol, Amount = 1, UnitType = Unit.szczypta },
                        new Ingredient { Product = pieprz, Amount = 1, UnitType = Unit.szczypta },
                    },
                    Steps = new List<Step>
                    {
                        new Step {Name = "PRZYGOTUJ",Order = 1,Description = "blachę piekarnikową i piekarnik rozgrzany do temperatury 200°C"},
                        new Step {Name = "KROK 1: PIECZEMY POMIDORY",Order = 2,Description = "Pomidory oczyszczamy, myjemy i – w zależności od wielkości – pozostawiamy w całości, kroimy na pół lub w ćwiartki. Cebulę obieramy i kroimy w piórka. Czosnek rozdzielamy na ząbki, ale nie obieramy. Blachę do pieczenia smarujemy 1 łyżką oliwy, rozkładamy na niej przygotowane składniki. Całość posypujemy solą i pieprzem, dodajemy gałązki ziół i skrapiamy pozostałą oliwą z oliwek. Pieczemy w piekarniku rozgrzanym do temperatury 200°C przez 20 minut."},
                        new Step {Name = "KROK 2: GOTUJEMY MAKARON",Order = 3,Description = "Makaron gotujemy zgodnie z instrukcją podaną na opakowaniu. Pomarańczę obieramy, by pozostał sam miąższ, który następnie kroimy na kawałki. Ser kozi osączamy i kruszymy. Kapary osączamy i grubo siekamy. Mieszamy z serem i pomarańczą."},
                        new Step {Name = "KROK 3: ŁĄCZYMY SKŁADNIKI DANIA",Order = 4,Description = "Makaron odcedzamy. Z upieczonych warzyw usuwamy gałązki ziół. Czosnek wyłuskujemy ze skórki, grubo siekamy i dodajemy do mieszanki na bazie sera koziego. Pomidory, cebulę i powstały sok mieszamy z makaronem i rozkładamy na talerzach. Ma wierzch dodajemy kozi ser z dodatkami."},
                    },
                    PathToImage = "path to main image",
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
                        new Ingredient { Product = oliwaZOliwek, Amount = 2, UnitType = Unit.łyżka },
                        new Ingredient { Product = bulionWarzywny, Amount = 250, UnitType = Unit.ml },
                        new Ingredient { Product = pomidorBezSkórki, Amount = 2, UnitType = Unit.puszka },
                        new Ingredient { Product = czosnek, Amount = 2, UnitType = Unit.ząbek },
                        new Ingredient { Product = przecierPomidorowy, Amount = 1, UnitType = Unit.łyżeczka },
                        new Ingredient { Product = sol, Amount = 1, UnitType = Unit.szczypta },
                        new Ingredient { Product = pieprz, Amount = 1, UnitType = Unit.szczypta },
                        new Ingredient { Product = cukier, Amount = 1, UnitType = Unit.szczypta },
                        new Ingredient { Product = oregano, Amount = 1, UnitType = Unit.łyżeczka },
                        new Ingredient { Product = pomidorKoktajlowy, Amount = 125, UnitType = Unit.g },
                        new Ingredient { Product = czarneOliwki, Amount = 75, UnitType = Unit.g },
                        new Ingredient { Product = makaronPenne, Amount = 600, UnitType = Unit.g },
                        new Ingredient { Product = bazylia, Amount = 2, UnitType = Unit.gałązka },
                        new Ingredient { Product = parmezan, Amount = 80, UnitType = Unit.g },

                    },
                    Steps = new List<Step>
                    {
                        new Step {Name = "KROK 1: SMAŻYMY SELER Z CEBULĄ",Order = 1,Description = "Marchew i cebule obieramy, selera oczyszczamy i w razie potrzeby usuwamy włókna. Marchew i selera kroimy w kostkę o wielkości ok. 1 cm, cebulę kroimy w drobną kostkę. Wszystko smażymy na rozgrzanej oliwie przez ok. 5 minut aż do zeszklenia. Rozcieńczamy bulionem i pomidorami, pomidory lekko rozdrabniamy widelcem. Dodajemy czosnek przeciśnięty przez praskę. Doprawiamy solą, pieprzem, szczyptą cukru i oregano. Doprowadzamy do wrzenia."},
                        new Step {Name = "KROK 2: DODAJEMY POMIDORY DO SOSU",Order = 2,Description = "Bolognese gotujemy na w pół przykryte na małym ogniu przez ok. 45 minut, aż zgęstnieje, od czasu do czasu przy tym mieszając. Pomidory koktajlowe myjemy i kroimy na pół lub w ćwiartki. Oliwki kroimy w grube krążki. Oba składniki dodajemy pod koniec gotowania sosu, krótko w nim podgrzewamy i doprawiamy do smaku."},
                        new Step {Name = "KROK 3: PODAJEMY Z MAKARONEM",Order = 3,Description = "Makaron gotujemy w dużej ilości wrzącej, osolonej wody zgodnie z instrukcją podaną na opakowaniu. Bazylię osuszamy, listki obrywamy i siekamy. Mieszamy z sosem i podajemy z odcedzonym makaronem i startym serem."},
                       
                    },
                    PathToImage = "path to main image",
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
                        new Ingredient { Product = oregano, Amount = 0.5, UnitType = Unit.łyżeczka },
                        new Ingredient { Product = sol, Amount = 1, UnitType = Unit.szczypta },
                        new Ingredient { Product = pieprz, Amount = 1, UnitType = Unit.szczypta },
                    },
                    Steps = new List<Step>
                    {
                        new Step {Name = "PRZYGOTUJ",Order = 1,Description = "mikser lub blender"},
                        new Step {Name = "KROK 1: SIEKAMY PAPRYCZKĘ",Order = 2,Description = "Paprykę oczyszczamy, pozbawiamy nasion i kroimy w drobną kostkę. Oliwki osączamy i siekamy wraz z nadzieniem."},
                        new Step {Name = "KROK 2: ŁĄCZYMY SKŁADNIKI PASTY",Order = 3,Description = "Fetę osączamy, kruszymy na małe kawałki i miksujemy wraz z jogurtem na gładką masę. Doprawiamy oregano, pieprzem i odrobiną soli. Dodajemy paprykę i oliwki. Podajemy z chlebem pita."},
                    },
                    PathToImage = "path to main image",
                    DifficultyLevel = Difficulty.Easy,
                    WhenAdded = DateTime.Today,
                    EstimatedTime = 10,
                    Popularity = 3,
                    Rating = 5
                }
            );
        }
    }
}