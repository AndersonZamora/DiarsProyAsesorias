namespace DiarsProy_1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Director",
                c => new
                    {
                        IdDirector = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellidos = c.String(),
                    })
                .PrimaryKey(t => t.IdDirector);
            
            CreateTable(
                "dbo.Pelicula",
                c => new
                    {
                        IdPelicula = c.Int(nullable: false, identity: true),
                        NombrePelicula = c.String(),
                        Año = c.Int(nullable: false),
                        DirectorId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdPelicula)
                .ForeignKey("dbo.Director", t => t.DirectorId, cascadeDelete: true)
                .Index(t => t.DirectorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pelicula", "DirectorId", "dbo.Director");
            DropIndex("dbo.Pelicula", new[] { "DirectorId" });
            DropTable("dbo.Pelicula");
            DropTable("dbo.Director");
        }
    }
}
