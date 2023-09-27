namespace Models.Entities;

public partial class Language
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Code { get; set; } = null!;

    public string Locale { get; set; } = null!;

    public short? IsActive { get; set; }

    public virtual ICollection<BlogCategoriesTranslation> BlogCategoriesTranslations { get; set; } = new List<BlogCategoriesTranslation>();

    public virtual ICollection<BlogsTranslation> BlogsTranslations { get; set; } = new List<BlogsTranslation>();

    public virtual ICollection<CalculatorHintsTranslation> CalculatorHintsTranslations { get; set; } = new List<CalculatorHintsTranslation>();

    public virtual ICollection<CalculatorOgpoCitiesTranslation> CalculatorOgpoCitiesTranslations { get; set; } = new List<CalculatorOgpoCitiesTranslation>();

    public virtual ICollection<CalculatorStagesTranslation> CalculatorStagesTranslations { get; set; } = new List<CalculatorStagesTranslation>();

    public virtual ICollection<CalculatorsTranslation> CalculatorsTranslations { get; set; } = new List<CalculatorsTranslation>();

    public virtual ICollection<CategoriesTranslation> CategoriesTranslations { get; set; } = new List<CategoriesTranslation>();

    public virtual ICollection<CitiesTranslation> CitiesTranslations { get; set; } = new List<CitiesTranslation>();

    public virtual ICollection<ContactsTranslation> ContactsTranslations { get; set; } = new List<ContactsTranslation>();

    public virtual ICollection<ContentTranslation> ContentTranslations { get; set; } = new List<ContentTranslation>();

    public virtual ICollection<FaqCategoriesTranslation> FaqCategoriesTranslations { get; set; } = new List<FaqCategoriesTranslation>();

    public virtual ICollection<FaqTranslation> FaqTranslations { get; set; } = new List<FaqTranslation>();

    public virtual ICollection<InsuranceCaseTypesTranslation> InsuranceCaseTypesTranslations { get; set; } = new List<InsuranceCaseTypesTranslation>();

    public virtual ICollection<MenuItem> MenuItems { get; set; } = new List<MenuItem>();

    public virtual ICollection<PagesTranslation> PagesTranslations { get; set; } = new List<PagesTranslation>();

    public virtual ICollection<ProductActionsTranslation> ProductActionsTranslations { get; set; } = new List<ProductActionsTranslation>();

    public virtual ICollection<ProductBenefitsTranslation> ProductBenefitsTranslations { get; set; } = new List<ProductBenefitsTranslation>();

    public virtual ICollection<ProductCategoriesTranslation> ProductCategoriesTranslations { get; set; } = new List<ProductCategoriesTranslation>();

    public virtual ICollection<ProductRisksTranslation> ProductRisksTranslations { get; set; } = new List<ProductRisksTranslation>();

    public virtual ICollection<ProductsTranslation> ProductsTranslations { get; set; } = new List<ProductsTranslation>();

    public virtual ICollection<TopManagementTranslation> TopManagementTranslations { get; set; } = new List<TopManagementTranslation>();
}
