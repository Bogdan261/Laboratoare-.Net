﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Asp_Ciubotaru_Bogdan_Ioan_Rp.Data;
using Asp_Ciubotaru_Bogdan_Ioan_Rp.Models;

namespace Asp_Ciubotaru_Bogdan_Ioan_Rp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly Asp_Ciubotaru_Bogdan_Ioan_Rp.Data.Asp_Ciubotaru_Bogdan_Ioan_RpContext _context;

        public IndexModel(Asp_Ciubotaru_Bogdan_Ioan_Rp.Data.Asp_Ciubotaru_Bogdan_Ioan_RpContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movie
                         select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
