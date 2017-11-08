using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StringChallenges
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //reverse name challenge

            String name = "Patrick Labes";
            String newName ="";
            char[] nameArray = name.ToCharArray();


            for (int i = 0; i < nameArray.Length; i++)
            {
                newName += nameArray[nameArray.Length-1 - i];
            }
            
            resultLabel.Text = newName;

            // reverse this sequence
            string names = "Luke,Leia,Han,Chewbacca";
            string tempName ="";

            char[] namesArray = names.ToCharArray();
            List<String> wholeNamesArrayList = new List<string>();

            for (int i = 0; i < namesArray.Length; i++)
            {
                if (namesArray[i].Equals(',') || namesArray.Length == i+1)
                {
                    wholeNamesArrayList.Add(tempName);
                    tempName = "";
                }else
                    tempName += namesArray[i];

            }

            wholeNamesArrayList.Reverse();
            string output = "";

            for (int i = 0; i < wholeNamesArrayList.Count; i++)
            {
                output += wholeNamesArrayList[i];
                if(!wholeNamesArrayList.Last().Equals(wholeNamesArrayList[i]))
                {
                    output += ",";
                }
            }
            
            resultLabel.Text = output;

            wholeNamesArrayList.Reverse();

            List<String> axArtWholeList = new List<String>();

            foreach(string nameforloop in wholeNamesArrayList)
            {
                int size = nameforloop.ToCharArray().Length;
                size = (14 - size) / 2;
                String temp = "";
                for (int i = 0; i < size; i++)
                {
                    temp += "*";
                }
                temp += nameforloop;

                size += nameforloop.ToCharArray().Length;
                size = 14 - size;

                for (int i = 0; i < size ; i++)
                {
                    temp += "*";
                }

                axArtWholeList.Add(temp);

            }

            string output1 = "";
            foreach(string nameforloop in axArtWholeList)
            {
                output1 += nameforloop;
                output1 += "</br>";
            }
            

            resultLabel.Text = output1;

        }
    }
}