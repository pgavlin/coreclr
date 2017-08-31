using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_collections_ienumerator_IEnumeratorMoveNext_IEnumeratorMoveNext_
    {
        [OuterLoop]
        [Fact]
        public void _system_collections_ienumerator_IEnumeratorMoveNext_IEnumeratorMoveNext_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\collections\\ienumerator\\IEnumeratorMoveNext\\IEnumeratorMoveNext.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
