using ResultsExamination.DataBase.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using File = ResultsExamination.DataBase.Tables.File;

namespace ResultsExamination.DataBase
{
    public class ContextResultsExamination : DbContext
    {
        public static string ConnectionString = "DbConnectionString";

        public ContextResultsExamination() : base(ConnectionString)
        {

        }
        /// <summary>
        /// Исполнители актов
        /// </summary>
        public DbSet<ActExecutor> ActExecutors { get; set; }

        /// <summary>
        /// Получатели актов
        /// </summary>
        public DbSet<ActRecipient> ActRecipients { get; set; }

        /// <summary>
        /// Исполнители
        /// </summary>
        public DbSet<Executor> Executors { get; set; }

        /// <summary>
        /// Получатели
        /// </summary>
        public DbSet<Recipient> Recipients { get; set; }

        /// <summary>
        /// Документы хранящиеся в базе данных
        /// </summary>
        public DbSet<File> Files { get; set; }

        /// <summary>
        /// Физические лица
        /// </summary>
        public DbSet<Person> Persons { get; set; }

        /// <summary>
        /// Должности
        /// </summary>
        public DbSet<Post> Posts { get; set; }

        /// <summary>
        /// Акты результатов обследования
        /// </summary>
        public DbSet<ResultsExaminationAct> ResultsExaminationActs { get; set; }

        /// <summary>
        /// Помещения
        /// </summary>
        public DbSet<Premise> Premises { get; set; }

        /// <summary>
        /// Покрытия стен
        /// </summary>
        public DbSet<WallСovering> WallСoverings { get; set; }

        /// <summary>
        /// Типы стены помещения
        /// </summary>
        public DbSet<WallPremiseType> WallPremiseTypes { get; set; }

        /// <summary>
        /// Строительные дефекты
        /// </summary>
        public DbSet<ConstructionDefect> ConstructionDefects { get; set; }

        /// <summary>
        /// Исполнения пола
        /// </summary>
        public DbSet<FloorPerformanse> FloorPerformanses { get; set; }

        /// <summary>
        /// Виды покрытия пола
        /// </summary>
        public DbSet<FloorType> FloorTypes { get; set; }

        /// <summary>
        /// Двери
        /// </summary>
        public DbSet<Door> Doors { get; set; }

        /// <summary>
        /// Материалы двери
        /// </summary>
        public DbSet<DoorMaterial> DoorMaterials { get; set; }

        /// <summary>
        /// Материал фальшпотолка
        /// </summary>
        public DbSet<FakeFloorMaterial> FakeFloorMaterials { get; set; }

        /// <summary>
        /// Окна
        /// </summary>
        public DbSet<Window> Windows { get; set; }

        /// <summary>
        /// Исполнение защитных решёток
        /// </summary>
        public DbSet<ProtectGridPerfomanse> ProtectGridPerfomanses { get; set; }
        
        /// <summary>
        /// Кондиционеры
        /// </summary>
        public DbSet<Conditioner> Conditioners { get; set; }

        /// <summary>
        /// Источники освещения
        /// </summary>
        public DbSet<LightSourse> LightSourses { get; set; }

        /// <summary>
        ///  Инженерно-технические обеспечения
        /// </summary>
        public DbSet<EngineringTechnicalProvision> EngineringTechnicalProvisions { get; set; }

