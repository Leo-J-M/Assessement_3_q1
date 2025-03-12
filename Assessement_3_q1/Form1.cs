namespace Assessement_3_q1
{
    public partial class Form1 : Form {
        //struct ListType {
        //    public int length;
        //    public List<string> info;
        //}
        private bool compareWords(string s1, string s2) {
            if(string.CompareOrdinal(s1, s2) > 0) {
                return true;
            }
            return false;
        }

        void BinarySearch(List<string> list, ref string item, ref bool found, ref int position) {
            int pos = -1;//position in the array
            int midPoint;
            int first = 0;
            int last = list.Count - 1;
            bool moreToSearch = first <= last;
            found = false;
            position = pos;
            while (moreToSearch && !found) {
                midPoint = (first + last) / 2;

                if (compareWords(list[midPoint], item)) {
                    last = midPoint - 1;
                    moreToSearch = first <= last;
                }
                else if (compareWords(item, list[midPoint])) {
                    first = midPoint + 1;
                    moreToSearch = first <= last;
                }
                else {
                    item = list[midPoint];
                    found = true;
                    position = ++midPoint;
                } 
            } 
        }

        List<string> str;
        public Form1() {
            InitializeComponent();
            setStr();
        }


        //List<string> str = new List<string>() 
        //    { "Jon", "Dot", "Eva", "Roy", "Guy", "Jan", "Tom", "Jim", "Ann", "Kim", "Ron", "Tim", "Kay", "Ami" };
        
        private void setStr() {
            str = new List<string>()
            { "Jon", "Dot", "Eva", "Roy", "Guy", "Jan", "Tom", "Jim", "Ann", "Kim", "Ron", "Tim", "Kay", "Ami" };
        }

        private void button1_Click(object sender, EventArgs e) {
            str = str.OrderBy(f => f[0]).ThenBy(s => s[1]).ThenBy(t => t[2]).ToList();
            string item = textBox1.Text;
            bool found = false;
            int position = 0;

            BinarySearch(str, ref item, ref found, ref position);

            textBox2.Text = string.Join(", ", str);

            textBox3.Text = position.ToString();

        }
    }
}
