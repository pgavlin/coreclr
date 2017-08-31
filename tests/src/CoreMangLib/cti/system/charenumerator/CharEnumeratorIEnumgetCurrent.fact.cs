using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_charenumerator_CharEnumeratorIEnumgetCurrent_CharEnumeratorIEnumgetCurrent_
    {
        [OuterLoop]
        [Fact]
        public void _system_charenumerator_CharEnumeratorIEnumgetCurrent_CharEnumeratorIEnumgetCurrent_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\charenumerator\\CharEnumeratorIEnumgetCurrent\\CharEnumeratorIEnumgetCurrent.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
