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
                file.Name = $"ResultsExamination{amountFile}.pdb";
                context.Files.Add(file);
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
                act.PlanPremise = file;
                context.ResultsExaminationActs.Add(act);
                context.SaveChanges();
            }
        }
    }
}
