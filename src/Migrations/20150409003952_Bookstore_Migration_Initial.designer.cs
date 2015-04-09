using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Metadata.Builders;
using Microsoft.Data.Entity.Relational.Migrations.Infrastructure;
using EF7Sample.Models;

namespace EF7Sample.Migrations
{
    [ContextType(typeof(BookstoreContext))]
    partial class Bookstore_Migration_Initial
    {
        public override string Id
        {
            get { return "20150409003952_Bookstore_Migration_Initial"; }
        }
        
        public override string ProductVersion
        {
            get { return "7.0.0-beta5-12870"; }
        }
        
        public override IModel Target
        {
            get
            {
                var builder = new BasicModelBuilder()
                    .Annotation("SqlServer:ValueGeneration", "Sequence");
                
                builder.Entity("ConsoleAppEF7.Models.Author", b =>
                    {
                        b.Property<int>("AuthorId")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<int>("BookId")
                            .Annotation("OriginalValueIndex", 1);
                        b.Property<string>("Name")
                            .Annotation("OriginalValueIndex", 2);
                        b.Key("AuthorId");
                    });
                
                builder.Entity("ConsoleAppEF7.Models.Book", b =>
                    {
                        b.Property<int>("BookId")
                            .GenerateValueOnAdd()
                            .Annotation("OriginalValueIndex", 0);
                        b.Property<string>("Title")
                            .Annotation("OriginalValueIndex", 1);
                        b.Key("BookId");
                    });
                
                builder.Entity("ConsoleAppEF7.Models.Author", b =>
                    {
                        b.ForeignKey("ConsoleAppEF7.Models.Book", "BookId");
                    });
                
                return builder.Model;
            }
        }
    }
}
