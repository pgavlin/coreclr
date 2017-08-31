using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_keyvaluepair_KeyValuePairKey_KeyValuePairKey_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_keyvaluepair_KeyValuePairKey_KeyValuePairKey_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\keyvaluepair\\KeyValuePairKey\\KeyValuePairKey.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
