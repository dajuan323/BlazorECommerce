﻿namespace BlazorECommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "The Hitchhikers Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Planet of the Apes",
                    Description = "La Planète des singes, known in English as Planet of the Apes in the US and Monkey Planet in the UK, is a 1963 science fiction novel by French author Pierre Boulle. It was adapted into the 1968 film Planet of the Apes, launching the Planet of the Apes media franchise.[",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/f/f1/LaPlan%C3%A8teDesSinges.jpg",
                    Price = 11.99m
                }
                );
        }
        public DbSet<Product> Products { get; set; }
    }
}

 