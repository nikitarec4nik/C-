namespace job2
{
    public class B : A
    {
        private decimal d;

        public decimal c2
        {
            get
            {
                while (true)
                {
                    return d + c;
                }
            }
            set { d = value; }
        }

        public B(decimal d, decimal c) : base()
        {
            this.d = d;
            this.c2 = d + c;
        }

        public B()
        {
        }
    }
}
