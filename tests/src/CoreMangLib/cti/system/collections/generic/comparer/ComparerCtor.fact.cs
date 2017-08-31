using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_comparer_ComparerCtor_ComparerCtor_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_comparer_ComparerCtor_ComparerCtor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\comparer\\ComparerCtor\\ComparerCtor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
