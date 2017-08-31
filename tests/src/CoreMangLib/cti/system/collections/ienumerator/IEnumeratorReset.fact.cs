using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_ienumerator_IEnumeratorReset_IEnumeratorReset_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_ienumerator_IEnumeratorReset_IEnumeratorReset_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\ienumerator\\IEnumeratorReset\\IEnumeratorReset.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
