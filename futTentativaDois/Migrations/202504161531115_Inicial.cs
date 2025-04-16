namespace futTentativaDois.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimeFutebols",
                c => new
                    {
                        TimeFutebolId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        AnoFundacao = c.Int(nullable: false),
                        Estadio = c.String(),
                        CapacidadeEstadio = c.Int(nullable: false),
                        CorPrimaria = c.String(),
                        CorSecundaria = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.TimeFutebolId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimeFutebols");
        }
    }
}
