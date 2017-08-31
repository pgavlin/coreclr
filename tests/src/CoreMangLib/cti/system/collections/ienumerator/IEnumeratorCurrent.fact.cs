using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_ienumerator_IEnumeratorCurrent_IEnumeratorCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_ienumerator_IEnumeratorCurrent_IEnumeratorCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\ienumerator\\IEnumeratorCurrent\\IEnumeratorCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
