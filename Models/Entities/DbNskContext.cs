using Microsoft.EntityFrameworkCore;

namespace Models.Entities;

public partial class DbNskContext : DbContext
{
    /*string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;*/

    public DbNskContext()
    {
    }

    public DbNskContext(DbContextOptions<DbNskContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminLog> AdminLogs { get; set; }

    public virtual DbSet<AlserPromo> AlserPromos { get; set; }

    public virtual DbSet<Blog> Blogs { get; set; }

    public virtual DbSet<BlogCategoriesTranslation> BlogCategoriesTranslations { get; set; }

    public virtual DbSet<BlogCategory> BlogCategories { get; set; }

    public virtual DbSet<BlogsTranslation> BlogsTranslations { get; set; }

    public virtual DbSet<BusinessOsgpo> BusinessOsgpos { get; set; }

    public virtual DbSet<Calculator> Calculators { get; set; }

    public virtual DbSet<CalculatorHint> CalculatorHints { get; set; }

    public virtual DbSet<CalculatorHintsTranslation> CalculatorHintsTranslations { get; set; }

    public virtual DbSet<CalculatorLog> CalculatorLogs { get; set; }

    public virtual DbSet<CalculatorOgpoCitiesTranslation> CalculatorOgpoCitiesTranslations { get; set; }

    public virtual DbSet<CalculatorOgpoCity> CalculatorOgpoCities { get; set; }

    public virtual DbSet<CalculatorOgpoCityCode> CalculatorOgpoCityCodes { get; set; }

    public virtual DbSet<CalculatorStage> CalculatorStages { get; set; }

    public virtual DbSet<CalculatorStagesTranslation> CalculatorStagesTranslations { get; set; }

    public virtual DbSet<CalculatorsTranslation> CalculatorsTranslations { get; set; }

    public virtual DbSet<CaseRequest> CaseRequests { get; set; }

    public virtual DbSet<CategoriesTranslation> CategoriesTranslations { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<CitiesTranslation> CitiesTranslations { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Config> Configs { get; set; }

    public virtual DbSet<Contact> Contacts { get; set; }

    public virtual DbSet<ContactsTranslation> ContactsTranslations { get; set; }

    public virtual DbSet<Content> Contents { get; set; }

    public virtual DbSet<ContentTranslation> ContentTranslations { get; set; }

    public virtual DbSet<Evacuator> Evacuators { get; set; }

    public virtual DbSet<Faq> Faqs { get; set; }

    public virtual DbSet<FaqCategoriesTranslation> FaqCategoriesTranslations { get; set; }

    public virtual DbSet<FaqCategory> FaqCategories { get; set; }

    public virtual DbSet<FaqTranslation> FaqTranslations { get; set; }

    public virtual DbSet<Gallery> Galleries { get; set; }

    public virtual DbSet<GalleryImage> GalleryImages { get; set; }

    public virtual DbSet<GoszakupTender> GoszakupTenders { get; set; }

    public virtual DbSet<InsuranceCase> InsuranceCases { get; set; }

    public virtual DbSet<InsuranceCaseImage> InsuranceCaseImages { get; set; }

    public virtual DbSet<InsuranceCaseType> InsuranceCaseTypes { get; set; }

    public virtual DbSet<InsuranceCaseTypesTranslation> InsuranceCaseTypesTranslations { get; set; }

    public virtual DbSet<Language> Languages { get; set; }

    public virtual DbSet<ManagerLog> ManagerLogs { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<MenuItem> MenuItems { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<Migration> Migrations { get; set; }

    public virtual DbSet<NskApiErrorLog> NskApiErrorLogs { get; set; }

    public virtual DbSet<NskCarCharacteristic> NskCarCharacteristics { get; set; }

    public virtual DbSet<NskCarCharacteristicValue> NskCarCharacteristicValues { get; set; }

    public virtual DbSet<NskCarGeneration> NskCarGenerations { get; set; }

    public virtual DbSet<NskCarMark> NskCarMarks { get; set; }

    public virtual DbSet<NskCarModel> NskCarModels { get; set; }

    public virtual DbSet<NskCarModification> NskCarModifications { get; set; }

    public virtual DbSet<NskCarSerie> NskCarSeries { get; set; }

    public virtual DbSet<NskCarType> NskCarTypes { get; set; }

    public virtual DbSet<OffersReview> OffersReviews { get; set; }

    public virtual DbSet<OgpoFormRequest> OgpoFormRequests { get; set; }

    public virtual DbSet<OgpoRequest> OgpoRequests { get; set; }

    public virtual DbSet<OsgpoBusinessRequest> OsgpoBusinessRequests { get; set; }

    public virtual DbSet<Page> Pages { get; set; }

    public virtual DbSet<PagesTranslation> PagesTranslations { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentLog> PaymentLogs { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAction> ProductActions { get; set; }

    public virtual DbSet<ProductActionsTranslation> ProductActionsTranslations { get; set; }

    public virtual DbSet<ProductBenefit> ProductBenefits { get; set; }

    public virtual DbSet<ProductBenefitsTranslation> ProductBenefitsTranslations { get; set; }

    public virtual DbSet<ProductCategoriesTranslation> ProductCategoriesTranslations { get; set; }

    public virtual DbSet<ProductCategory> ProductCategories { get; set; }

    public virtual DbSet<ProductOsgpoChNotariusRequest> ProductOsgpoChNotariusRequests { get; set; }

    public virtual DbSet<ProductRisk> ProductRisks { get; set; }

    public virtual DbSet<ProductRisksTranslation> ProductRisksTranslations { get; set; }

    public virtual DbSet<ProductRule> ProductRules { get; set; }

    public virtual DbSet<ProductsSuggest> ProductsSuggests { get; set; }

    public virtual DbSet<ProductsTranslation> ProductsTranslations { get; set; }

    public virtual DbSet<Promo> Promos { get; set; }

    public virtual DbSet<PromoSmsNotivication> PromoSmsNotivications { get; set; }

    public virtual DbSet<PushNotification> PushNotifications { get; set; }

    public virtual DbSet<QualityService> QualityServices { get; set; }

    public virtual DbSet<Queue> Queues { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<Slider> Sliders { get; set; }

    public virtual DbSet<SourceMessage> SourceMessages { get; set; }

    public virtual DbSet<TelegramNotification> TelegramNotifications { get; set; }

    public virtual DbSet<TopManagement> TopManagements { get; set; }

    public virtual DbSet<TopManagementTranslation> TopManagementTranslations { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserActivity> UserActivities { get; set; }

    public virtual DbSet<UserDevice> UserDevices { get; set; }

    public virtual DbSet<UsersAuth> UsersAuths { get; set; }

    public virtual DbSet<UsersCode> UsersCodes { get; set; }

    public virtual DbSet<UsersLog> UsersLogs { get; set; }

    public virtual DbSet<UsersLog2> UsersLog2s { get; set; }

    public virtual DbSet<UsersLog3> UsersLog3s { get; set; }

    public virtual DbSet<UsersSendSmsUser> UsersSendSmsUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
    => optionsBuilder.UseMySQL("server=172.16.0.132;port=3306;user=root;password=EpqMenYw2k;Database=db_nsk;Convert Zero Datetime=True");
    //  => optionsBuilder.UseMySQL(connectionString);
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdminLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("admin_logs");

            entity.HasIndex(e => e.UserId, "user_id_index");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.ItemId)
                .HasColumnType("int(11)")
                .HasColumnName("item_id");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.Module)
                .HasMaxLength(255)
                .HasColumnName("module");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.AdminLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("user_id_log_fk");
        });

        modelBuilder.Entity<AlserPromo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("alser_promo");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ActivationDate)
                .HasColumnType("timestamp")
                .HasColumnName("activation_date");
            entity.Property(e => e.AgreeId)
                .HasMaxLength(100)
                .HasColumnName("agree_id");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("code");
            entity.Property(e => e.Sum)
                .HasColumnType("int(11)")
                .HasColumnName("sum");
        });

        modelBuilder.Entity<Blog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("blogs");

            entity.HasIndex(e => e.CategoryId, "blogs-category_id-idx");

            entity.HasIndex(e => e.IsActive, "blogs-is_active-idx");

            entity.HasIndex(e => e.IsUsefull, "blogs-is_usefull-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasComment("Категория")
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.IsMainpage)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_mainpage");
            entity.Property(e => e.IsUsefull)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_usefull");
            entity.Property(e => e.PublishDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("publish_date");
            entity.Property(e => e.Sefname)
                .HasMaxLength(255)
                .HasColumnName("sefname");
            entity.Property(e => e.Text)
                .HasComment("Текст")
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
            entity.Property(e => e.Views)
                .HasDefaultValueSql("'0'")
                .HasComment("Просмотры")
                .HasColumnType("int(11)")
                .HasColumnName("views");

            entity.HasOne(d => d.Category).WithMany(p => p.Blogs)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk-blogs-blogs_categories");
        });

        modelBuilder.Entity<BlogCategoriesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("blog_categories_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-blog_categories_translation");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Category).WithMany(p => p.BlogCategoriesTranslations)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk-blog_categories_blog_categories_translation");

