namespace LTQL28.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_table_employee : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        MyProperty = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.MyProperty);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        PersonName = c.String(),
                        Company = c.String(),
                        Address = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
            DropTable("dbo.Accounts");
        }
    }
}
