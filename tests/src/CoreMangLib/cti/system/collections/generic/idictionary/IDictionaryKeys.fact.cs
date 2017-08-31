using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_idictionary_IDictionaryKeys_IDictionaryKeys_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_idictionary_IDictionaryKeys_IDictionaryKeys_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\idictionary\\IDictionaryKeys\\IDictionaryKeys.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
