using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1

{

    public class Person
    {
        private string strname;
        private int strage;
        private string strphone;
        private string strgender;
        string ValidationError = "";
        public string Name 
      
        {
            get { return strname; }
            set
            {  if (value.Length< 3 || value.Length> 80)
                    ValidationError = " Invalid Name";
                else
                {
                    strname = value;
                    ValidationError = "";
                }
            }
        }
        public int Age
        {
           get { return strage; }
           set
           {
              if (value < 16 || value > 80)
              ValidationError = " Invalid Age";
             else
             {
                strage = value;
                ValidationError = "";
             }
           }
        }
        public string Phone
        {
           get { return strphone; }
           set { strphone = value; }
         }
         public string Gender
         {
            get { return strgender; }
            set { strgender = value; }
         }
        public Person(string strname,int strage,string strphone,string strgender)

        {
            this.strname = strname;
            this.strage = strage;
            this.strphone = strphone;
            this.strgender = strgender;

        }
        public static decimal TotalBalance { get; set; } = 0;


    }
    public class  Members : Person
{
    private string strplan;
    private int strweight;
    private int strdweight;
    private int strheight;
    private string strhealthprom;
    private string strstatus;
    private string traintype;
    public Members(string strplan, int strweight, int strdweight, int strheight, string strhealthprom, string traintype, string strname, int strage, string strphone, string strgender) : base(strname, strage, strphone, strgender)
    {
        this.strplan = strplan;
        this.strweight = strweight;
        this.strdweight = strdweight;
        this.strheight = strheight;
        this.strhealthprom = strhealthprom;
        this.traintype = traintype;




    }
    public string Plan
    {
        get { return strplan; }
        set { strplan = value; }

    }

    public int Weight
    {
        get { return strweight; }
        set { strweight = value; }

    }
    public int Strdweight
    {
        get { return strdweight; }
        set { strweight = value; }

    }
    public int Strheight
    {
        get { return strheight; }
        set { strheight = value; }

    }
    public string Strhealthprom
    {
        get { return strhealthprom; }
        set { strhealthprom = value; }
    }
    public string Strstatus
    {
        get { return strstatus; }

    }
    public string Traintype
    {
        get { return traintype; }
        set { traintype = value; }

    }
     
        public  void AddToBalance()
        {
            if (strplan == "Monthly")
            {
                TotalBalance += 400;
            }
            else if (strplan == "Quarterly")
            {
                TotalBalance += 1000;
            }
            else 
            {
                TotalBalance += 4500;
            }

        }
        public static decimal Id { get; set; } = 1000;
        public static int Membersno { get; set; } = 0;
        public static void AddMember()
        {
            Membersno += 1;
            Id++;


        }





    }
    public class Trainers : Person
{
    
    private int exp_years;
    
    public int Exp_years
    {
        get { return exp_years; }
        set { exp_years = value; }
    }
    public Trainers( int exp_years, string strname, int strage, string strphone, string strgender) : base(strname, strage, strphone, strgender)
    {
        
        this.exp_years = exp_years;
    }
    public static int Coachesno { get; set; } = 0;
    public static void AddCoache()
    {
       Coachesno += 1;
    }
        public void SubFromBalance() 
    {
            TotalBalance-=2000;

    }

   }
    public static class Global 
    {
        public static Members[] allMembers = new Members[100];
        public static int CurrentCountM = 0;
        public static Trainers[] alltrainers = new Trainers[30];
        public static int CurrentCountC = 0;

    }
}