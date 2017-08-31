using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_charenumerator_CharEnumeratorReset_CharEnumeratorReset_
    {
        [OuterLoop]
        [Fact]
        public void _system_charenumerator_CharEnumeratorReset_CharEnumeratorReset_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\charenumerator\\CharEnumeratorReset\\CharEnumeratorReset.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
