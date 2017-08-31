using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_generic_idictionary_IDictionaryItem_IDictionaryItem_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_generic_idictionary_IDictionaryItem_IDictionaryItem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\generic\\idictionary\\IDictionaryItem\\IDictionaryItem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
