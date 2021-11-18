namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newFuncionario : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Funcionarios", name: "condominio_id", newName: "condominioId");
            RenameIndex(table: "dbo.Funcionarios", name: "IX_condominio_id", newName: "IX_condominioId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Funcionarios", name: "IX_condominioId", newName: "IX_condominio_id");
            RenameColumn(table: "dbo.Funcionarios", name: "condominioId", newName: "condominio_id");
        }
    }
}
