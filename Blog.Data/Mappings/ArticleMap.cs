using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(
                new Article
                {
                    Id = Guid.NewGuid(),
                    Title = "Asp.Net Core Deneme Makalesi",
                    Content = "Asp.Net Core Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Faucibus nisl tincidunt eget nullam non nisi est sit amet. Fermentum posuere urna nec tincidunt praesent. Massa enim nec dui nunc mattis enim ut. Et netus et malesuada fames ac turpis. Aliquam malesuada bibendum arcu vitae elementum. Augue interdum velit euismod in pellentesque massa. Non nisi est sit amet facilisis magna etiam tempor orci. Diam sollicitudin tempor id eu. Dictum at tempor commodo ullamcorper a lacus vestibulum sed. Augue interdum velit euismod in pellentesque massa placerat. Quisque non tellus orci ac. Tortor aliquam nulla facilisi cras fermentum odio eu. Urna nunc id cursus metus aliquam eleifend mi in.\r\n\r\nDuis at consectetur lorem donec. Tortor at risus viverra adipiscing at in. Nisl pretium fusce id velit ut tortor pretium. Cras ornare arcu dui vivamus arcu felis. Sed nisi lacus sed viverra tellus in hac habitasse platea. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Dui nunc mattis enim ut tellus. Id diam maecenas ultricies mi eget mauris. Velit euismod in pellentesque massa placerat duis ultricies lacus sed. Tincidunt lobortis feugiat vivamus at augue. Ultricies tristique nulla aliquet enim tortor. Ultricies mi quis hendrerit dolor magna eget est. Cras tincidunt lobortis feugiat vivamus at augue eget arcu dictum. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est. Elit ut aliquam purus sit amet. Ultricies mi quis hendrerit dolor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ultrices sagittis orci a scelerisque.",
                    ViewCount = 15,
                    ImageId = Guid.Parse("214BCD11-2794-4A88-96B5-53580337C0AE"),
                    CategoryId = Guid.Parse("010BB85E-9604-4AC8-B164-1D9034757438"),
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false,
                    UserId = Guid.Parse("372F18FE-FE3F-4826-A47E-8E77260F684B")
                },
                  new Article
                  {
                      Id = Guid.NewGuid(),
                      Title = "Visual Studio Deneme Makalesi",
                      Content = "Visual Studio Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Faucibus nisl tincidunt eget nullam non nisi est sit amet. Fermentum posuere urna nec tincidunt praesent. Massa enim nec dui nunc mattis enim ut. Et netus et malesuada fames ac turpis. Aliquam malesuada bibendum arcu vitae elementum. Augue interdum velit euismod in pellentesque massa. Non nisi est sit amet facilisis magna etiam tempor orci. Diam sollicitudin tempor id eu. Dictum at tempor commodo ullamcorper a lacus vestibulum sed. Augue interdum velit euismod in pellentesque massa placerat. Quisque non tellus orci ac. Tortor aliquam nulla facilisi cras fermentum odio eu. Urna nunc id cursus metus aliquam eleifend mi in.\r\n\r\nDuis at consectetur lorem donec. Tortor at risus viverra adipiscing at in. Nisl pretium fusce id velit ut tortor pretium. Cras ornare arcu dui vivamus arcu felis. Sed nisi lacus sed viverra tellus in hac habitasse platea. Vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt. Dui nunc mattis enim ut tellus. Id diam maecenas ultricies mi eget mauris. Velit euismod in pellentesque massa placerat duis ultricies lacus sed. Tincidunt lobortis feugiat vivamus at augue. Ultricies tristique nulla aliquet enim tortor. Ultricies mi quis hendrerit dolor magna eget est. Cras tincidunt lobortis feugiat vivamus at augue eget arcu dictum. Risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est. Elit ut aliquam purus sit amet. Ultricies mi quis hendrerit dolor. Eu tincidunt tortor aliquam nulla facilisi cras fermentum. Ultrices sagittis orci a scelerisque.",
                      ViewCount = 15,
                      CategoryId = Guid.Parse("0F7A15A2-876E-4BF6-B052-D1B84DF559D6"),
                      ImageId = Guid.Parse("B92D05D0-AF78-4A73-8C12-69560C7A9F3F"),
                      CreatedBy = "Admin Test",
                      CreatedDate = DateTime.Now,
                      IsDeleted = false,
                      UserId = Guid.Parse("4A0F8924-5B95-427E-8E19-C19225C1B880")
                  }

                );
        }
    }
}
