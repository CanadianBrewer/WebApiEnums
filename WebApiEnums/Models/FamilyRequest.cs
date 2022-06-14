using System.Text.Json.Serialization;
using WebApiEnums.Enums;

namespace WebApiEnums.Models;

public class FamilyRequest
{
    public int Id { get; init; }
    
    public Family FamilyMember { get; init; }
    
    public Pets Pet { get; init; }
}