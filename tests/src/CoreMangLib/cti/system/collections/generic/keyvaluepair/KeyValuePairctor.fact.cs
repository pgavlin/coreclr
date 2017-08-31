using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_keyvaluepair_KeyValuePairctor_KeyValuePairctor_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_keyvaluepair_KeyValuePairctor_KeyValuePairctor_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\keyvaluepair\\KeyValuePairctor\\KeyValuePairctor.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
