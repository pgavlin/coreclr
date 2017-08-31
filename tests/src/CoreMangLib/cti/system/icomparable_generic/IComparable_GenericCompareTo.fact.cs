using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_icomparable_generic_IComparable_GenericCompareTo_IComparable_GenericCompareTo_
    {
        [OuterLoop]
        [Fact]
        public void _system_icomparable_generic_IComparable_GenericCompareTo_IComparable_GenericCompareTo_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\icomparable_generic\\IComparable_GenericCompareTo\\IComparable_GenericCompareTo.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
