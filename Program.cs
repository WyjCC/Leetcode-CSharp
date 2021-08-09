using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 重塑矩阵 #566
            //int[][] mat = new int[2][];
            //mat[0] = new int[] { 1, 2 };
            //mat[1] = new int[] { 3, 4 };
            //int r, c;
            //r = 1;
            //c = 4;
            //int count = 0;
            //for (int i = 0; i < mat.Length; i++)
            //{
            //    count += mat[i].Length;
            //}
            //if (count != r * c)
            //{
            //}
            //int int2 = mat[0].Length;
            //int[][] newMat = new int[r][];
            ////int indexr, indexc;
            ////indexr = indexc = 0;
            ////for (int i = 0; i < mat.Length; i++)
            ////{
            ////    for (int j = 0; j < mat[i].Length; j++)
            ////    {
            ////        if (indexc == 0)
            ////        {
            ////            newMat[indexr] = new int[c];
            ////        }
            ////        newMat[indexr][indexc] = mat[i][j];
            ////        indexc++;
            ////        if (indexc > c)
            ////        {
            ////            indexc = 0;
            ////            indexr++;
            ////        }
            ////    }
            ////}
            //for (int i = 0; i < r * c; i++)
            //{
            //    if (i % c == 0)
            //    {
            //        newMat[i / c] = new int[c];
            //    }
            //    newMat[i / c][i % c] = mat[i / int2][i % int2];
            //}
            #endregion

            #region 杨辉三角 #118
            //int numRows = 5;
            //IList<IList<int>> result = new List<IList<int>>();
            //for (int i = 0; i < numRows; i++)
            //{
            //    for (int j = 0; j < i + 1; j++)
            //    {
            //        if (j == 0)
            //        {
            //            result.Add(new List<int>());
            //            result[i].Add(1);
            //            continue;
            //        }
            //        if (j == i)
            //        {
            //            result[i].Add(1);
            //            break;
            //        }
            //        result[i].Add(result[i - 1][j - 1] + result[i - 1][j]);
            //    }
            //}
            #endregion

            #region 矩阵置零 #73
            //int[][] matrix = new int[3][];
            //matrix[0] = new int[] { 1, 1, 1 };
            //matrix[1] = new int[] { 1, 0, 1 };
            //matrix[2] = new int[] { 1, 1, 1 };
            //HashSet<int> rowNo = new HashSet<int>();
            //HashSet<int> colNo = new HashSet<int>();
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        if (matrix[i][j] == 0)
            //        {
            //            if (!rowNo.Contains(i))
            //            {
            //                rowNo.Add(i);
            //            }
            //            if (!colNo.Contains(j))
            //            {
            //                colNo.Add(j);
            //            }
            //        }
            //    }
            //}
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        if (matrix[i][j] == 0)
            //        {
            //            continue;
            //        }
            //        if (rowNo.Contains(i))
            //        {
            //            matrix[i][j] = 0;
            //            continue;
            //        }
            //        if (colNo.Contains(j))
            //        {
            //            matrix[i][j] = 0;
            //            continue;
            //        }
            //    }
            //}
            #endregion

            #region 存在重复元素 #217
            //int[] nums = new int[] { };
            //HashSet<int> hsN = new HashSet<int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (hsN.Contains(nums[i]))
            //    {
            //        Console.WriteLine(true);
            //        return;
            //    }
            //    hsN.Add(nums[i]);
            //}
            //Console.WriteLine(false);
            #endregion

            #region 最大子序和 #53

            int[] nums = new int[] { };
            #region 动态规划
            //int max = nums[0];
            //int sum = nums[0];
            //for (int i = 1; i < nums.Length; i++)
            //{
            //    sum = Math.Max(sum + nums[i], nums[i]);
            //    max = Math.Max(sum, max);
            //}
            //return max;
            #endregion

            #region 分治

            #endregion
            #endregion
        }

        #region Func

        #endregion
    }

    #region Model
    #region 分治
    public class MaximumSubarray
    {
        /// <summary>
        /// 左起最大子序和
        /// </summary>
        public int LSum { get; set; }
        /// <summary>
        /// 右结束最大子序和
        /// </summary>
        public int RSum { get; set; }
        /// <summary>
        /// 最大子序和
        /// </summary>
        public int MSum { get; set; }
        /// <summary>
        /// 整个序列和
        /// </summary>
        public int ISum { get; set; }
    }
    #endregion
    #endregion

}
