﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    class Swap_Nodes_in_Pairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode returnValue = default;
            returnValue = Map(head, returnValue);

            return returnValue;
        }

        private ListNode Map(ListNode a, ListNode result)
        {
            if (a?.next != null)
            {
                result = new ListNode(a.next.val, new ListNode(a.val));

                result.next.next = Map(a.next.next, result.next.next);
            }
            else if (a != null)
            {
                result = new ListNode(a.val);
            }

            return result;
        }


        [Test(Description = "https://leetcode.com/problems/swap-nodes-in-pairs/")]
        [Category("Medium")]
        [Category("Leetcode")]
        [Category("Swap Nodes in Pairs")]
        [TestCaseSource("Input")]
        public void Test1((ListNode Output, ListNode Input) item)
        {
            var response = SwapPairs(item.Input);
            Assert.AreEqual(item.Output, response);
        }

        public static IEnumerable<(ListNode Output, ListNode Input)> Input
        {
            get
            {
                return new List<(ListNode Output, ListNode Input)>()
                {

                    (new ListNode(2, new ListNode(1, new ListNode(4, new ListNode(3)))),
                    new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))))),
                };
            }
        }
    }
}
