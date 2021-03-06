using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EditWordWithOpenXML.Models;

    public class DocumentContext : DbContext
    {
        public DocumentContext (DbContextOptions<DocumentContext> options)
            : base(options)
        {
        }

        public DbSet<EditWordWithOpenXML.Models.Document> Document { get; set; }
    }
