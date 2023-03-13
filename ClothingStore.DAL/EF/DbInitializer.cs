
using ClothingStore.DAL.Entities;
using ClothingStore.DAL.Entities.Dimensions;

namespace ClothingStore.DAL.EF
{
    internal class DbInitializer
    {
        private ClothingStoreDbContext context;
        public DbInitializer(ClothingStoreDbContext context)
        {
            this.context = context;
            Brands();
            Colors();
            Types();
            TypesHuman();

            TypesDimensions();

            NamesDimensions();
            NamesCriteriaOfDimensions();

            UnionNamesCriteriaOfDimensions();
            UnionNamesAndDimensions();


            Sizes();
            CriteriaOfDimensions();

            Dimensions();
        }

        private void Brands()
        {

            if (context.Brands.Any())
            {
                return;   // В DB имеется информация
            }

            var group = new Brands[]
            {
                new Brands {
                    Name="Nike"
                },
                new Brands {
                    Name="Abibas",
                    isDeleted=false,
                },
                new Brands {
                    Name="O`stin",
                    isDeleted=false,
                },
                new Brands {
                    Name="Like",
                    isDeleted=true,
                },
            };

            foreach (Brands s in group)
            {
                context.Brands.Add(s);
            }
            context.SaveChanges();
        }

        private void Colors()
        {
            if (context.Colors.Any())
            {
                return;
            }

            var group = new Colors[]
            {
                new Colors {
                    Name="red",
                    color="ff0000"
                },
                new Colors {
                    Name="white",
                    color="ffffff",
                    isDeleted=false,
                },
                new Colors {
                    Name="Green",
                    color="00ff00",
                    isDeleted=false,
                },
                new Colors {
                    Name="Blue",
                    color="0000ff",
                    isDeleted=true,
                },
            };

            foreach (Colors s in group)
            {
                context.Colors.Add(s);
            }
            context.SaveChanges();
        }

        private void Types()
        {
            if (context.Types.Any())
            {
                return;
            }

            var group = new Types[]
           {
                new Types{
                    Name="Футболки",
                },
                new Types{
                    Name="Джинсы",
                    isDeleted=false,
                },
                new Types{
                    Name="Платья",
                    isDeleted=false,
                },
                new Types{
                    Name="Носки",
                    isDeleted=true,
                },
           };

            foreach (Types s in group)
            {
                context.Types.Add(s);
            }
            context.SaveChanges();
        }

        private void TypesHuman()
        {
            if (context.TypesHumans.Any())
            {
                return;
            }

            var group = new TypesHuman[]
           {
                new TypesHuman{
                    Name="Мужчины",
                },
                new TypesHuman{
                    Name="Женщины",
                    isDeleted=false,
                },
                new TypesHuman{
                    Name="Дети",
                    isDeleted=false,
                },
                new TypesHuman{
                    Name="Беременные",
                    isDeleted=true,
                },
           };

            foreach (TypesHuman s in group)
            {
                context.TypesHumans.Add(s);
            }
            context.SaveChanges();
        }

        private void TypesDimensions()
        {
            if (context.TypesDimensions.Any())
            {
                return;
            }

            var group = new TypesDimensions[]
           {
                new TypesDimensions{ // футболки муж.
                    typeId=1,
                    typeHumanId=1,
                },
                new TypesDimensions{ // футболка жен.
                    typeId=1,
                    typeHumanId=2,
                    isDeleted=false,
                },
                new TypesDimensions{ // джинсы муж.
                    typeId=2,
                    typeHumanId=1,
                    isDeleted=false,
                },
                new TypesDimensions{ // джинсы жен.
                    typeId=2,
                    typeHumanId=2,
                    isDeleted=false,
                },
                new TypesDimensions{ // платья жен.
                    typeId=3,
                    typeHumanId=2,
                    isDeleted=false,
                },
                new TypesDimensions{ // носки муж.
                    typeId=4,
                    typeHumanId=1,
                    isDeleted=false,
                },
                new TypesDimensions{ // джинсы дет.
                    typeId=2,
                    typeHumanId=3,
                    isDeleted=false,
                },
                new TypesDimensions{ // джинсы бер.(false)
                    typeId=2,
                    typeHumanId=4,
                    isDeleted=false,
                },
                new TypesDimensions{ // носки дет.
                    typeId=4,
                    typeHumanId=3,
                    isDeleted=true,
                },
           };

            foreach (TypesDimensions s in group)
            {
                context.TypesDimensions.Add(s);
            }
            context.SaveChanges();
        }

        private void NamesDimensions()
        {
            if (context.NamesDimensions.Any())
            {
                return;
            }

            var group = new NamesDimensions[]
            {
                new NamesDimensions {
                    Name="RUS"
                },
                new NamesDimensions {
                    Name="US"
                },
                new NamesDimensions {
                    Name="INT"
                },
                new NamesDimensions {
                    Name="FR"
                },
            };

            foreach (NamesDimensions s in group)
            {
                context.NamesDimensions.Add(s);
            }
            context.SaveChanges();
        }

