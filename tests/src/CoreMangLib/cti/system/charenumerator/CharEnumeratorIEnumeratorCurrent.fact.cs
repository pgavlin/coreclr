using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_charenumerator_CharEnumeratorIEnumeratorCurrent_CharEnumeratorIEnumeratorCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_charenumerator_CharEnumeratorIEnumeratorCurrent_CharEnumeratorIEnumeratorCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\charenumerator\\CharEnumeratorIEnumeratorCurrent\\CharEnumeratorIEnumeratorCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
