using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_equalitycomparer_EqulityComparerDefault_EqulityComparerDefault_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_equalitycomparer_EqulityComparerDefault_EqulityComparerDefault_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\equalitycomparer\\EqulityComparerDefault\\EqulityComparerDefault.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
