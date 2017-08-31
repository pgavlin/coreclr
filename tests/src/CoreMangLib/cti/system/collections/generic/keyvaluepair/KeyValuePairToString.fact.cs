using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_keyvaluepair_KeyValuePairToString_KeyValuePairToString_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_keyvaluepair_KeyValuePairToString_KeyValuePairToString_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\keyvaluepair\\KeyValuePairToString\\KeyValuePairToString.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
