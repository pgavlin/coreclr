using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_idictionary_IDictionaryGetEnumerator_IDictionaryGetEnumerator_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_idictionary_IDictionaryGetEnumerator_IDictionaryGetEnumerator_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\idictionary\\IDictionaryGetEnumerator\\IDictionaryGetEnumerator.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
