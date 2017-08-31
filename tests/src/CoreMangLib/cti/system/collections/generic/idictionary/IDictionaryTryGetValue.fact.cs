using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_idictionary_IDictionaryTryGetValue_IDictionaryTryGetValue_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_idictionary_IDictionaryTryGetValue_IDictionaryTryGetValue_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\idictionary\\IDictionaryTryGetValue\\IDictionaryTryGetValue.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
