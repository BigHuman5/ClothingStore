
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
            Category();
            TypesHuman();

            UnionCategoryAndTypeHuman();

            Subcategory();

            Collections();
            Cards();


            NamesDimensions();
            NamesCriteriaOfDimensions();

            UnionNamesCriteriaOfDimensions();
            UnionNamesAndDimensions();


            Sizes();
            CriteriaOfDimensions();

            Dimensions();

            Products();
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
                    Name="Название брэнда #1"
                },
                new Brands {
                    Name="Название брэнда #2",
                    isDeleted=false,
                },
                new Brands {
                    Name="Название брэнда #3",
                    isDeleted=false,
                },
                new Brands {
                    Name="Название брэнда #4",
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
        private void Category()
        {
            if (context.Category.Any())
            {
                return;
            }

            var group = new Category[]
           {
                new Category{
                    Name="Футболки",
                },
                new Category{
                    Name="Джинсы",
                    isDeleted=false,
                },
                new Category{
                    Name="Платья",
                    isDeleted=false,
                },
                new Category{
                    Name="Носки",
                    isDeleted=true,
                },
           };

            foreach (Category s in group)
            {
                context.Category.Add(s);
            }
            context.SaveChanges();
        }
        private void Subcategory()
        {
            if (context.Subcategories.Any())
            {
                return;
            }

            var group = new Subcategory[]
           {
                new Subcategory{
                    Name="Зауженные",
                    unionCategoryAndTypeHumanId=3,
                },
                new Subcategory{
                    Name="Широкие",
                    unionCategoryAndTypeHumanId=3,
                    isDeleted=false,
                },
                new Subcategory{
                    Name="Длинные",
                    unionCategoryAndTypeHumanId=5,
                    isDeleted=false,
                },
                new Subcategory{
                    Name="Короткин",
                    unionCategoryAndTypeHumanId=5,
                    isDeleted=true,
                },
           };

            foreach (Subcategory s in group)
            {
                context.Subcategories.Add(s);
            }
            context.SaveChanges();
        }
        private void Collections()
        {
            if (context.Collections.Any())
            {
                return;
            }

            var group = new Collections[]
           {
                new Collections{
                    Name="Зима 2022",
                },
                new Collections{
                    Name="Зима 2023",
                    isActual=true,
                    isDeleted=false,
                },
                new Collections{
                    Name="Зима 2010",
                    isActual=false,
                    isDeleted=false,
                },
                new Collections{
                    Name="Лето 2022",
                    isActual=true,
                    isDeleted=true,
                },
           };

            foreach (Collections s in group)
            {
                context.Collections.Add(s);
            }
            context.SaveChanges();
        }

        private void Cards()
        {
            if (context.Cards.Any())
            {
                return;
            }

            var group = new Cards[]
           {
                new Cards{
                    Name="Название карточки #1",
                    collectionId=1,
                    subcategoryId=1,
                    About="fdff",
                    fakePopularity=1,
                    Price=100.5f,
                    realPopulatiry=2,
                },
           };

            foreach (Cards s in group)
            {
                context.Cards.Add(s);
            }
            context.SaveChanges();
        }
        private void Products()
        {
            if (context.Products.Any())
            {
                return;
            }

            var group = new Products[]
           {
                new Products{
                    cardId=1,
                    colorId=1,
                    howMany=100,
                    howManyPictures=3,
                    sizeId=1,
                },
           };

            foreach (Products s in group)
            {
                context.Products.Add(s);
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
        private void UnionCategoryAndTypeHuman()
        {
            if (context.UnionCategoryAndTypeHuman.Any())
            {
                return;
            }

            var group = new UnionCategoryAndTypeHuman[]
           {
                new UnionCategoryAndTypeHuman{ // футболки муж.
                    categoryId=1,
                    typeHumanId=1,
                },
                new UnionCategoryAndTypeHuman{ // футболка жен.
                    categoryId=1,
                    typeHumanId=2,
                    isDeleted=false,
                },
                new UnionCategoryAndTypeHuman{ // джинсы муж.
                    categoryId=2,
                    typeHumanId=1,
                    isDeleted=false,
                },
                new UnionCategoryAndTypeHuman{ // джинсы жен.
                    categoryId=2,
                    typeHumanId=2,
                    isDeleted=false,
                },
                new UnionCategoryAndTypeHuman{ // платья жен.
                    categoryId=3,
                    typeHumanId=2,
                    isDeleted=false,
                },
                new UnionCategoryAndTypeHuman{ // носки муж.
                    categoryId=4,
                    typeHumanId=1,
                    isDeleted=false,
                },
                new UnionCategoryAndTypeHuman{ // джинсы дет.
                    categoryId=2,
                    typeHumanId=3,
                    isDeleted=false,
                },
                new UnionCategoryAndTypeHuman{ // джинсы бер.(false)
                    categoryId=2,
                    typeHumanId=4,
                    isDeleted=false,
                },
                new UnionCategoryAndTypeHuman{ // носки дет.
                    categoryId=4,
                    typeHumanId=3,
                    isDeleted=true,
                },
           };

            foreach (UnionCategoryAndTypeHuman s in group)
            {
                context.UnionCategoryAndTypeHuman.Add(s);
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
            if (context.UnionNamesAndDimensions.Any())
            {
                return;
            }

            var group = new UnionNamesAndDimensions[]
           {
                new UnionNamesAndDimensions{
                    NamesDimensionsId=1,
                    UnionCategoryAndTypeHumanId=1,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=2,
                    UnionCategoryAndTypeHumanId=1,
                    isDeleted=false,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=3,
                    UnionCategoryAndTypeHumanId=1,
                    isDeleted=false,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=4,
                    UnionCategoryAndTypeHumanId=1,
                    isDeleted=true,
                },
                 new UnionNamesAndDimensions{
                    NamesDimensionsId=1,
                    UnionCategoryAndTypeHumanId=2,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=2,
                    UnionCategoryAndTypeHumanId=2,
                    isDeleted=false,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=3,
                    UnionCategoryAndTypeHumanId=2,
                    isDeleted=false,
                },
                 new UnionNamesAndDimensions{
                    NamesDimensionsId=1,
                    UnionCategoryAndTypeHumanId=3,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=2,
                    UnionCategoryAndTypeHumanId=4,
                    isDeleted=false,
                },
                new UnionNamesAndDimensions{
                    NamesDimensionsId=3,
                    UnionCategoryAndTypeHumanId=3,
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
            if (context.UnionNamesCriteriaOfDimensions.Any())
            {
                return;
            }

            var group = new UnionNamesCriteriaOfDimensions[]
           {
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    UnionCategoryAndTypeHumanId=1,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    UnionCategoryAndTypeHumanId=2,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=2,
                    UnionCategoryAndTypeHumanId=1,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    UnionCategoryAndTypeHumanId=2,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    UnionCategoryAndTypeHumanId=3,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    UnionCategoryAndTypeHumanId=4,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    UnionCategoryAndTypeHumanId=5,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=2,
                    UnionCategoryAndTypeHumanId=5,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=1,
                    UnionCategoryAndTypeHumanId=8,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=3,
                    UnionCategoryAndTypeHumanId=9,
                    isDeleted=false,
                },
                new UnionNamesCriteriaOfDimensions{
                    NamesCriteriaOfDimensionsId=3,
                    UnionCategoryAndTypeHumanId=8,
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