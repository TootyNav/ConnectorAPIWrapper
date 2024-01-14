namespace Connector.Models.Entities;

public class Provider
{
    public string ProviderId { get; set; }
    public List<string>? LocationIds { get; set; } = new List<string>();
    public string? OrganisationType { get; set; } = string.Empty;
    public string? OwnershipType { get; set; } = string.Empty;  
    public string? Type { get; set; } = string.Empty;   
    public string? Name { get; set; } = string.Empty;
    public string? BrandId { get; set; } = string.Empty;
    public string? BrandName { get; set; } = string.Empty;
    public string? RegistrationStatus { get; set; } = string.Empty;
    public string? RegistrationDate { get; set; } = string.Empty;
    public string? CompaniesHouseNumber { get; set; } = string.Empty;
    public string? CharityNumber { get; set; } = string.Empty;
    public string? Website { get; set; } = string.Empty;
    public string? PostalAddressLine1 { get; set; } = string.Empty;
    public string? PostalAddressLine2 { get; set; } = string.Empty;
    public string? PostalAddressTownCity { get; set; } = string.Empty;
    public string? PostalAddressCounty { get; set; } = string.Empty;
    public string? Region { get; set; } = string.Empty;
    public string? PostalCode { get; set; } = string.Empty;
    public string? Uprn { get; set; } = string.Empty;
    public double? OnspdLatitude { get; set; }
    public double? OnspdLongitude { get; set; }
    public string? MainPhoneNumber { get; set; } = string.Empty;
    public string? InspectionDirectorate { get; set; } = string.Empty;
    public string? Constituency { get; set; } = string.Empty;
    public string? LocalAuthority { get; set; } = string.Empty;
    public List<DateOnly>? LastInspection { get; set; } = new List<DateOnly>();

    public DateTimeOffset CachedOnDate { get; set; }


}
