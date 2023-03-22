using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repasoVideoClub
{
    internal class Trailer
    {
        private string url;
        private int duracionSeg;

        public Trailer(string url, int duracionSeg)
        {
            this.url = url;
            this.duracionSeg = duracionSeg;
        }

        public string GetUrl() => this.url;
        public int GetDuracionSeg() => this.duracionSeg;
        public void SetUrl(string url) => this.url = url;
        public void SetDuracionSeg(int duracionSeg) => this.duracionSeg = duracionSeg;
    }
}