        private void NamesCriteriaOfDimensions()
        {
            if (context.NamesCriteriaOfDimensions.Any())
            {
                return;
            }

            var group = new NamesCriteriaOfDimensions[]
            {
                new NamesCriteriaOfDimensions {
                    Name="Обхват груди",
                },
                new NamesCriteriaOfDimensions {
                    Name="Обхват талии"
                },
                new NamesCriteriaOfDimensions {
                    Name="См"
                },
            };

            foreach (NamesCriteriaOfDimensions s in group)
            {
                context.NamesCriteriaOfDimensions.Add(s);
            }
            context.SaveChanges();
        }

        private void UnionNamesAndDimensions()
        {
            if (context.NamesDimensions.Any())
            {
                return;
            }

            var group = new UnionNamesAndDimensions[]
           {
                new UnionNamesAndDimensions{
                    NamesDimensionsId=1,
                    typeDimensionsId=1,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=2,
                    typeDimensionsId=1,
                    isDeleted=false,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=3,
                    typeDimensionsId=1,
                    isDeleted=false,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=4,
                    typeDimensionsId=1,
                    isDeleted=true,
                },
                 new UnionNamesAndDimensions{
                    NamesDimensionsId=1,
                    typeDimensionsId=2,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=2,
                    typeDimensionsId=2,
                    isDeleted=false,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=3,
                    typeDimensionsId=2,
                    isDeleted=false,
                },
                 new UnionNamesAndDimensions{
                    NamesDimensionsId=1,
                    typeDimensionsId=3,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=2,
                    typeDimensionsId=4,
                    isDeleted=false,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=3,
                    typeDimensionsId=3,
                    isDeleted=false,
                },
           };

            foreach (UnionNamesAndDimensions s in group)
            {
                context.UnionNamesAndDimensions.Add(s);
            }
            context.SaveChanges();
        }

        private void UnionNamesCriteriaOfDimensions()
        {
            if (context.NamesCriteriaOfDimensions.Any())
            {
                return;
            }

            var group = new UnionNamesCriteriaOfDimensions[]
           {
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    typesDimensionsId=1,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    typesDimensionsId=2,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=2,
                    typesDimensionsId=1,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    typesDimensionsId=2,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    typesDimensionsId=3,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    typesDimensionsId=4,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    typesDimensionsId=5,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=2,
                    typesDimensionsId=5,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    typesDimensionsId=8,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=3,
                    typesDimensionsId=9,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=3,
                    typesDimensionsId=8,
                    isDeleted=true,
                },
           };

            foreach (UnionNamesCriteriaOfDimensions s in group)
            {
                context.UnionNamesCriteriaOfDimensions.Add(s);
            }
            context.SaveChanges();
        }

        private void Sizes()
        {
            if (context.Sizes.Any())
            {
                return;
            }

            var group = new Sizes[]
            {
                new Sizes {
                    Name="40",
                    namesDimensionsId=1
                },
                new Sizes {
                    Name="41",
                    namesDimensionsId=1
                },
                new Sizes {
                    Name="42",
                    namesDimensionsId=1
                },
                new Sizes {
                    Name="XL",
                    namesDimensionsId=3
                },
            };

            foreach (Sizes s in group)
            {
                context.Sizes.Add(s);
            }
            context.SaveChanges();
        }

        private void CriteriaOfDimensions()
        {
            if (context.CriteriaOfDimensions.Any())
            {
                return;
            }

            var group = new CriteriaOfDimensions[]
            {
                new CriteriaOfDimensions {
                    namesCriteriaOfDimensionsId=1,
                    MinSize=165,
                    MaxSize=170
                },
                new CriteriaOfDimensions {
                    namesCriteriaOfDimensionsId=1,
                    MinSize=171,
                    MaxSize=185
                },
                new CriteriaOfDimensions {
                    namesCriteriaOfDimensionsId=1,
                    MinSize=185,
                    MaxSize=190
                },

            };

            foreach (CriteriaOfDimensions s in group)
            {
                context.CriteriaOfDimensions.Add(s);
            }
            context.SaveChanges();
        }

        private void Dimensions()
        {
            if (context.Dimensions.Any())
            {
                return;
            }

            var group = new Dimensions[]
           {
                new Dimensions{                 
                    CriteriaOfDimensionsId=1,
                    sizesId=1,
                    
                },
                new Dimensions{                 
                    CriteriaOfDimensionsId=2,
                    sizesId=1
                }
           };

            foreach (Dimensions s in group)
            {
                context.Dimensions.Add(s);
            }
            context.SaveChanges();
        }
    }
}