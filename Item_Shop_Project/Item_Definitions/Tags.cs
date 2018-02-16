using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFML
{
    enum Inheritence_Level : short { None, Intermediate, Full };
    struct Tag
    {
        public string Identifier;
        Inheritence_Level Inheritence_level;

        public Tag(string Tag_Name, Inheritence_Level Tag_Inheritence)
        {
            Identifier = Tag_Name;
            Inheritence_level = Tag_Inheritence;

        }
    }

    class Tag_Listings
    {
        Dictionary<string, Tag> Tag_Dictionary;

        public Tag_Listings()
        {
            Tag_Dictionary = new Dictionary<string, Tag>();
        }

        public void Define_Tag(string Identifier, Inheritence_Level Inheritence_level)
        {
            if(Tag_Dictionary.ContainsKey(Identifier))
            {
                return;
            }

            Tag_Dictionary.Add(Identifier, new Tag(Identifier, Inheritence_level));


        }

        private void Seed_Default_Tags()
        {
            //This function should eventually be replaced with a function that reads in from a script.

            Define_Tag("Metal", Inheritence_Level.None);
            Define_Tag("Wood", Inheritence_Level.None);
            Define_Tag("Leather", Inheritence_Level.None);

        }

        public Tag GetTag(string identifier)
        {
            if (!Tag_Dictionary.ContainsKey(identifier))
            {
                Define_Tag(identifier, Inheritence_Level.None);
            }

            return Tag_Dictionary[identifier];
        }


    }


}
