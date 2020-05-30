namespace Veterinaria.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Imagen : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pets", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pets", "Image", c => c.Byte(nullable: false));
        }
    }
}
