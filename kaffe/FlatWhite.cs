using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaffe
{
    public class FlatWhite : Kaffe, Imælk
    {

        /// <summary>
        /// denne metode er implementeret fra interfacet Imælk
        /// </summary>
        /// <returns></returns>
        public int MlMælk()
        {
            return 160;
        }

        /// <summary>
        /// denne metoder er arvet fra kaffe som er abstract og er derfor overridet.
        /// </summary>
        /// <returns></returns>

        public override int Pris()
        {
            return 45;
        }
        /// <summary>
        /// Denne metode er overridet fra metoden styrke fra base klassen kaffe.
        /// </summary>
        /// <returns></returns>
        public override string Styrke()
        {
            return "mild";
        }
    }
}
