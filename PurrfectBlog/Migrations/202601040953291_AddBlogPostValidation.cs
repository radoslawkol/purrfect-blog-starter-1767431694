namespace PurrfectBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBlogPostValidation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogPost", "Content", c => c.String(nullable: false));
            AddColumn("dbo.BlogPost", "Category", c => c.String(maxLength: 100));
            DropColumn("dbo.BlogPost", "Description");
            DropColumn("dbo.BlogPost", "Author");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BlogPost", "Author", c => c.String(nullable: false));
            AddColumn("dbo.BlogPost", "Description", c => c.String(nullable: false));
            DropColumn("dbo.BlogPost", "Category");
            DropColumn("dbo.BlogPost", "Content");
        }
    }
}
