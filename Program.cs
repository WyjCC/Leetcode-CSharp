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
            #region 两数之和 #1
            //int[] nums = new int[] { };
            //int target = 0;

            #region 方法1，暴力求解
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            return new int[] { i, j };
            //        }
            //    }
            //}
            //return null;
            #endregion

            #region 方法2
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int de = target - nums[i];
            //    if (dic.ContainsKey(de))
            //    {
            //        return new int[] { i, dic[de] };
            //    }
            //    dic.Add(nums[i], i);
            //}
            //return null;
            #endregion


            #endregion

            #region 有效的数独 #36
            //char[][] board = new char[9][];
            //board[0] = new char[] { '8', '3', '.', '.', '7', '.', '.', '.', '.' };
            //board[1] = new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' };
            //board[2] = new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' };
            //board[3] = new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' };
            //board[4] = new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' };
            //board[5] = new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' };
            //board[6] = new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' };
            //board[7] = new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' };
            //board[8] = new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' };
            //bool result = true;
            //for (int i = 0; i < board.Length; i++)
            //{
            //    for (int j = 0; j < board[i].Length; j++)
            //    {
            //        if (board[i][j] == '.')
            //        {
            //            continue;
            //        }
            //        //行重复排查
            //        for (int k = j + 1; k < board[i].Length; k++)
            //        {
            //            if (board[i][j] == board[i][k])
            //            {
            //                //有相等，错误
            //                result = false;
            //            }
            //        }
            //        //列重复排查
            //        for (int k = i + 1; k < board.Length; k++)
            //        {
            //            if (board[i][j] == board[k][j])
            //            {
            //                //有相等，错误
            //                result = false;
            //            }
            //        }
            //        //3x3排查
            //        //计算当前所属矩阵
            //        int ii = i / 3;
            //        int jj = j / 3;
            //        int bii = ii * 3;
            //        int bjj = jj * 3;
            //        //验证非同行同列4个数字
            //        if (board[i][j] == board[((i + 1) % 3) + bii][((j + 1) % 3) + bjj])
            //        {
            //            result = false;
            //        }
            //        else if (board[i][j] == board[((i + 1) % 3) + bii][((j + 2) % 3) + bjj])
            //        {
            //            result = false;
            //        }
            //        else if (board[i][j] == board[((i + 2) % 3) + bii][((j + 1) % 3) + bjj])
            //        {
            //            result = false;
            //        }
            //        else if (board[i][j] == board[((i + 2) % 3) + bii][((j + 2) % 3) + bjj])
            //        {
            //            result = false;
            //        }
            //    }
            //}
            //Console.WriteLine(result);
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

            #region 合并两数组 #88
            //int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            //int m = 3;
            //int n = 3;
            //int[] nums2 = new int[] { 2, 5, 6 };

            #region 暴力赖皮求解
            //for (int i = 0; i < n; i++)
            //{
            //    nums1[m + i] = nums2[i];
            //}
            //nums2.CopyTo(nums1, m);
            //nums1 = nums1.OrderBy(t => t).ToArray();
            //Array.Sort(nums1);
            #endregion

            #region 双指针
            //int n1i = 0;
            //int n2i = 0;
            //int[] nnums1 = new int[m + n];
            //for (int i = 0; i < m + n; i++)
            //{
            //    if (n1i >= m)
            //    {
            //        nnums1[i] = nums2[n2i];
            //        n2i++;
            //        continue;
            //    }
            //    if (n2i >= n)
            //    {
            //        nnums1[i] = nums1[n1i];
            //        n1i++;
            //        continue;
            //    }
            //    if (nums1[n1i] < nums2[n2i])
            //    {
            //        nnums1[i] = nums1[n1i];
            //        n1i++;
            //    }
            //    else
            //    {
            //        nnums1[i] = nums2[n2i];
            //        n2i++;
            //    }
            //}
            //nnums1.CopyTo(nums1, 0);
            #endregion

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

            #region 买卖股票的最佳时机 #121
            //int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            #region 简单循环----超时
            //int max = 0;
            //int minIndex = int.MaxValue;
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    //优化，后续更大的值不进行考虑
            //    if (prices[i] >= minIndex)
            //    {
            //        continue;
            //    }
            //    for (int j = i + 1; j < prices.Length; j++)
            //    {
            //        if (prices[j] - prices[i] > max)
            //        {
            //            max = prices[j] - prices[i];
            //        }
            //        if (minIndex > prices[i])
            //        {
            //            minIndex = prices[i];
            //        }
            //    }
            //}
            //return max;
            #endregion

            #region 今日利润及算法
            //int minPrice = prices[0];
            //int maxPrice = 0;
            //for (int i = 0; i < prices.Length; i++)
            //{
            //    //当日卖出最大利润
            //    if (prices[i] - minPrice > maxPrice)
            //    {
            //        maxPrice = prices[i] - minPrice;
            //    }
            //    //记录前日最小金额
            //    if (prices[i] < minPrice)
            //    {
            //        minPrice = prices[i];
            //    }
            //}
            //return maxPrice;
            #endregion

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

            #region 两个数组的交集Ⅱ #350
            //int[] nums1, nums2;
            //nums1 = new int[] { 3, 1, 2 };
            //nums2 = new int[] { 1, 1 };
            //int[] minArr = null;
            //if (nums1.Length < nums2.Length)
            //{
            //    minArr = nums1;
            //}
            //else
            //{
            //    minArr = nums2;
            //    nums2 = nums1;
            //}
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //List<int> result = new List<int>();
            //for (int i = 0; i < minArr.Length; i++)
            //{
            //    if (dic.ContainsKey(minArr[i]))
            //    {
            //        dic[minArr[i]]++;
            //    }
            //    else
            //    {
            //        dic.Add(minArr[i], 1);
            //    }
            //}
            //for (int i = 0; i < nums2.Length; i++)
            //{
            //    if (dic.ContainsKey(nums2[i]) && dic[nums2[i]] > 0)
            //    {
            //        result.Add(nums2[i]);
            //        if (dic[nums2[i]] > 1)
            //        {
            //            dic[nums2[i]]--;
            //        }
            //    }
            //}
            //result.ToArray();
            #endregion

            #region 字符串中的第一个唯一字符 #387
            //string s = "loveleetcodevtcod";
            #region 暴力循环 时间复杂度O(n2)
            //HashSet<char> hs = new HashSet<char>();
            //for (int i = 0; i < s.Length; i++)
            //{
            //    char c = s[i];
            //    if (hs.Contains(c))
            //    {
            //        continue;
            //    }
            //    bool hasValue = false;
            //    for (int j = i + 1; j < s.Length; j++)
            //    {
            //        if (c == s[j])
            //        {
            //            hs.Add(c);
            //            hasValue = true;
            //        }
            //    }
            //    if (!hasValue)
            //    {
            //        Console.WriteLine(i);
            //        return;
            //    }
            //}
            //Console.WriteLine(-1);
            #endregion

            #endregion

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
