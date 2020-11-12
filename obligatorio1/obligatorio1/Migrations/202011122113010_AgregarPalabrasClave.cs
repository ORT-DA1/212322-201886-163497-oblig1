namespace obligatorio1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarPalabrasClave : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PalabraClaves",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Palabra = c.String(),
                        Categoria_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Id)
                .Index(t => t.Categoria_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PalabraClaves", "Categoria_Id", "dbo.Categorias");
            DropIndex("dbo.PalabraClaves", new[] { "Categoria_Id" });
            DropTable("dbo.PalabraClaves");
        }
    }
}
