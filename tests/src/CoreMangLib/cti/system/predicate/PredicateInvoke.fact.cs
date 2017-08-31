using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_predicate_PredicateInvoke_PredicateInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_predicate_PredicateInvoke_PredicateInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\predicate\\PredicateInvoke\\PredicateInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
