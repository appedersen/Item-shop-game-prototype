using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFML
{
    class Material
    {
        string Name;

        float Difficulty_Modifier;
        int Base_Cost;

        Tag Category_Tag;
        List<Tag> Tag_List;



        public Material(string Material_name, float Difficulty, int Cost, Tag Material_Type)
        {
            Name = Material_name;
            Difficulty_Modifier = Difficulty;
            Base_Cost = Cost;
            Category_Tag = Material_Type;
        }





    }

    class Material_Handler
    {
        Dictionary<string, Material> Material_Dictionary;
        Tag_Listings Tag_Dictionary;

        public Material_Handler(Tag_Listings Tag_Listings_Reference)
        {
            Tag_Dictionary = Tag_Listings_Reference;

            Create_Material("NULL", 0, 0, Tag_Dictionary.GetTag("NULL"));
        }

        void Create_Material(string Material_name, float Difficulty, int Cost, Tag Material_Type)
        {
            if(Material_Dictionary.ContainsKey(Material_name))
            {
                //Logging goes here
                return;
            }

            Material_Dictionary.Add(Material_name, new Material(Material_name, Difficulty, Cost, Material_Type));
        }


    }



}
