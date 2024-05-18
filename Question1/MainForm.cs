using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Question1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnFindPrimes1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber1.Text, out int number))  // Check if the input is a valid number.
            {
                Thread thread = new Thread(() => FindPrimes(number, listBox1));  // Create a new thread to find prime numbers.
                thread.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnFindPrimes2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber2.Text, out int number)) 
            {
                Thread thread = new Thread(() => FindPrimes(number, listBox2)); 
                thread.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        /// <summary>
        /// Find prime numbers up to a given number and display them in a list box.
        /// Call SieveOfEratosthenes method to find prime numbers.
        /// </summary>
        /// <param name="number"> The number up to which to find prime numbers.</param>
        /// <param name="listBox"> The list box in which to display the prime numbers.</param>
        private void FindPrimes(int number, ListBox listBox)
        {
            List<int> primes = SieveOfEratosthenes(number);
            listBox.Invoke(new Action(() =>
            {
                listBox.Items.Clear();
                foreach (int prime in primes)
                {
                    listBox.Items.Add(prime);
                }
            }));
        }

        /// <summary>
        /// Find all prime numbers up to a given number using the Sieve of Eratosthenes algorithm.
        /// </summary>
        /// <param name="number">The number up to which to find prime numbers.</param></param>
        /// <returns> A list of prime numbers up to the given number.</returns>
        private List<int> SieveOfEratosthenes(int number)
        {
            bool[] isPrime = new bool[number + 1];
            for (int i = 2; i <= number; i++) isPrime[i] = true;

            for (int p = 2; p * p <= number; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= number; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= number; i++)
            {
                if (isPrime[i]) primes.Add(i);
            }

            return primes;
        }

    }
}
