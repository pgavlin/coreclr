using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_predicate_PredicateBeginInvoke_PredicateBeginInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_predicate_PredicateBeginInvoke_PredicateBeginInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\predicate\\PredicateBeginInvoke\\PredicateBeginInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
