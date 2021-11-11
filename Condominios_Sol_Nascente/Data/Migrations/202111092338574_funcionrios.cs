namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class funcionrios : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Funcionarios",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        cpf = c.String(),
                        turno = c.String(),
                        funcao = c.String(),
                        salario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        nome = c.String(),
                        endereco = c.String(),
                        condominio_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Condominios", t => t.condominio_id)
                .Index(t => t.condominio_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Funcionarios", "condominio_id", "dbo.Condominios");
            DropIndex("dbo.Funcionarios", new[] { "condominio_id" });
            DropTable("dbo.Funcionarios");
        }
    }
}
