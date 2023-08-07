using System;
using System.Threading.Tasks;
namespace MecerEmployees
{

    class Program
    {
        static void Main(string[] args)
        {
            Blessing blessing = new Blessing();
            Sivu sivu = new Sivu();
            Banele banele = new Banele();
            Lebo lebo = new Lebo();

            blessing.Checkin();
            blessing.Checkout();
            blessing.DoThis();
            ((ReportProgress)blessing).DoThis();

            sivu.Checkin();
            sivu.Checkout();

            banele.Checkin();
            banele.Checkout();

            lebo.Checkin();
            lebo.Checkout();

        }
    }
    public class Blessing : IControls, ReportProgress
    {
        public void Checkin()
        {
            Console.WriteLine("CHECKED IN VIA MS TEAMS FROM HOME");
        }

        public void Checkout()
        {
            Console.WriteLine("REQUESTED TIME OFF");
        }

        public void DoThis()
        {
            throw new NotImplementedException();
        }

        public void MonthlyReport()
        {
            throw new NotImplementedException();
        }

        public void WeeklyMeetings()
        {
            throw new NotImplementedException();
        }

        void IControls.Checkin()
        {
            throw new NotImplementedException();
        }

        void IControls.Checkout()
        {
            throw new NotImplementedException();
        }

        void Location.HeadOffice()
        {
            throw new NotImplementedException();
        }

        void Location.LocalBranch()
        {
            throw new NotImplementedException();
        }

        //void ReportProgress.DoThis()
        //{
        //    throw new NotImplementedException();
        //}

        //void Location.HeadOffice()
        //{
        //    throw new NotImplementedException();
        //}

        //void Location.LocalBranch()
        //{
        //    throw new NotImplementedException();
        //}

        //void ReportProgress.MonthlyReport()
        //{
        //    throw new NotImplementedException();
        //}

        //void ReportProgress.WeeklyMeetings()
        //{
        //    throw new NotImplementedException();
        //}
    }
    public class Sivu : IControls
    {
        public void Checkin()
        {
            Console.WriteLine("COMING IN LATE, WENT TO THE DOCTOR");
        }

        public void Checkout()
        {
            Console.WriteLine("DIDNT CHECK IN");
        }

        void Location.HeadOffice()
        {
            throw new NotImplementedException();
        }

        void Location.LocalBranch()
        {
            throw new NotImplementedException();
        }
    }
    public class Banele : IControls
    {
        public void Checkin()
        {
            Console.WriteLine("ARRIVED AT 07:00");
        }

        public void Checkout()
        {
            Console.WriteLine("LEFT 15:00"); ;
        }

        void Location.HeadOffice()
        {
            throw new NotImplementedException();
        }

        void Location.LocalBranch()
        {
            throw new NotImplementedException();
        }
    }
    public class Lebo : IControls
    {
        public void Checkin()
        {
            Console.WriteLine("ARRIVED 08:00");
        }

        public void Checkout()
        {
            Console.WriteLine("LEFT 15:00");
        }

        void IControls.Checkin()
        {
            throw new NotImplementedException();
        }

        void IControls.Checkout()
        {
            throw new NotImplementedException();
        }

        void Location.HeadOffice()
        {
            throw new NotImplementedException();
        }

        void Location.LocalBranch()
        {
            throw new NotImplementedException();
        }
    }
    interface IControls: Location
    {

        void Checkin();
        void Checkout();

    }
    interface ReportProgress
    {
        void MonthlyReport();
        void WeeklyMeetings();
        void DoThis();

    }




    interface Location
    {
        void HeadOffice();
        void LocalBranch();


    }

}
