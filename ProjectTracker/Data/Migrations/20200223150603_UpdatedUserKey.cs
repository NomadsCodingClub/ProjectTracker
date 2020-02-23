using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTracker.Data.Migrations
{
    public partial class UpdatedUserKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_UserID",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_FromID",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ToID",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_CreatedByID",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_CreatedByID",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_OwnerID",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CreatedByID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_OwnerID",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CreatedByID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Messages_FromID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ToID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Comments_UserID",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "OwnerID",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CreatedByID",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "FromID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ToID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUsername",
                table: "Tasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerUsername",
                table: "Tasks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedByUsername",
                table: "Projects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FromUsername",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ToUsername",
                table: "Messages",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "Comments",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CreatedByUsername",
                table: "Tasks",
                column: "CreatedByUsername");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_OwnerUsername",
                table: "Tasks",
                column: "OwnerUsername");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CreatedByUsername",
                table: "Projects",
                column: "CreatedByUsername");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromUsername",
                table: "Messages",
                column: "FromUsername");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToUsername",
                table: "Messages",
                column: "ToUsername");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_Username",
                table: "Comments",
                column: "Username");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_Username",
                table: "Comments",
                column: "Username",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_FromUsername",
                table: "Messages",
                column: "FromUsername",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ToUsername",
                table: "Messages",
                column: "ToUsername",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_CreatedByUsername",
                table: "Projects",
                column: "CreatedByUsername",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_CreatedByUsername",
                table: "Tasks",
                column: "CreatedByUsername",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_OwnerUsername",
                table: "Tasks",
                column: "OwnerUsername",
                principalTable: "Users",
                principalColumn: "Username",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Users_Username",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_FromUsername",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Users_ToUsername",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Users_CreatedByUsername",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_CreatedByUsername",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_OwnerUsername",
                table: "Tasks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_CreatedByUsername",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_OwnerUsername",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Projects_CreatedByUsername",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Messages_FromUsername",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_ToUsername",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Comments_Username",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CreatedByUsername",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "OwnerUsername",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "CreatedByUsername",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "FromUsername",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "ToUsername",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "Comments");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CreatedByID",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OwnerID",
                table: "Tasks",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CreatedByID",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FromID",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ToID",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_CreatedByID",
                table: "Tasks",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_OwnerID",
                table: "Tasks",
                column: "OwnerID");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_CreatedByID",
                table: "Projects",
                column: "CreatedByID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_FromID",
                table: "Messages",
                column: "FromID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ToID",
                table: "Messages",
                column: "ToID");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserID",
                table: "Comments",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Users_UserID",
                table: "Comments",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_FromID",
                table: "Messages",
                column: "FromID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Users_ToID",
                table: "Messages",
                column: "ToID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Users_CreatedByID",
                table: "Projects",
                column: "CreatedByID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_CreatedByID",
                table: "Tasks",
                column: "CreatedByID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_OwnerID",
                table: "Tasks",
                column: "OwnerID",
                principalTable: "Users",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