            entity.HasOne(d => d.Lang).WithMany(p => p.BlogCategoriesTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-blog_categories_translation");
        });

        modelBuilder.Entity<BlogCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("blog_categories");

            entity.HasIndex(e => e.IsActive, "blog_categories-is_active-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.Sefname)
                .HasMaxLength(255)
                .HasColumnName("sefname");
            entity.Property(e => e.Title)
                .HasComment("Наименование")
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<BlogsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.BlogId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("blogs_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-blogs_translations");

            entity.Property(e => e.BlogId)
                .HasColumnType("int(11)")
                .HasColumnName("blog_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Description)
                .HasComment("Описание")
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Text)
                .HasComment("text")
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasComment("Заголовок")
                .HasColumnName("title");

            entity.HasOne(d => d.Blog).WithMany(p => p.BlogsTranslations)
                .HasForeignKey(d => d.BlogId)
                .HasConstraintName("fk-blogs_-blogs_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.BlogsTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-blogs_translations");
        });

        modelBuilder.Entity<BusinessOsgpo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("business_osgpo");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ActivityKindId)
                .HasMaxLength(5)
                .HasColumnName("ACTIVITY_KIND_ID");
            entity.Property(e => e.Address).HasMaxLength(20);
            entity.Property(e => e.ClientId)
                .HasMaxLength(10)
                .HasColumnName("CLIENT_ID");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DateEnd).HasColumnType("date");
            entity.Property(e => e.DateStart).HasColumnType("date");
            entity.Property(e => e.DocLic)
                .HasMaxLength(255)
                .HasColumnName("docLic");
            entity.Property(e => e.DocTer)
                .HasMaxLength(255)
                .HasColumnName("docTer");
            entity.Property(e => e.DocUd)
                .HasMaxLength(255)
                .HasColumnName("docUd");
            entity.Property(e => e.DocumentGivedDate)
                .HasColumnType("date")
                .HasColumnName("DOCUMENT_GIVED_DATE");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(10)
                .HasColumnName("DOCUMENT_NUMBER");
            entity.Property(e => e.DocumentTypeId)
                .HasMaxLength(3)
                .HasColumnName("DOCUMENT_TYPE_ID");
            entity.Property(e => e.EconomicsSectorId)
                .HasMaxLength(5)
                .HasColumnName("ECONOMICS_SECTOR_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.Iin)
                .HasMaxLength(20)
                .HasColumnName("IIN");
            entity.Property(e => e.Inssum)
                .HasMaxLength(255)
                .HasColumnName("inssum");
            entity.Property(e => e.InsurerBool).HasMaxLength(1);
            entity.Property(e => e.JuridicalPersonName)
                .HasMaxLength(100)
                .HasColumnName("Juridical_Person_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Licdate)
                .HasColumnType("date")
                .HasColumnName("licdate");
            entity.Property(e => e.Licnum)
                .HasMaxLength(20)
                .HasColumnName("licnum");
            entity.Property(e => e.MainChief)
                .HasMaxLength(100)
                .HasColumnName("MAIN_CHIEF");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.NaturalPersonBool)
                .HasMaxLength(1)
                .HasColumnName("Natural_Person_Bool");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(2)
                .HasColumnName("paymenttype");
            entity.Property(e => e.Phones)
                .HasMaxLength(20)
                .HasColumnName("PHONES");
            entity.Property(e => e.PreferredLang)
                .HasMaxLength(5)
                .HasColumnName("preferredLang");
            entity.Property(e => e.Premium)
                .HasMaxLength(255)
                .HasColumnName("premium");
            entity.Property(e => e.PremiumDiscount)
                .HasMaxLength(255)
                .HasColumnName("premiumDiscount");
            entity.Property(e => e.Regregion)
                .HasMaxLength(5)
                .HasColumnName("regregion");
            entity.Property(e => e.ResidentBool)
                .HasMaxLength(1)
                .HasColumnName("RESIDENT_BOOL");
            entity.Property(e => e.Tarif)
                .HasMaxLength(255)
                .HasColumnName("tarif");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Calculator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("calculators");

            entity.HasIndex(e => e.IsActive, "calculators-is_active-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Class)
                .HasMaxLength(255)
                .HasComment("Класс реализации")
                .HasColumnName("class");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.Sefname)
                .HasMaxLength(255)
                .HasComment("ЧПУ")
                .HasColumnName("sefname");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
            entity.Property(e => e.Weight)
                .HasColumnType("int(11)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<CalculatorHint>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("calculator_hints");

            entity.HasIndex(e => e.CalculatorId, "idx_calculator_hints_calculator_id");

            entity.HasIndex(e => e.Key, "idx_calculator_hints_keys").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CalculatorId)
                .HasColumnType("int(11)")
                .HasColumnName("calculator_id");
            entity.Property(e => e.Key).HasColumnName("key");
            entity.Property(e => e.Step)
                .HasColumnType("int(11)")
                .HasColumnName("step");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");
        });

        modelBuilder.Entity<CalculatorHintsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.HintId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("calculator_hints_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-calculator_hints_translations");

            entity.Property(e => e.HintId)
                .HasColumnType("int(11)")
                .HasColumnName("hint_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.Value)
                .HasColumnType("text")
                .HasColumnName("value");

            entity.HasOne(d => d.Hint).WithMany(p => p.CalculatorHintsTranslations)
                .HasForeignKey(d => d.HintId)
                .HasConstraintName("fk-calculator_hints-calculator_hints_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.CalculatorHintsTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-calculator_hints_translations");
        });

        modelBuilder.Entity<CalculatorLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("calculator_logs");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CalcId)
                .HasMaxLength(50)
                .HasColumnName("calc_id");
            entity.Property(e => e.CalcStatus)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("calc_status");
            entity.Property(e => e.CalcType)
                .HasMaxLength(20)
                .HasColumnName("calc_type");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Debug)
                .HasColumnType("text")
                .HasColumnName("debug");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Event)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("event");
            entity.Property(e => e.Fio)
                .HasMaxLength(100)
                .HasColumnName("fio");
            entity.Property(e => e.Iin)
                .HasMaxLength(20)
                .HasColumnName("iin");
            entity.Property(e => e.LoggedAt)
                .HasColumnType("datetime")
                .HasColumnName("logged_at");
            entity.Property(e => e.ManagerId)
                .HasColumnType("int(11)")
                .HasColumnName("manager_id");
            entity.Property(e => e.PersonType)
                .HasColumnType("int(3)")
                .HasColumnName("person_type");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.PolicyId)
                .HasColumnType("int(11)")
                .HasColumnName("policy_id");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Step)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("step");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CalculatorOgpoCitiesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.CityId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("calculator_ogpo_cities_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-calculator_ogpo_cities_translations");

            entity.Property(e => e.CityId)
                .HasColumnType("int(11)")
                .HasColumnName("city_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.City).WithMany(p => p.CalculatorOgpoCitiesTranslations)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("fk-calculator_ogpo_cities-calculator_ogpo_cities_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.CalculatorOgpoCitiesTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-calculator_ogpo_cities_translations");
        });

        modelBuilder.Entity<CalculatorOgpoCity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("calculator_ogpo_cities");

            entity.HasIndex(e => e.RegionId, "idx_calculator_ogpo_cities").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IsBigCity)
                .HasDefaultValueSql("'0'")
                .HasComment("Город обл. значения")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_big_city");
            entity.Property(e => e.IsCheckCity)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_check_city");
            entity.Property(e => e.RegionId)
                .HasComment("ID региона")
                .HasColumnType("int(11)")
                .HasColumnName("region_id");
            entity.Property(e => e.Title)
                .HasComment("Наименование")
                .HasColumnType("text")
                .HasColumnName("title");
        });

        modelBuilder.Entity<CalculatorOgpoCityCode>(entity =>
        {
            entity.HasKey(e => new { e.RegionId, e.Code }).HasName("PRIMARY");

            entity.ToTable("calculator_ogpo_city_codes");

            entity.Property(e => e.RegionId)
                .HasColumnType("int(11)")
                .HasColumnName("region_id");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("code");

            entity.HasOne(d => d.Region).WithMany(p => p.CalculatorOgpoCityCodes)
                .HasPrincipalKey(p => p.RegionId)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("fk_calculator_ogpo_city_codes");
        });

        modelBuilder.Entity<CalculatorStage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("calculator_stages");

            entity.HasIndex(e => e.CalculatorId, "product_calculator_stages-calculator_id-idx");

            entity.HasIndex(e => e.IsActive, "product_calculator_stages-is_active-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CalculatorId)
                .HasComment("Калькулятор")
                .HasColumnType("int(11)")
                .HasColumnName("calculator_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Описание этапа")
                .HasColumnName("description");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.Number)
                .HasComment("Номер этапа")
                .HasColumnType("smallint(4)")
                .HasColumnName("number");
            entity.Property(e => e.ParentId)
                .HasDefaultValueSql("'0'")
                .HasComment("Родитель")
                .HasColumnType("int(11)")
                .HasColumnName("parent_id");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("'0'")
                .HasComment("Порядок")
                .HasColumnType("int(11)")
                .HasColumnName("position");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<CalculatorStagesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.StageId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("calculator_stages_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-calculator_stages_translations");

            entity.Property(e => e.StageId)
                .HasColumnType("int(11)")
                .HasColumnName("stage_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Lang).WithMany(p => p.CalculatorStagesTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-calculator_stages_translations");

            entity.HasOne(d => d.Stage).WithMany(p => p.CalculatorStagesTranslations)
                .HasForeignKey(d => d.StageId)
                .HasConstraintName("fk-calculator_stages-calculator_stages_translations_translations");
        });

        modelBuilder.Entity<CalculatorsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.CalculatorId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("calculators_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-calculators_translations");

            entity.Property(e => e.CalculatorId)
                .HasColumnType("int(11)")
                .HasColumnName("calculator_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Calculator).WithMany(p => p.CalculatorsTranslations)
                .HasForeignKey(d => d.CalculatorId)
                .HasConstraintName("fk-calculators-calculators_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.CalculatorsTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-calculators_translations");
        });

        modelBuilder.Entity<CaseRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("case_requests");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CaseDate)
                .HasColumnType("date")
                .HasColumnName("caseDate");
            entity.Property(e => e.CaseDetails)
                .HasColumnType("text")
                .HasColumnName("caseDetails");
            entity.Property(e => e.CaseRegion)
                .HasColumnType("int(11)")
                .HasColumnName("caseRegion");
            entity.Property(e => e.CounterpartFio)
                .HasMaxLength(100)
                .HasColumnName("counterpartFio");
            entity.Property(e => e.CounterpartIin)
                .HasMaxLength(12)
                .HasColumnName("counterpartIin");
            entity.Property(e => e.CounterpartRegnum)
                .HasMaxLength(10)
                .HasColumnName("counterpartRegnum");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Documents)
                .HasColumnType("text")
                .HasColumnName("documents");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Fio)
                .HasMaxLength(100)
                .HasColumnName("fio");
            entity.Property(e => e.Iin)
                .HasMaxLength(12)
                .HasColumnName("iin");
            entity.Property(e => e.IsInjured)
                .HasColumnType("int(1)")
                .HasColumnName("isInjured");
            entity.Property(e => e.ManagerId)
                .HasColumnType("int(11)")
                .HasColumnName("manager_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.PolicyNum)
                .HasMaxLength(10)
                .HasColumnName("policyNum");
            entity.Property(e => e.Product)
                .HasMaxLength(100)
                .HasColumnName("product");
            entity.Property(e => e.Regnum)
                .HasMaxLength(10)
                .HasColumnName("regnum");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<CategoriesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("categories_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-categories_translations");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Description)
                .HasComment("Описание")
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasComment("Заголовок")
                .HasColumnName("title");

            entity.HasOne(d => d.Category).WithMany(p => p.CategoriesTranslations)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk-categories-categories_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.CategoriesTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-categories_translations");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("categories");

            entity.HasIndex(e => e.IsActive, "active");

            entity.HasIndex(e => e.Level, "level");

            entity.HasIndex(e => e.Lft, "lft");

            entity.HasIndex(e => e.ParentId, "parent_id");

            entity.HasIndex(e => e.Rgt, "rgt");

            entity.HasIndex(e => e.Root, "root");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_active");
            entity.Property(e => e.Level)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("level");
            entity.Property(e => e.Lft)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("lft");
            entity.Property(e => e.ParentId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11) unsigned")
                .HasColumnName("parent_id");
            entity.Property(e => e.Rgt)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("rgt");
            entity.Property(e => e.Root)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("root");
            entity.Property(e => e.Sefname)
                .HasMaxLength(255)
                .HasColumnName("sefname");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<CitiesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.CityId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("cities_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-cities_translations");

            entity.Property(e => e.CityId)
                .HasColumnType("int(11)")
                .HasColumnName("city_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.City).WithMany(p => p.CitiesTranslations)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("fk-cities_cities_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.CitiesTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-cities_translations");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cities");

            entity.HasIndex(e => e.IsActive, "cities-is_active-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.GeoipCity)
                .HasMaxLength(255)
                .HasComment("Город в базе GeoIP")
                .HasColumnName("geoip_city");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.Latitude).HasColumnName("latitude");
            entity.Property(e => e.Longitude).HasColumnName("longitude");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");
            entity.Property(e => e.PhoneSecondary)
                .HasMaxLength(255)
                .HasColumnName("phone_secondary");
            entity.Property(e => e.Title)
                .HasComment("Наименование")
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<Config>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("config");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Param)
                .HasMaxLength(255)
                .HasColumnName("param");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasComment("Наименование")
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasColumnType("datetime")
                .HasColumnName("update_date");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasComment("Значение")
                .HasColumnName("value");
        });

        modelBuilder.Entity<Contact>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("contacts");

            entity.HasIndex(e => e.CityId, "contacts-city_id-idx");

            entity.HasIndex(e => e.IsActive, "contacts-is_active-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasComment("Адрес")
                .HasColumnName("address");
            entity.Property(e => e.CityId)
                .HasComment("Город")
                .HasColumnType("int(11)")
                .HasColumnName("city_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Director)
                .HasMaxLength(255)
                .HasComment("Директор")
                .HasColumnName("director");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasComment("E-mail")
                .HasColumnName("email");
            entity.Property(e => e.IsActive)
                .HasColumnType("smallint(6)")
                .HasColumnName("is_active");
            entity.Property(e => e.IsPaymentCenter)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_payment_center");
            entity.Property(e => e.Latitude)
                .HasMaxLength(255)
                .HasComment("Широта")
                .HasColumnName("latitude");
            entity.Property(e => e.Longitude)
                .HasMaxLength(255)
                .HasComment("Долгота")
                .HasColumnName("longitude");
            entity.Property(e => e.Phones)
                .HasMaxLength(255)
                .HasComment("Телефоны")
                .HasColumnName("phones");
            entity.Property(e => e.Title)
                .HasComment("Наименование")
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
            entity.Property(e => e.WorkHours)
                .HasMaxLength(255)
                .HasComment("Режим работы")
                .HasColumnName("work_hours");

            entity.HasOne(d => d.City).WithMany(p => p.Contacts)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk_contacts-cities");
        });

        modelBuilder.Entity<ContactsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ContactId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("contacts_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-contacts_translations");

            entity.Property(e => e.ContactId)
                .HasColumnType("int(11)")
                .HasColumnName("contact_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasColumnName("address");
            entity.Property(e => e.Director)
                .HasMaxLength(255)
                .HasColumnName("director");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.WorkHours)
                .HasMaxLength(255)
                .HasColumnName("work_hours");

            entity.HasOne(d => d.Contact).WithMany(p => p.ContactsTranslations)
                .HasForeignKey(d => d.ContactId)
                .HasConstraintName("fk-contacts_contacts_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.ContactsTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-contacts_translations");
        });

        modelBuilder.Entity<Content>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("content");

            entity.HasIndex(e => e.IsActive, "is_active_index");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_active");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaImage)
                .HasMaxLength(255)
                .HasColumnName("meta_image");
            entity.Property(e => e.MetaKeywords)
                .HasMaxLength(255)
                .HasColumnName("meta_keywords");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Sefname)
                .HasMaxLength(255)
                .HasColumnName("sefname");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<ContentTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ContentId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("content_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-content_translations");

            entity.Property(e => e.ContentId)
                .HasColumnType("int(11)")
                .HasColumnName("content_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.MetaDescription)
                .HasColumnType("text")
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaKeywords)
                .HasMaxLength(255)
                .HasColumnName("meta_keywords");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Text)
                .HasComment("Описание")
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasComment("Заголовок")
                .HasColumnName("title");

            entity.HasOne(d => d.Content).WithMany(p => p.ContentTranslations)
                .HasForeignKey(d => d.ContentId)
                .HasConstraintName("fk-content-content_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.ContentTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-content_translations");
        });

        modelBuilder.Entity<Evacuator>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("evacuator");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasComment("Адрес")
                .HasColumnName("address");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.Comment)
                .HasComment("Комментарий")
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasComment("ФИО")
                .HasColumnName("full_name");
            entity.Property(e => e.LangId)
                .HasComment("Язык")
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasComment("Телефон")
                .HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasComment("Статус")
                .HasColumnType("smallint(6)")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasComment("Тип")
                .HasColumnType("smallint(6)")
                .HasColumnName("type");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
            entity.Property(e => e.UserId)
                .HasComment("User Id")
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<Faq>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("faq");

            entity.HasIndex(e => e.CategoryId, "faq-categry_id-index");

            entity.HasIndex(e => e.IsActive, "faq-is_active-index");

            entity.HasIndex(e => e.IsOften, "faq-is_often-index");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Answer)
                .HasComment("Ответ")
                .HasColumnType("text")
                .HasColumnName("answer");
            entity.Property(e => e.CategoryId)
                .HasComment("Категория")
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.IsOften)
                .HasColumnType("smallint(6)")
                .HasColumnName("is_often");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("'0'")
                .HasComment("Позиция")
                .HasColumnType("int(11)")
                .HasColumnName("position");
            entity.Property(e => e.Question)
                .HasComment("Вопрос")
                .HasColumnType("text")
                .HasColumnName("question");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<FaqCategoriesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("faq_categories_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-faq_categories_translations");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Category).WithMany(p => p.FaqCategoriesTranslations)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk-faq_categories_faq_categories_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.FaqCategoriesTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-faq_categories_translations");
        });

        modelBuilder.Entity<FaqCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("faq_categories");

            entity.HasIndex(e => e.ParentId, "faq_categories-parent_id-idx");

            entity.HasIndex(e => e.ProductId, "fk_faq_category_to_product");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.ParentId)
                .HasComment("Родительская категория")
                .HasColumnType("int(11)")
                .HasColumnName("parent_id");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Sefname)
                .HasMaxLength(255)
                .HasColumnName("sefname");
            entity.Property(e => e.Title)
                .HasComment("Наименование")
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<FaqTranslation>(entity =>
        {
            entity.HasKey(e => new { e.FaqId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("faq_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-faq_translations");

            entity.Property(e => e.FaqId)
                .HasColumnType("int(11)")
                .HasColumnName("faq_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Answer)
                .HasColumnType("text")
                .HasColumnName("answer");
            entity.Property(e => e.Question)
                .HasColumnType("text")
                .HasColumnName("question");

            entity.HasOne(d => d.Faq).WithMany(p => p.FaqTranslations)
                .HasForeignKey(d => d.FaqId)
                .HasConstraintName("fk-faq-faq_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.FaqTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-faq_translations");
        });

        modelBuilder.Entity<Gallery>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gallery");

            entity.HasIndex(e => e.IsActive, "active_gallery");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<GalleryImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gallery_images");

            entity.HasIndex(e => e.IsActive, "active_gallery_image");

            entity.HasIndex(e => e.GalleryId, "gallery");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("filename");
            entity.Property(e => e.GalleryId)
                .HasColumnType("int(11)")
                .HasColumnName("gallery_id");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.Position)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("position");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");

            entity.HasOne(d => d.Gallery).WithMany(p => p.GalleryImages)
                .HasForeignKey(d => d.GalleryId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("gallery_fk");
        });

        modelBuilder.Entity<GoszakupTender>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("goszakup_tenders");

            entity.HasIndex(e => e.LotId, "lot_id").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasMaxLength(255)
                .HasColumnName("amount");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Href)
                .HasMaxLength(2000)
                .HasColumnName("href");
            entity.Property(e => e.IsNotified)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_notified");
            entity.Property(e => e.IsViewed)
                .HasDefaultValueSql("'0'")
                .HasColumnName("is_viewed");
            entity.Property(e => e.LotId)
                .HasMaxLength(100)
                .HasColumnName("lot_id");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.Source)
                .HasMaxLength(100)
                .HasColumnName("source");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<InsuranceCase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("insurance_cases");

            entity.HasIndex(e => e.ProductId, "insurance_cases-product_id-idx");

            entity.HasIndex(e => e.TypeId, "insurance_cases-type_id-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .HasComment("Точный адрес")
                .HasColumnName("address");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Date)
                .HasComment("Дата")
                .HasColumnType("date")
                .HasColumnName("date");
            entity.Property(e => e.Description)
                .HasComment("Описание ситуации")
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Iin)
                .HasMaxLength(255)
                .HasComment("ИИН")
                .HasColumnName("iin");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasComment("Телефон")
                .HasColumnName("phone");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(255)
                .HasComment("Номер полиса")
                .HasColumnName("policy_number");
            entity.Property(e => e.ProductId)
                .HasComment("Продукт")
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Time)
                .HasComment("Время")
                .HasColumnType("time")
                .HasColumnName("time");
            entity.Property(e => e.TypeId)
                .HasComment("Что произошло")
                .HasColumnType("int(11)")
                .HasColumnName("type_id");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
            entity.Property(e => e.WhoGuilty)
                .HasDefaultValueSql("'0'")
                .HasComment("Виновник")
                .HasColumnType("smallint(1)")
                .HasColumnName("who_guilty");
        });

        modelBuilder.Entity<InsuranceCaseImage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("insurance_case_images");

            entity.HasIndex(e => e.CaseId, "insurance_case_images-case_id-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CaseId)
                .HasComment("Случай")
                .HasColumnType("int(11)")
                .HasColumnName("case_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasComment("Изображение")
                .HasColumnName("image");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");

            entity.HasOne(d => d.Case).WithMany(p => p.InsuranceCaseImages)
                .HasForeignKey(d => d.CaseId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk-insurance_case_images-insurance_cases");
        });

        modelBuilder.Entity<InsuranceCaseType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("insurance_case_types");

            entity.HasIndex(e => e.IsActive, "insurance_case_types-is_active-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<InsuranceCaseTypesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.TypeId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("insurance_case_types_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-insurance_case_types_translations");

            entity.Property(e => e.TypeId)
                .HasColumnType("int(11)")
                .HasColumnName("type_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Lang).WithMany(p => p.InsuranceCaseTypesTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-insurance_case_types_translations");

            entity.HasOne(d => d.Type).WithMany(p => p.InsuranceCaseTypesTranslations)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("fk-insurance_case_types-insurance_case_types_translations");
        });

        modelBuilder.Entity<Language>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("languages");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_active");
            entity.Property(e => e.Locale)
                .HasMaxLength(255)
                .HasColumnName("locale");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<ManagerLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("manager_log");

            entity.HasIndex(e => e.ManagerId, "fk_manager_log_to_user");

            entity.HasIndex(e => e.Section, "idx_manager_log_section");

            entity.HasIndex(e => e.Type, "idx_manager_log_type");

            entity.HasIndex(e => e.Url, "idx_manager_log_url");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(255)
                .HasColumnName("action");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.ManagerId)
                .HasColumnType("int(11)")
                .HasColumnName("manager_id");
            entity.Property(e => e.Section)
                .HasColumnType("int(11)")
                .HasColumnName("section");
            entity.Property(e => e.Type)
                .HasColumnType("int(11)")
                .HasColumnName("type");
            entity.Property(e => e.Url).HasColumnName("url");

            entity.HasOne(d => d.Manager).WithMany(p => p.ManagerLogs)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("fk_manager_log_to_user");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("menus");

            entity.HasIndex(e => e.IsActive, "active_menu");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_active");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
        });

        modelBuilder.Entity<MenuItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("menu_items");

            entity.HasIndex(e => e.IsActive, "active_index");

            entity.HasIndex(e => e.LangId, "lang_id_index");

            entity.HasIndex(e => e.Level, "level_index");

            entity.HasIndex(e => e.Lft, "lft_index");

            entity.HasIndex(e => e.MenuId, "menu_id_index");

            entity.HasIndex(e => e.IsNewWindow, "new_window");

            entity.HasIndex(e => e.ParentId, "parent_index");

            entity.HasIndex(e => e.Rgt, "rgt_index");

            entity.HasIndex(e => e.Root, "root_index");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_active");
            entity.Property(e => e.IsNewWindow)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_new_window");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Level)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("level");
            entity.Property(e => e.Lft)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("lft");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasColumnName("link");
            entity.Property(e => e.MenuId)
                .HasColumnType("int(11)")
                .HasColumnName("menu_id");
            entity.Property(e => e.Params)
                .HasMaxLength(255)
                .HasColumnName("params");
            entity.Property(e => e.ParentId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("parent_id");
            entity.Property(e => e.Rgt)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("rgt");
            entity.Property(e => e.Root)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("root");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");

            entity.HasOne(d => d.Lang).WithMany(p => p.MenuItems)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("lang_fk");

            entity.HasOne(d => d.Menu).WithMany(p => p.MenuItems)
                .HasForeignKey(d => d.MenuId)
                .HasConstraintName("menu_fk");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Language }).HasName("PRIMARY");

            entity.ToTable("message");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Language)
                .HasDefaultValueSql("''")
                .HasColumnName("language");
            entity.Property(e => e.Translation)
                .HasColumnType("text")
                .HasColumnName("translation");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.Messages)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("fk_message_source_message");
        });

        modelBuilder.Entity<Migration>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PRIMARY");

            entity.ToTable("migration");

            entity.Property(e => e.Version)
                .HasMaxLength(180)
                .HasColumnName("version");
            entity.Property(e => e.ApplyTime)
                .HasColumnType("int(11)")
                .HasColumnName("apply_time");
        });

        modelBuilder.Entity<NskApiErrorLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nsk_api_error_log");

            entity.HasIndex(e => e.UserId, "fk_nsk_api_error_log_users");

            entity.HasIndex(e => e.Category, "idx_nsk_api_error_log_category");

            entity.HasIndex(e => e.Code, "idx_nsk_api_error_log_code");

            entity.HasIndex(e => e.Iin, "idx_nsk_api_error_log_iin");

            entity.HasIndex(e => e.Phone, "idx_nsk_api_error_log_phone");

            entity.HasIndex(e => e.RequestName, "idx_nsk_api_error_log_request_name");

            entity.HasIndex(e => e.Status, "idx_nsk_api_error_log_status");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CalculatorId)
                .HasMaxLength(255)
                .HasComment("ID калькулятора в MongoDB")
                .HasColumnName("calculator_id");
            entity.Property(e => e.CalculatorModel)
                .HasMaxLength(255)
                .HasComment("Класс калькулятора")
                .HasColumnName("calculator_model");
            entity.Property(e => e.Category)
                .HasComment("Группа")
                .HasColumnName("category");
            entity.Property(e => e.Code)
                .HasComment("Код ошибки")
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasComment("Дата создания")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Iin)
                .HasComment("ИИН клиента в запросе")
                .HasColumnName("iin");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.Params)
                .HasComment("Параметры запроса")
                .HasColumnType("text")
                .HasColumnName("params");
            entity.Property(e => e.Phone)
                .HasComment("Номер телефона при рассчете")
                .HasColumnName("phone");
            entity.Property(e => e.RequestName)
                .HasComment("Название запроса")
                .HasColumnName("request_name");
            entity.Property(e => e.Status)
                .HasComment("Статус ошибки")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasComment("Дата обновления")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UserId)
                .HasComment("Пользователь")
                .HasColumnType("int(11)")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.NskApiErrorLogs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("fk_nsk_api_error_log_users");
        });

        modelBuilder.Entity<NskCarCharacteristic>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nsk_car_characteristic", tb => tb.HasComment("Характеристики автомобилей"));

            entity.HasIndex(e => e.IdCarType, "id_car_type");

            entity.HasIndex(e => new { e.Name, e.IdParent, e.IdCarType }, "name");

            entity.Property(e => e.Id)
                .HasComment("id")
                .HasColumnType("int(8)")
                .HasColumnName("id");
            entity.Property(e => e.IdCarType)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_type");
            entity.Property(e => e.IdParent)
                .HasColumnType("int(8)")
                .HasColumnName("id_parent");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<NskCarCharacteristicValue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nsk_car_characteristic_value", tb => tb.HasComment("Значения характеристик автомобиля"));

            entity.HasIndex(e => new { e.IdCarCharacteristic, e.IdCarModification, e.IdCarType }, "id_car_characteristic").IsUnique();

            entity.HasIndex(e => e.IdCarType, "id_car_type");

            entity.HasIndex(e => e.IdCarType, "id_car_type_2");

            entity.HasIndex(e => new { e.IdCarCharacteristic, e.IdCarModification }, "id_characteristic").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(8)")
                .HasColumnName("id");
            entity.Property(e => e.IdCarCharacteristic)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_characteristic");
            entity.Property(e => e.IdCarModification)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_modification");
            entity.Property(e => e.IdCarType)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_type");
            entity.Property(e => e.Unit)
                .HasMaxLength(255)
                .HasComment("Еденица измерения")
                .HasColumnName("unit");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("value");
        });

        modelBuilder.Entity<NskCarGeneration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nsk_car_generation", tb => tb.HasComment("Поколения Моделей"));

            entity.HasIndex(e => e.IdCarModel, "id_car_model");

            entity.HasIndex(e => e.IdCarType, "id_car_type");

            entity.Property(e => e.Id)
                .HasColumnType("int(8)")
                .HasColumnName("id");
            entity.Property(e => e.DateCreate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("date_create");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("date_update");
            entity.Property(e => e.IdCarModel)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_model");
            entity.Property(e => e.IdCarType)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_type");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.YearBegin)
                .HasMaxLength(255)
                .HasColumnName("year_begin");
            entity.Property(e => e.YearEnd)
                .HasMaxLength(255)
                .HasColumnName("year_end");
        });

        modelBuilder.Entity<NskCarMark>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nsk_car_mark", tb => tb.HasComment("Марки автомобилей"));

            entity.HasIndex(e => e.IdCarType, "id_car_type");

            entity.Property(e => e.Id)
                .HasComment("ID")
                .HasColumnType("int(8)")
                .HasColumnName("id");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("date_create");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("datetime")
                .HasColumnName("date_update");
            entity.Property(e => e.IdCarType)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_type");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
            entity.Property(e => e.NameRus)
                .HasMaxLength(255)
                .HasColumnName("name_rus");
        });

        modelBuilder.Entity<NskCarModel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nsk_car_model", tb => tb.HasComment("Модели автомобилей"));

            entity.HasIndex(e => e.IdCarMark, "id_car_mark");

            entity.HasIndex(e => e.IdCarType, "id_car_type");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.Id)
                .HasComment("ID")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DateCreate)
                .HasColumnType("datetime")
                .HasColumnName("date_create");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("datetime")
                .HasColumnName("date_update");
            entity.Property(e => e.IdCarMark)
                .HasColumnType("int(11)")
                .HasColumnName("id_car_mark");
            entity.Property(e => e.IdCarType)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_type");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.NameRus)
                .HasMaxLength(255)
                .HasColumnName("name_rus");
        });

        modelBuilder.Entity<NskCarModification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nsk_car_modification", tb => tb.HasComment("Модификации автомобилей"));

            entity.HasIndex(e => e.IdCarModel, "id_car_model");

            entity.HasIndex(e => e.IdCarSerie, "id_car_serie");

            entity.HasIndex(e => e.IdCarType, "id_car_type");

            entity.Property(e => e.Id)
                .HasComment("ID")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DateCreate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("date_create");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("date_update");
            entity.Property(e => e.IdCarModel)
                .HasColumnType("int(11)")
                .HasColumnName("id_car_model");
            entity.Property(e => e.IdCarSerie)
                .HasColumnType("int(11)")
                .HasColumnName("id_car_serie");
            entity.Property(e => e.IdCarType)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_type");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<NskCarSerie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nsk_car_serie", tb => tb.HasComment("Cерии автомобилей"));

            entity.HasIndex(e => e.IdCarModel, "id_car_model");

            entity.HasIndex(e => e.IdCarType, "id_car_type");

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.Id)
                .HasComment("ID")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.DateCreate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("date_create");
            entity.Property(e => e.DateUpdate)
                .HasColumnType("int(10) unsigned")
                .HasColumnName("date_update");
            entity.Property(e => e.IdCarGeneration)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_generation");
            entity.Property(e => e.IdCarModel)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_model");
            entity.Property(e => e.IdCarType)
                .HasColumnType("int(8)")
                .HasColumnName("id_car_type");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        modelBuilder.Entity<NskCarType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("nsk_car_type", tb => tb.HasComment("Автомобильный сайт"));

            entity.Property(e => e.Id)
                .HasColumnType("int(8)")
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("name");
        });

        modelBuilder.Entity<OffersReview>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("offers_reviews");

            entity.HasIndex(e => e.CityId, "Fk-offers_reviews_cities");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CityId)
                .HasColumnType("int(11)")
                .HasColumnName("city_id");
            entity.Property(e => e.CreateDate)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.IsNew).HasColumnName("is_new");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");

            entity.HasOne(d => d.City).WithMany(p => p.OffersReviews)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("Fk-offers_reviews_cities");
        });

        modelBuilder.Entity<OgpoFormRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ogpo_form_requests");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CountryId)
                .HasColumnType("int(11)")
                .HasColumnName("country_id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Documents)
                .HasColumnType("text")
                .HasColumnName("documents");
            entity.Property(e => e.Fio)
                .HasMaxLength(70)
                .HasColumnName("fio");
            entity.Property(e => e.Iin)
                .HasMaxLength(20)
                .HasColumnName("iin");
            entity.Property(e => e.ManagerId)
                .HasColumnType("int(11)")
                .HasColumnName("manager_id");
            entity.Property(e => e.OgpoType)
                .HasMaxLength(20)
                .HasColumnName("ogpo_type");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.PrefCh)
                .HasMaxLength(15)
                .HasColumnName("pref_ch");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<OgpoRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ogpo_requests");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.Customers)
                .HasColumnType("text")
                .HasColumnName("customers");
            entity.Property(e => e.Documents)
                .HasColumnType("text")
                .HasColumnName("documents");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Extra)
                .HasColumnType("text")
                .HasColumnName("extra");
            entity.Property(e => e.IsResident)
                .HasDefaultValueSql("'1'")
                .HasColumnType("int(1)")
                .HasColumnName("is_resident");
            entity.Property(e => e.ManagerId)
                .HasColumnType("int(11)")
                .HasColumnName("manager_id");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
            entity.Property(e => e.Vehicles)
                .HasColumnType("text")
                .HasColumnName("vehicles");
        });

        modelBuilder.Entity<OsgpoBusinessRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("osgpo_business_requests");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ActivityKindId)
                .HasMaxLength(5)
                .HasColumnName("ACTIVITY_KIND_ID");
            entity.Property(e => e.Address).HasMaxLength(20);
            entity.Property(e => e.CalcData)
                .HasColumnType("text")
                .HasColumnName("calcData");
            entity.Property(e => e.CityId)
                .HasColumnType("int(11)")
                .HasColumnName("city_id");
            entity.Property(e => e.ClientId)
                .HasMaxLength(255)
                .HasColumnName("client_id");
            entity.Property(e => e.Comment)
                .HasColumnType("text")
                .HasColumnName("comment");
            entity.Property(e => e.CreatedAt)
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DateEnd).HasColumnType("date");
            entity.Property(e => e.DateStart).HasColumnType("date");
            entity.Property(e => e.DocumentGivedDate)
                .HasColumnType("date")
                .HasColumnName("DOCUMENT_GIVED_DATE");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(10)
                .HasColumnName("DOCUMENT_NUMBER");
            entity.Property(e => e.DocumentTypeId)
                .HasMaxLength(3)
                .HasColumnName("DOCUMENT_TYPE_ID");
            entity.Property(e => e.Documents)
                .HasColumnType("text")
                .HasColumnName("documents");
            entity.Property(e => e.EconomicsSectorId)
                .HasMaxLength(5)
                .HasColumnName("ECONOMICS_SECTOR_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.Iin)
                .HasMaxLength(20)
                .HasColumnName("IIN");
            entity.Property(e => e.Inssum)
                .HasMaxLength(255)
                .HasColumnName("inssum");
            entity.Property(e => e.InsuredList)
                .HasColumnType("text")
                .HasColumnName("insuredList");
            entity.Property(e => e.JuridicalPersonName)
                .HasMaxLength(100)
                .HasColumnName("Juridical_Person_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Licdate)
                .HasColumnType("date")
                .HasColumnName("licdate");
            entity.Property(e => e.Licnum)
                .HasMaxLength(20)
                .HasColumnName("licnum");
            entity.Property(e => e.MainChief)
                .HasMaxLength(100)
                .HasColumnName("MAIN_CHIEF");
            entity.Property(e => e.ManagerId)
                .HasColumnType("int(11)")
                .HasColumnName("manager_id");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.NaturalPersonBool)
                .HasMaxLength(1)
                .HasColumnName("Natural_Person_Bool");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(2)
                .HasColumnName("paymenttype");
            entity.Property(e => e.Phones)
                .HasMaxLength(20)
                .HasColumnName("PHONES");
            entity.Property(e => e.PreferredLang)
                .HasMaxLength(5)
                .HasColumnName("preferredLang");
            entity.Property(e => e.Premium)
                .HasMaxLength(255)
                .HasColumnName("premium");
            entity.Property(e => e.PremiumDiscount)
                .HasMaxLength(255)
                .HasColumnName("premiumDiscount");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.ResidentBool)
                .HasMaxLength(1)
                .HasColumnName("RESIDENT_BOOL");
            entity.Property(e => e.Status)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<Page>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pages");

            entity.HasIndex(e => e.IsActive, "active");

            entity.HasIndex(e => e.IsMainpage, "pages-is_mainpage-idx");

            entity.HasIndex(e => e.UserId, "user_id");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("category_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.DownloadFile)
                .HasMaxLength(255)
                .HasColumnName("download_file");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_active");
            entity.Property(e => e.IsMainpage)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_mainpage");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaImage)
                .HasMaxLength(255)
                .HasColumnName("meta_image");
            entity.Property(e => e.MetaKeywords)
                .HasMaxLength(255)
                .HasColumnName("meta_keywords");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.PublishDate)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("publish_date");
            entity.Property(e => e.Sefname)
                .HasMaxLength(255)
                .HasColumnName("sefname");
            entity.Property(e => e.ShortText)
                .HasColumnType("text")
                .HasColumnName("short_text");
            entity.Property(e => e.Text).HasColumnName("text");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
            entity.Property(e => e.Views)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("views");

            entity.HasOne(d => d.User).WithMany(p => p.Pages)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("page_user_fk");
        });

        modelBuilder.Entity<PagesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.PageId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("pages_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-pages_tranlations");

            entity.Property(e => e.PageId)
                .HasColumnType("int(11)")
                .HasColumnName("page_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.MetaDescription)
                .HasColumnType("text")
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaKeywords)
                .HasMaxLength(255)
                .HasColumnName("meta_keywords");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.ShortText)
                .HasComment("Краткий Текст")
                .HasColumnType("text")
                .HasColumnName("short_text");
            entity.Property(e => e.Text)
                .HasComment("Текст")
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasComment("Наименование")
                .HasColumnName("title");

            entity.HasOne(d => d.Lang).WithMany(p => p.PagesTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-pages_tranlations");

            entity.HasOne(d => d.Page).WithMany(p => p.PagesTranslations)
                .HasForeignKey(d => d.PageId)
                .HasConstraintName("fk-pages-pages_tranlations");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("payments");

            entity.HasIndex(e => new { e.ModelClass, e.ModelId }, "idx_payments_model");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ApprovalCode)
                .HasMaxLength(255)
                .HasComment("код авторизации")
                .HasColumnName("approval_code");
            entity.Property(e => e.CardBin)
                .HasMaxLength(255)
                .HasComment("Страна эмитент карты")
                .HasColumnName("card_bin");
            entity.Property(e => e.CreateDate)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.ErrorType)
                .HasMaxLength(255)
                .HasColumnName("error_type");
            entity.Property(e => e.Items)
                .HasColumnType("text")
                .HasColumnName("items");
            entity.Property(e => e.ModelClass).HasColumnName("model_class");
            entity.Property(e => e.ModelId).HasColumnName("model_id");
            entity.Property(e => e.Price)
                .HasColumnType("int(11)")
                .HasColumnName("price");
            entity.Property(e => e.Reference)
                .HasMaxLength(255)
                .HasComment("номер обращения к платежной системе")
                .HasColumnName("reference");
            entity.Property(e => e.Status)
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<PaymentLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("payment_log");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Log)
                .HasColumnType("text")
                .HasColumnName("log");
            entity.Property(e => e.PaymentId)
                .HasMaxLength(255)
                .HasComment("Payment ID")
                .HasColumnName("payment_id");
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("products");

            entity.HasIndex(e => e.CalculatorId, "products-calculator_id-idx");

            entity.HasIndex(e => e.CategoryId, "products-category_id-idx");

            entity.HasIndex(e => e.IsActive, "products-is_active-idx");

            entity.HasIndex(e => e.IsLarge, "products-is_large-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BannerImage)
                .HasMaxLength(255)
                .HasColumnName("banner_image");
            entity.Property(e => e.BannerText)
                .HasColumnType("text")
                .HasColumnName("banner_text");
            entity.Property(e => e.BannerTitle)
                .HasMaxLength(255)
                .HasColumnName("banner_title");
            entity.Property(e => e.CalculatorId)
                .HasColumnType("int(11)")
                .HasColumnName("calculator_id");
            entity.Property(e => e.CategoryId)
                .HasComment("Категория")
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Description)
                .HasComment("Описание")
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.HasBanner).HasColumnName("has_banner");
            entity.Property(e => e.HasDescription)
                .IsRequired()
                .HasDefaultValueSql("'1'")
                .HasColumnName("has_description");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasComment("Большое изображение")
                .HasColumnName("image");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.IsLarge)
                .HasDefaultValueSql("'0'")
                .HasComment("Большая плитка")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_large");
            entity.Property(e => e.IsPlainPage)
                .HasDefaultValueSql("'0'")
                .HasComment("Обычная страница продукта с заявкой")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_plain_page");
            entity.Property(e => e.MetaDescription)
                .HasMaxLength(255)
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaImage)
                .HasMaxLength(255)
                .HasColumnName("meta_image");
            entity.Property(e => e.MetaKeywords)
                .HasMaxLength(255)
                .HasColumnName("meta_keywords");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("'0'")
                .HasComment("Позиция")
                .HasColumnType("int(11)")
                .HasColumnName("position");
            entity.Property(e => e.Sefname)
                .HasMaxLength(255)
                .HasColumnName("sefname");
            entity.Property(e => e.ShortDescription)
                .HasMaxLength(255)
                .HasComment("Краткое описание")
                .HasColumnName("short_description");
            entity.Property(e => e.SmallImage)
                .HasMaxLength(255)
                .HasComment("Маленькое изображение")
                .HasColumnName("small_image");
            entity.Property(e => e.SuggestedButtonLabel)
                .HasMaxLength(255)
                .HasColumnName("suggested_button_label");
            entity.Property(e => e.SuggestedLabel)
                .HasMaxLength(255)
                .HasColumnName("suggested_label");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");

            entity.HasOne(d => d.Category).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk-products-products_categories");

            entity.HasMany(d => d.ProductBenefits).WithMany(p => p.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductsProductBenefit",
                    r => r.HasOne<ProductBenefit>().WithMany()
                        .HasForeignKey("ProductBenefitId")
                        .HasConstraintName("fk_products_product_benefits_to_product_benefit"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk_products_product_benefits_to_product"),
                    j =>
                    {
                        j.HasKey("ProductId", "ProductBenefitId").HasName("PRIMARY");
                        j.ToTable("products_product_benefits");
                        j.HasIndex(new[] { "ProductBenefitId" }, "fk_products_product_benefits_to_product_benefit");
                        j.IndexerProperty<int>("ProductId")
                            .HasColumnType("int(11)")
                            .HasColumnName("product_id");
                        j.IndexerProperty<int>("ProductBenefitId")
                            .HasColumnType("int(11)")
                            .HasColumnName("product_benefit_id");
                    });

            entity.HasMany(d => d.Reviews).WithMany(p => p.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductReview",
                    r => r.HasOne<Review>().WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_product_reviews_to_reviews"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("fk_product_reviews_to_products"),
                    j =>
                    {
                        j.HasKey("ProductId", "ReviewId").HasName("PRIMARY");
                        j.ToTable("product_reviews");
                        j.HasIndex(new[] { "ReviewId" }, "fk_product_reviews_to_reviews");
                        j.IndexerProperty<int>("ProductId")
                            .HasColumnType("int(11)")
                            .HasColumnName("product_id");
                        j.IndexerProperty<int>("ReviewId")
                            .HasColumnType("int(11)")
                            .HasColumnName("review_id");
                    });

            entity.HasMany(d => d.Risks).WithMany(p => p.Products)
                .UsingEntity<Dictionary<string, object>>(
                    "ProductsProductRisk",
                    r => r.HasOne<ProductRisk>().WithMany()
                        .HasForeignKey("RiskId")
                        .HasConstraintName("fk-products_product_risks-product_risks"),
                    l => l.HasOne<Product>().WithMany()
                        .HasForeignKey("ProductId")
                        .HasConstraintName("fk-products_product_risks-products"),
                    j =>
                    {
                        j.HasKey("ProductId", "RiskId").HasName("PRIMARY");
                        j.ToTable("products_product_risks");
                        j.HasIndex(new[] { "RiskId" }, "fk-products_product_risks-product_risks");
                        j.IndexerProperty<int>("ProductId")
                            .HasColumnType("int(11)")
                            .HasColumnName("product_id");
                        j.IndexerProperty<int>("RiskId")
                            .HasColumnType("int(11)")
                            .HasColumnName("risk_id");
                    });
        });

        modelBuilder.Entity<ProductAction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product_actions");

            entity.HasIndex(e => e.IsActive, "product_actions-is_active-idx");

            entity.HasIndex(e => e.ProductId, "product_actions-product_id-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasComment("Изображение")
                .HasColumnName("image");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasComment("Ссылка")
                .HasColumnName("link");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductActions)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("fk-product_actions-products");
        });

        modelBuilder.Entity<ProductActionsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ActionId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("product_actions_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-product_actions_translations");

            entity.Property(e => e.ActionId)
                .HasColumnType("int(11)")
                .HasColumnName("action_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Action).WithMany(p => p.ProductActionsTranslations)
                .HasForeignKey(d => d.ActionId)
                .HasConstraintName("fk-product_actions-product_actions_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.ProductActionsTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-product_actions_translations");
        });

        modelBuilder.Entity<ProductBenefit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product_benefits");

            entity.HasIndex(e => e.IsActive, "idx_product_benefits_active");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<ProductBenefitsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.BenefitId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("product_benefits_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-product_benefits_translations");

            entity.Property(e => e.BenefitId)
                .HasColumnType("int(11)")
                .HasColumnName("benefit_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Benefit).WithMany(p => p.ProductBenefitsTranslations)
                .HasForeignKey(d => d.BenefitId)
                .HasConstraintName("fk-product_benefits-product_benefits_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.ProductBenefitsTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-product_benefits_translations");
        });

        modelBuilder.Entity<ProductCategoriesTranslation>(entity =>
        {
            entity.HasKey(e => new { e.CategoryId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("product_categories_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-product_categories_translations");

            entity.Property(e => e.CategoryId)
                .HasColumnType("int(11)")
                .HasColumnName("category_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Category).WithMany(p => p.ProductCategoriesTranslations)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("fk-product_categories-product_categories_translations");

            entity.HasOne(d => d.Lang).WithMany(p => p.ProductCategoriesTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-product_categories_translations");
        });

        modelBuilder.Entity<ProductCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product_categories");

            entity.HasIndex(e => e.CategoryType, "product_categories-category_type-ids");

            entity.HasIndex(e => e.IsActive, "product_categories-is_active-ids");

            entity.HasIndex(e => e.Position, "product_categories-position-ids");

            entity.HasIndex(e => e.IsActive, "product_risks-is_active-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CategoryType)
                .HasDefaultValueSql("'0'")
                .HasComment("Пользователь продукта")
                .HasColumnType("smallint(1)")
                .HasColumnName("category_type");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Описание")
                .HasColumnName("description");
            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .HasColumnName("icon");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasComment("Изображение")
                .HasColumnName("image");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("'0'")
                .HasComment("Позиция")
                .HasColumnType("int(11)")
                .HasColumnName("position");
            entity.Property(e => e.Sefname)
                .HasMaxLength(255)
                .HasColumnName("sefname");
            entity.Property(e => e.Title)
                .HasComment("Наименование")
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<ProductOsgpoChNotariusRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product_osgpo_ch_notarius_requests");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ActivityKindId)
                .HasMaxLength(5)
                .HasColumnName("ACTIVITY_KIND_ID");
            entity.Property(e => e.Address).HasMaxLength(20);
            entity.Property(e => e.ClientId)
                .HasMaxLength(10)
                .HasColumnName("CLIENT_ID");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DateEnd).HasColumnType("date");
            entity.Property(e => e.DateStart).HasColumnType("date");
            entity.Property(e => e.DocLic)
                .HasMaxLength(255)
                .HasColumnName("docLic");
            entity.Property(e => e.DocTer)
                .HasMaxLength(255)
                .HasColumnName("docTer");
            entity.Property(e => e.DocUd)
                .HasMaxLength(255)
                .HasColumnName("docUd");
            entity.Property(e => e.DocumentGivedDate)
                .HasColumnType("date")
                .HasColumnName("DOCUMENT_GIVED_DATE");
            entity.Property(e => e.DocumentNumber)
                .HasMaxLength(10)
                .HasColumnName("DOCUMENT_NUMBER");
            entity.Property(e => e.DocumentTypeId)
                .HasMaxLength(3)
                .HasColumnName("DOCUMENT_TYPE_ID");
            entity.Property(e => e.EconomicsSectorId)
                .HasMaxLength(5)
                .HasColumnName("ECONOMICS_SECTOR_ID");
            entity.Property(e => e.Email)
                .HasMaxLength(70)
                .HasColumnName("EMAIL");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.Iin)
                .HasMaxLength(20)
                .HasColumnName("IIN");
            entity.Property(e => e.Inssum)
                .HasMaxLength(255)
                .HasColumnName("inssum");
            entity.Property(e => e.InsurerBool).HasMaxLength(1);
            entity.Property(e => e.JuridicalPersonName)
                .HasMaxLength(100)
                .HasColumnName("Juridical_Person_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Licdate)
                .HasColumnType("date")
                .HasColumnName("licdate");
            entity.Property(e => e.Licnum)
                .HasMaxLength(20)
                .HasColumnName("licnum");
            entity.Property(e => e.MainChief)
                .HasMaxLength(100)
                .HasColumnName("MAIN_CHIEF");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.NaturalPersonBool)
                .HasMaxLength(1)
                .HasColumnName("Natural_Person_Bool");
            entity.Property(e => e.Paymenttype)
                .HasMaxLength(2)
                .HasColumnName("paymenttype");
            entity.Property(e => e.Phones)
                .HasMaxLength(20)
                .HasColumnName("PHONES");
            entity.Property(e => e.PreferredLang)
                .HasMaxLength(5)
                .HasColumnName("preferredLang");
            entity.Property(e => e.Premium)
                .HasMaxLength(255)
                .HasColumnName("premium");
            entity.Property(e => e.PremiumDiscount)
                .HasMaxLength(255)
                .HasColumnName("premiumDiscount");
            entity.Property(e => e.Regregion)
                .HasMaxLength(5)
                .HasColumnName("regregion");
            entity.Property(e => e.ResidentBool)
                .HasMaxLength(1)
                .HasColumnName("RESIDENT_BOOL");
            entity.Property(e => e.Tarif)
                .HasMaxLength(255)
                .HasColumnName("tarif");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<ProductRisk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product_risks");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_active");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<ProductRisksTranslation>(entity =>
        {
            entity.HasKey(e => new { e.RiskId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("product_risks_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-product_risks_translations");

            entity.Property(e => e.RiskId)
                .HasColumnType("int(11)")
                .HasColumnName("risk_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Lang).WithMany(p => p.ProductRisksTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-product_risks_translations");

            entity.HasOne(d => d.Risk).WithMany(p => p.ProductRisksTranslations)
                .HasForeignKey(d => d.RiskId)
                .HasConstraintName("fk-product_risks-product_risks_translations");
        });

        modelBuilder.Entity<ProductRule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("product_rules");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ActualDate)
                .HasColumnType("date")
                .HasColumnName("actual_date");
            entity.Property(e => e.File)
                .HasMaxLength(255)
                .HasColumnName("file");
            entity.Property(e => e.IsActual).HasColumnName("is_actual");
            entity.Property(e => e.Lang)
                .HasMaxLength(10)
                .HasColumnName("lang");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .HasColumnName("name");
            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
        });

        modelBuilder.Entity<ProductsSuggest>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.SuggestProductId }).HasName("PRIMARY");

            entity.ToTable("products_suggest");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.SuggestProductId)
                .HasColumnType("int(11)")
                .HasColumnName("suggest_product_id");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductsSuggests)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk-products_suggest-products");
        });

        modelBuilder.Entity<ProductsTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ProductId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("products_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-products_translations");

            entity.Property(e => e.ProductId)
                .HasColumnType("int(11)")
                .HasColumnName("product_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.BannerText)
                .HasColumnType("text")
                .HasColumnName("banner_text");
            entity.Property(e => e.BannerTitle)
                .HasMaxLength(255)
                .HasColumnName("banner_title");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.MetaDescription)
                .HasColumnType("text")
                .HasColumnName("meta_description");
            entity.Property(e => e.MetaKeywords)
                .HasMaxLength(255)
                .HasColumnName("meta_keywords");
            entity.Property(e => e.MetaTitle)
                .HasMaxLength(255)
                .HasColumnName("meta_title");
            entity.Property(e => e.ShortDescription)
                .HasMaxLength(255)
                .HasColumnName("short_description");
            entity.Property(e => e.SuggestedButtonLabel)
                .HasMaxLength(255)
                .HasColumnName("suggested_button_label");
            entity.Property(e => e.SuggestedLabel)
                .HasMaxLength(255)
                .HasColumnName("suggested_label");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Lang).WithMany(p => p.ProductsTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-products_translations");

            entity.HasOne(d => d.Product).WithMany(p => p.ProductsTranslations)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("fk-products-products_translations");
        });

        modelBuilder.Entity<Promo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("promos");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CalculatorId)
                .HasComment("Калькулятор")
                .HasColumnType("int(11)")
                .HasColumnName("calculator_id");
            entity.Property(e => e.CreateDate)
                .HasComment("Дата создания")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("int(11)")
                .HasColumnName("is_active");
            entity.Property(e => e.Percent)
                .HasComment("Процент скидки")
                .HasColumnType("int(11)")
                .HasColumnName("percent");
            entity.Property(e => e.Promo1)
                .HasMaxLength(255)
                .HasComment("Название промо")
                .HasColumnName("promo");
            entity.Property(e => e.UpdateDate)
                .HasComment("Дата обновления")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<PromoSmsNotivication>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("promo_sms_notivication");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasMaxLength(250)
                .HasColumnName("created_at");
            entity.Property(e => e.Phone)
                .HasMaxLength(250)
                .HasColumnName("phone");
            entity.Property(e => e.Product)
                .HasMaxLength(250)
                .HasColumnName("product");
            entity.Property(e => e.Promo)
                .HasMaxLength(250)
                .HasColumnName("promo");
            entity.Property(e => e.UpdatedAt)
                .HasMaxLength(250)
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<PushNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("push_notification");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ClientId)
                .HasDefaultValueSql("'0'")
                .HasColumnType("int(11)")
                .HasColumnName("client_id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.DocId)
                .HasColumnType("bigint(15) unsigned")
                .HasColumnName("doc_id");
            entity.Property(e => e.IsSend)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_send");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasComment("Сообщение")
                .HasColumnName("message");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<QualityService>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("quality_service");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CityId)
                .HasColumnType("int(11)")
                .HasColumnName("city_id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.File)
                .HasMaxLength(255)
                .HasComment("Файл")
                .HasColumnName("file");
            entity.Property(e => e.Iin)
                .HasMaxLength(255)
                .HasColumnName("iin");
            entity.Property(e => e.ManagerId)
                .HasColumnType("int(11)")
                .HasColumnName("manager_id");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.MessageType)
                .HasColumnType("int(11)")
                .HasColumnName("message_type");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");
            entity.Property(e => e.Status)
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.UtmLabels)
                .HasMaxLength(255)
                .HasColumnName("utm_labels");
        });

        modelBuilder.Entity<Queue>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("queue");

            entity.HasIndex(e => e.Channel, "channel");

            entity.HasIndex(e => e.Priority, "priority");

            entity.HasIndex(e => e.ReservedAt, "reserved_at");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Attempt)
                .HasColumnType("int(11)")
                .HasColumnName("attempt");
            entity.Property(e => e.Channel).HasColumnName("channel");
            entity.Property(e => e.Delay)
                .HasColumnType("int(11)")
                .HasColumnName("delay");
            entity.Property(e => e.DoneAt)
                .HasColumnType("int(11)")
                .HasColumnName("done_at");
            entity.Property(e => e.Job)
                .HasColumnType("blob")
                .HasColumnName("job");
            entity.Property(e => e.Priority)
                .HasDefaultValueSql("'1024'")
                .HasColumnType("int(11) unsigned")
                .HasColumnName("priority");
            entity.Property(e => e.PushedAt)
                .HasColumnType("int(11)")
                .HasColumnName("pushed_at");
            entity.Property(e => e.ReservedAt)
                .HasColumnType("int(11)")
                .HasColumnName("reserved_at");
            entity.Property(e => e.Ttr)
                .HasColumnType("int(11)")
                .HasColumnName("ttr");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("reviews");

            entity.HasIndex(e => e.IsActive, "reviews-is_active-idx");

            entity.HasIndex(e => e.LangId, "reviews-lang_id-idx");

            entity.HasIndex(e => e.Position, "reviews-position-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Должность")
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasComment("Маленькое изображение")
                .HasColumnName("image");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_active");
            entity.Property(e => e.LangId)
                .HasComment("Язык")
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.LargeImage)
                .HasMaxLength(255)
                .HasComment("Большое изображение")
                .HasColumnName("large_image");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasComment("Имя")
                .HasColumnName("name");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("'0'")
                .HasComment("Позиция")
                .HasColumnType("int(11)")
                .HasColumnName("position");
            entity.Property(e => e.Review1)
                .HasColumnType("text")
                .HasColumnName("review");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
            entity.Property(e => e.Video)
                .HasMaxLength(255)
                .HasComment("Видео-файл")
                .HasColumnName("video");
        });

        modelBuilder.Entity<Slider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("sliders");

            entity.HasIndex(e => e.IsActive, "sliders-is_active-idx");

            entity.HasIndex(e => e.LangId, "sliders-lang_id-idx");

            entity.HasIndex(e => e.Position, "sliders-position-idx");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Описание")
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasComment("Изображение")
                .HasColumnName("image");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasComment("Активность")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_active");
            entity.Property(e => e.LangId)
                .HasComment("Язык")
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.Link)
                .HasMaxLength(255)
                .HasComment("Ссылка с кнопки")
                .HasColumnName("link");
            entity.Property(e => e.Position)
                .HasDefaultValueSql("'0'")
                .HasComment("Позиция")
                .HasColumnType("int(11)")
                .HasColumnName("position");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasComment("Заголовок")
                .HasColumnName("title");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
        });

        modelBuilder.Entity<SourceMessage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("source_message");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasMaxLength(255)
                .HasColumnName("category");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
        });

        modelBuilder.Entity<TelegramNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("telegram_notifications");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Chat)
                .HasMaxLength(100)
                .HasColumnName("chat");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.File)
                .HasMaxLength(255)
                .HasColumnName("file");
            entity.Property(e => e.Status)
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<TopManagement>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("top_management");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.FullName)
                .HasColumnType("text")
                .HasColumnName("full_name");
            entity.Property(e => e.Image)
                .HasMaxLength(255)
                .HasColumnName("image");
            entity.Property(e => e.ImageDescription)
                .HasMaxLength(255)
                .HasColumnName("image_description");
            entity.Property(e => e.IsActive).HasColumnName("is_active");
            entity.Property(e => e.Position)
                .HasColumnType("int(11)")
                .HasColumnName("position");
            entity.Property(e => e.Text)
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.Title)
                .HasColumnType("text")
                .HasColumnName("title");
            entity.Property(e => e.UpdatedAt)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
            entity.Property(e => e.Weight)
                .HasColumnType("int(11)")
                .HasColumnName("weight");
        });

        modelBuilder.Entity<TopManagementTranslation>(entity =>
        {
            entity.HasKey(e => new { e.ManagerId, e.LangId }).HasName("PRIMARY");

            entity.ToTable("top_management_translations");

            entity.HasIndex(e => e.LangId, "fk-languages-top_management_translations");

            entity.Property(e => e.ManagerId)
                .HasColumnType("int(11)")
                .HasColumnName("manager_id");
            entity.Property(e => e.LangId)
                .HasColumnType("int(11)")
                .HasColumnName("lang_id");
            entity.Property(e => e.FullName)
                .HasMaxLength(255)
                .HasColumnName("full_name");
            entity.Property(e => e.Text)
                .HasComment("Описание")
                .HasColumnType("text")
                .HasColumnName("text");
            entity.Property(e => e.Title)
                .HasMaxLength(255)
                .HasColumnName("title");

            entity.HasOne(d => d.Lang).WithMany(p => p.TopManagementTranslations)
                .HasForeignKey(d => d.LangId)
                .HasConstraintName("fk-languages-top_management_translations");

            entity.HasOne(d => d.Manager).WithMany(p => p.TopManagementTranslations)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("fk-top_management-top_management_translations");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users");

            entity.HasIndex(e => e.IsActive, "is_active_users");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.DocNum)
                .HasMaxLength(64)
                .HasColumnName("doc_num");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("first_name");
            entity.Property(e => e.Iin)
                .HasMaxLength(255)
                .HasColumnName("iin");
            entity.Property(e => e.IsActive)
                .HasDefaultValueSql("'1'")
                .HasColumnType("smallint(6)")
                .HasColumnName("is_active");
            entity.Property(e => e.IsConnected)
                .HasDefaultValueSql("'0'")
                .HasColumnType("smallint(1)")
                .HasColumnName("is_connected");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("last_name");
            entity.Property(e => e.NskClientId)
                .HasColumnType("int(11)")
                .HasColumnName("nsk_client_id");
            entity.Property(e => e.OnesignalId)
                .HasMaxLength(255)
                .HasColumnName("onesignal_id");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");
            entity.Property(e => e.Role)
                .HasMaxLength(255)
                .HasDefaultValueSql("'user'")
                .HasColumnName("role");
            entity.Property(e => e.SendinblueId)
                .HasColumnType("int(11)")
                .HasColumnName("sendinblue_id");
            entity.Property(e => e.SmsCode)
                .HasColumnType("int(11)")
                .HasColumnName("sms_code");
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("update_date");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserActivity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("user_activities");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("created_at");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Phone)
                .HasMaxLength(255)
                .HasColumnName("phone");
            entity.Property(e => e.Product)
                .HasMaxLength(255)
                .HasColumnName("product");
            entity.Property(e => e.Status)
                .HasColumnType("int(11)")
                .HasColumnName("status");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("timestamp")
                .HasColumnName("updated_at");
        });

        modelBuilder.Entity<UserDevice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("user_devices");

            entity.HasIndex(e => e.UserId, "fk_user_devices_user");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.DeviceId)
                .HasMaxLength(255)
                .HasColumnName("device_id");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UserDevices)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("fk_user_devices_user");
        });

        modelBuilder.Entity<UsersAuth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users_auth");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasColumnType("timestamp")
                .HasColumnName("create_date");
            entity.Property(e => e.ExpireDate)
                .HasDefaultValueSql("'0000-00-00 00:00:00'")
                .HasComment("Срок действия токена")
                .HasColumnType("timestamp")
                .HasColumnName("expire_date");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .HasComment("Токен авторизации")
                .HasColumnName("token");
            entity.Property(e => e.UserId)
                .HasComment("Пользователь")
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<UsersCode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users_code");

            entity.HasIndex(e => e.UserId, "users_code_ibfk_1");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasColumnType("int(11)")
                .HasColumnName("code");
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("datetime")
                .HasColumnName("created_at");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");

            entity.HasOne(d => d.User).WithMany(p => p.UsersCodes)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("users_code_ibfk_1");
        });

        modelBuilder.Entity<UsersLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users_log");

            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Action)
                .HasMaxLength(250)
                .HasColumnName("action");
            entity.Property(e => e.CreatedAt)
                .HasMaxLength(250)
                .HasColumnName("created_at");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Ip)
                .HasMaxLength(250)
                .HasColumnName("ip");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .HasColumnName("login");
            entity.Property(e => e.Request)
                .HasMaxLength(250)
                .HasColumnName("request");
            entity.Property(e => e.UpdatedAt)
                .HasMaxLength(250)
                .HasColumnName("updated_at");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<UsersLog2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("users_log_2");

            entity.Property(e => e.Action)
                .HasMaxLength(250)
                .HasColumnName("action");
            entity.Property(e => e.CreatedAt)
                .HasMaxLength(250)
                .HasColumnName("created_at");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Ip)
                .HasMaxLength(250)
                .HasColumnName("ip");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .HasColumnName("login");
            entity.Property(e => e.Request)
                .HasMaxLength(250)
                .HasColumnName("request");
            entity.Property(e => e.UpdatedAt)
                .HasMaxLength(250)
                .HasColumnName("updated_at");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<UsersLog3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("users_log_3");

            entity.Property(e => e.Action)
                .HasMaxLength(250)
                .HasColumnName("action");
            entity.Property(e => e.CreatedAt)
                .HasMaxLength(250)
                .HasColumnName("created_at");
            entity.Property(e => e.Data)
                .HasColumnType("text")
                .HasColumnName("data");
            entity.Property(e => e.Id)
                .HasColumnType("int(11) unsigned")
                .HasColumnName("id");
            entity.Property(e => e.Ip)
                .HasMaxLength(250)
                .HasColumnName("ip");
            entity.Property(e => e.Login)
                .HasMaxLength(100)
                .HasColumnName("login");
            entity.Property(e => e.Request)
                .HasMaxLength(250)
                .HasColumnName("request");
            entity.Property(e => e.UpdatedAt)
                .HasMaxLength(250)
                .HasColumnName("updated_at");
            entity.Property(e => e.Url)
                .HasMaxLength(250)
                .HasColumnName("url");
            entity.Property(e => e.UserId)
                .HasColumnType("int(11)")
                .HasColumnName("user_id");
        });

        modelBuilder.Entity<UsersSendSmsUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("users_send_sms_users");

            entity.HasIndex(e => e.Code, "idx_code");

            entity.HasIndex(e => e.Phone, "idx_phone");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Code)
                .HasColumnType("int(11)")
                .HasColumnName("code");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
