using System;
using System.Collections.Generic;
using System.Text;

namespace paskaitaDevyni
{
    public struct Miskas
    {
        public List<int> Medziai { get; set; }

        public Miskas(List<int> medziai)
        {
            Medziai = medziai;

        }

        public void PasodintiMedi()
        {
            TikrintiMedziaiList();
            Medziai.Add(1);
        }

        private void TikrintiMedziaiList()
        {
            if(Medziai == null)
            {
                Medziai = new List<int>();
            }
        }
    }
}