        /// <summary>
        /// Тестирование подключения к базе данных, добавление новых данных, сохранение изменений
        /// </summary>
        public static void Testing()
        {
            using (ContextResultsExamination context = new ContextResultsExamination())
            {
                int amountPerson = context.Persons.Count();
                Person person = new Person();
                person.LastName = $"LastName {amountPerson}";
                person.Name = $"Name {amountPerson}";
                person.MiddleName = $"MiddleName {amountPerson}";
                person.DataBirth = DateTime.Now;
                context.Persons.Add(person);
                context.SaveChanges();

                int amountPost = context.Posts.Count();
                Post post = new Post();
                post.Name = $"Post {amountPost}";
                context.Posts.Add(post);
                context.SaveChanges();

                int amountEx = context.Executors.Count();
                Executor executor = new Executor();
                executor.Person = person;
                executor.Post = post;
                context.Executors.Add(executor);
                context.SaveChanges();

                ActExecutor actExecutor = new ActExecutor();
                actExecutor.Executor = executor;
                context.ActExecutors.Add(actExecutor);
                context.SaveChanges();

                int amountR = context.Recipients.Count();
                Recipient recipient = new Recipient();
                recipient.Person = person;
                recipient.Post = post;
                context.Recipients.Add(recipient);
                context.SaveChanges();

                ActRecipient actRecipient = new ActRecipient();
                actRecipient.Recipient = recipient;
                context.ActRecipients.Add(actRecipient);
                context.SaveChanges();

                int amountFile = context.Files.Count();
                File file = new File(Path.Combine(Application.StartupPath, $"ResultsExamination.exe.config"));
                file.Name = $"ResultsExamination{amountFile}.exe.config";
                context.Files.Add(file);
                context.SaveChanges();

                int amountWallСoverings = context.WallСoverings.Count();
                WallСovering wallСovering = new WallСovering();
                wallСovering.Name = $"WallСovering {amountWallСoverings}";
                context.WallСoverings.Add(wallСovering);
                context.SaveChanges();

                int amountwallPremiseType = context.WallPremiseTypes.Count();
                WallPremiseType wallPremiseType = new WallPremiseType();
                wallPremiseType.Name = $"wallPremiseType {amountwallPremiseType}";
                context.WallPremiseTypes.Add(wallPremiseType);
                context.SaveChanges();

                int amountConstructionDefects = context.ConstructionDefects.Count();
                ConstructionDefect constructionDefect = new ConstructionDefect();
                constructionDefect.Name = $"constructionDefect {amountConstructionDefects}";
                context.ConstructionDefects.Add(constructionDefect);
                context.SaveChanges();

                int amountFloorPerformanses = context.FloorPerformanses.Count();
                FloorPerformanse floorPerformanse = new FloorPerformanse();
                floorPerformanse.Name = $"floorPerformanse {amountFloorPerformanses}";
                context.FloorPerformanses.Add(floorPerformanse);
                context.SaveChanges();

                int amountfloorType = context.FloorTypes.Count();
                FloorType floorType = new FloorType();
                floorType.Name = $"floorType {amountfloorType}";
                context.FloorTypes.Add(floorType);
                context.SaveChanges();

                int amountdoorMaterial = context.DoorMaterials.Count();
                DoorMaterial doorMaterial = new DoorMaterial();
                doorMaterial.Name = $"doorMaterial {amountdoorMaterial}";
                context.DoorMaterials.Add(doorMaterial);
                context.SaveChanges();

                int amountFakeFloorMaterial = context.FakeFloorMaterials.Count();
                FakeFloorMaterial fakeFloorMaterials = new FakeFloorMaterial();
                fakeFloorMaterials.Name = $"fakeFloorMaterials {amountFakeFloorMaterial}";
                context.FakeFloorMaterials.Add(fakeFloorMaterials);
                context.SaveChanges();

                int amountDoor = context.Doors.Count();
                Door door = new Door();
                door.Material = doorMaterial;
                door.Single = amountDoor / 2 == 0;
                door.Dual = amountDoor / 2 != 0;
                door.ExistLock = amountDoor / 2 == 0;
                door.ExistSeal = amountDoor / 2 == 0;
                door.Height = amountDoor;
                door.Width = amountDoor;
                door.WidthTambour = amountDoor;
                door.Thickness = amountDoor;
                context.Doors.Add(door);
                context.SaveChanges();

                int amountProtectGridPerfomanse = context.ProtectGridPerfomanses.Count();
                ProtectGridPerfomanse protectGridPerfomanse = new ProtectGridPerfomanse();
                protectGridPerfomanse.Name = $"protectGridPerfomanse {amountProtectGridPerfomanse}";
                context.ProtectGridPerfomanses.Add(protectGridPerfomanse);
                context.SaveChanges();

                int amountWindow = context.Windows.Count();
                Window window = new Window();
                window.Height = amountWindow;
                window.Width = amountWindow;
                window.IsPlasticMaterial = amountWindow / 2 == 0;
                window.IsWoodMaterial = amountWindow / 2 != 0;
                window.AmmountGlass = amountWindow;
                window.AmmountTransom = amountWindow;
                window.ProtectGridPerfomanse = protectGridPerfomanse;
                context.Windows.Add(window);
                context.SaveChanges();

                int amountconditioner = context.Conditioners.Count();
                Conditioner conditioner = new Conditioner();
                conditioner.SystemFreon = amountconditioner / 2 == 0;
                conditioner.SystemFankoil = amountconditioner / 2 == 0;
                conditioner.Name = $"Name {amountconditioner}";
                context.Conditioners.Add(conditioner);
                context.SaveChanges();

                int amountlightSourse = context.LightSourses.Count();
                LightSourse lightSourse = new LightSourse();
                lightSourse.AmountIncLamps = amountlightSourse;
                lightSourse.AmountLumLamps = amountlightSourse;
                lightSourse.AmountPlacesPeople = amountlightSourse;
                context.LightSourses.Add(lightSourse);
                context.SaveChanges();

                int amountEngineringTechnicalProvision = context.EngineringTechnicalProvisions.Count();
                EngineringTechnicalProvision engineringTechnicalProvision = new EngineringTechnicalProvision();
                engineringTechnicalProvision.Conditioner = conditioner;
                engineringTechnicalProvision.LightSourse = lightSourse;
                engineringTechnicalProvision.HeatingSystem = HeatingSystemType.Водяная;
                engineringTechnicalProvision.Ventilation = VentilationType.Принудительная;
                context.EngineringTechnicalProvisions.Add(engineringTechnicalProvision);
                context.SaveChanges();

                int amountPremise = context.Premises.Count();
                Premise premise = new Premise();
                premise.Name = $"Name {amountPremise}";
                premise.Num = $"Num {amountPremise}";
                premise.Height = amountPremise;
                premise.Width = amountPremise;
                premise.Depth = amountPremise;
                premise.Floor = amountPremise;
                premise.FirstFloor = amountPremise / 2 == 0;
                premise.LastFloor = amountPremise / 2 != 0;
                premise.EquipmentStorage = $"EquipmentStorage {amountPremise}";
                premise.WallsServisePremises = context.WallPremiseTypes?.OrderByDescending(e => e.Id).Take(2).ToList();
                premise.WallPremiseCorridor = context.WallPremiseTypes?.OrderByDescending(e => e.Id).First();
                premise.HeightCeiling = amountPremise;
                premise.FakeHeightCeiling = amountPremise / 2 == 0 ? null : (double?)amountPremise;
                premise.WallThickness = amountPremise;
                premise.WallСovering = wallСovering;
                premise.FakeDepthFloor = amountPremise / 2 == 0 ? null : (double?)amountPremise;
                premise.FakeFloorMaterial = context.FakeFloorMaterials?.OrderByDescending(e => e.Id).First();
                premise.PureCeiling = amountPremise / 2 == 0;
                premise.ExistAntistaticFloor = amountPremise / 2 == 0;
                premise.DefferenceSizeFloorBetweenCorridor = amountPremise;
                premise.ConstructionDefects = context.ConstructionDefects?.OrderByDescending(e => e.Id).Take(2).ToList();
                premise.FloorPerformanse = floorPerformanse;
                premise.FloorType = floorType;
                premise.Door = door;
                premise.Windows = context.Windows?.OrderByDescending(e => e.Id).Take(2).ToList();
                premise.EngineringTechnicalProvision = context.EngineringTechnicalProvisions?.OrderByDescending(e => e.Id).First();
                context.Premises.Add(premise);
                context.SaveChanges();

                int amountActs= context.ResultsExaminationActs.Count();
                ResultsExaminationAct act = new ResultsExaminationAct();
                act.NumObject = $"NumObject {amountActs}";
                act.AddresObject = $"AddresObject {amountActs}";
                act.ActExecutors = context.ActExecutors?.OrderByDescending(e => e.Id).Take(2).ToList();
                act.ActRecipients = context.ActRecipients?.OrderByDescending(e => e.Id).Take(2).ToList();
                act.Additionally = $"Additionally {amountActs}";
                act.CommissionConclusion = amountActs / 2 == 0;
                act.ShortcomingEliminate = $"ShortcomingEliminate {amountActs}";
                act.CorrectionPeriodIn = DateTime.Now;
                act.CorrectionPeriodOut = act.CorrectionPeriodIn.Value.AddMonths(6);
                act.Premise = premise;
                act.PlanPremise = file;

                context.ResultsExaminationActs.Add(act);
                context.SaveChanges();
            }
        }
    }
}
