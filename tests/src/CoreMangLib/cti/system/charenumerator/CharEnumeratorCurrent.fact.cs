using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_charenumerator_CharEnumeratorCurrent_CharEnumeratorCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_charenumerator_CharEnumeratorCurrent_CharEnumeratorCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\charenumerator\\CharEnumeratorCurrent\\CharEnumeratorCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
