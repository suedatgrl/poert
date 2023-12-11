using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace portfolyo
{
    internal class PortfolyoUserEntityConfiguration : IEntityTypeConfiguration<object>
    {
        public PortfolyoUserEntityConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<object> builder)
        {
            throw new NotImplementedException();
        }
    }
}