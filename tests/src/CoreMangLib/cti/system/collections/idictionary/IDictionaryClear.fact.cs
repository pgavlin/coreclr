using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_idictionary_IDictionaryClear_IDictionaryClear_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_idictionary_IDictionaryClear_IDictionaryClear_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\idictionary\\IDictionaryClear\\IDictionaryClear.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
