using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csvToVcf
{
    class Util
    {
        public static string[] saveMemberToVector(string memberLine)
        {
            string[] member;
            // split the line by comma
            member = memberLine.Split(',');
            return member;

        }
        public static string writeToVcfFile(string[] member, string organizationName, string year)
        {
         

            string firstName = member[0];
            string secondName = member[1] + " " + organizationName + year;// see Name Format in 38. row
            string phoneNumber = member[4];
            string email = member[5];
            string organization = "BBTK";
            // if someone enters their phone number without a leading zero
            if (phoneNumber[0] != '0' && phoneNumber[0] != '+')
            {
                phoneNumber = "0" + phoneNumber;
            }
            string contact = "BEGIN:VCARD" + Environment.NewLine + "VERSION:3.0N;CHARSET=utf-8:" + secondName + ";" + firstName
                + ";;;;" + Environment.NewLine + "FN;CHARSET=utf-8:" + firstName + " " + secondName + Environment.NewLine + "ORG:" + organization + Environment.NewLine
                + "TEL;TYPE=WORK,MOBILE:" + phoneNumber + Environment.NewLine + "EMAIL:" + email + Environment.NewLine + "END:VCARD" + Environment.NewLine;

            return contact;
        }
    }
}
