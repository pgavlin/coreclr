using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_predicate_PredicateEndInvoke_PredicateEndInvoke_
    {
        [OuterLoop]
        [Fact]
        public void _system_predicate_PredicateEndInvoke_PredicateEndInvoke_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\predicate\\PredicateEndInvoke\\PredicateEndInvoke.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
