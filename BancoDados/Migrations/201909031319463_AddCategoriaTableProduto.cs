namespace BancoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoriaTableProduto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        idProduto = c.Int(nullable: false, identity: true),
                        Categoria = c.String(),
                    })
                .PrimaryKey(t => t.idProduto);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Produtos");
        }
    }
}
