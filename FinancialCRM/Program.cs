using Autofac;
using FinancialCRM.Business.Abstract;
using FinancialCRM.Business.Concrete;
using FinancialCRM.Business.Validation.FluentValidation;
using FinancialCRM.Business.ValidationRules.FluentValidation;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.DataAccess.Concrete;
using FinancialCRM.DataAccess.Contexts;
using FinancialCRM.Entities.Concrete;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace FinancialCRM.UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var builder = new ContainerBuilder();

            builder.Register(c =>
            {
                var optionsBuilder = new DbContextOptionsBuilder<BankDbContext>();
                optionsBuilder.UseSqlServer("Server=CAVLAK\\SQLEXPRESS;Database=FinancialCRM;Trusted_Connection=True;TrustServerCertificate=True");
                optionsBuilder.UseLazyLoadingProxies();
                return new BankDbContext(optionsBuilder.Options);
            }).As<DbContext>().AsSelf().InstancePerLifetimeScope();

            builder.RegisterType<BankManager>().As<IBankService>().SingleInstance();
            builder.RegisterType<BankProcessManager>().As<IBankProcessService>().SingleInstance();
            builder.RegisterType<BillManager>().As<IBillService>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();
            builder.RegisterType<SpendingManager>().As<ISpendingService>().SingleInstance();
            builder.RegisterType<RegisterManager>().As<IRegisterService>().SingleInstance();

            builder.RegisterType<BankValidator>().As<IValidator<Bank>>().SingleInstance();
            builder.RegisterType<BankProcessValidator>().As<IValidator<BankProcess>>().SingleInstance();
            builder.RegisterType<BillValidator>().As<IValidator<Bill>>().SingleInstance();
            builder.RegisterType<CategoryValidator>().As<IValidator<Category>>().SingleInstance();
            builder.RegisterType<SpendingValidator>().As<IValidator<Spending>>().SingleInstance();
            builder.RegisterType<UserValidator>().As<IValidator<User>>().SingleInstance();

            builder.RegisterType<BankDal>().As<IBankDal>().SingleInstance();
            builder.RegisterType<BankProcessDal>().As<IBankProcessDal>().SingleInstance();
            builder.RegisterType<BillDal>().As<IBillDal>().SingleInstance();
            builder.RegisterType<CategoryDal>().As<ICategoryDal>().SingleInstance();
            builder.RegisterType<SpendingDal>().As<ISpendingDal>().SingleInstance();
            builder.RegisterType<RegisterDal>().As<IRegisterDal>().SingleInstance();

            var container = builder.Build();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var scope = container.BeginLifetimeScope())
            {
                var bankService = scope.Resolve<IBankService>();
                var bankProcessService = scope.Resolve<IBankProcessService>();
                var billService = scope.Resolve<IBillService>();
                var categoryService = scope.Resolve<ICategoryService>();
                var spendingService = scope.Resolve<ISpendingService>();
                var registerService = scope.Resolve<IRegisterService>();

                ApplicationConfiguration.Initialize();
                Application.Run(new LoginUI(registerService,bankService,bankProcessService,billService,categoryService,spendingService));
            }
        }
    }
}