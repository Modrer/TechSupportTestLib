using HedgehogCheckLib;

namespace TechSupportTestLibTest
{
    [TestFixture]
    public class Tests
    {
        private static IEnumerable<(int, int[], int)> TestInputs()
        {
            yield return (0, [0, 0, 0], 0);
            yield return (-1, [0, 0, 1], 0);
            yield return (-1, [0, 0, 2], 0);
            yield return (-1, [0, 1, 0], 0);
            yield return (-1, [0, 0, 1], 0);
            yield return (1, [0, 1, 1], 0);
            yield return (-1, [0, 1, 2], 0);
            yield return (2, [0, 2, 2], 0);
            yield return (0, [1, 0, 0], 0);
            yield return (-1, [1, 0, 1], 0);
            yield return (-1, [1, 0, 2], 0);
            yield return (-1, [1, 1, 0], 0);
            yield return (1, [1, 1, 1], 0);
            yield return (-1, [1, 1, 2], 0);
            yield return (-1, [1, 2, 0], 0);
            yield return (-1, [1, 2, 1], 0);
            yield return (2, [1, 2, 2], 0);
            yield return (3, [1, 0, 3], 0);
            yield return (3, [2, 0, 3], 0);
            yield return (6,  [2, 0, 6], 0);
            yield return (-1, [2, 0, 6], 2);
            yield return (5, [2, 0, 5], 1);
            yield return (400, [64, 533, 400], 1);
            yield return (-1, [230, 70, 733], 1);
            yield return (-1, [313, 577, 212], 1);
            yield return (-1, [51, 480, 2675], 1);
            yield return (648, [423, 86, 648], 1);
            yield return (-1, [432, 617, 161], 1);
            yield return (-1, [290, 917, 696], 1);
            yield return (381, [219, 305, 381], 1);
            yield return (452, [71, 114, 452], 1);
            yield return (564, [81, 632, 564], 1);
        }

        [Test, TestCaseSource(nameof(TestInputs)), Timeout(200)]

        public void Test((int, int[], int) tests)
        {

            (int count, int[] hendehogs, int colorNum) = tests;

            HedgehogCheck.Check(hendehogs, colorNum);

            Assert.That(count, Is.EqualTo(HedgehogCheck.Check(hendehogs, colorNum)));
        }
    }
}