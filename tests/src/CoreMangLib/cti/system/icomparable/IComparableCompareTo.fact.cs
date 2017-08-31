using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_icomparable_IComparableCompareTo_IComparableCompareTo_
    {
        [OuterLoop]
        [Fact]
        public void _system_icomparable_IComparableCompareTo_IComparableCompareTo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\icomparable\\IComparableCompareTo\\IComparableCompareTo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
