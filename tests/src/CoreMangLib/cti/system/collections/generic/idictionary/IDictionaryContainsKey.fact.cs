using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_idictionary_IDictionaryContainsKey_IDictionaryContainsKey_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_idictionary_IDictionaryContainsKey_IDictionaryContainsKey_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\idictionary\\IDictionaryContainsKey\\IDictionaryContainsKey.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
