namespace obligatorio1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablasNuevas : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gastoes", "Categoria_Id", "dbo.Categorias");
            DropForeignKey("dbo.Gastoes", "Moneda_Id", "dbo.Monedas");
            DropIndex("dbo.Gastoes", new[] { "Categoria_Id" });
            DropIndex("dbo.Gastoes", new[] { "Moneda_Id" });
            DropTable("dbo.Gastoes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Gastoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Monto = c.Double(nullable: false),
                        Descripcion = c.String(),
                        MontoEnPesos = c.Double(nullable: false),
                        Fecha = c.DateTime(),
                        Fecha1 = c.Int(),
                        Categoria_Id = c.Int(),
                        Moneda_Id = c.Int(),
                        TipoGasto = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Gastoes", "Moneda_Id");
            CreateIndex("dbo.Gastoes", "Categoria_Id");
            AddForeignKey("dbo.Gastoes", "Moneda_Id", "dbo.Monedas", "Id");
            AddForeignKey("dbo.Gastoes", "Categoria_Id", "dbo.Categorias", "Id");
        }
    }
}
