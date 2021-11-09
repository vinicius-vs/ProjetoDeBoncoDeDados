namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Condominios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Condominios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cnpj = c.String(),
                        nome = c.String(),
                        endereco = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Condominios");
        }
    }
}
