namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMembershipTypeEntryWithNames : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name ='Pay as you go' where DurationInMonths = 0");
            Sql("Update MembershipTypes Set Name ='Monthly' where DurationInMonths = 1");
            Sql("Update MembershipTypes Set Name ='Quarterly' where DurationInMonths = 3");
            Sql("Update MembershipTypes Set Name ='Annually' where DurationInMonths = 12");

        }
        public override void Down()
        {
        }
    }
}
