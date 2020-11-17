namespace obligatorio1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Monedas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Monedas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Simbolo = c.String(),
                        Cotizacion = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Monedas");
        }
    }
}
