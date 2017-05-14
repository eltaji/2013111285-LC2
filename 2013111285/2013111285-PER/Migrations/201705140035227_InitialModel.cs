namespace _2013132285_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asientos",
                c => new
                    {
                        asientoid = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Cinturon_cinturonid = c.Int(),
                        Carro_carroid = c.Int(),
                    })
                .PrimaryKey(t => t.asientoid)
                .ForeignKey("dbo.Cinturones", t => t.Cinturon_cinturonid)
                .ForeignKey("dbo.Carros", t => t.Carro_carroid)
                .Index(t => t.Cinturon_cinturonid)
                .Index(t => t.Carro_carroid);
            
            CreateTable(
                "dbo.Cinturones",
                c => new
                    {
                        cinturonid = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Metraje = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.cinturonid);
            
            CreateTable(
                "dbo.Carros",
                c => new
                    {
                        carroid = c.Int(nullable: false, identity: true),
                        TipoCarro = c.Int(nullable: false),
                        NumSerieChasis = c.String(),
                        Parabrisas_parabrisasid = c.Int(),
                        Propietario_propietarioid = c.Int(),
                        Volante_volanteid = c.Int(),
                        Ensambladora_ensambladoraid = c.Int(),
                    })
                .PrimaryKey(t => t.carroid)
                .ForeignKey("dbo.Parabrisas", t => t.Parabrisas_parabrisasid)
                .ForeignKey("dbo.Propietarios", t => t.Propietario_propietarioid)
                .ForeignKey("dbo.Volantes", t => t.Volante_volanteid)
                .ForeignKey("dbo.Ensambladoras", t => t.Ensambladora_ensambladoraid)
                .Index(t => t.Parabrisas_parabrisasid)
                .Index(t => t.Propietario_propietarioid)
                .Index(t => t.Volante_volanteid)
                .Index(t => t.Ensambladora_ensambladoraid);
            
            CreateTable(
                "dbo.Llantas",
                c => new
                    {
                        llantaid = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                        Carro_carroid = c.Int(),
                    })
                .PrimaryKey(t => t.llantaid)
                .ForeignKey("dbo.Carros", t => t.Carro_carroid)
                .Index(t => t.Carro_carroid);
            
            CreateTable(
                "dbo.Parabrisas",
                c => new
                    {
                        parabrisasid = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.parabrisasid);
            
            CreateTable(
                "dbo.Propietarios",
                c => new
                    {
                        propietarioid = c.Int(nullable: false, identity: true),
                        DNI = c.String(),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        LicenciaConducir = c.String(),
                    })
                .PrimaryKey(t => t.propietarioid);
            
            CreateTable(
                "dbo.Volantes",
                c => new
                    {
                        volanteid = c.Int(nullable: false, identity: true),
                        NumSerie = c.String(),
                    })
                .PrimaryKey(t => t.volanteid);
            
            CreateTable(
                "dbo.Ensambladoras",
                c => new
                    {
                        ensambladoraid = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ensambladoraid);
            
            CreateTable(
                "dbo.Automoviles",
                c => new
                    {
                        carroid = c.Int(nullable: false),
                        automovilid = c.Int(nullable: false),
                        TipoAuto = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.carroid)
                .ForeignKey("dbo.Carros", t => t.carroid)
                .Index(t => t.carroid);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        carroid = c.Int(nullable: false),
                        busid = c.Int(nullable: false),
                        TipoBus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.carroid)
                .ForeignKey("dbo.Carros", t => t.carroid)
                .Index(t => t.carroid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Buses", "carroid", "dbo.Carros");
            DropForeignKey("dbo.Automoviles", "carroid", "dbo.Carros");
            DropForeignKey("dbo.Carros", "Ensambladora_ensambladoraid", "dbo.Ensambladoras");
            DropForeignKey("dbo.Carros", "Volante_volanteid", "dbo.Volantes");
            DropForeignKey("dbo.Carros", "Propietario_propietarioid", "dbo.Propietarios");
            DropForeignKey("dbo.Carros", "Parabrisas_parabrisasid", "dbo.Parabrisas");
            DropForeignKey("dbo.Llantas", "Carro_carroid", "dbo.Carros");
            DropForeignKey("dbo.Asientos", "Carro_carroid", "dbo.Carros");
            DropForeignKey("dbo.Asientos", "Cinturon_cinturonid", "dbo.Cinturones");
            DropIndex("dbo.Buses", new[] { "carroid" });
            DropIndex("dbo.Automoviles", new[] { "carroid" });
            DropIndex("dbo.Llantas", new[] { "Carro_carroid" });
            DropIndex("dbo.Carros", new[] { "Ensambladora_ensambladoraid" });
            DropIndex("dbo.Carros", new[] { "Volante_volanteid" });
            DropIndex("dbo.Carros", new[] { "Propietario_propietarioid" });
            DropIndex("dbo.Carros", new[] { "Parabrisas_parabrisasid" });
            DropIndex("dbo.Asientos", new[] { "Carro_carroid" });
            DropIndex("dbo.Asientos", new[] { "Cinturon_cinturonid" });
            DropTable("dbo.Buses");
            DropTable("dbo.Automoviles");
            DropTable("dbo.Ensambladoras");
            DropTable("dbo.Volantes");
            DropTable("dbo.Propietarios");
            DropTable("dbo.Parabrisas");
            DropTable("dbo.Llantas");
            DropTable("dbo.Carros");
            DropTable("dbo.Cinturones");
            DropTable("dbo.Asientos");
        }
    }
}
