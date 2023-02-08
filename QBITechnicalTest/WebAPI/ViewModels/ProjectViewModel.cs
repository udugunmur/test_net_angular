using Core.Data.Domain.TechnicalDbModel;

namespace WebAPI.ViewModels
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectName { get; set; }

        public CountryViewModel Country { get; set; }
        public string State { get; set; }
        public string Tech { get; set; }
    }
}