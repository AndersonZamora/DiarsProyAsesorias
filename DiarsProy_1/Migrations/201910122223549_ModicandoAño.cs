namespace DiarsProy_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModicandoAño : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pelicula", "Año", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pelicula", "Año", c => c.Int(nullable: false));
        }
    }
}
