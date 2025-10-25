using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpulenciaDataStructureCpe2025
{
    public partial class FrmBinarySearch : Form
    {
        public FrmBinarySearch()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                ltbResult.Items.Clear();

                try
                {
                    int[] arr = txtNumber.Text
                        .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    Array.Sort(arr);

                    int target = int.Parse(txtSearch.Text);

                    int index = BinarySearch(arr, target);

                    ltbResult.Items.Add(string.Join(", ", arr));

                    if (index != -1)
                        ltbResult.Items.Add($"The value {target} was found at index {index}");
                    else
                        ltbResult.Items.Add($"The value {target} was not found in the list.");
                }
                catch (Exception)
                {
                    ltbResult.Items.Add("Please enter valid numbers and try again.");
                }
            }
        }
        private int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1;
        }
    }
}
