using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_charenumerator_CharEnumeratorMoveNext_CharEnumeratorMoveNext_
    {
        [OuterLoop]
        [Fact]
        public void _system_charenumerator_CharEnumeratorMoveNext_CharEnumeratorMoveNext_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\charenumerator\\CharEnumeratorMoveNext\\CharEnumeratorMoveNext.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
