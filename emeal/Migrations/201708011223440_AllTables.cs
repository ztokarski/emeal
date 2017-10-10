using System.Data.Entity.Migrations;

namespace emeal.Migrations
{
    public partial class AllTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                    "dbo.Ingredients",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Amount = c.String(),
                        UnitType = c.Int(nullable: false),
                        Product_Id = c.Int(),
                        Recipe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.Product_Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .Index(t => t.Product_Id)
                .Index(t => t.Recipe_Id);

            CreateTable(
                    "dbo.Products",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        PathToImage = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.Recipes",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        PathToImage = c.String(),
                        DifficultyLevel = c.Int(nullable: false),
                        WhenAdded = c.DateTime(nullable: false),
                        EstimatedTime = c.Int(nullable: false),
                        Popularity = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        Author_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Author_Id)
                .Index(t => t.Author_Id);

            CreateTable(
                    "dbo.Users",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PathToImage = c.String()
                    })
                .PrimaryKey(t => t.Id);

            CreateTable(
                    "dbo.Steps",
                    c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PathToImage = c.String(),
                        Timer = c.Int(nullable: false),
                        Order = c.Int(nullable: false),
                        Recipe_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Recipes", t => t.Recipe_Id)
                .Index(t => t.Recipe_Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Steps", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Ingredients", "Recipe_Id", "dbo.Recipes");
            DropForeignKey("dbo.Recipes", "Author_Id", "dbo.Users");
            DropForeignKey("dbo.Ingredients", "Product_Id", "dbo.Products");
            DropIndex("dbo.Steps", new[] {"Recipe_Id"});
            DropIndex("dbo.Recipes", new[] {"Author_Id"});
            DropIndex("dbo.Ingredients", new[] {"Recipe_Id"});
            DropIndex("dbo.Ingredients", new[] {"Product_Id"});
            DropTable("dbo.Steps");
            DropTable("dbo.Users");
            DropTable("dbo.Recipes");
            DropTable("dbo.Products");
            DropTable("dbo.Ingredients");
        }
    }
}