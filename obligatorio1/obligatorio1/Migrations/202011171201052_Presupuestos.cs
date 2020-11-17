namespace obligatorio1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Presupuestos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CategoriaMontos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Monto = c.Double(nullable: false),
                        Categoria_Id = c.Int(),
                        Presupuesto_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id)
                .ForeignKey("dbo.Presupuestos", t => t.Presupuesto_Id)
                .Index(t => t.Categoria_Id)
                .Index(t => t.Presupuesto_Id);
            
            CreateTable(
                "dbo.Presupuestos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CategoriaMontos", "Presupuesto_Id", "dbo.Presupuestos");
            DropForeignKey("dbo.CategoriaMontos", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.CategoriaMontos", new[] { "Presupuesto_Id" });
            DropIndex("dbo.CategoriaMontos", new[] { "Categoria_Id" });
            DropTable("dbo.Presupuestos");
            DropTable("dbo.CategoriaMontos");
        }
    }
}
