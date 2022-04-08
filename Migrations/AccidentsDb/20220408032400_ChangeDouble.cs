using Microsoft.EntityFrameworkCore.Migrations;

namespace UtahMotorVehicleAccidentAnalysis.Migrations.AccidentsDb
{
    public partial class ChangeDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "WORK_ZONE_RELATED",
                table: "Accidents",
                newName: "work_zone_related");

            migrationBuilder.RenameColumn(
                name: "WILD_ANIMAL_RELATED",
                table: "Accidents",
                newName: "wild_animal_related");

            migrationBuilder.RenameColumn(
                name: "UNRESTRAINED",
                table: "Accidents",
                newName: "unrestrained");

            migrationBuilder.RenameColumn(
                name: "TEENAGE_DRIVER_INVOLVED",
                table: "Accidents",
                newName: "teenage_driver_involved");

            migrationBuilder.RenameColumn(
                name: "SINGLE_VEHICLE",
                table: "Accidents",
                newName: "single_vehicle");

            migrationBuilder.RenameColumn(
                name: "ROUTE",
                table: "Accidents",
                newName: "route");

            migrationBuilder.RenameColumn(
                name: "ROADWAY_DEPARTURE",
                table: "Accidents",
                newName: "roadway_departure");

            migrationBuilder.RenameColumn(
                name: "PEDESTRIAN_INVOLVED",
                table: "Accidents",
                newName: "pedestrian_involved");

            migrationBuilder.RenameColumn(
                name: "OVERTURN_ROLLOVER",
                table: "Accidents",
                newName: "overturn_rollover");

            migrationBuilder.RenameColumn(
                name: "OLDER_DRIVER_INVOLVED",
                table: "Accidents",
                newName: "older_driver_involved");

            migrationBuilder.RenameColumn(
                name: "NIGHT_DARK_CONDITION",
                table: "Accidents",
                newName: "night_dark_condition");

            migrationBuilder.RenameColumn(
                name: "MOTORCYCLE_INVOLVED",
                table: "Accidents",
                newName: "motorcycle_involved");

            migrationBuilder.RenameColumn(
                name: "MILEPOINT",
                table: "Accidents",
                newName: "milepoint");

            migrationBuilder.RenameColumn(
                name: "MAIN_ROAD_NAME",
                table: "Accidents",
                newName: "main_road_name");

            migrationBuilder.RenameColumn(
                name: "LONG_UTM_X",
                table: "Accidents",
                newName: "long_utm_x");

            migrationBuilder.RenameColumn(
                name: "LAT_UTM_Y",
                table: "Accidents",
                newName: "lat_utm_y");

            migrationBuilder.RenameColumn(
                name: "INTERSECTION_RELATED",
                table: "Accidents",
                newName: "intersection_related");

            migrationBuilder.RenameColumn(
                name: "IMPROPER_RESTRAINT",
                table: "Accidents",
                newName: "improper_restraint");

            migrationBuilder.RenameColumn(
                name: "DUI",
                table: "Accidents",
                newName: "dui");

            migrationBuilder.RenameColumn(
                name: "DROWSY_DRIVING",
                table: "Accidents",
                newName: "drowsy_driving");

            migrationBuilder.RenameColumn(
                name: "DOMESTIC_ANIMAL_RELATED",
                table: "Accidents",
                newName: "domestic_animal_related");

            migrationBuilder.RenameColumn(
                name: "DISTRACTED_DRIVING",
                table: "Accidents",
                newName: "distracted_driving");

            migrationBuilder.RenameColumn(
                name: "CRASH_SEVERITY_ID",
                table: "Accidents",
                newName: "crash_severity_id");

            migrationBuilder.RenameColumn(
                name: "CRASH_DATETIME",
                table: "Accidents",
                newName: "crash_datetime");

            migrationBuilder.RenameColumn(
                name: "COUNTY_NAME",
                table: "Accidents",
                newName: "county_name");

            migrationBuilder.RenameColumn(
                name: "COMMERCIAL_MOTOR_VEH_INVOLVED",
                table: "Accidents",
                newName: "commercial_motor_veh_involved");

            migrationBuilder.RenameColumn(
                name: "CITY",
                table: "Accidents",
                newName: "city");

            migrationBuilder.RenameColumn(
                name: "BICYCLIST_INVOLVED",
                table: "Accidents",
                newName: "bicyclist_involved");

            migrationBuilder.RenameColumn(
                name: "CRASH_ID",
                table: "Accidents",
                newName: "crash_id");

            migrationBuilder.AlterColumn<string>(
                name: "work_zone_related",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "wild_animal_related",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "unrestrained",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "teenage_driver_involved",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "single_vehicle",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "roadway_departure",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "pedestrian_involved",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "overturn_rollover",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "older_driver_involved",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "night_dark_condition",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "motorcycle_involved",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<double>(
                name: "milepoint",
                table: "Accidents",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "long_utm_x",
                table: "Accidents",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "lat_utm_y",
                table: "Accidents",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "intersection_related",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "improper_restraint",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "dui",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "drowsy_driving",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "domestic_animal_related",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "distracted_driving",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "commercial_motor_veh_involved",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<string>(
                name: "bicyclist_involved",
                table: "Accidents",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "work_zone_related",
                table: "Accidents",
                newName: "WORK_ZONE_RELATED");

            migrationBuilder.RenameColumn(
                name: "wild_animal_related",
                table: "Accidents",
                newName: "WILD_ANIMAL_RELATED");

            migrationBuilder.RenameColumn(
                name: "unrestrained",
                table: "Accidents",
                newName: "UNRESTRAINED");

            migrationBuilder.RenameColumn(
                name: "teenage_driver_involved",
                table: "Accidents",
                newName: "TEENAGE_DRIVER_INVOLVED");

            migrationBuilder.RenameColumn(
                name: "single_vehicle",
                table: "Accidents",
                newName: "SINGLE_VEHICLE");

            migrationBuilder.RenameColumn(
                name: "route",
                table: "Accidents",
                newName: "ROUTE");

            migrationBuilder.RenameColumn(
                name: "roadway_departure",
                table: "Accidents",
                newName: "ROADWAY_DEPARTURE");

            migrationBuilder.RenameColumn(
                name: "pedestrian_involved",
                table: "Accidents",
                newName: "PEDESTRIAN_INVOLVED");

            migrationBuilder.RenameColumn(
                name: "overturn_rollover",
                table: "Accidents",
                newName: "OVERTURN_ROLLOVER");

            migrationBuilder.RenameColumn(
                name: "older_driver_involved",
                table: "Accidents",
                newName: "OLDER_DRIVER_INVOLVED");

            migrationBuilder.RenameColumn(
                name: "night_dark_condition",
                table: "Accidents",
                newName: "NIGHT_DARK_CONDITION");

            migrationBuilder.RenameColumn(
                name: "motorcycle_involved",
                table: "Accidents",
                newName: "MOTORCYCLE_INVOLVED");

            migrationBuilder.RenameColumn(
                name: "milepoint",
                table: "Accidents",
                newName: "MILEPOINT");

            migrationBuilder.RenameColumn(
                name: "main_road_name",
                table: "Accidents",
                newName: "MAIN_ROAD_NAME");

            migrationBuilder.RenameColumn(
                name: "long_utm_x",
                table: "Accidents",
                newName: "LONG_UTM_X");

            migrationBuilder.RenameColumn(
                name: "lat_utm_y",
                table: "Accidents",
                newName: "LAT_UTM_Y");

            migrationBuilder.RenameColumn(
                name: "intersection_related",
                table: "Accidents",
                newName: "INTERSECTION_RELATED");

            migrationBuilder.RenameColumn(
                name: "improper_restraint",
                table: "Accidents",
                newName: "IMPROPER_RESTRAINT");

            migrationBuilder.RenameColumn(
                name: "dui",
                table: "Accidents",
                newName: "DUI");

            migrationBuilder.RenameColumn(
                name: "drowsy_driving",
                table: "Accidents",
                newName: "DROWSY_DRIVING");

            migrationBuilder.RenameColumn(
                name: "domestic_animal_related",
                table: "Accidents",
                newName: "DOMESTIC_ANIMAL_RELATED");

            migrationBuilder.RenameColumn(
                name: "distracted_driving",
                table: "Accidents",
                newName: "DISTRACTED_DRIVING");

            migrationBuilder.RenameColumn(
                name: "crash_severity_id",
                table: "Accidents",
                newName: "CRASH_SEVERITY_ID");

            migrationBuilder.RenameColumn(
                name: "crash_datetime",
                table: "Accidents",
                newName: "CRASH_DATETIME");

            migrationBuilder.RenameColumn(
                name: "county_name",
                table: "Accidents",
                newName: "COUNTY_NAME");

            migrationBuilder.RenameColumn(
                name: "commercial_motor_veh_involved",
                table: "Accidents",
                newName: "COMMERCIAL_MOTOR_VEH_INVOLVED");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Accidents",
                newName: "CITY");

            migrationBuilder.RenameColumn(
                name: "bicyclist_involved",
                table: "Accidents",
                newName: "BICYCLIST_INVOLVED");

            migrationBuilder.RenameColumn(
                name: "crash_id",
                table: "Accidents",
                newName: "CRASH_ID");

            migrationBuilder.AlterColumn<bool>(
                name: "WORK_ZONE_RELATED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "WILD_ANIMAL_RELATED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "UNRESTRAINED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "TEENAGE_DRIVER_INVOLVED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SINGLE_VEHICLE",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "ROADWAY_DEPARTURE",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "PEDESTRIAN_INVOLVED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "OVERTURN_ROLLOVER",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "OLDER_DRIVER_INVOLVED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "NIGHT_DARK_CONDITION",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "MOTORCYCLE_INVOLVED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MILEPOINT",
                table: "Accidents",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "LONG_UTM_X",
                table: "Accidents",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "LAT_UTM_Y",
                table: "Accidents",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<bool>(
                name: "INTERSECTION_RELATED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "IMPROPER_RESTRAINT",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DUI",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DROWSY_DRIVING",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DOMESTIC_ANIMAL_RELATED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "DISTRACTED_DRIVING",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "COMMERCIAL_MOTOR_VEH_INVOLVED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "BICYCLIST_INVOLVED",
                table: "Accidents",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
