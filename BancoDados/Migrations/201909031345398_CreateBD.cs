namespace BancoDados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateBD : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produtos", "Nome", c => c.String());
            AddColumn("dbo.Produtos", "Quant", c => c.Int(nullable: false));
            AddColumn("dbo.Produtos", "Preco", c => c.Double(nullable: false));
            AddColumn("dbo.Produtos", "CriadoEm", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Produtos", "CriadoEm");
            DropColumn("dbo.Produtos", "Preco");
            DropColumn("dbo.Produtos", "Quant");
            DropColumn("dbo.Produtos", "Nome");
        }
    }
}
